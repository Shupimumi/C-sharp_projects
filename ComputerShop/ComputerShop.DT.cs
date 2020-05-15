using System;

namespace ComputerShop.Entities
{
		//DTO - Data transfer object (Предназначена для транспортировки данных в базу данных.)	
		//+ в том, что не надо накладывать ограничения на инкапсуляцию
		public class ComputerShopDTO 
		{

			public Guid Id { get; set; }
			public DateTime CreatedData { get; set; }
			public string Text { get; set; }
		
		}
}
