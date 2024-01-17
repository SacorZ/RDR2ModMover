using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDR2ModMover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileManager.CheckForModFiles();

            modStatusLabel.Text = "Mod Status: " + (FileManager.GetModStatus() ? "Modded" : "Unmodded");
            modButton.Text = FileManager.GetModStatus() ? "Unmod" : "Mod";
        }


        private void modStatus_Click(object sender, EventArgs e)
        {

        }

        private void modButton_Click(object sender, EventArgs e)
        {
            FileManager.CreateFolder();
            FileManager.MoveFiles();

            FileManager.CheckForModFiles(); // Ensure mod status is updated
            bool currentModStatus = FileManager.GetModStatus();

            modStatusLabel.Text = "Mod Status: " + (currentModStatus ? "Modded" : "Unmodded");
            modButton.Text = currentModStatus ? "Unmod" : "Mod";
        }
    }
}
