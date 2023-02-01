using System;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Amif_practice.Models
{
	public class database
	{
		public static MySqlConnection DB;

		public static List<User> getAllUsers()
		{
			return DB.GetAll<User>().ToList();
		}
	}
}

