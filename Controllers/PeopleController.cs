using Microsoft.AspNetCore.Mvc;
using WebApplicationTesteBackend.Db;
using Microsoft.EntityFrameworkCore;
using WebApplicationTesteBackend.Models;

namespace WebApplicationTesteBackend.Controllers;

[ApiController]
[Route("api/peoples")]
public class PeopleController : ControllerBase
{
    private readonly ApplicationDbContext dbContext;

    public PeopleController(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
    } 

    [HttpGet]
    public async Task<ActionResult<IEnumerable<People>>> GetAll()
    {
        var peoples = await dbContext.Peoples.ToListAsync();
        return peoples;
    }

}