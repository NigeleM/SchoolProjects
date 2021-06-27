using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Artifact_
{
    public partial class AddReport : Form
    {
        ModifyReport ModifyForm = new ModifyReport();
        public AddReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id="";
            try
            {

                // Model used to hold the data from the textbox and list
                string name = nameText.Text;
                string description = descriptionText.Text;
                string Date = DateText.Text;


                // Create a connection to SQLite and insert into table
                string cs = @"URI=file:C:..\..\ArtifactDatabase\Artifact.db";
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                string statement = String.Format("INSERT INTO Reports(name, desc, date) VALUES('{0}','{1}','{2}')", name, description, Date);
                cmd.CommandText = statement;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Report Saved");
                listedReports.Items.Clear();
                loadDataIntoCombo();
                con.Close();

            }
            catch (Exception ex)
            {
                // Catch exception if one occurs
                MessageBox.Show(ex.ToString());

            }


            try
            {
                string name = nameText.Text;
                string description = descriptionText.Text;
                string Date = DateText.Text;
                // Creat connection
                string cs = @"URI=file:C:..\..\ArtifactDatabase\Artifact.db";
                var con = new SQLiteConnection(cs);
                con.Open();
                // Get all records from table
                string stm = String.Format("SELECT id FROM Reports where name='{0}' AND desc='{1}'",name,description);
                MessageBox.Show(stm);
                var cmd = new SQLiteCommand(stm, con);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                //Adding each record to the listView
                while (rdr.Read())
                {
                   id = string.Format("{0}", rdr.GetInt32(0));
                    MessageBox.Show(id);
                }

                // Create a connection to SQLite and insert into table
                 cs = @"URI=file:C:..\..\ArtifactDatabase\Artifact.db";
                 con = new SQLiteConnection(cs);
                con.Open();
                cmd = new SQLiteCommand(con);
                string statement = String.Format("INSERT INTO Reports_Xref(Artifact_ID, id, Ref_ID) VALUES('{0}','{1}','{2}')", id, id, id);
                cmd.CommandText = statement;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Report Reference Saved");

            }
            catch (Exception ex)
            {
                // Display Error message is something goes wrong
                MessageBox.Show(ex.ToString());

            }



        }


        public void loadDataIntoCombo()
        {

            try
            {
                // Creat connection
                string cs = @"URI=file:C:..\..\ArtifactDatabase\Artifact.db";
                var con = new SQLiteConnection(cs);
                con.Open();
                // Get all records from table
                string stm = "SELECT id, name, desc, date FROM Reports";
                var cmd = new SQLiteCommand(stm, con);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                //Adding each record to the listView
                while (rdr.Read())
                {
                    listedReports.Items.Add(string.Format("{0}, {1} , {2}, {3}", rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetValue(3)));
                }

            }
            catch (Exception ex)
            {
                // Display Error message is something goes wrong
                MessageBox.Show(ex.ToString());

            }

        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((null == ModifyForm) || (ModifyForm.IsDisposed))
            {
                ModifyReport ModifyForm = new ModifyReport();

                ModifyForm.Show();
                ModifyForm.loadDataIntoCombo();
            }
            else
            {
                ModifyForm.Show();
                ModifyForm.loadDataIntoCombo();
            }

        }
    }
}
