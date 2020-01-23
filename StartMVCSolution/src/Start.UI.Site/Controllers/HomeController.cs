using Microsoft.AspNetCore.Mvc;
using Start.UI.Site.Data;
using Start.UI.Site.Servicos;
using System;

namespace Start.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;

        //public HomeController(IPedidoRepository pedidoRepository)
        //{
        //    _pedidoRepository = pedidoRepository;
        //}


        ///*
        // * Injetar dependncia diretamemte no Metodo
        // * Utilizar apenas em casos muito especicos
        // *
        //    public IActionResult Index([FromServices] IPedidoRepository _pedidoRepository)
        //    {
        //        var pedido = _pedidoRepository.ObterPedido();
        //        return View();
        //    }
        // *
        // */

        //public IActionResult Index()
        //{
        //    var pedido = _pedidoRepository.ObterPedido();
        //    return View();
        //}

        public  OperacaoService OperacaoService { get; }
        public OperacaoService OperacaoService2 { get; }

        public HomeController(OperacaoService operacaoService, OperacaoService operacaoService2)
        {
            OperacaoService = operacaoService;
            OperacaoService2 = operacaoService2;
        }

        public string Index()
        {
            return
                "Primeira instância: " + Environment.NewLine +
                OperacaoService.Transient.OperacaoId + Environment.NewLine +
                OperacaoService.Scoped.OperacaoId + Environment.NewLine +
                OperacaoService.Singleton.OperacaoId + Environment.NewLine +
                OperacaoService.SingletonInstance.OperacaoId + Environment.NewLine +

                Environment.NewLine +
                Environment.NewLine +

                "Segunda instância: " + Environment.NewLine +
                OperacaoService2.Transient.OperacaoId + Environment.NewLine +
                OperacaoService2.Scoped.OperacaoId + Environment.NewLine +
                OperacaoService2.Singleton.OperacaoId + Environment.NewLine +
                OperacaoService2.SingletonInstance.OperacaoId + Environment.NewLine;
        }
    }
}
