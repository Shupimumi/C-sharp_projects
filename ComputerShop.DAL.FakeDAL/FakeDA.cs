using System;
using ComputerShop.DAL.Abstract;
using ComputerShop.Entities; 

namespace ComputerShop.DAL.FakeDAL
{

	public class FakeDAL : ComputerShopDAL
	{
		List<ComputerShopDTO> ComputerShopOject = new List<ComputerShopDTO>();

		public bool Add(ComputerShopDTO data)
		{
			throw new NotImplementeedException();
		}

		public bool Remove(Guid id)
		{
			throw new NotImplementeedException();
		}
		public bool Update(ComputerShopDTO data)
		{
			throw new NotImplementeedException();
		}
		public ComputerShopDTO Get()
		{
			throw new NotImplementeedException();
		}
		public IEnumerable<ComputerShopDTO> GetAll()
		{
			throw new NotImplementeedException();
		}

	}
}
