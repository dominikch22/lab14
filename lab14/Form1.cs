using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void showPersonButton_Click(object sender, EventArgs e)
        {
            try
            {
                Trojka<Person> trojkaPerson = new Trojka<Person>(
                               new Person(nameA.Text, int.Parse(ageA.Text)),
                               new Person(nameB.Text, int.Parse(ageB.Text)),
                               new Person(nameC.Text, int.Parse(ageC.Text)));

                personShow.Text = trojkaPerson.ToString();
            }
            catch (Exception ex) { 
            
            }
            
        }

        private void sortPersonButton_Click(object sender, EventArgs e)
        {
            try
            {
                Trojka<Person> trojkaPerson = new Trojka<Person>(
                               new Person(nameA.Text, int.Parse(ageA.Text)),
                               new Person(nameB.Text, int.Parse(ageB.Text)),
                               new Person(nameC.Text, int.Parse(ageC.Text)));

                trojkaPerson.Sort();
                personSorted.Text = trojkaPerson.GetSortedString();
            }
            catch (Exception ex)
            {

            }
        }

        private void showIntButton_Click(object sender, EventArgs e)
        {
            try {
                Trojka<int> trojkaInt = new Trojka<int>(
                   int.Parse(A.Text),
                   int.Parse(B.Text),
                   int.Parse(C.Text));

                intShow.Text = trojkaInt.ToString();

            }
            catch (Exception ex) { }
           
        }

        private void sortIntButton_Click(object sender, EventArgs e)
        {
            try
            {
                Trojka<int> trojkaInt = new Trojka<int>(
                   int.Parse(A.Text),
                   int.Parse(B.Text),
                   int.Parse(C.Text));

                trojkaInt.Sort();
                intSort.Text = trojkaInt.GetSortedString();

            }
            catch (Exception ex) { }
        }
    }
}
