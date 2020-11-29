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
        public List<Software> softwares = new List<Software>();
        public Scheme scheme;

        public NewSoftware()
        {
            InitializeComponent();
        }

        public void fillComboBox()
        {
            CB_softwares.Text = "Válasszon egy programot!";
            CB_softwares.ForeColor = Color.Silver;
            foreach (var software in softwares)
            {
                CB_softwares.Items.Add(software);
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
            checkForm();
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
            checkForm();
        }

        private void TXTBOX_softwareName_FocusEnter(object sender, EventArgs e)
        {
            if (TXTBOX_softwareName.Text == "Szoftver neve" && TXTBOX_softwareName.ForeColor == Color.Silver)
            {
                TXTBOX_softwareName.Text = "";
                TXTBOX_softwareName.ForeColor = Color.Black;
            }
            checkForm();
        }

        private void TXTBOX_softwareName_FocusLeave(object sender, EventArgs e)
        {
            if (TXTBOX_softwareName.Text == "")
            {
                TXTBOX_softwareName.ForeColor = Color.Silver;
                TXTBOX_softwareName.Text = "Szoftver neve";
            }
            checkForm();
        }

        private void TXTBOX_executePath_FocusEnter(object sender, EventArgs e)
        {
            if (TXTBOX_executePath.Text == "Alkalmazás (.exe) fájlt elérési útja" && TXTBOX_executePath.ForeColor == Color.Silver)
            {
                TXTBOX_executePath.Text = "";
                TXTBOX_executePath.ForeColor = Color.Black;
            }
            checkForm();
        }

        private void TXTBOX_executePath_FocusLeave(object sender, EventArgs e)
        {
            if (TXTBOX_executePath.Text == "")
            {
                TXTBOX_executePath.ForeColor = Color.Silver;
                TXTBOX_executePath.Text = "Alkalmazás (.exe) fájlt elérési útja";
            }
            checkForm();
        }

        private void TXTBOX_openPath_FocusEnter(object sender, EventArgs e)
        {
            if (TXTBOX_openPath.Text == "Betöltendő mappa, fájl vagy URL" && TXTBOX_openPath.ForeColor == Color.Silver)
            {
                TXTBOX_openPath.Text = "";
                TXTBOX_openPath.ForeColor = Color.Black;
            }
            checkForm();
        }

        private void TXTBOX_openPath_FocusLeave(object sender, EventArgs e)
        {
            if (TXTBOX_openPath.Text == "")
            {
                TXTBOX_openPath.ForeColor = Color.Silver;
                TXTBOX_openPath.Text = "Betöltendő mappa, fájl vagy URL";
            }
            checkForm();
        }

        void checkForm()
        {
            if (TXTBOX_softwareName.Text != "" && TXTBOX_softwareName.ForeColor != Color.Silver && TXTBOX_executePath.Text != "" && TXTBOX_executePath.ForeColor != Color.Silver)
            {
                if(softwares.Count != 0)
                {
                    foreach (var software in softwares)
                    {
                        if (software.Name != TXTBOX_softwareName.Text)
                        {
                            BTN_newSoftware.Enabled = true;
                        }
                        else
                        {
                            BTN_newSoftware.Enabled = false;
                            break;
                        }
                    }
                } else
                {
                    BTN_newSoftware.Enabled = true;
                }
            }
            else
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

        private void CB_softwares_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkSelectionForm();
        }

        private void BTN_selectSoftware_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Software selectedSoftware = (Software)CB_softwares.SelectedItem;
            if (TXTBOX_selectOpenPath.ForeColor != Color.Silver)
            {
                // MEGNYITUNK EGY FÁJLT
                main.SQLCommand("INSERT INTO softwares (scheme_id, name, path, openPath) VALUES ('" + scheme.Id + "', '" + selectedSoftware.Name + "', '" + selectedSoftware.Path + "', '" + TXTBOX_selectOpenPath.Text + "')", null);
            }
            else
            {
                main.SQLCommand("INSERT INTO softwares (scheme_id, name, path) VALUES ('" + scheme.Id + "', '" + selectedSoftware.Name + "', '" + selectedSoftware.Path + "')", null);
            }
            this.Close();
        }

        public void setSoftwares(List<Software> inputSoftwares)
        {
            softwares = inputSoftwares;
            fillComboBox();
        }

        private void TXTBOX_selectOpenPath_FocusEnter(object sender, EventArgs e)
        {
            if (TXTBOX_selectOpenPath.Text == "Betöltendő mappa, fájl vagy URL" && TXTBOX_selectOpenPath.ForeColor == Color.Silver)
            {
                TXTBOX_selectOpenPath.Text = "";
                TXTBOX_selectOpenPath.ForeColor = Color.Black;
            }
        }

        private void TXTBOX_selectOpenPath_FocusLeave(object sender, EventArgs e)
        {
            if (TXTBOX_selectOpenPath.Text == "")
            {
                TXTBOX_selectOpenPath.ForeColor = Color.Silver;
                TXTBOX_selectOpenPath.Text = "Betöltendő mappa, fájl vagy URL";
            }
        }

        private void TXTBOX_selectOpenPath_TextChanged(object sender, EventArgs e)
        {
            checkSelectionForm();
        }

        private void BTN_selectOpenPathExplorer_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TXTBOX_selectOpenPath.Text = openFileDialog.FileName;
                TXTBOX_selectOpenPath.ForeColor = Color.Black;
            }
            checkSelectionForm();
        }

        void checkSelectionForm()
        {
            if(CB_softwares.SelectedIndex != -1)
            {
                BTN_selectSoftware.Enabled = true;
            } else
            {
                BTN_selectSoftware.Enabled = false;
            }
        }

        private void CB_softwares_TextUpdate(object sender, EventArgs e)
        {
            foreach(var software in softwares)
            {
                if(CB_softwares.Text == software.Name)
                {
                    BTN_selectSoftware.Enabled = true;
                    break;
                } else
                {
                    BTN_selectSoftware.Enabled = false;
                }
            }
        }

        private void CB_softwares_FocusEnter(object sender, EventArgs e)
        {
            if(CB_softwares.ForeColor == Color.Silver)
            {
                CB_softwares.Text = "";
                CB_softwares.ForeColor = Color.Black;
            }
        }

        private void CB_softwares_FocusLeave(object sender, EventArgs e)
        {
            if(CB_softwares.Text == "" && CB_softwares.ForeColor == Color.Black)
            {
                CB_softwares.Text = "Válasszon egy programot!";
                CB_softwares.ForeColor = Color.Silver;
            }
        }
    }
}
