using Newtonsoft.Json;

namespace Employee.me.Services;
public class EmployeeService : IEmployeeService
{
    HttpClient _client;

    public EmployeeService()
    {
    }
    public async Task<List<EmployeeModel>> GetAllEmployees()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://apiemployee22.azurewebsites.net/api/Employees");
        request.Headers.Add("Accept", "application/json");

        _client = new HttpClient();

        var response = await _client.SendAsync(request);

        response.EnsureSuccessStatusCode();

        var responseContent = JsonConvert.DeserializeObject<List<EmployeeModel>>(await response.Content.ReadAsStringAsync());

        return responseContent;

    }
}
