using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.market
{
    public class Lots : ILotContainer
    {
        private readonly List<Lot> lots;

        public Lots()
        {
            lots = new List<Lot>();
        }

        public void AddLots(params Lot[] lotsToAdd)
        {
            lots.AddRange(lotsToAdd);
        }

        public void DeleteLots(params Lot[] lotsToDelete)
        {
            foreach(var lot in lotsToDelete)
            {
                var lotToDelete = lots.First(x => lot.Id == x.Id);
                lots.Remove(lotToDelete);
            }                
        }

        public bool ExistsById(Lot lot)
        {
            return lots.Exists(l => l.Id == lot.Id);
        }

        public IEnumerable<Lot> GetLots(int count = 5)
        {
            return lots.TakeLast(count);
        }
    }
}
