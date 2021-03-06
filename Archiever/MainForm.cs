﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace Archiever
{
    public partial class MainForm : Form
    {
       
        List<string> selectedFiles;

        public MainForm()
        {
            InitializeComponent();
            selectedFiles = new List<string>();
        }

      
        private void BUT_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
                selectedFiles.AddRange(choofdlog.FileNames);

            if (selectedFiles.Count >= 1)
            {
                foreach (var item in this.selectedFiles)
                {
                    if (!LB_SelectedItems.Items.Contains(item))
                    {
                        this.LB_SelectedItems.Items.Add(item);
                    }
                }
            }
        }
        
        private void BUT_Archive_Click(object sender, EventArgs e)
        {
            string defaultPathOfNewFolder = @"c:\example\start";
            string defaultPathOfZippedFile = @"c:\example\result.zip";

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    defaultPathOfNewFolder = fbd.SelectedPath;
                }

                defaultPathOfZippedFile = Path.Combine(defaultPathOfNewFolder, "result.zip");
                defaultPathOfNewFolder = Path.Combine(defaultPathOfNewFolder, "start");
            }

            try
            {
               
                Directory.CreateDirectory(defaultPathOfNewFolder);

                
                foreach (var file in this.selectedFiles)
                {
                    File.Copy(file, Path.Combine(defaultPathOfNewFolder, file.Split('\\').Last()));
                }

               
                ZipFile.CreateFromDirectory(defaultPathOfNewFolder, defaultPathOfZippedFile);

                
                MessageBox.Show("Zip archieve was created successfuly");

                
                this.LB_SelectedItems.Items.Clear();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
        }
    }
}
