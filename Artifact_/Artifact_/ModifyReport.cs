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
    public partial class ModifyReport : Form
    {

       
        public ModifyReport()
        {
            InitializeComponent();
        }

        private void listedReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Record;
            string[] ParsedRecord;
            Record = listedReports.SelectedItem.ToString();

            ParsedRecord = Record.Split(',');
            nameText.Text = ParsedRecord[1];
            descriptionText.Text = ParsedRecord[2];
            DateText.Text = ParsedRecord[3];
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateText_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {


            try
            {
                string Record;
                string[] ParsedRecord;
                Record = listedReports.SelectedItem.ToString();

                ParsedRecord = Record.Split(',');


                string name = nameText.Text;
                string description = descriptionText.Text;
                string Date = DateText.Text;

                // Create a connection to SQLite and insert into table
                string cs = @"URI=file:C:..\..\ArtifactDatabase\Artifact.db";
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                string statement = String.Format("UPDATE Reports set name='{0}',  desc='{1}',  date='{2}' WHERE id='{3}'",name,description,Date, ParsedRecord[0]);
                // (Artifact_Type, Artifact_Name, Artifact_Description)
                cmd.CommandText = statement;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reports Saved");
                listedReports.Items.Clear();
                this.loadDataIntoCombo();

            }
            catch (Exception ex)
            {
                // Catch exception if one occurs
                MessageBox.Show(ex.ToString());

            }



            try
            {
                string id = "";
                string name = nameText.Text;
                string description = descriptionText.Text;
                string Date = DateText.Text;
                // Creat connection
                string cs = @"URI=file:C:..\..\ArtifactDatabase\Artifact.db";
                var con = new SQLiteConnection(cs);
                con.Open();
                // Get all records from table
                string stm = String.Format("SELECT id FROM Reports where name='{0}' AND desc='{1}'", name, description);
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
                string statement = String.Format("UPDATE Reports_Xref set Ref_ID='{0}',  Artifact_ID='{1}',  id='{2}' where id={3}", id, id, id,id);
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
    }
}
