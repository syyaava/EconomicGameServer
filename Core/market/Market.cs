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
        private readonly ILotContainer lots;

        public Market(ILotContainer lotContainer)
        {
            lots = lotContainer;
        }

        public void AddLots(params Lot[] goodsToAdd)
        {
            if (goodsToAdd is null)
                return;

            lots.AddLots(goodsToAdd);
        }

        public IEnumerable<Lot> GetLots(int count = 5)
        {
            return lots.GetLots(count);
        }

        public IEnumerable<Lot> BuyLots(params Lot[] lotsToBuy)
        {
            var purchasedItems = new List<Lot>();
            foreach(var lot in lotsToBuy)
            {
                if (lots.ExistsById(lot))
                {
                    lots.DeleteLots(lot);
                    purchasedItems.Add(lot);
                }
            }

            return purchasedItems;
        }
    }
}
