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
        IEnumerable<Good> GetGoods(int count = 1);
        void AddGoods(IEnumerable<Good> goodsToAdd);
    }
}
