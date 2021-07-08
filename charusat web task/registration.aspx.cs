using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Security.Cryptography;


namespace LAB13_encryption
{
    public partial class registration : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source = (localdb)\\ProjectsV13; Initial Catalog = depatsr; Integrated Security = True");
            con.Open();
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

        protected void Button1_Click1(object sender, EventArgs e)
        {

            // String ins = "Insert into student (id,password) values('" + TextBox1.Text.ToString() + "','" + TextBox2.Text.ToString() + "'," + TextBox3.Text.ToString() + ",'" + TextBox4.Text.ToString() + "')";

            // string ins = "Insertstudent";

            //cmd.CommandType = CommandType.StoredProcedure;
            // cmd.CommandType = CommandType.Text;


               string strpass = encrypt(TextBox3.Text);
            //string strpass = EncodePassword(TextBox3.Text);
            SqlCommand cmd = new SqlCommand("insert into login values(@id,@name,@password)", con);
            cmd.Parameters.AddWithValue("@id", TextBox1.Text);
            cmd.Parameters.AddWithValue("@name",TextBox2.Text);
            cmd.Parameters.AddWithValue("@password", strpass);

            cmd.ExecuteScalar();
            con.Close();

            Response.Write("Your values are inserted in Table, Done");
          
                Response.Redirect("login.aspx");  //for sucsseful login
   
            /*            SqlParameter param;
                                    param = cmd.Parameters.Add("@id", SqlDbType.Int);
                                    param.Value = TextBox1.Text.ToString();
                        param = cmd.Parameters.Add("@password", SqlDbType.NVarChar, 15);
                        param.Value = TextBox2.Text.ToString();*/


            //  param = cmd.Parameters.Add("@student_age", SqlDbType.Int);

            //            param.Value = Int32.Parse(TextBox3.Text.ToString());





        }

        
    }
}