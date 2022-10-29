using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.me.Models;
public class EmployeeModel
{
    public int Empid
    {
        get; set;
    }
    public string Empname { get; set; } = null!;
    public DateTime Empdob
    {
        get; set;
    }
    public string? Empphonenumber
    {
        get; set;
    }
    public string? Emplocation
    {
        get; set;
    }
}
