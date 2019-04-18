using CareerCloud.DataAccessLayer;
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
    public class ApplicantSkillRepository : BaseADO, IDataRepository<ApplicantSkillPoco>
    {
        public void Add(params ApplicantSkillPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                foreach (ApplicantSkillPoco poco in items)
                {
                    command.CommandText = @"INSERT INTO [dbo].[Applicant_Skills]([Id],[Applicant],[Skill],[Skill_Level],[Start_Month],[Start_Year],[End_Month],[End_Year])
                     VALUES
                        (@Id,@Applicant,@Skill,@Skill_Level,@Start_Month,@Start_Year,@End_Month,@End_Year)";
                    command.Parameters.AddWithValue("@Id", poco.Id);
                    command.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    command.Parameters.AddWithValue("@Skill", poco.Skill);
                    command.Parameters.AddWithValue("@Skill_Level", poco.SkillLevel);
                    command.Parameters.AddWithValue("@Start_Month", poco.StartMonth);
                    command.Parameters.AddWithValue("@Start_Year", poco.StartYear);
                    command.Parameters.AddWithValue("@End_Month", poco.EndMonth);
                    command.Parameters.AddWithValue("@End_Year", poco.EndYear);
                 

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

        public IList<ApplicantSkillPoco> GetAll(params Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            ApplicantSkillPoco[] pocos = new ApplicantSkillPoco[500];

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("select * from Applicant_Skills", conn);

                int position = 0;
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ApplicantSkillPoco poco = new ApplicantSkillPoco();

                    poco.Id = reader.GetGuid(0);
                    poco.Applicant = reader.GetGuid(1);
                    poco.Skill = reader.GetString(2);
                    poco.SkillLevel = reader.GetString(3);
                    poco.StartMonth = reader.GetByte(4);
                    poco.StartYear = reader.GetInt32(5);
                    poco.EndMonth = reader.GetByte(6);
                    poco.EndYear = reader.GetInt32(7);
                    poco.TimeStamp = (byte[])reader[8];

                    pocos[position] = poco;
                    position++;
                }
                conn.Close();
            }


            return pocos.Where(a => a != null).ToList();
        }

        public IList<ApplicantSkillPoco> GetList(Expression<Func<ApplicantSkillPoco, bool>> where, params Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantSkillPoco GetSingle(Expression<Func<ApplicantSkillPoco, bool>> where, params Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            IQueryable<ApplicantSkillPoco> pocos =
                    GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params ApplicantSkillPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (ApplicantSkillPoco poco in items)
                {
                    cmd.CommandText = @"DELETE FROM Applicant_Skills where Id= @Id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    conn.Open();
                    int numOfRows = cmd.ExecuteNonQuery();
                    conn.Close();

                }

            }
        }

        public void Update(params ApplicantSkillPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (ApplicantSkillPoco poco in items)
                {
                    cmd.CommandText = @"UPDATE Applicant_Skills 
                        SET Applicant= @Applicant,
                            Skill= @Skill,
                            Skill_Level= @SkillLevel,
                            Start_Month=@StartMonth,
                            Start_Year=@StartYear,
                            End_Month=@EndMonth,
                            End_Year=@EndYear
                            WHERE ID= @Id";
                    cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    cmd.Parameters.AddWithValue("@Skill", poco.Skill);
                    cmd.Parameters.AddWithValue("@SkillLevel", poco.SkillLevel);
                    cmd.Parameters.AddWithValue("@StartMonth", poco.StartMonth);
                    cmd.Parameters.AddWithValue("@StartYear", poco.StartYear);
                    cmd.Parameters.AddWithValue("@EndMonth", poco.EndMonth);
                    cmd.Parameters.AddWithValue("@EndYear", poco.EndYear);
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    conn.Open();
                    int numOfRows = cmd.ExecuteNonQuery();
                    conn.Close();
                }



            }
        }
    }

}

