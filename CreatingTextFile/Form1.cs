using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CreatingTextFile
{
    public partial class FrmLab1 : Form
    {

        public FrmLab1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFileName frm = new FrmFileName(); // Create a new instance of the form
            frm.ShowDialog(); // Show the form as a modal dialog box

            string getInput = txtInput.Text; // Get user input from the text box

            // Get the path to the My Documents folder
            //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string relativePath = @"../../05LabEx_Stream_Joson_Shiela_Mae"; // Set the path to a specific folder
            string docPath = Path.GetFullPath(relativePath); // Get the full path

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName()))) // Create a new text file in the My Documents folder
            {
                outputFile.WriteLine(getInput); // Write the user input to the text file
                Console.WriteLine(getInput); // Write the user input to the console
            }
        }
    }
}
