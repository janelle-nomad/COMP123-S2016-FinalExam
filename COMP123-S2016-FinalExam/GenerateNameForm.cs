using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Author: Janelle Heron
   Student ID: 300839820
   COMP 123-004
     
*/

namespace COMP123_S2016_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        public SplashForm SplashForm;
        private Random _rnd = new Random();
        

        //50 First Names in the FirstName listbox
        //50 Last Names in the last name listbox

           //Generate name form constructor
        public GenerateNameForm()
        {
            InitializeComponent();
        }


        //Use the Form load 

        //Call the GenerateNames twice, on form load [] & on the names generate button

        // 

            //Fastest way to grab the names from both listboxes

            //private methods
        private void _GenerateRandomNames(object sender, EventArgs e) 
        {
            Random rand = new Random();
            int _firstName = rand.Next(1, (FirstNameListBox.Items.Count - 1)); //Gets the names in the first name list
            int _lastName = rand.Next(1, (listBox1.Items.Count -1));


            FirstNameListBox.SelectedIndex = _firstName; //Asiigns fName
            textBox1.Text = FirstNameListBox.Text;

            listBox1.SelectedIndex = _lastName;
            LastNameTextBox.Text = listBox1.Text;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            // You can either pull the List box items 
            //FirstNameListBox = 
            
            //tb_firstName = FirstNameListBox.GetItemText() 
            //  Program.character = textBox1
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.FirstName = textBox1.Text;
            character.LastName = LastNameTextBox.Text;
            AbilityGeneratorForm newAbilityGeneratorForm = new AbilityGeneratorForm();

            
            /* Outstanding Set-up
             * In the NextButton’s click event handler, call the Show() method of 
             * abilityGeneratorForm object
               and the Hide() method of the GenerateNameForm
            
            */
            
            this.Hide();
            newAbilityGeneratorForm.RandName = this();
            newAbilityGeneratorForm.Show();



        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            //disregarrd
        }
    }
    }

