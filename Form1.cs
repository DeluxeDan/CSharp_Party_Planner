using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_Planner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(checkBox2.Checked); //healthy option is checked.
            labelCost.Text = Cost.ToString("c"); //passing c tells it to use local currency value. Can also use f3
        }
        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty(); // { NumberOfPeople = 5 };
            dinnerParty.SetPartyOptions(5, checkBox1.Checked);
            dinnerParty.SetHealthyOption(checkBox2.Checked);
            //dinnerParty.CalculateCostOfDecorations(checkBox1.Checked);
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //dinnerParty.numberOfPeople = (int)numericUpDown1.Value; //casting numericUpdown1.value because it is a decimal
            dinnerParty.SetPartyOptions((int)numericUpDown1.Value, checkBox1.Checked);
            DisplayDinnerPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(checkBox1.Checked);
            DisplayDinnerPartyCost(); //recalculates and displays new dinner party cost.
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(checkBox2.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
