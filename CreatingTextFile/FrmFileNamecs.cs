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

namespace CreatingTextFile
{
    public partial class FrmFileName : Form
    {
        public static string FileNamecs; // Declare a public static variable to hold the file name
        public FrmFileName()
        {
            InitializeComponent();
        }
        public static string SetFileName() // Declare a public static property to access the file name
        {
            return FileNamecs; // Return the file name

        }
        private void btnOkay_Click(object sender, EventArgs e)
        {
            FileNamecs = txtFileName.Text + "txt"; // Get user input from the text box
            Close(); // Close the form
        }
    }
}

