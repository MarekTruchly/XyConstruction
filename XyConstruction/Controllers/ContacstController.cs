using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using XyConstruction.Models.SampleData;
using Microsoft.AspNetCore.Mvc;


namespace XyConstruction.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public object GetData(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(SampleData.Projects, loadOptions);
        }
    }

}
