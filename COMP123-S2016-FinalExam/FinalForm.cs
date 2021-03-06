﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * Generates a method called form load that will use the program.character object to fill out the
         * textboxes with the names that were randomly selected
         * 
         */
        private void FinalForm_Load(object sender, EventArgs e)
        {
            /*
            FinalForm: This form is partially complete (5 Marks: Functionality)
            
            The Load Method of this form should use the Program.character object and fill out the Text
            
            values of the TextBox controls contained in this form.
           */
           
            Character character = Program.character;

            textBox1.Text = character.FirstName;
            LastNameTextBox.Text = character.LastName;
        }
    }
}
