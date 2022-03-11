using Microsoft.AspNetCore.Mvc;
using eMovieTicket.Data;
namespace eMovieTicket.Controllers;
public class MoviesController : Controller
{
    private readonly AppDbContext _context;

    public MoviesController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var data = _context.Movies.ToList();
        return View();
    }
}