namespace Employee_Class
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
            this.buttonShowEmployees = new System.Windows.Forms.Button();
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowEmployees
            // 
            this.buttonShowEmployees.Location = new System.Drawing.Point(91, 88);
            this.buttonShowEmployees.Name = "buttonShowEmployees";
            this.buttonShowEmployees.Size = new System.Drawing.Size(129, 41);
            this.buttonShowEmployees.TabIndex = 0;
            this.buttonShowEmployees.Text = "Display Employees";
            this.buttonShowEmployees.UseVisualStyleBackColor = true;
            this.buttonShowEmployees.Click += new System.EventHandler(this.buttonShowEmployees_Click);
            // 
            // employeeListBox
            // 
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.Location = new System.Drawing.Point(0, 0);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(463, 82);
            this.employeeListBox.TabIndex = 1;
            this.employeeListBox.SelectedIndexChanged += new System.EventHandler(this.employeeListBox_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(226, 88);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(129, 41);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 135);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.employeeListBox);
            this.Controls.Add(this.buttonShowEmployees);
            this.Name = "Form1";
            this.Text = "Employee List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowEmployees;
        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.Button exitButton;
    }
}

