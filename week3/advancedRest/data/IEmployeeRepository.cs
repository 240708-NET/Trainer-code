using advancedRest.Models;

public interface IEmployeeRepository{
    public Task<List<Employee>> GetAllEmployees();
    public Task<Employee> GetEmployeeById(int id);
    public Task<Employee> AddEmployee(Employee employee);
    public Task UpdateEmployee(Employee employee);
    public Task DeleteEmployee(int id);

}