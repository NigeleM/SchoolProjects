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

namespace Artifact_
{
   
    public partial class EditForm : Form
    {
        ArtifactModel Model = new ArtifactModel();
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditArtifactList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void newArtifactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newArtifact = new Form1();
            newArtifact.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Record;
            string[] ParsedRecord;
            Record = ListedArtifacts.SelectedItem.ToString();

           ParsedRecord = Record.Split(',');
            EditedArtifactType.Text = ParsedRecord[1];
            EditedArtifactName.Text = ParsedRecord[2];
            EditedDescription.Text = ParsedRecord[3];

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
                string stm = "SELECT * FROM ArtifactTable";

                var cmd = new SQLiteCommand(stm, con);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                //Adding each record to the listView
                while (rdr.Read())
                {
                     ListedArtifacts.Items.Add(string.Format(" {0} , {1} , {2} , {3}", rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(3), rdr.GetString(4)));

                }

            }
            catch (Exception ex)
            {
                // Display Error message is something goes wrong
                MessageBox.Show(ex.ToString());

            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Record;
                string[] ParsedRecord;
                Record = ListedArtifacts.SelectedItem.ToString();

                ParsedRecord = Record.Split(',');

                // Check if all the Text boxes are filled 
                // Check if something has been selected in the Category list
                // int intselectedindex = NewArtifactList.SelectedIndices[0];
                // if (NewName.Text != "" && NewDescription.Text != "" && NewArtifactList.Items[intselectedindex].Text != "")
                {
                    // Model used to hold the data from the textbox and list
                    Model.Name = EditedArtifactName.Text;
                    Model.description = EditedDescription.Text;
                    if (EditedArtifactType.SelectedItem == null)
                        Model.type = ParsedRecord[1];
                    else
                        Model.type = EditedArtifactType.SelectedItem.ToString();

                    try
                    {
                        


                        // Create a connection to SQLite and insert into table
                        string cs = @"URI=file:C:..\..\ArtifactDatabase\Artifact.db";
                        var con = new SQLiteConnection(cs);
                        con.Open();
                        var cmd = new SQLiteCommand(con);
                        string statement = String.Format("UPDATE ArtifactTable set Artifact_Type='{0}',  Artifact_Name='{1}',  Artifact_Description='{2}' WHERE Artifact_ID='{3}'", Model.type, Model.Name, Model.description,ParsedRecord[0]);
                        // (Artifact_Type, Artifact_Name, Artifact_Description)
                        cmd.CommandText = statement;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Artifact Saved");
                        ListedArtifacts.Items.Clear();
                        this.loadDataIntoCombo();

                    }
                    catch (Exception ex)
                    {
                        // Catch exception if one occurs
                        MessageBox.Show(ex.ToString());

                    }

                }
            }
            catch (Exception ex)
            {
                // If Category hasn't been selected 
                // display this message
                MessageBox.Show("Select An Artifact Category");
            }
        }
    }
}
