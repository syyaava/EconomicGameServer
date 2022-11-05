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
        private List<Good> goods;

        public void AddGoods(IEnumerable<Good> goodsToAdd)
        {
            if (goodsToAdd is null)
                return;

            goods.AddRange(goodsToAdd);
        }

        public IEnumerable<Good> GetGoods(int count = 1)
        {
            return goods.TakeLast(count);
        }
    }
}
