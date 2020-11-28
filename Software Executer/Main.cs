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
            SQLCommand("CREATE TABLE IF NOT EXISTS softwares (id INTEGER PRIMARY KEY, scheme_id NOT NULL, name VARCHAR DEFAULT NULL, path VARCHAR DEFAULT NULL, openPath VARCHAR DEFAULT NULL)", null);
            SQLCommand("CREATE TABLE IF NOT EXISTS settings (language VARCHAR DEFAULT 'English', launch_scheme INTEGER DEFAULT NULL)", null);
            SQLCommand("INSERT INTO schemes (name) VALUES ('OneShot')", null);

            LoadData();
        }

        private void BTN_newScheme_Click(object sender, EventArgs e)
        {
            NewScheme newScheme = new NewScheme();
            newScheme.Show();
        }

        void LoadData()
        {
            SQLCommand("SELECT * FROM schemes;", LB_Schemes);
        }

        void SQLCommand(String inputComm, ListBox insertList)
        {
            SQLiteCommand command;
            command = conn.CreateCommand();
            command.CommandText = inputComm;
            command.ExecuteNonQuery();

            if(insertList != null)
            {
                SQLiteDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    insertList.Items.Add(reader.);
                }
            }
        }

        private void LB_Schemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLCommand("SELECT * FROM softwares INNER JOIN schemes ON softwares.scheme_id = schemes.id WHERE scheme_id LIKE "+LB_Schemes.SelectedIndex+";", LB_Programs);
        }
    }
}
