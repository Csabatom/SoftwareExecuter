using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public Scheme scheme;

        public NewSoftware()
        {
            InitializeComponent();
            if(softwares.Count != 0)
            {
                foreach (var software in softwares)
                {
                    CB_softwares.Items.Add(software);
                }
            } else
            {
                CB_softwares.Enabled = true;
                CB_softwares.Items.Add("Hozz létre programot!");
            }
        }

        private void CB_softwares_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTN_selectSoftware_Click(object sender, EventArgs e)
        {
            if(CB_softwares.SelectedIndex != -1)
            {
                Main main = new Main();
                //main.SQLCommand("INSERT INTO schemes (name) VALUES ('" + TXTBOX_softwareName.Text + "')", null);
                this.Close();
            }
        }

        private void BTN_pathExplorer_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = ".exe|*.exe";
            var result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                //StreamReader streamReader = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                TXTBOX_executePath.Text = openFileDialog.FileName;
                TXTBOX_executePath.ForeColor = Color.Black;
            }
        }

        private void BTN_openPathFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //StreamReader streamReader = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                TXTBOX_openPath.Text = openFileDialog.FileName;
                TXTBOX_openPath.ForeColor = Color.Black;
            }
        }

        private void TXTBOX_softwareName_FocusEnter(object sender, EventArgs e)
        {
            if (TXTBOX_softwareName.Text == "Szoftver neve" && TXTBOX_softwareName.ForeColor == Color.Silver)
            {
                TXTBOX_softwareName.Text = "";
                TXTBOX_softwareName.ForeColor = Color.Black;
            }
        }

        private void TXTBOX_softwareName_FocusLeave(object sender, EventArgs e)
        {
            if (TXTBOX_softwareName.Text == "")
            {
                TXTBOX_softwareName.ForeColor = Color.Silver;
                TXTBOX_softwareName.Text = "Szoftver neve";
            }
        }

        private void TXTBOX_executePath_FocusEnter(object sender, EventArgs e)
        {
            if (TXTBOX_executePath.Text == "Alkalmazás (.exe) fájlt elérési útja" && TXTBOX_executePath.ForeColor == Color.Silver)
            {
                TXTBOX_executePath.Text = "";
                TXTBOX_executePath.ForeColor = Color.Black;
            }
        }

        private void TXTBOX_executePath_FocusLeave(object sender, EventArgs e)
        {
            if (TXTBOX_executePath.Text == "")
            {
                TXTBOX_executePath.ForeColor = Color.Silver;
                TXTBOX_executePath.Text = "Alkalmazás (.exe) fájlt elérési útja";
            }
        }

        private void TXTBOX_openPath_FocusEnter(object sender, EventArgs e)
        {
            if (TXTBOX_openPath.Text == "Betöltendő mappa, fájl vagy URL" && TXTBOX_openPath.ForeColor == Color.Silver)
            {
                TXTBOX_openPath.Text = "";
                TXTBOX_openPath.ForeColor = Color.Black;
            }
        }

        private void TXTBOX_openPath_FocusLeave(object sender, EventArgs e)
        {
            if (TXTBOX_openPath.Text == "")
            {
                TXTBOX_openPath.ForeColor = Color.Silver;
                TXTBOX_openPath.Text = "Betöltendő mappa, fájl vagy URL";
            }
        }

        void checkForm()
        {
            if ((TXTBOX_softwareName.ForeColor == Color.Black && TXTBOX_softwareName.Text != "") && (TXTBOX_executePath.ForeColor == Color.Black && TXTBOX_executePath.Text != "") && (TXTBOX_openPath.ForeColor == Color.Black && TXTBOX_openPath.Text != ""))
            {
                BTN_newSoftware.Enabled = true;
            } else
            {
                BTN_newSoftware.Enabled = false;
            }
        }

        private void TXTBOX_softwareName_TextChanged(object sender, EventArgs e)
        {
            checkForm();
        }

        private void TXTBOX_executePath_TextChanged(object sender, EventArgs e)
        {
            checkForm();
        }

        private void TXTBOX_openPath_TextChanged(object sender, EventArgs e)
        {
            checkForm();
        }

        private void BTN_newSoftware_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            if(TXTBOX_openPath.ForeColor != Color.Silver)
            {
                // MEGNYITUNK EGY FÁJLT
                main.SQLCommand("INSERT INTO softwares (scheme_id, name, path, openPath) VALUES ('" + scheme.Id + "', '" + TXTBOX_softwareName.Text + "', '" + TXTBOX_executePath.Text + "', '" + TXTBOX_openPath.Text + "')", null);
            } else
            {
                main.SQLCommand("INSERT INTO softwares (scheme_id, name, path) VALUES ('" + scheme.Id + "', '" + TXTBOX_softwareName.Text + "', '" + TXTBOX_executePath.Text + "')", null);
            }
            this.Close();
        }
    }
}
