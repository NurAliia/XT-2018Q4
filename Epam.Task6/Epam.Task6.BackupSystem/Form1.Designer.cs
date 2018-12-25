// <copyright file="Form1.Designer.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task6.BackupSystem
{
    /// <summary>
    ///  This class performs a main function work with Form1
    /// </summary>
    public partial class Form1
    {
        /// <summary>
        /// First State
        /// </summary>
        private System.Windows.Forms.Label firstState;

        /// <summary>
        /// button Activate
        /// </summary>
        private System.Windows.Forms.Button buttonActivate;

        /// <summary>
        /// Second State
        /// </summary>
        private System.Windows.Forms.Label secondState;

        /// <summary>
        /// date Time Picker1
        /// </summary>
        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        /// <summary>
        /// button Date
        /// </summary>
        private System.Windows.Forms.Button buttonDate;

        /// <summary>
        /// text Box Path
        /// </summary>
        private System.Windows.Forms.TextBox textBoxPath;

        /// <summary>
        /// Mandatory constructor variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Release all used resources.
        /// </summary>
        /// <param name="disposing">true if the managed resource should be deleted; otherwise it is false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method to support constructor - do not change
        /// the contents of this method using the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstState = new System.Windows.Forms.Label();
            this.buttonActivate = new System.Windows.Forms.Button();
            this.secondState = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonDate = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            this.firstState.AutoSize = true;
            this.firstState.Location = new System.Drawing.Point(13, 13);
            this.firstState.Name = "firstState";
            this.firstState.Size = new System.Drawing.Size(74, 13);
            this.firstState.TabIndex = 0;
            this.firstState.Text = "Enter the path";

            this.buttonActivate.Location = new System.Drawing.Point(16, 75);
            this.buttonActivate.Name = "buttonActivate";
            this.buttonActivate.Size = new System.Drawing.Size(75, 23);
            this.buttonActivate.TabIndex = 1;
            this.buttonActivate.Text = "Perfom";
            this.buttonActivate.UseVisualStyleBackColor = true;
            this.buttonActivate.Click += new System.EventHandler(this.ButtonActivate_Click);

            this.secondState.AutoSize = true;
            this.secondState.Location = new System.Drawing.Point(16, 119);
            this.secondState.Name = "secondState";
            this.secondState.Size = new System.Drawing.Size(112, 13);
            this.secondState.TabIndex = 2;
            this.secondState.Text = "Select date to backup";
 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged_1);

            this.buttonDate.Location = new System.Drawing.Point(19, 185);
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.Size = new System.Drawing.Size(75, 23);
            this.buttonDate.TabIndex = 4;
            this.buttonDate.Text = "Perform";
            this.buttonDate.UseVisualStyleBackColor = true;
            this.buttonDate.Click += new System.EventHandler(this.ButtonDate_Click);
 
            this.textBoxPath.Location = new System.Drawing.Point(16, 39);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(203, 20);
            this.textBoxPath.TabIndex = 5;
            this.textBoxPath.Text = "Enter the path of the directory";

            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.secondState);
            this.Controls.Add(this.buttonActivate);
            this.Controls.Add(this.firstState);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
