using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

using System.Windows.Forms;

namespace Artifact_
{
    public partial class Form1 : Form
    {
        ArtifactModel Model = new ArtifactModel();
        EditForm eForm = new EditForm();
        AddReport ReportForm = new AddReport();
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            try
            {
                // Check if all the Text boxes are filled 
                // Check if something has been selected in the Category list
               // int intselectedindex = NewArtifactList.SelectedIndices[0];
               // if (NewName.Text != "" && NewDescription.Text != "" && NewArtifactList.Items[intselectedindex].Text != "")
                {
                    // Model used to hold the data from the textbox and list
                    Model.Name = NewName.Text;
                    Model.description = NewDescription.Text;
                    Model.type = SelectionBox.SelectedItem.ToString();
                
                    try
                    {

                        // Create a connection to SQLite and insert into table
                        string cs = @"URI=file:C:..\..\ArtifactDatabase\Artifact.db";
                        var con = new SQLiteConnection(cs);
                        con.Open();
                        var cmd = new SQLiteCommand(con);
                        string statement = String.Format("INSERT INTO ArtifactTable(Artifact_Type, Artifact_Name, Artifact_Description) VALUES('{0}','{1}','{2}')", Model.type, Model.Name, Model.description);
                        cmd.CommandText = statement;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Artifact Saved");

                    }
                    catch(Exception ex)
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

        

        private void NewAttach_Click(object sender, EventArgs e)
        {
            // Code for how to attach a file
        }

        private void EditAttach_Click(object sender, EventArgs e)
        {
            // Code for how to attach a file
        }

        private void EditSaveButton_Click(object sender, EventArgs e)
        {
            // Code for modifying the a record in the table
        }

        private void NewArtifact_Enter(object sender, EventArgs e)
        {

        }

        private void NewArtifactList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if ((null == eForm) || (eForm.IsDisposed))
            {
                EditForm eForm = new EditForm();
                eForm.Show();
                eForm.loadDataIntoCombo();
            }
            else
            {
                eForm.Show();
                eForm.loadDataIntoCombo();
            }

        }

        private void addReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((null == ReportForm) || (ReportForm.IsDisposed))
            {
               AddReport ReportForm = new AddReport();

                ReportForm.Show();
                ReportForm.loadDataIntoCombo();
            }
            else
            {
                ReportForm.Show();
                ReportForm.loadDataIntoCombo();
            }

           
        }
    }
}
