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

    public partial class NewScheme : Form
    {
        public List<Scheme> schemes = new List<Scheme>();

        public NewScheme()
        {
            InitializeComponent();
        }

        private void TXTBOX_schemeName_TextChanged(object sender, EventArgs e)
        {
            if (TXTBOX_schemeName.Text != "" && TXTBOX_schemeName.ForeColor != Color.Silver)
            {
                if(schemes.Count != 0)
                {
                    foreach (var scheme in schemes)
                    {
                        if (scheme.Name != TXTBOX_schemeName.Text)
                        {
                            BTN_newScheme.Enabled = true;
                        }
                        else
                        {
                            BTN_newScheme.Enabled = false;
                            break;
                        }
                    }
                } else
                {
                    BTN_newScheme.Enabled = true;
                }
            } else
            {
                BTN_newScheme.Enabled = false;
            }
        }

        private void TXTBOX_schemeName_Enter(object sender, EventArgs e)
        {
            if(TXTBOX_schemeName.Text == "Séma neve" && TXTBOX_schemeName.ForeColor == Color.Silver)
            {
                TXTBOX_schemeName.Text = "";
                TXTBOX_schemeName.ForeColor = Color.Black;
            }
        }

        private void TXTBOX_schemeName_Leave(object sender, EventArgs e)
        {
            if(TXTBOX_schemeName.Text == "")
            {
                TXTBOX_schemeName.ForeColor = Color.Silver;
                TXTBOX_schemeName.Text = "Séma neve";
            }
        }

        private void NewScheme_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;   
        }

        private void BTN_newScheme_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.SQLCommand("INSERT INTO schemes (name) VALUES ('" + TXTBOX_schemeName.Text + "')", null);
            this.Close();
        }
    }
}
