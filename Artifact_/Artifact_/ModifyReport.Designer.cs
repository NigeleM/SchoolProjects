
namespace Artifact_
{
    partial class ModifyReport
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listedReports = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateText = new System.Windows.Forms.TextBox();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(35, 233);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 17;
            this.UpdateButton.Text = "Update Report";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Records";
            // 
            // listedReports
            // 
            this.listedReports.FormattingEnabled = true;
            this.listedReports.Location = new System.Drawing.Point(85, 46);
            this.listedReports.Name = "listedReports";
            this.listedReports.Size = new System.Drawing.Size(384, 21);
            this.listedReports.TabIndex = 15;
            this.listedReports.SelectedIndexChanged += new System.EventHandler(this.listedReports_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // DateText
            // 
            this.DateText.Location = new System.Drawing.Point(295, 91);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(178, 20);
            this.DateText.TabIndex = 11;
            this.DateText.TextChanged += new System.EventHandler(this.DateText_TextChanged);
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(102, 131);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(371, 75);
            this.descriptionText.TabIndex = 10;
            this.descriptionText.TextChanged += new System.EventHandler(this.descriptionText_TextChanged);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(85, 91);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(157, 20);
            this.nameText.TabIndex = 9;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // ModifyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 290);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listedReports);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateText);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.nameText);
            this.Name = "ModifyReport";
            this.Text = "ModifyReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox listedReports;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DateText;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.TextBox nameText;
    }
}