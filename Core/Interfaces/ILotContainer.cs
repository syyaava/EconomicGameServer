using Core.market;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ILotContainer
    {
        IEnumerable<Lot> GetLots(int count = 5);
        void AddLots(params Lot[] lots);
        bool ExistsById(Lot lot);
        void DeleteLots(params Lot[] lotsToDelete);
    }
}
