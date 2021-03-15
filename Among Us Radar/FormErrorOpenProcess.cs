using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Among_Us_Radar
{
    public partial class FormErrorOpenProcess : Form
    {
        public FormErrorOpenProcess()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            ActiveForm.Close();
        }
    }
}
