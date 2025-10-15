using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string[] list = new string[7]; // Declare an array to hold the user input
            list[0] = "Student No." + txtStudentNo.Text; // Get user input from the text box
            list[1] = "FullName: " + txtFirstName.Text + ", " + txtLastName + ", " + txtMI; // Get user input from the text box
            list[2] = "Program: " + cboxProgram.Text;
            list[3] = "Gender: " + cbGender.Text;
            list[4] = "Age: " + txtAge.Text;
            list[5] = "Birthday: " + dateBirth.Value.ToString("yyyy-MM-dd");
            list[6] = "Contact No.: " + txtContactNo.Text;

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(txtStudentNo.Text + ".txt"))) // Create a new text file in the My Documents folder
            {
                foreach (string line in list)
                {
                    outputFile.WriteLine(line); // Write the user input to the text file
                }

            }
        }
    }
}
