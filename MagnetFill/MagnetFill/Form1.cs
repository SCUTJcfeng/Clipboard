using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MagnetFill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (tbInput.Text != null)
            {
                lbMagnet.Text = "magnet:?xt=urn:btih:" + tbInput.Text;
                
                //Default
                //Process.Start("Thunder");
                //My specific Process Path
                Process.Start(@"C:\Users\JC\Downloads\Thunder V9.1.37.846\Program\Thunder.exe");
                Clipboard.SetDataObject(lbMagnet.Text,true);
                IDataObject idata = Clipboard.GetDataObject();
                if (idata.GetData(DataFormats.Text).ToString() == lbMagnet.Text)
                    MessageBox.Show("Magnet has been copied to Clipboard, Thunder will be opened.");
            }
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            if(tbWeb!=null)
            {
                Process.Start("Chrome", tbWeb.Text);
            }
        }
    }
}
