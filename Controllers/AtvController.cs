using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Teste.Models;

namespace Teste.Controllers;

public class AtvController : Controller
{
    private readonly ILogger<AtvController> _logger;

    public AtvController(ILogger<AtvController> logger)
    {
        _logger = logger;
    }

    public IActionResult Atv()
    {
        return View();
    }
}