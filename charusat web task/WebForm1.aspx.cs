using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace lab_12
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source = (localdb)\\ProjectsV13; Initial Catalog = depatsr; Integrated Security = True");
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ins = "Insertstudent";
            cmd = new SqlCommand(ins, con);
            cmd.CommandType = CommandType.StoredProcedure;


            SqlParameter param;

            param = cmd.Parameters.Add("@city", SqlDbType.VarChar, 50);

            param.Value = TextBox3.Text.ToString();


            param = cmd.Parameters.Add("@name", SqlDbType.VarChar, 50);

            param.Value = TextBox2.Text.ToString();


            param = cmd.Parameters.Add("@id", SqlDbType.Int);

            param.Value = Int32.Parse(TextBox1.Text.ToString());




            cmd.ExecuteNonQuery();
            con.Close();

            Response.Write("Your values are inserted in Table, Done");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                //   SqlCommand cmd = new SqlCommand("select * from student", con);

                SqlCommand cmd = new SqlCommand("reader", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader red;

                red = cmd.ExecuteReader();

                while (red.Read())
                {
                    Response.Write("ID:" + red["id"] + "   ");

                    Response.Write("NAME:" + red["name"] + "   ");


                    Response.Write("CITY:" + red["city"] + "   <br>");
                }
                red.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            string upd = "update";
            //  string upd = "Update student set student_age=" + Int32.Parse(TextBox2.Text.ToString()) + " where student_id='" + TextBox1.Text.ToString() + "'";
            cmd = new SqlCommand(upd, con);
            cmd.CommandType = CommandType.StoredProcedure;


            SqlParameter param;


            param = cmd.Parameters.Add("@id", SqlDbType.Int);

            param.Value = Int32.Parse(TextBox1.Text.ToString());


            param = cmd.Parameters.Add("@name", SqlDbType.VarChar,50);

            param.Value = TextBox2.Text.ToString();


            param = cmd.Parameters.Add("@city", SqlDbType.VarChar, 50);

            param.Value = TextBox3.Text.ToString();


            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("Upadate done");

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            //string upd = "Delete from student where student_id='" + TextBox1.Text.ToString() + "'";
            string del = "delete";
            cmd = new SqlCommand(del, con);
            cmd.CommandType = CommandType.StoredProcedure;


            SqlParameter param;


            param = cmd.Parameters.Add("@id", SqlDbType.Int);

            param.Value = Int32.Parse(TextBox1.Text.ToString());


            param = cmd.Parameters.Add("@name", SqlDbType.VarChar, 50);

            param.Value = TextBox2.Text.ToString();


            param = cmd.Parameters.Add("@city", SqlDbType.VarChar, 50);

            param.Value = TextBox3.Text.ToString();


            //con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("Delete done");

        }
        //xml part is dis connected model xml view and data add
        protected void Button5_Click(object sender, EventArgs e)
        {

            string queryString = "SELECT * from person;";
            SqlDataAdapter da = new SqlDataAdapter(queryString, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "person");

            // SqlCommand cmd1 = new SqlCommand("Update student set student_age=" + Int32.Parse(TextBox2.Text.ToString()) + " where student_id='" + TextBox1.Text.ToString() + "'");
            //    da.UpdateCommand = cmd1;

            //  da.Update(ds,"student");
            ds.WriteXml(Server.MapPath("jaimin.xml"));

            /*
            for (int i=0;i<4;i++)
            { 
            Response.Write(ds.Tables[0].Rows[i]["student_id"]+ " ");
            Response.Write(ds.Tables[0].Rows[i]["student_name"] + " ");
            Response.Write(ds.Tables[0].Rows[i]["student_age"] + " ");
            Response.Write(ds.Tables[0].Rows[i]["city"] + " \n");
            }*/
            con.Close();
            Response.Write("Data added to xml file");

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(Server.MapPath("jaimin.xml"), new XmlReaderSettings());
            DataSet ds = new DataSet();
            ds.ReadXml(xmlFile);
            int i = 0;

            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
               // Response.Write("  " + ds.Tables[0].Rows[i].ItemArray[0].ToString());
                Response.Write(ds.Tables[0].Rows[i]["ID"] + " ");
                Response.Write(ds.Tables[0].Rows[i]["NAME"] + " ");
                Response.Write(ds.Tables[0].Rows[i]["CITY"] + " ");

            }


        }
    }
}