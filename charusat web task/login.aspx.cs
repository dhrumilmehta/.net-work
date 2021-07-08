using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace LAB13_encryption
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source = (localdb)\\ProjectsV13; Initial Catalog =depatsr; Integrated Security = True");
            con.Open();
        }


        public string EncodePassword(string pass)
        {
            //Declarations
            Byte[] originalBytes;
            Byte[] encodedBytes;
            System.Security.Cryptography.MD5 md5;
            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(pass);
            encodedBytes = md5.ComputeHash(originalBytes);
            //Convert encoded bytes back to a 'readable' string
            return BitConverter.ToString(encodedBytes);
        }



        private string encrypt(string str)
        {
            string _result = string.Empty;
            char[] temp = str.ToCharArray();
            foreach (var _singleChar in temp)
            {
                var i = (int)_singleChar;
                i = i - 2;
                _result += (char)i;
            }
            return _result;
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            string query = "insertlogin";   //stored procedure Name
            SqlCommand com = new SqlCommand(query, con);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            param = com.Parameters.Add("@password", SqlDbType.NVarChar, 50);
               param.Value = encrypt(TextBox2.Text.ToString());
           // param.Value = EncodePassword(TextBox3.Text.ToString());

            // Response.Write(param.Value);

            param = com.Parameters.Add("@id", SqlDbType.Int);
            param.Value = Int32.Parse(TextBox2.Text.ToString());




            // com.Parameters.AddWithValue("@id", Int32.Parse((TextBox1.Text.ToString())));   //for username 
            //com.Parameters.AddWithValue("@password", TextBox2.Text.ToString());  //for password

            int usercount = (Int32)com.ExecuteScalar();// for taking single value

            if (usercount == 1)  // comparing users from table 
            {
                Response.Redirect("Welcome.aspx");  //for sucsseful login
            }
            else
            {
                con.Close();
                Label1.Text = "Invalid User Name or Password";  //for invalid login
            }
         }

        
    }
}