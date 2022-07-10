using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;

namespace WebApplication3.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class IssueControllerBase
    {
        private readonly IssueDbContext _context;
    }
}