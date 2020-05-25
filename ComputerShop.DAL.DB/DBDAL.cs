using ComputerShop.DAL.Abstract;
using ComputerShop.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.DAL.DB
{
	public class DBDAL : IComputerShopDAL
	{

		private static string connectionString;
		static DBDAL()
		{
			connectionString = ConfigurationManager.ConnectionStrings
				["computerShop"].ConnectionString;
		}	

		public bool Add(ComputerShopDTO data)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlCommand command = new SqlCommand("INSERT INTO " +
					"ComputerShop(Id, User, Password, Surname, Phone, Email, Passport, Name)" +
					"VALUES(@Id,@User,@Password,@Surname,@Phone,@Email,@Passport,@Name)",connection);
				command.Parameters.AddWithValue("@Id", data.Id);
				command.Parameters.AddWithValue("@User", data.User);
				command.Parameters.AddWithValue("@Password", data.Password);
				command.Parameters.AddWithValue("@Surname", data.Surname);
				command.Parameters.AddWithValue("@Phone", data.Phone);
				command.Parameters.AddWithValue("@Email", data.Email);
				command.Parameters.AddWithValue("@Passport", data.Passport);
				command.Parameters.AddWithValue("@Name", data.Name);
				int countRow = command.ExecuteNonQuery();
				return countRow == 1;
			}
		}

		public ComputerShopDTO Get(Guid id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ComputerShopDTO> GetAll()
		{
			throw new NotImplementedException();
		}

		public bool Remove(Guid id)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlCommand command = new SqlCommand("DELETE FROM " +
					"ComputerShop(Id, User, Password, Surname, Phone, Email, Passport, Name)" +
					"WHERE Id=@Id", connection);
				command.Parameters.AddWithValue("@Id", id);
				int countRow = command.ExecuteNonQuery();
				return countRow == 1;
			}
		}

		public bool Update(ComputerShopDTO data)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlCommand command = new SqlCommand("UPDATE FROM" +
					"ComputerShop WHERE Id=@Id SET User=@User, Password=@Password, Surname=@Surname, Phone=@Phone," +
					" Email=@Email, Passport=@Passport, Name=@Name)", connection);
				command.Parameters.AddWithValue("@Id", data.Id);
				command.Parameters.AddWithValue("@User", data.User);
				command.Parameters.AddWithValue("@Password", data.Password);
				command.Parameters.AddWithValue("@Surname", data.Surname);
				command.Parameters.AddWithValue("@Phone", data.Phone);
				command.Parameters.AddWithValue("@Email", data.Email);
				command.Parameters.AddWithValue("@Passport", data.Passport);
				command.Parameters.AddWithValue("@Name", data.Name);
				int countRow = command.ExecuteNonQuery();
				return countRow == 1;
			}
		}
	}
}
