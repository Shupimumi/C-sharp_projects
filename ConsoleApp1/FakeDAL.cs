using System;
using System.Collections.Generic;
using System.Linq;
using ComputerShop.DAL.Abstract;
using ComputerShop.Entities;

namespace ComputerShop.DAL.FakeDAL
{

	public class FakeDAL : IComputerShopDAL
	{
		List<ComputerShopDTO> ComputerShopObject = new List<ComputerShopDTO>();

		public bool Add(ComputerShopDTO data)
		{
			if (data != null)
			{
				ComputerShopObject.Add(data);
				return true;
			}
			throw new NullReferenceException();
		}

		public ComputerShopDTO Get(Guid id)
		{
			var shop = ComputerShopObject.FirstOrDefault(x => x.Id == id);
			if (shop != null)
			{
				return shop;
			}
			throw new Exception();
		
		
		}

		public IEnumerable<ComputerShopDTO> GetAll()
		{
			return ComputerShopObject;
		}

		public bool Remove(Guid id)
		{
			throw new NotImplementedException();
		}

		public bool Update(ComputerShopDTO data)
		{
			throw new NotImplementedException();
		}
	}
}
