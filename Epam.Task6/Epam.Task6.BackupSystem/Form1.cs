// <copyright file="Form1.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task6.BackupSystem
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    ///  This class performs a main function.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Instance File System Watcher My Class
        /// </summary>
        private FileSystemWatcherMyClass watcher = new FileSystemWatcherMyClass();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1" /> class
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH: mm: ss";
            dateTimePicker1.ValueChanged += this.DateTimePicker1_ValueChanged_1;
        }

        /// <summary>
        /// Define the event click handler active tracking
        /// </summary>
        /// <param name="sender">App resource</param>
        /// <param name="e">Object provides information about the renaming operation</param>
        private void ButtonActivate_Click(object sender, EventArgs e)
        {
            this.watcher.InitializeWatcher(textBoxPath.Text);
            this.watcher.Start();
        }

        /// <summary>
        /// Define the event click handler date for back up
        /// </summary>
        /// <param name="sender">App resource</param>
        /// <param name="e">Object provides information about the renaming operation</param>
        private void DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            this.watcher.Stop();
            secondState.Text = string.Format("Вы выбрали: {0}", dateTimePicker1.Value);
        }

        /// <summary>
        /// Define the event start back up handler
        /// </summary>
        /// <param name="sender">App resource</param>
        /// <param name="e">Object provides information about the renaming operation</param>
        private void ButtonDate_Click(object sender, EventArgs e)
        {
            this.watcher.StartBackUp(dateTimePicker1.Value);
        }
    }
}
