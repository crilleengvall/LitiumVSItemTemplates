using System.Web.Mvc;
using Litium.Web.Models.Blocks;

namespace $rootnamespace$
{
    public class $safeitemrootname$ : ControllerBase
    {
        public $safeitemrootname$()
        {

        }

        [HttpGet]
        public ActionResult Index(BlockModel currentBlockModel)
        {
            return View();
        }
    }
}