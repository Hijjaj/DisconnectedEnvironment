using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconnectedEnvironment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet1.empdetails' table. You can move, or remove it, as needed.
            this.empdetailsTableAdapter1.Fill(this.prodiTIDataSet1.empdetails);
            // TODO: This line of code loads data into the 'prodiTIDataSet.empdetails' table. You can move, or remove it, as needed.
            this.empdetailsTableAdapter.Fill(this.prodiTIDataSet.empdetails);

        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
