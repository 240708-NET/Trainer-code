using advancedRest.Models;
using Microsoft.EntityFrameworkCore;

public class EmployeeRepository : IEmployeeRepository{

    //DbContext dependecy injection
    private readonly DemoDbContext _context;

    public EmployeeRepository(DemoDbContext demoDbContext){
        _context = demoDbContext;
    }

    public async Task<List<Employee>> GetAllEmployees(){
        List<Employee> employees = await _context.Employees.ToListAsync();
        return employees;
    }
    public async Task<Employee> GetEmployeeById(int id){
        Employee employee = await _context.Employees.FindAsync(id);
        return employee;
    }
    public async Task<Employee> AddEmployee(Employee employee){
        _context.Employees.Add(employee);
       await _context.SaveChangesAsync();
        return employee;

    }
    public async Task UpdateEmployee(Employee employee){
        
        Employee existingEmployee = _context.Employees.Find(employee.EmployeeId);
        
        existingEmployee.FirstName = employee.FirstName;
        existingEmployee.LastName = employee.LastName;
        existingEmployee.FirstName = employee.Email;

        await _context.SaveChangesAsync();
    }
    public async Task DeleteEmployee(int id){
        Employee employee = _context.Employees.Find(id);
        _context.Employees.Remove(employee);
        await _context.SaveChangesAsync();
    }

}