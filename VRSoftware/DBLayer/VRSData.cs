using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRSoftware.Model;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace VRSoftware.DBLayer
{
   public class VRSData
    {
        //Sql connecction
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());

        #region Customer
        /// <summary>
        /// Add new customer entity
        /// </summary>
        /// <param name="customerModel">customerModel</param>
        /// <returns>boolean</returns>
        public bool AddCustomer(CustomerModel customerModel)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddUpdateCustomer", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar,100).Value = customerModel.FirstName;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 100).Value = customerModel.LastName;
                cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 100).Value = customerModel.Phone;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar, 500).Value = customerModel.Address;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = customerModel.Date;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@StatementType", SqlDbType.NVarChar, 20).Value = "Insert";
                if (Conn.State!=ConnectionState.Open)
                {
                    Conn.Open();
                }                
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                Conn.Close();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Update existing customer entity
        /// </summary>
        /// <param name="customerModel">customerModel</param>
        /// <returns>boolean</returns>
        public bool UpdateCustomer(CustomerModel customerModel)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddUpdateCustomer", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 100).Value = customerModel.FirstName;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 100).Value = customerModel.LastName;
                cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 100).Value = customerModel.Phone;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar, 500).Value = customerModel.Address;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = customerModel.Date;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = customerModel.Id;
                cmd.Parameters.Add("@StatementType", SqlDbType.NVarChar, 20).Value = "Update";
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                Conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Delete Customer by CustomerId
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>
        public bool DeleteCustomerById(int CustomerId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteCustomer", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = CustomerId;
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                Conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Get all CustomerList
        /// </summary>
        /// <returns>sqldatareader</returns>
        public DataTable GetAllCustomerList()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("GetCustomer", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = 0;                
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                SqlDataReader Result = cmd.ExecuteReader();
                
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[7] { new DataColumn("Id", typeof(int)),
                        new DataColumn("FirstName", typeof(string)),
                        new DataColumn("LastName", typeof(string)),
                        new DataColumn("Phone", typeof(string)),
                        new DataColumn("Address", typeof(string)),
                        new DataColumn("Date",typeof(DateTime)),
                        new DataColumn("FullName", typeof(string))});

                while (Result.Read())
                {                  
                    DataRow dr = dt.NewRow();
                    dr["Id"]= Convert.ToString(Result["Id"]);
                    dr["FirstName"]= Convert.ToString(Result["FirstName"]);
                    dr["LastName"] = Convert.ToString(Result["LastName"]);
                    dr["Phone"] = Convert.ToString(Result["Phone"]);
                    dr["Address"] = Convert.ToString(Result["Address"]);
                    dr["Date"] = Convert.ToString(Result["Date"]);
                    dr["FullName"] = Convert.ToString(Result["FirstName"])+" " + Convert.ToString(Result["LastName"]);
                    dt.Rows.Add(dr);
                }
                               
                cmd.Dispose();
                Conn.Close();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Get customer by customerId
        /// </summary>
        /// <returns>sqldatareader</returns>
        public DataTable GetCustomerById(int CustomerId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("GetCustomer", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = CustomerId;                
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                SqlDataReader Result = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[6] { new DataColumn("Id", typeof(int)),
                        new DataColumn("FirstName", typeof(string)),
                        new DataColumn("LastName", typeof(string)),
                        new DataColumn("Phone", typeof(string)),
                        new DataColumn("Address", typeof(string)),
                        new DataColumn("Date",typeof(DateTime)) });

                while (Result.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["Id"] = Convert.ToString(Result["Id"]);
                    dr["FirstName"] = Convert.ToString(Result["FirstName"]);
                    dr["LastName"] = Convert.ToString(Result["LastName"]);
                    dr["Phone"] = Convert.ToString(Result["Phone"]);
                    dr["Address"] = Convert.ToString(Result["Address"]);
                    dr["Date"] = Convert.ToString(Result["Date"]);
                    dt.Rows.Add(dr);
                }

                cmd.Dispose();
                Conn.Close();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Video
        /// <summary>
        /// Add new video entity
        /// </summary>
        /// <param name="videoModel">videoModel</param>
        /// <returns>boolean</returns>
        public bool AddVideo(VideoModel videoModel)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddUpdateVideo", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar, 100).Value = videoModel.Title;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar, 100).Value = videoModel.Description;
                cmd.Parameters.Add("@Genre", SqlDbType.VarChar, 500).Value = videoModel.Genre;
                cmd.Parameters.Add("@Cost", SqlDbType.Decimal).Value = videoModel.Cost;
                cmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = videoModel.ReleaseDate;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = videoModel.Date;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@StatementType", SqlDbType.NVarChar, 20).Value = "Insert";
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                Conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Update existing video entity
        /// </summary>
        /// <param name="videoModel">videoModel</param>
        /// <returns>boolean</returns>
        public bool UpdateVideo(VideoModel videoModel)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddUpdateVideo", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar, 100).Value = videoModel.Title;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar, 100).Value = videoModel.Description;
                cmd.Parameters.Add("@Genre", SqlDbType.VarChar, 500).Value = videoModel.Genre;
                cmd.Parameters.Add("@Cost", SqlDbType.Decimal).Value = videoModel.Cost;
                cmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = videoModel.ReleaseDate;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = videoModel.Date;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = videoModel.Id;
                cmd.Parameters.Add("@StatementType", SqlDbType.NVarChar, 20).Value = "Update";
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }                
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                Conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Delete Video by VideoId
        /// </summary>
        /// <param name="VideoId">VideoId</param>
        /// <returns></returns>
        public bool DeleteVideoById(int VideoId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteVideo", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = VideoId;
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                Conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Get all Videos list
        /// </summary>
        /// <returns>sqldatareader</returns>
        public DataTable GetAllVideoList()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("GetVideo", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = 0;
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                SqlDataReader Result = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[7] { new DataColumn("Id", typeof(int)),
                        new DataColumn("Title", typeof(string)),
                        new DataColumn("Description", typeof(string)),
                        new DataColumn("Cost", typeof(decimal)),
                        new DataColumn("Genre", typeof(string)),
                        new DataColumn("ReleaseDate", typeof(string)),
                        new DataColumn("Date",typeof(DateTime)) });

                while (Result.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["Id"] = Convert.ToInt32(Result["Id"]);
                    dr["Title"] = Convert.ToString(Result["Title"]);
                    dr["Description"] = Convert.ToString(Result["Description"]);
                    dr["Cost"] = Convert.ToDecimal(Result["Cost"]);
                    dr["Genre"] = Convert.ToString(Result["Genre"]);
                    dr["ReleaseDate"] = Convert.ToString(Result["ReleaseDate"]);
                    dr["Date"] = Convert.ToString(Result["Date"]);
                    dt.Rows.Add(dr);
                }
                cmd.Dispose();
                Conn.Close();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Get video by VideoId
        /// </summary>
        /// <returns>sqldatareader</returns>
        public DataTable GetVideoById(int VideoId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("GetVideo", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = VideoId;
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                SqlDataReader Result = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[7] { new DataColumn("Id", typeof(int)),
                        new DataColumn("Title", typeof(string)),
                        new DataColumn("Description", typeof(string)),
                        new DataColumn("Cost", typeof(decimal)),
                        new DataColumn("Genre", typeof(string)),
                        new DataColumn("ReleaseDate", typeof(string)),
                        new DataColumn("Date",typeof(DateTime)) });

                while (Result.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["Id"] = Convert.ToInt32(Result["Id"]);
                    dr["Title"] = Convert.ToString(Result["Title"]);
                    dr["Description"] = Convert.ToString(Result["Description"]);
                    dr["Cost"] = Convert.ToDecimal(Result["Cost"]);
                    dr["Genre"] = Convert.ToString(Result["Genre"]);
                    dr["ReleaseDate"] = Convert.ToString(Result["ReleaseDate"]);
                    dr["Date"] = Convert.ToString(Result["Date"]);
                    dt.Rows.Add(dr);
                }
                cmd.Dispose();
                Conn.Close();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Rental
        /// <summary>
        /// Add new rental entity
        /// </summary>
        /// <param name="rentalModel">rentalModel</param>
        /// <returns>boolean</returns>
        public bool AddRental(RentalModel rentalModel)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddUpdateRental", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = rentalModel.CustomerId;
                cmd.Parameters.Add("@VideoId", SqlDbType.Int).Value = rentalModel.VideoId;
                cmd.Parameters.Add("@IsReturned", SqlDbType.Bit).Value = rentalModel.IsReturned;
                cmd.Parameters.Add("@IssuedDate", SqlDbType.Date).Value = rentalModel.IssuedDate;
                cmd.Parameters.Add("@ReturnedDate", SqlDbType.Date).Value = rentalModel.ReturnedDate;
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = rentalModel.Date;
                cmd.Parameters.Add("@StatementType", SqlDbType.VarChar,20).Value = "Insert";                
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                Conn.Close();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Update existing rental entity
        /// </summary>
        /// <param name="rentalModel">rentalModel</param>
        /// <returns>boolean</returns>
        public bool UpdateRental(RentalModel rentalModel)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddUpdateRental", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = rentalModel.Id;
                cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = rentalModel.CustomerId;
                cmd.Parameters.Add("@VideoId", SqlDbType.Int).Value = rentalModel.VideoId;
                cmd.Parameters.Add("@IsReturned", SqlDbType.Bit).Value = rentalModel.IsReturned;
                cmd.Parameters.Add("@IssuedDate", SqlDbType.Date).Value = rentalModel.IssuedDate;
                cmd.Parameters.Add("@ReturnedDate", SqlDbType.Date).Value = rentalModel.ReturnedDate;
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = rentalModel.Date;
                cmd.Parameters.Add("@StatementType", SqlDbType.VarChar, 20).Value = "Update";
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                Conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Delete Rental by RentalId
        /// </summary>
        /// <param name="RentalId">RentalId</param>
        /// <returns></returns>
        public bool DeleteRentalById(int RentalId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteRental", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = RentalId;
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                Conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Get all Rental video List
        /// </summary>
        /// <returns>sqldatareader</returns>
        public SqlDataReader GetAllRentalList()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("GetRental", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = 0;                
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                SqlDataReader Result = cmd.ExecuteReader();
                cmd.Dispose();
                Conn.Close();
                return Result;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Get Rental by RentalId
        /// </summary>
        /// <returns>sqldatareader</returns>
        public DataTable GetRentalById(int RentalId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("GetRental", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = RentalId;
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                SqlDataReader Result = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(Result);
                cmd.Dispose();
                Conn.Close();
                return dt;
            }
            catch
            {
                return null;
            }
        }


        /// <summary>
        /// Get all Rental Record video List
        /// </summary>
        /// <returns>sqldatareader</returns>
        public DataTable GetAllRentalRecordList(string CustomerName="", string Title="")
        {
            try
            {
                string Query = "SELECT * FROM GetRentalRecord where 1=1";
                if (!string.IsNullOrEmpty(CustomerName))
                {
                    //Query+= " and CONCAT(FirstName,' ', LastName) like '%"+ CustomerName + "%'";
                    Query+= " and CONCAT(FirstName,' ', LastName) like '%@CustomerName%'";
                }
                if (!string.IsNullOrEmpty(Title))
                {
                    //Query += " and Title like '%"+ Title + "%'";
                    Query += " and Title like '%@Title%'";
                }
                SqlCommand cmd = new SqlCommand(Query, Conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@CustomerName", SqlDbType.VarChar,100).Value = CustomerName;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar,100).Value = Title;
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                SqlDataReader Result = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(Result);
                cmd.Dispose();
                Conn.Close();
                return dt;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region PopularData
        /// <summary>
        /// Get most rented video
        /// </summary>
        /// <returns>list of most rented video</returns>
        public DataTable GetPopularVideo()
        {
            try
            {
                string Query = @"select v.Id,v.Title,v.Description,v.Genre, count(*) as IssuedCount from Video v join Rental r on v.Id=r.VideoId 
join Customer c on c.Id=r.CustomerId
group by v.Id,v.Title,v.Description,v.Genre order by count(*) desc";                
                SqlCommand cmd = new SqlCommand(Query, Conn);
                cmd.CommandType = CommandType.Text;
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                SqlDataReader Result = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(Result);
                cmd.Dispose();
                Conn.Close();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Get most rented video customer
        /// </summary>
        /// <returns>list of most rented video customer</returns>
        public DataTable GetPopularCustomer()
        {
            try
            {
                string Query = @"select c.Id,c.FirstName,c.LastName,c.Phone,c.Address, count(*) as IssuedCount from Customer c join Rental r on c.Id=r.CustomerId
join Video v on v.Id=r.VideoId
group by c.Id,c.FirstName,c.LastName,c.Phone,c.Address order by count(*) desc";
                SqlCommand cmd = new SqlCommand(Query, Conn);
                cmd.CommandType = CommandType.Text;
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                SqlDataReader Result = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(Result);
                cmd.Dispose();
                Conn.Close();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}
