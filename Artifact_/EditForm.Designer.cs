namespace Artifact_
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditedDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewName = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NewAttach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EditedArtifactType = new System.Windows.Forms.ComboBox();
            this.EditArtifact = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EditedArtifactName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newArtifactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListedArtifacts = new System.Windows.Forms.ComboBox();
            this.EditArtifact.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(416, 46);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditedDescription
            // 
            this.EditedDescription.Location = new System.Drawing.Point(11, 76);
            this.EditedDescription.Multiline = true;
            this.EditedDescription.Name = "EditedDescription";
            this.EditedDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EditedDescription.Size = new System.Drawing.Size(459, 121);
            this.EditedDescription.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Artifact Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Artifact Type";
            // 
            // NewName
            // 
            this.NewName.Location = new System.Drawing.Point(85, -20);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(385, 20);
            this.NewName.TabIndex = 11;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(11, 279);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NewAttach
            // 
            this.NewAttach.Location = new System.Drawing.Point(11, 250);
            this.NewAttach.Name = "NewAttach";
            this.NewAttach.Size = new System.Drawing.Size(75, 23);
            this.NewAttach.TabIndex = 16;
            this.NewAttach.Text = "Attach";
            this.NewAttach.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, -17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Artifact Name";
            // 
            // EditedArtifactType
            // 
            this.EditedArtifactType.FormattingEnabled = true;
            this.EditedArtifactType.Items.AddRange(new object[] {
            "Requirement Workflow",
            "UI Design ",
            "Database Table Design ",
            "Source Code",
            "Database Code",
            "Test Cases"});
            this.EditedArtifactType.Location = new System.Drawing.Point(81, 213);
            this.EditedArtifactType.Name = "EditedArtifactType";
            this.EditedArtifactType.Size = new System.Drawing.Size(204, 21);
            this.EditedArtifactType.TabIndex = 18;
            // 
            // EditArtifact
            // 
            this.EditArtifact.Controls.Add(this.label4);
            this.EditArtifact.Controls.Add(this.EditedArtifactName);
            this.EditArtifact.Controls.Add(this.EditedArtifactType);
            this.EditArtifact.Controls.Add(this.label1);
            this.EditArtifact.Controls.Add(this.NewAttach);
            this.EditArtifact.Controls.Add(this.SaveButton);
            this.EditArtifact.Controls.Add(this.NewName);
            this.EditArtifact.Controls.Add(this.label3);
            this.EditArtifact.Controls.Add(this.label2);
            this.EditArtifact.Controls.Add(this.EditedDescription);
            this.EditArtifact.Location = new System.Drawing.Point(12, 75);
            this.EditArtifact.Name = "EditArtifact";
            this.EditArtifact.Size = new System.Drawing.Size(479, 311);
            this.EditArtifact.TabIndex = 13;
            this.EditArtifact.TabStop = false;
            this.EditArtifact.Text = "EditArtifact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Artifact Name";
            // 
            // EditedArtifactName
            // 
            this.EditedArtifactName.Location = new System.Drawing.Point(85, 26);
            this.EditedArtifactName.Name = "EditedArtifactName";
            this.EditedArtifactName.Size = new System.Drawing.Size(385, 20);
            this.EditedArtifactName.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newArtifactToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newArtifactToolStripMenuItem
            // 
            this.newArtifactToolStripMenuItem.Name = "newArtifactToolStripMenuItem";
            this.newArtifactToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.newArtifactToolStripMenuItem.Text = "New Artifact";
            this.newArtifactToolStripMenuItem.Click += new System.EventHandler(this.newArtifactToolStripMenuItem_Click);
            // 
            // ListedArtifacts
            // 
            this.ListedArtifacts.FormattingEnabled = true;
            this.ListedArtifacts.Location = new System.Drawing.Point(12, 46);
            this.ListedArtifacts.Name = "ListedArtifacts";
            this.ListedArtifacts.Size = new System.Drawing.Size(398, 21);
            this.ListedArtifacts.TabIndex = 18;
            this.ListedArtifacts.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 398);
            this.Controls.Add(this.ListedArtifacts);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditArtifact);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.EditArtifact.ResumeLayout(false);
            this.EditArtifact.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox EditedDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NewAttach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EditedArtifactType;
        private System.Windows.Forms.GroupBox EditArtifact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EditedArtifactName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newArtifactToolStripMenuItem;
        private System.Windows.Forms.ComboBox ListedArtifacts;
    }
}