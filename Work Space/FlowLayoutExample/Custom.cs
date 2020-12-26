using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowLayoutExample
{
    public partial class Custom : Form
    {
        public Custom()
        {
            InitializeComponent();
        }

        public void change()
        {
            lbl.Text = "Changed text";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
