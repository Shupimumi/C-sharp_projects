using System;
using System.Collections.Generic;
using System.Text;
using ComputerShop.Entities;


namespace ComputerShop.DAL.Abstract
{
	public interface ComputerShopDAL
	{

		bool Add(ComputerShopDTO data);
		bool Remove(Guid id);
		bool Update(ComputerShopDTO data);

		ComputerShopDTO Get();
		IEnumerable<ComputerShopDTO> GetAll();


	}
}
