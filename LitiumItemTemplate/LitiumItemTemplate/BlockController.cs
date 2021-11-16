using System.Web.Mvc;
using Litium.Web.Models.Blocks;

namespace LitiumItemTemplate
{
    public class BlockController : ControllerBase
    {
        public BlockController()
        {

        }

        [HttpGet]
        public ActionResult Index(BlockModel currentBlockModel)
        {
            return View();
        }
    }
}
