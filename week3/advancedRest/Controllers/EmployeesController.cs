using advancedRest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Http;


[ApiController] //indicates that our class is responsible for http API responses
[Route("/api/[controller]")] // route template
public class EmployeeController : ControllerBase{

    private readonly IEmployeeRepository _employeesRepository;
    private readonly IMemoryCache _memoryCache;


    public EmployeeController(IEmployeeRepository employeesRepository, IMemoryCache memoryCache) {
        _employeesRepository = employeesRepository;
        _memoryCache = memoryCache;
    }

    
    //Get all employees
    [HttpGet("getAllEmployees")]
    public async Task<IEnumerable<Employee>> GetAllEmployees(){

        try{
            //IEnumerable<Employee> employees = await _employeesRepository.GetAllEmployees();
            //return employees;
            if(! _memoryCache.TryGetValue("EmployeeList", out IEnumerable<Employee> employees)){

                // Retrieve all employees from the db
                employees = await _employeesRepository.GetAllEmployees();

                //Set cache options

                var cacheEntryOptions = new MemoryCacheEntryOptions{

                    AbsoluteExpirationRelativeToNow  = TimeSpan.FromSeconds(30) // 30 seconds
                };

                _memoryCache.Set("EmployeeList", employees, cacheEntryOptions);
                  
            }

            return employees;
        }
        catch(Exception e){

            return null;
        }
    }


    //Get employee by id
    [HttpGet("getEmployee/{id}")]
    public async Task<IActionResult> GetEmployeeByIdAsync(int id){
        try{
            Employee requestedEmployee = await _employeesRepository.GetEmployeeById(id);

            var cookieOptions = new CookieOptions{

                Expires = DateTime.Now.AddDays(2),
                HttpOnly = true,
                Secure = true
            };

            Response.Cookies.Append("EmployeeId", id.ToString(), cookieOptions);
            return Ok(requestedEmployee);
        }
        catch(Exception e){

            return BadRequest(e.Message);
        }
    }

    // Add employee


}