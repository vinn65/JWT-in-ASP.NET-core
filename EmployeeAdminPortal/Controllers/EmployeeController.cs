using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace EmployeeAdminPortal.Controllers;



[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly AppDbContext dBContext;
    public EmployeeController(AppDbContext dbContext)
    {
        this.dBContext = dbContext;
    }

    [Authorize(Roles = "Admin")]
    [HttpGet]
    public IActionResult GetAllEmployees()
    {

        var allEmployees = dBContext.Employee.ToList();
        
        return Ok(allEmployees);
    }

    [HttpGet]
    [Route("{id:guid}")]
    [Authorize(Roles = "Admin")]
    public IActionResult GetEmployeeByID(Guid id)
    {

        var employee = dBContext.Employee.Find(id);

        if (employee is null)
        {
            return NotFound();
        }

        return Ok(employee);
    }

    [HttpPut]
    [Route("{id:guid}")]
    public IActionResult UpdateEmployeeByID(Guid id, UpdateEmployeeDto UpdateEmployeeDto)
    {
        var employee = dBContext.Employee.Find(id);
        if (employee is null)
        {
            return NotFound();
        }
        employee.Name = UpdateEmployeeDto.Name;
        employee.Email = UpdateEmployeeDto.Email;   
        employee.Phone = UpdateEmployeeDto.Phone;
        employee.Salary = UpdateEmployeeDto.Salary;

        dBContext.SaveChanges();
        return Ok(employee);
    }

     [HttpPost]
    public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
    {
        var employeeEntity = new Employee()
        {
            Name = addEmployeeDto.Name,
            Email = addEmployeeDto.Email,
            Phone = addEmployeeDto.Phone,
            Salary = addEmployeeDto.Salary
        };

        dBContext.Employee.Add(employeeEntity);
        dBContext.SaveChanges();

        return Ok(employeeEntity);
    }

    [HttpDelete]
    [Route("{id:guid}")]
    public IActionResult DeleteEmployeeByID(Guid id)
    {

        var employee = dBContext.Employee.Find(id);

        if (employee is null)
        {
            return NotFound();
        }

        dBContext.Employee.Remove(employee);
        dBContext.SaveChanges();
        return Ok();

    }
}
