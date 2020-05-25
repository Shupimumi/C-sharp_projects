using System;

namespace ComputerShop.Entities
{
	//DTO - Data transfer object (Предназначена для транспортировки данных в базу данных.)	
	//+ в том, что не надо накладывать ограничения на инкапсуляцию
	public class ComputerShopDTO
	{

		public Guid Id { get; set; }
		public string Password { get; set; } //CreatedData
		public string User { get; set; }//Text
		public string Surname { get; set; }
		public int Phone { get; set; }
		public string Email { get; set; }
		public int Passport { get; set; }
		public string Name { get; set; }

	}
}
