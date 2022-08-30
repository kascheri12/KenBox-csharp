using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KenBox_csharp.Models;

namespace KenBox_csharp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            int count_recur = new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox()))))))))))))))))))))))))))))))))))))))))))))))))))))))))))).NumberOfContainedBoxesRecursive;
            watch.Stop();
            long ticks_recur = watch.ElapsedTicks;

            watch.Restart();
            int count_iter = new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox(new KenBox()))))))))))))))))))))))))))))))))))))))))))))))))))))))))))).NumberOfContainedBoxesIterative;
            watch.Stop();
            long ticks_iter = watch.ElapsedTicks;

            long perc_faster = (ticks_recur - ticks_iter) / ticks_iter * 100;

            ViewBag.CountRecur = count_recur;
            ViewBag.CountIter = count_iter;
            ViewBag.TicksRecur = ticks_recur;
            ViewBag.TicksIter = ticks_iter;
            ViewBag.PercFaster = perc_faster;

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
}

