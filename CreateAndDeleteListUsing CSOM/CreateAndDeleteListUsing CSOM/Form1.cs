using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPClient=Microsoft.SharePoint.Client;

namespace CreateAndDeleteListUsing_CSOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "http://appsemea.sanofi.com/ws/PVI_DEV/";
            SPClient.ClientContext ctx = new SPClient.ClientContext(url);
            SPClient.Web web = ctx.Web;

            SPClient.ListCreationInformation ListInfo = new SPClient.ListCreationInformation();
            ListInfo.Title = "Parag_TEST1";
            ListInfo.Description = "Created for TESTing purpose";
            ListInfo.TemplateType = (int)SPClient.ListTemplateType.GenericList;
            SPClient.List list = web.Lists.Add(ListInfo);
            ctx.ExecuteQuery();
            MessageBox.Show("List Created");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "http://appsemea.sanofi.com/ws/PVI_DEV/";
            SPClient.ClientContext ctx = new SPClient.ClientContext(url);
            SPClient.Web web = ctx.Web;
            SPClient.List list= web.Lists.GetByTitle("Parag_TEST1");
            list.DeleteObject();
            ctx.ExecuteQuery();
            MessageBox.Show("List Deleted");
        }
    }
}
