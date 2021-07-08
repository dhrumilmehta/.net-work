using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;

namespace lab_12
{
    public partial class xml_programming : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)

            {

                //Bind xml data to datalist

                BindDatalist();

            }

        }

        private void BindDatalist()

        {

            XmlTextReader xmlreader = new XmlTextReader(Server.MapPath("employee.xml"));

            DataSet ds = new DataSet();

            ds.ReadXml(xmlreader);

            xmlreader.Close();

            if (ds.Tables.Count != 0)

            {

                DataList1.DataSource = ds;

                DataList1.DataBind();
                Response.Write("data getting");

            }

            else

            {

                DataList1.DataSource = null;

                DataList1.DataBind();
                Response.Write("data not getting");

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
               XmlDocument xmldoc = new XmlDocument();

                xmldoc.Load(Server.MapPath("employee.xml"));

                BindDatalist();
            Response.Write("data has been submitted to xml flie");
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();

            xmldoc.Load(Server.MapPath("employee.xml"));

            XmlElement parentelement = xmldoc.CreateElement("Details");

            XmlElement emp_name = xmldoc.CreateElement("emp_name");

            emp_name.InnerText = TextBox1.Text;

            XmlElement Emp_id = xmldoc.CreateElement("emp_id");

            Emp_id.InnerText = TextBox2.Text;

            XmlElement Qualification = xmldoc.CreateElement("Qualification");

            Qualification.InnerText = DropDownList1.SelectedItem.Text;

            parentelement.AppendChild(emp_name);

            parentelement.AppendChild(Emp_id);

            parentelement.AppendChild(Qualification);

            xmldoc.DocumentElement.AppendChild(parentelement);

            xmldoc.Save(Server.MapPath("employee.xml"));

            BindDatalist();
        }
    }
}