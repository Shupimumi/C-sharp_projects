using ComputerShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Abstract
{
    public interface IComputerShopBLL
    {
        bool Add(ComputerShopDTO data);
        bool Remove(Guid id);
        bool Update(ComputerShopDTO data);
        ComputerShopDTO Get(Guid id);
        IEnumerable<ComputerShopDTO> GetALL();
       // IEnumerable<ComputerShopDTO> GetRecent();
       // IEnumerable<ComputerShopDTO> GetByInterval(DateTime from, DateTime to);
    }
  
}
