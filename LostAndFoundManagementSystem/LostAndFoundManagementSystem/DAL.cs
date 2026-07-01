using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LostAndFoundManagementSystem
{
    internal class DAL
    {
        private readonly string connectionString = "Data Source=TAHSIN-HPPROBOO\\SQLSERVER;Initial Catalog=LostStuff;User ID=Lost&Found;Password=T9#vQ2!zLp@7Xf$3";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public DAL() { 
            this.connection = new SqlConnection(connectionString);
            this.connection.Open();
        }
        
        public int Validity(string id, string pass) 
        {       
            
            try
            {
                string query = "SELECT * FROM Login WHERE Id =@i AND Password =@p";
                this.command = new SqlCommand(query);
                this.command.Parameters.AddWithValue("@i", id);
                this.command.Parameters.AddWithValue("@p", pass);

                this.dataTable = new DataTable();
                this.adapter = new SqlDataAdapter(command);
                this.adapter.SelectCommand.Connection = this.connection;
                this.adapter.Fill(dataTable);

                return dataTable.Rows.Count;
            }
            catch(Exception ex)
            {
                throw ex;
            }                              
        }

        //UPDATE
        //public bool UpdateUser(string id, string password, string name, string role, string phoneNumber)
        //{
        //    try
        //    {
        //        string query = "UPDATE Login SET Password =@p, Name=@n, Role=@r, PhoneNumber=@ph";
        //    }
        //}

        //INSERT 
        public bool InsertUser(string id, string password, string name, string role, string phoneNumber)
        {
            try
            {
                string query = "Insert into Login(Id, Password, Name, Role, PhoneNumber) Values (@id, @pass, @name, @role, @Phone)";
                this.command = new SqlCommand(query);

                this.command.Parameters.AddWithValue("@id", id);
                this.command.Parameters.AddWithValue("@pass", password);
                this.command.Parameters.AddWithValue("@name", name);
                this.command.Parameters.AddWithValue("@role", role);
                this.command.Parameters.AddWithValue("@phone", phoneNumber);

                this.command.Connection = this.connection;
                int cnt = this.command.ExecuteNonQuery();

                return cnt == 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertItem(string Id , string itemName,string picLocation, string type, string status, string LostPlace, string Shelfno)
        {
            try
            {
                string query = "Insert into Lost_Item(ItemId , ItemName, Picture, Type, Status, Lost_Place, Item_Shelf_no) Values (@ID, @ItemName, @pic, @type, @stat, @LostPlace, @shelf)";
                this.command = new SqlCommand(query);
                
                this.command.Parameters.AddWithValue("@ID", Id);
                this.command.Parameters.AddWithValue("@ItemName", itemName);
                this.command.Parameters.AddWithValue("@pic", picLocation);
                this.command.Parameters.AddWithValue("@type", type);
                this.command.Parameters.AddWithValue("@stat", status);
                this.command.Parameters.AddWithValue("@LostPlace", LostPlace);                
                this.command.Parameters.AddWithValue("@shelf", Shelfno);

                this.command.Connection = this.connection;
                int cnt = this.command.ExecuteNonQuery();

                return cnt == 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool SubmitItem(string submissionID, string ItemName ,string picPath, string ItemID,string SubmittedBy, string SubmissionTime, string SubmittedOn)
        {
            try
            {
                string query = "Insert into Submission(SubmissionID, ItemName ,Picture, ItemID, Submitted_By, SubmissionTime, SubmittedOn) Values (@ID, @ItemName ,@pic, @ItemID ,@SubmittedBy, @SubmissionTime, @SubmittedOn)";
                this.command = new SqlCommand(query);

                this.command.Parameters.AddWithValue("@ID", submissionID);
                this.command.Parameters.AddWithValue("@ItemName", ItemName);
                this.command.Parameters.AddWithValue("@pic", picPath);
                this.command.Parameters.AddWithValue("@ItemID", ItemID);
                this.command.Parameters.AddWithValue("@SubmittedBy", SubmittedBy);
                this.command.Parameters.AddWithValue("@SubmissionTime", SubmissionTime);
                this.command.Parameters.AddWithValue("@SubmittedOn", SubmittedOn);

                this.command.Connection = this.connection;
                int cnt = this.command.ExecuteNonQuery();

                return cnt == 1;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            

        }
        //Update
        public bool InsertReturnTable(string retID,string itemName, string picPath, string itemID, string returnedBy, string returnedTime, string returnedOn)
        {
            try
            {
                string sql = "Insert into TReturn(ReturnID, ItemName, Picture, ItemID, Returned_By, ReturnedTime, ReturnedOn) Values (@retID, @itemN, @picPath, @itemID, @retBy, @retTime, @retOn)";
                this.command = new SqlCommand(sql);

                this.command.Parameters.AddWithValue("@retID", retID);
                this.command.Parameters.AddWithValue("@itemN", itemName);
                this.command.Parameters.AddWithValue("@picPath", picPath);
                this.command.Parameters.AddWithValue("@itemID",itemID);
                this.command.Parameters.AddWithValue("@retBy", returnedBy);
                this.command.Parameters.AddWithValue("@retTime", returnedTime);
                this.command.Parameters.AddWithValue("@retOn", returnedOn);

                this.command.Connection = this.connection;
                int cnt = this.command.ExecuteNonQuery();

                return cnt == 1;                    
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateSubmissionHistory(string submissionID, string ItemName, string PicPath, string SubmittedBy, string SubTime, string subOn)
        {
            try
            {
                string query = "Update Submission Set ItemName = @Item, Picture = @picPath, Submitted_By = @submittedBy, SubmissionTime = @SubTime, SubmittedOn = @SubOn Where SubmissionID = @SubID ";
                this.command = new SqlCommand(query);

                this.command.Parameters.AddWithValue("@Item",ItemName);
                this.command.Parameters.AddWithValue("@picPath",PicPath);
                this.command.Parameters.AddWithValue("@submittedBy", SubmittedBy);
                this.command.Parameters.AddWithValue("@SubTime", SubTime);
                this.command.Parameters.AddWithValue("@SubOn", subOn);
                this.command.Parameters.AddWithValue("SubID", submissionID);

                this.command.Connection = this.connection;
                int cnt = this.command.ExecuteNonQuery();

                return cnt == 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
        public bool ReturnStuff(string id)
        {
            try
            {
                string sql = "Update Lost_Item Set Status = 'Returned' Where ItemID = @ItID ";
                this.command = new SqlCommand(sql);
                this.command.Parameters.AddWithValue("@ItID", id);

                this.command.Connection = this.connection;
                int cnt = this.command.ExecuteNonQuery();

                return cnt == 1;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error : " + ex);
                return false;
            }
        }
        //Data Retreiving
        public int ExecuteDMLQuery(string sql)
        {
            this.command = new SqlCommand(sql);
            this.command.Connection = this.connection;
            
            int cnt = this.command.ExecuteNonQuery();
            return cnt;
        }
        public DataTable ExecuteQueryTable(string sql)
        {

            this.command = new SqlCommand(sql);
            this.adapter = new SqlDataAdapter(command);
            this.dataTable = new DataTable();
            this.adapter.SelectCommand.Connection = this.connection;
            this.adapter.Fill(this.dataTable);

            return this.dataTable;
        }
        //public DataTable AutoSearch(string searchText)
        //{
        //    try
        //    {
        //        this.command = new SqlCommand("SELECT * FROM Lost_Item WHERE ItemId LIKE @searchText + '%'");
        //    }
        //    catch(Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public void closeConnection()
        {
            if (this.connection.State == System.Data.ConnectionState.Open)
                this.connection.Close();
        }
    }
}
