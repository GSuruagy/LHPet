using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        _logger.LogInformation("Criando clientes e fornecedores...");

        Cliente cliente1 = new Cliente(1, "Arthur A. Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(2, "William Henry Gates III", "039.618.250-09", "bill@microsoft.com", "Bug");
        Cliente cliente3 = new Cliente(3, "Ada Lovelace", "800.777.920-50", "ada@ada.language.com", "Byron");
        Cliente cliente4 = new Cliente(4, "Linus Torvalds", "933.622.400-03", "torvalds@osdl.org", "Pinguim");
        Cliente cliente5 = new Cliente(5, "Grace Hopper", "911.702.988-00", "grace.hopper@cobol.com", "Loboc");

        List<Cliente> listaClientes = new List<Cliente> { cliente1, cliente2, cliente3, cliente4, cliente5 };
        _logger.LogInformation("Lista de clientes criada com {Count} clientes.", listaClientes.Count);
        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(1, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(2, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(3, "BootsPet INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(4, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(5, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us");

        List<Fornecedor> listaFornecedores = new List<Fornecedor> { fornecedor1, fornecedor2, fornecedor3, fornecedor4, fornecedor5 };
        _logger.LogInformation("Lista de fornecedores criada com {Count} fornecedores.", listaFornecedores.Count);
        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
