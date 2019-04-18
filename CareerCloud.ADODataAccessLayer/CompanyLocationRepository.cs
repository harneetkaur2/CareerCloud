﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyLocationRepository : BaseADO, IDataRepository<CompanyLocationPoco>
    {
        public void Add(params CompanyLocationPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                foreach (CompanyLocationPoco poco in items)
                {
                    command.CommandText = @"INSERT INTO [dbo].[Company_Locations]([Id],[Company],[Country_Code],[State_Province_Code],[Street_Address],[City_Town],[Zip_Postal_Code])
                     VALUES
                        (@Id,@Company,@Country_Code,@State_Province_Code,@Street_Address,@City_Town,@Zip_Postal_Code)";
                    command.Parameters.AddWithValue("@Id", poco.Id);
                    command.Parameters.AddWithValue("@Company", poco.Company);
                    command.Parameters.AddWithValue("@Country_Code", poco.CountryCode);
                    command.Parameters.AddWithValue("@State_Province_Code", poco.Province);
                    command.Parameters.AddWithValue("@Street_Address", poco.Street);
                    command.Parameters.AddWithValue("@City_Town", poco.City);
                    command.Parameters.AddWithValue("@Zip_Postal_Code", poco.PostalCode);

                    conn.Open();
                    int rowEffected = command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyLocationPoco> GetAll(params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {
            CompanyLocationPoco[] pocos = new CompanyLocationPoco[500];

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("Select * from Company_Locations", conn);

                int position = 0;
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CompanyLocationPoco poco = new CompanyLocationPoco();

                    poco.Id = reader.GetGuid(0);
                    poco.Company = reader.GetGuid(1);
                    poco.CountryCode = reader.GetString(2);
                    if (!reader.IsDBNull(3))
                    {
                        poco.Province = reader.GetString(3);
                    }
                    else
                    {
                        poco.Province = null;
                    }
                    if (!reader.IsDBNull(4))
                    {
                        poco.Street = reader.GetString(4);
                    }
                    else
                    {
                        poco.Street = null;
                    }
                    if (!reader.IsDBNull(5))
                    {
                        poco.City = reader.GetString(5);
                    }
                    else
                    {
                        poco.City = null;
                    }
                    if (!reader.IsDBNull(6))
                    {
                        poco.PostalCode = reader.GetString(6);
                    }
                    else
                    {
                        poco.PostalCode = null;

                    }
                    poco.TimeStamp = (byte[])reader[7];

                    pocos[position] = poco;
                    position++;
                }
                conn.Close();
            }

            return pocos.Where(a => a != null).ToList();
        }

        public IList<CompanyLocationPoco> GetList(Expression<Func<CompanyLocationPoco, bool>> where, params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyLocationPoco GetSingle(Expression<Func<CompanyLocationPoco, bool>> where, params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {

            IQueryable<CompanyLocationPoco> pocos =
                   GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyLocationPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (CompanyLocationPoco poco in items)
                {
                    cmd.CommandText = @"DELETE FROM Company_Locations where Id= @Id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    conn.Open();
                    int numOfRows = cmd.ExecuteNonQuery();
                    conn.Close();

                }

            }
        }

        public void Update(params CompanyLocationPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (CompanyLocationPoco poco in items)
                {
                    cmd.CommandText = @"UPDATE Company_Locations
                        SET Company= @Company,
                            Country_Code= @Country_Code,
                            State_Province_Code= @State_Province, 
                            Street_Address=@Street_Address,
                            City_Town=@City_Town,
                            Zip_Postal_Code=@Zip_Postal_Code
                            WHERE ID= @Id";
                    cmd.Parameters.AddWithValue("@Company", poco.Company);
                    cmd.Parameters.AddWithValue("@Country_Code", poco.CountryCode);
                    cmd.Parameters.AddWithValue("@State_Province", poco.Province);
                    cmd.Parameters.AddWithValue("@Street_Address", poco.Street);
                    cmd.Parameters.AddWithValue("@City_Town", poco.City);
                    cmd.Parameters.AddWithValue("@Zip_Postal_Code", poco.PostalCode);
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    conn.Open();
                    int numOfRows = cmd.ExecuteNonQuery();
                    conn.Close();
                }



            }
        }
    }
}
