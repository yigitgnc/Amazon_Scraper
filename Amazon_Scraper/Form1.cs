using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScraper.Utils.Clients;
using Amazon_Scraper.Utils;

namespace Amazon_Scraper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            BusinessCore.GetProductsAsync(tbUrl.Text);
            //Test();
            customWebBrowser1.Navigate(tbUrl.Text);
        }

        CustomWebBrowser browser = new CustomWebBrowser();
        public async void Test()
        {
            //webBrowser1.Navigate("about:blank");

            ////var a = await browser.GetDocumentAsync(tbUrl.Text);

            //string b = "";

            //await Task.Run(async () =>
            //{
            //    var bd = await browser.GetDocumentAsync(tbUrl.Text);
            //    b = bd.Body.OuterHtml;
            //});
            //webBrowser1.Document.Write(b);
            //webBrowser1.Refresh();

        }

        private void NumberOnlyTextBox(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (!int.TryParse(tb.Text, out BusinessCore.MaxThread))
            {
                tb.Text = 1.ToString();
            }
        }

        private void cbAsyncMode_CheckedChanged(object sender, EventArgs e)
        {
            var cb = sender as CheckBox;
            if (cb.Checked)
            {
                gbPreview.Enabled = false;
            }
            else
            {
                gbPreview.Enabled = true;
            }

            BusinessCore.AsyncMode = cb.Checked;

        }

        private void cbUseRndDelay_CheckedChanged(object sender, EventArgs e)
        {

            var cb = sender as CheckBox;
            BusinessCore.RndDelayMin = Convert.ToInt32(tbRndDelayMin.Text);
            BusinessCore.RndDelayMax = Convert.ToInt32(tbRndDelayMax.Text);
            BusinessCore.UseRndDelay = cb.Checked;
        }
    }
}
