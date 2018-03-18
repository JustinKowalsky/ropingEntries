namespace ropingEntries
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
            this.entryName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addEntry = new System.Windows.Forms.Button();
            this.randomEntires = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pickPartner = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.csvExport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entryName
            // 
            this.entryName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entryName.Location = new System.Drawing.Point(146, 27);
            this.entryName.Name = "entryName";
            this.entryName.Size = new System.Drawing.Size(221, 20);
            this.entryName.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(128, 13);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Entrant Name:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addEntry
            // 
            this.addEntry.Location = new System.Drawing.Point(292, 145);
            this.addEntry.Name = "addEntry";
            this.addEntry.Size = new System.Drawing.Size(75, 23);
            this.addEntry.TabIndex = 2;
            this.addEntry.Text = "Add Entry";
            this.addEntry.UseVisualStyleBackColor = true;
            this.addEntry.Click += new System.EventHandler(this.addEntry_Click);
            // 
            // randomEntires
            // 
            this.randomEntires.Location = new System.Drawing.Point(146, 221);
            this.randomEntires.Name = "randomEntires";
            this.randomEntires.Size = new System.Drawing.Size(198, 64);
            this.randomEntires.TabIndex = 3;
            this.randomEntires.Text = "Randomize Entries";
            this.randomEntires.UseVisualStyleBackColor = true;
            this.randomEntires.Click += new System.EventHandler(this.randomEntries_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(246, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Please choose a role";
            // 
            // pickPartner
            // 
            this.pickPartner.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.pickPartner.Location = new System.Drawing.Point(146, 98);
            this.pickPartner.Name = "pickPartner";
            this.pickPartner.Size = new System.Drawing.Size(221, 20);
            this.pickPartner.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 13);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Pick 1 Partner";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // csvExport
            // 
            this.csvExport.Location = new System.Drawing.Point(49, 427);
            this.csvExport.Name = "csvExport";
            this.csvExport.Size = new System.Drawing.Size(133, 33);
            this.csvExport.TabIndex = 7;
            this.csvExport.Text = "Export to CSV";
            this.csvExport.UseVisualStyleBackColor = true;
            this.csvExport.Click += new System.EventHandler(this.csvExport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "RESET!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.csvExport);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pickPartner);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.randomEntires);
            this.Controls.Add(this.addEntry);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.entryName);
            this.Name = "Form1";
            this.Text = "Kinsman Quarter Horses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entryName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addEntry;
        private System.Windows.Forms.Button randomEntires;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox pickPartner;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button csvExport;
        private System.Windows.Forms.Button button1;
    }
}

