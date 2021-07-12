﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPClient =Microsoft.SharePoint.Client;

namespace ReadUpdateProp_using_CSOM_Windows_Fom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String url = "https://appsamer.sanofi.com/ws/PVI_dev/";
            SPClient.ClientContext ctx = new SPClient.ClientContext(url);
            SPClient.Web web = ctx.Web;
            ctx.Load(web);
            ctx.ExecuteQuery();
            MessageBox.Show(web.Title);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String url = "https://appsamer.sanofi.com/ws/PVI_dev/";
            SPClient.ClientContext ctx = new SPClient.ClientContext(url);
            SPClient.Web web = ctx.Web;
            web.Title = "PVI";
            web.Update();
            ctx.ExecuteQuery();
            MessageBox.Show("Updated");
        }
    }
}