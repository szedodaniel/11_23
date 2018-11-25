namespace _2311
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
            this.nevTextBox = new System.Windows.Forms.TextBox();
            this.jelszoTextBox = new System.Windows.Forms.TextBox();
            this.szuletesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.regButton = new System.Windows.Forms.Button();
            this.frissitesButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nevTextBox
            // 
            this.nevTextBox.Location = new System.Drawing.Point(12, 13);
            this.nevTextBox.Name = "nevTextBox";
            this.nevTextBox.Size = new System.Drawing.Size(256, 20);
            this.nevTextBox.TabIndex = 0;
            // 
            // jelszoTextBox
            // 
            this.jelszoTextBox.Location = new System.Drawing.Point(12, 49);
            this.jelszoTextBox.Name = "jelszoTextBox";
            this.jelszoTextBox.PasswordChar = '*';
            this.jelszoTextBox.Size = new System.Drawing.Size(256, 20);
            this.jelszoTextBox.TabIndex = 1;
            // 
            // szuletesDateTimePicker
            // 
            this.szuletesDateTimePicker.Location = new System.Drawing.Point(12, 84);
            this.szuletesDateTimePicker.Name = "szuletesDateTimePicker";
            this.szuletesDateTimePicker.Size = new System.Drawing.Size(256, 20);
            this.szuletesDateTimePicker.TabIndex = 2;
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(193, 136);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(75, 23);
            this.regButton.TabIndex = 3;
            this.regButton.Text = "regbutton";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // frissitesButton
            // 
            this.frissitesButton.Location = new System.Drawing.Point(103, 136);
            this.frissitesButton.Name = "frissitesButton";
            this.frissitesButton.Size = new System.Drawing.Size(75, 23);
            this.frissitesButton.TabIndex = 4;
            this.frissitesButton.Text = "Módosít";
            this.frissitesButton.UseVisualStyleBackColor = true;
            this.frissitesButton.Click += new System.EventHandler(this.frissitesButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Törlés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 184);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.frissitesButton);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.szuletesDateTimePicker);
            this.Controls.Add(this.jelszoTextBox);
            this.Controls.Add(this.nevTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nevTextBox;
        private System.Windows.Forms.TextBox jelszoTextBox;
        private System.Windows.Forms.DateTimePicker szuletesDateTimePicker;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Button frissitesButton;
        private System.Windows.Forms.Button button1;
    }
}

