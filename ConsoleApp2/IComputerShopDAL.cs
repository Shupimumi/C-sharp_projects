using System;
using System.Collections.Generic;
using System.Text;
using ComputerShop.Entities;


namespace ComputerShop.DAL.Abstract
{
	public interface IComputerShopDAL
	{

		bool Add(ComputerShopDTO data);
		bool Remove(Guid id);
		bool Update(ComputerShopDTO data);

		ComputerShopDTO Get(Guid id);
		IEnumerable<ComputerShopDTO> GetAll();


	}
}
