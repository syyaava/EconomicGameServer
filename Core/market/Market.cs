using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.market
{
    public class Market : IMarket
    {
        private readonly List<Lot> lots;

        public Market()
        {
            lots = LoadLots();
            AddLots(new List<Lot>()
            {
                new Lot(new Item("Resources.Basic.Wood", "Wood", "Basic resource."), 12, 1)
            });
        }

        private List<Lot> LoadLots()
        {
            return new List<Lot>();
        }

        public void AddLots(IEnumerable<Lot> goodsToAdd)
        {
            if (goodsToAdd is null)
                return;

            lots.AddRange(goodsToAdd);
        }

        public IEnumerable<Lot> GetLots(int count = 1)
        {
            return lots.TakeLast(count);
        }
    }
}
