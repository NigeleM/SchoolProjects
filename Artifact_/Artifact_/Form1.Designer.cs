namespace Artifact_
{
    partial class Form1
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
            this.NewName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewDescription = new System.Windows.Forms.TextBox();
            this.NewAttach = new System.Windows.Forms.Button();
            this.NewArtifact = new System.Windows.Forms.GroupBox();
            this.SelectionBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewArtifact.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewName
            // 
            this.NewName.Location = new System.Drawing.Point(88, 24);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(385, 20);
            this.NewName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artifact Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artifact Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Artifact Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // NewDescription
            // 
            this.NewDescription.Location = new System.Drawing.Point(14, 74);
            this.NewDescription.Multiline = true;
            this.NewDescription.Name = "NewDescription";
            this.NewDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NewDescription.Size = new System.Drawing.Size(459, 121);
            this.NewDescription.TabIndex = 4;
            // 
            // NewAttach
            // 
            this.NewAttach.Location = new System.Drawing.Point(14, 259);
            this.NewAttach.Name = "NewAttach";
            this.NewAttach.Size = new System.Drawing.Size(75, 23);
            this.NewAttach.TabIndex = 6;
            this.NewAttach.Text = "Attach";
            this.NewAttach.UseVisualStyleBackColor = true;
            this.NewAttach.Click += new System.EventHandler(this.NewAttach_Click);
            // 
            // NewArtifact
            // 
            this.NewArtifact.Controls.Add(this.SelectionBox);
            this.NewArtifact.Controls.Add(this.label1);
            this.NewArtifact.Controls.Add(this.NewAttach);
            this.NewArtifact.Controls.Add(this.SaveButton);
            this.NewArtifact.Controls.Add(this.NewName);
            this.NewArtifact.Controls.Add(this.label3);
            this.NewArtifact.Controls.Add(this.label2);
            this.NewArtifact.Controls.Add(this.NewDescription);
            this.NewArtifact.Location = new System.Drawing.Point(12, 41);
            this.NewArtifact.Name = "NewArtifact";
            this.NewArtifact.Size = new System.Drawing.Size(479, 345);
            this.NewArtifact.TabIndex = 7;
            this.NewArtifact.TabStop = false;
            this.NewArtifact.Text = "New Artifact";
            this.NewArtifact.Enter += new System.EventHandler(this.NewArtifact_Enter);
            // 
            // SelectionBox
            // 
            this.SelectionBox.FormattingEnabled = true;
            this.SelectionBox.Items.AddRange(new object[] {
            "Requirement Workflow",
            "UI Design ",
            "Database Table Design ",
            "Source Code",
            "Database Code",
            "Test Cases"});
            this.SelectionBox.Location = new System.Drawing.Point(84, 220);
            this.SelectionBox.Name = "SelectionBox";
            this.SelectionBox.Size = new System.Drawing.Size(204, 21);
            this.SelectionBox.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(14, 305);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.addReportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem1.Text = "Edit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // addReportsToolStripMenuItem
            // 
            this.addReportsToolStripMenuItem.Name = "addReportsToolStripMenuItem";
            this.addReportsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.addReportsToolStripMenuItem.Text = "Add Reports";
            this.addReportsToolStripMenuItem.Click += new System.EventHandler(this.addReportsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 398);
            this.Controls.Add(this.NewArtifact);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.NewArtifact.ResumeLayout(false);
            this.NewArtifact.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewDescription;
        private System.Windows.Forms.Button NewAttach;
        private System.Windows.Forms.GroupBox NewArtifact;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ComboBox SelectionBox;
        private System.Windows.Forms.ToolStripMenuItem addReportsToolStripMenuItem;
    }
}

