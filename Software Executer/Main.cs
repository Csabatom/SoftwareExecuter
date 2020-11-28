using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Executer
{
    public partial class Main : Form
    {
        private SQLiteConnection conn;

        public Main()
        {
            InitializeComponent();

            conn = new SQLiteConnection("Data Source=SoftwareExecuter.db;");
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {

            }
            SQLCommand("CREATE TABLE IF NOT EXISTS schemes (id INTEGER PRIMARY KEY, name VARCHAR DEFAULT NULL)", null);
            SQLCommand("CREATE TABLE IF NOT EXISTS softwares (id INTEGER PRIMARY KEY, scheme_id DEFAULT -1, name VARCHAR DEFAULT NULL, path VARCHAR DEFAULT NULL, openPath VARCHAR DEFAULT NULL)", null);
            SQLCommand("CREATE TABLE IF NOT EXISTS settings (language VARCHAR DEFAULT 'English', launch_scheme INTEGER DEFAULT NULL)", null);
            //SQLCommand("INSERT INTO schemes (name) VALUES ('PHP Blog')", null);
            //SQLCommand("INSERT INTO schemes (name) VALUES ('C# állapot')", null);
            //SQLCommand("INSERT INTO softwares (scheme_id, name, path) VALUES (0, 'VS Code', 'C:/Users/nyiro/AppData/Local/Programs/Microsoft VS Code/Code.exe')", null);
            //SQLCommand("INSERT INTO softwares (scheme_id, name, path) VALUES (0, 'VS Studio 2019', 'C:/Program Files (x86)/Microsoft Visual Studio/2019/Community/Common7/IDE/devenv.exe')", null);

            LoadData();
        }

        private void BTN_newScheme_Click(object sender, EventArgs e)
        {
            NewScheme newScheme = new NewScheme();
            newScheme.FormClosed += new FormClosedEventHandler(newScheme_FormClosed);
            foreach (var scheme in LB_Schemes.Items)
            {
                newScheme.schemes.Add((Scheme)scheme);
            }
            newScheme.Show();
        }

        void newScheme_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.LoadData();
        }

        public void LoadData()
        {
            LB_Schemes.Items.Clear();
            SQLCommand("SELECT * FROM schemes;", LB_Schemes);
        }

        public void SQLCommand(String inputComm, ListBox insertList)
        {
            SQLiteCommand command;
            command = conn.CreateCommand();
            command.CommandText = inputComm;
            command.ExecuteNonQuery();

            if(inputComm.Contains("SELECT") && insertList != null)
            {
                SQLiteDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if(insertList.Name.Contains("Schemes"))
                    {
                        LB_Schemes.Items.Add(new Scheme(int.Parse(reader["id"].ToString()), reader["name"].ToString()));
                    } else if(insertList.Name.Contains("Softwares") && inputComm.Contains("WHERE"))
                    {
                        LB_Softwares.Items.Add(new Software(int.Parse(reader["id"].ToString()), int.Parse(reader["scheme_id"].ToString()), reader["name"].ToString(), reader["path"].ToString(), reader["openPath"].ToString()));
                    }
                }
            }
        }

        private void LB_Schemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_Softwares.Items.Clear();
            BTN_deleteSoftware.Enabled = false;
            if (LB_Schemes.SelectedIndex == -1)
            {
                BTN_newSoftware.Enabled = false;
                BTN_deleteScheme.Enabled = false;
            }
            else
            {
                BTN_newSoftware.Enabled = true;
                BTN_deleteScheme.Enabled = true;
                SQLCommand("SELECT * FROM softwares WHERE scheme_id LIKE '" + ((Scheme)LB_Schemes.SelectedItem).Id + "';", LB_Softwares);
            }
        }

        private void BTN_deleteScheme_Click(object sender, EventArgs e)
        {
            SQLCommand("DELETE FROM schemes WHERE id LIKE '" + ((Scheme)LB_Schemes.SelectedItem).Id + "';", null);
            SQLCommand("DELETE FROM softwares WHERE scheme_id LIKE '" + ((Scheme)LB_Schemes.SelectedItem).Id + "';", null);
            LB_Schemes.Items.RemoveAt(LB_Schemes.SelectedIndex);
        }

        private void BTN_deleteSoftware_Click(object sender, EventArgs e)
        {
            //var kivalasztott = (Scheme)LB_Softwares.SelectedIndex;
            SQLCommand("DELETE FROM softwares WHERE id LIKE '" + ((Software)LB_Softwares.Items[LB_Softwares.SelectedIndex]).Id + "';", null);
            LB_Softwares.Items.RemoveAt(LB_Softwares.SelectedIndex);
        }

        private void LB_Softwares_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LB_Softwares.SelectedIndex == -1)
            {
                BTN_deleteSoftware.Enabled = false;
            } else
            {
                BTN_deleteSoftware.Enabled = true;
            }
        }

        private void BTN_newSoftware_Click(object sender, EventArgs e)
        {
            NewSoftware newSoftware = new NewSoftware();
            newSoftware.FormClosed += new FormClosedEventHandler(newSoftware_FormClosed);
            newSoftware.scheme = (Scheme)LB_Schemes.SelectedItem;
            newSoftware.softwares = new List<Software>(){new Software(0, 0, "valami", "path", "path")};
            newSoftware.Show();
        }

        void newSoftware_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.LoadData();
        }
    }
}
