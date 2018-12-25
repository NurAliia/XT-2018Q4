// <copyright file="DirectoryExtensions.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task6.BackupSystem
{
    /// <summary>
    /// Directory Extensions
    /// </summary>
    public static class DirectoryExtensions
    {
        /// <summary>
        /// Clear Directory
        /// </summary>
        /// <param name="directory">current directory</param>
        public static void Empty(this System.IO.DirectoryInfo directory)
        {
            foreach (System.IO.FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }

            foreach (System.IO.DirectoryInfo subDirectory in directory.GetDirectories())
            {
                Empty(subDirectory);
                subDirectory.Delete(true);
            }
        }
    }
}
