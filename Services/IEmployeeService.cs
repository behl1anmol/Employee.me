namespace Employee.me.Services;
public interface IEmployeeService
{
    Task<List<EmployeeModel>> GetAllEmployees(); 
}
