using Core.market;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IMarket
    {
        IEnumerable<Lot> GetLots(int count = 1);
        void AddLots(params Lot[] goodsToAdd);
        IEnumerable<Lot> BuyLots(params Lot[] lotsToBuy);
    }
}
