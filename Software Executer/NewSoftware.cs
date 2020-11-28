using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Executer
{
    public partial class NewSoftware : Form
    {
        public List<Scheme> schemes = new List<Scheme>();
        public List<Software> softwares = new List<Software>();

        public NewSoftware()
        {
            InitializeComponent();
            foreach(var software in softwares)
            {
                CB_softwares.Items.Add(software);
            }
        }

        private void CB_softwares_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
