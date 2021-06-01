using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace WinFormAdsLibrary
{
	public class AdDB
	{
		public static SqlConnection sqlConnection = new SqlConnection(
		"Data Source=KMR-HD-VIPER\\SQLEXPRESS;Initial Catalog=AdDB;Integrated Security=True");

		public static List<Ad> DatabaseLoad(string nameTable)
		{
			List<Ad> ads = new List<Ad>();
			string sql = $"SELECT * FROM {nameTable}";
			SqlCommand command = new SqlCommand(sql, sqlConnection);
			sqlConnection.Open();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					string ad_name = reader.GetString(1);
					string ad_description = reader.GetString(2);
					uint ad_price = (uint)reader.GetInt32(3);
					ulong seller_number = (ulong)reader.GetInt64(4);
					string seller_name = reader.GetString(5);
					DateTime ad_date = reader.GetDateTime(6);
					ads.Add(new Ad(ad_name, ad_description, ad_price, seller_number, seller_name, ad_date));
				}
			}
			sqlConnection.Close();
			return ads;
		}

		public static void DatabaseSave(List<Ad> ads, string nameTable)
		{
			string sql = $"TRUNCATE TABLE {nameTable}";
			SqlCommand command = new SqlCommand(sql, sqlConnection);
			sqlConnection.Open();
			if (ads.Count == 0)
			{
				sqlConnection.Close();
			}
			else {
				command.ExecuteNonQuery();
				sql = $"INSERT {nameTable} VALUES";
				foreach (var ad in ads)
				{
					if (sql[sql.Length - 1] == ')')
						sql += ",";
					sql += $" ('{ad.adName}', '{ad.adDescription}', {ad.adPrice}, {ad.sellerNumber}, '{ad.sellerName}', '{ad.adDate}')";
				}
				command = new SqlCommand(sql, sqlConnection);
				command.ExecuteNonQuery();
			}

			sqlConnection.Close();
		}

		public static void DatabaseDelete(Ad ad, string nameTable)
		{
			string sql = $"DELETE FROM {nameTable} WHERE ad_name = '{ad.adName}' AND ad_description = '{ad.adDescription}' AND ad_price = {ad.adPrice} AND seller_number = {ad.sellerNumber} AND seller_name = '{ad.sellerName}' AND ad_date = '{ad.adDate}'";
			SqlCommand command = new SqlCommand(sql, sqlConnection);
			sqlConnection.Open();
			int DeletedCount = command.ExecuteNonQuery();
			sqlConnection.Close();
		}
	}
}
