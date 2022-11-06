using Core.Interfaces;
using Core.market;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EconomicGameServer.Controllers
{
    [Route("apiv1/[controller]")]
    [ApiController]
    public class MarketController : ControllerBase
    {
        private const string PATH_TO_ITEMS = "Items";
        private ILogger logger;
        private IMarket market;
        private List<Item> items = new List<Item>();

        public MarketController(IMarket market)
        {
            this.logger = logger;
            this.market = market;
            LoadItems();
        }

        [HttpGet]
        [Route("items")]
        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        [HttpGet]
        [Route("lots/{count:int=5}")]
        public IEnumerable<Lot> GetLots(int count = 1)
        {            
            return market.GetLots(count);
        }

        [HttpPost]
        [Route("lots")]
        public IActionResult AddLots(IEnumerable<Lot> lotsToAdd)
        {
            foreach (var item in lotsToAdd)
                if (!items.Exists(x => x.Id == item.Item.Id))
                    return BadRequest(lotsToAdd);
            //TODO: добавить проверку на соответствие предметам
            market.AddLots(lotsToAdd);
            return Ok();
        }

        private void LoadItems()
        {
            var itemsFolders = Directory.Exists(PATH_TO_ITEMS) 
                ? Directory.GetDirectories(PATH_TO_ITEMS) 
                : throw new ArgumentNullException(nameof(PATH_TO_ITEMS) + " not exists.");

            //TODO: сделать обход по папкам и загрузить все предметы в память.
            items = new List<Item>()
            {
                new Item("Resources.Basic.Wood", "Wood", "Basic resource.")
            };
        }
    }
}
