using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XyConstruction.Models;
using Microsoft.AspNetCore.Mvc;

namespace XyConstruction.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ChartData()
        {
            var projectRevenues = DataRepository.GetProjectRevenues();
            var countryRevenueData = projectRevenues
                .GroupBy(pr => pr.Country)
                .Select(group => new
                {
                    Country = group.Key,
                    Revenue = group.Sum(pr => pr.Revenue)
                }).ToList();

            return Json(countryRevenueData);
        }

        public IActionResult AllProjectsChartData()
        {
            return Json(DataRepository.GetProjectRevenues());
        }

        public IActionResult ProjectChartData(string country)
        {
            var projectRevenues = DataRepository.GetProjectRevenues();
            var filteredData = projectRevenues.Where(pr => pr.Country == country).ToList();
            return Json(filteredData);
        }
    }

}
