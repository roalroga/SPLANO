using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPLANO
{
    public partial class SEGUNDO : Form
    {
        public SEGUNDO()
        {
            InitializeComponent();
        }

        private void Change(object sender, EventArgs e)
        {
            lblText.Text = txtText.Text;
        }
    }
}
