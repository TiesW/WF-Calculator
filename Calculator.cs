using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCalculator
{
    public partial class Calculator : Form
    {
        string op;
        double EersteNummer;
        double TweedeNummer;

        Calculations calculation = new Calculations();

        public Calculator()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void Number_Click(object sender, EventArgs e)
        {
            button1.Focus(); // Zorgt ervoor dat er geen focus om de buttons heen komt wanneer je op ze klikt.

            string num = (sender as Button).Text;

            if (Result.Text == "" || Result.Text == "x" || Result.Text == "+" || Result.Text == "÷" || (Result.Text == "0" && !Result.Text.Contains(",")))
            {
                Result.Text = num;
            }
            else if (Result.Text == "-")
            {
                Result.Text += num;
            }
            else
            {
                Result.Text += num;
            }
        }

        private void Point_Click(object sender, EventArgs e)
        {
            button1.Focus();

            if (Result.Text == "")
            {
                Result.Text = "0,";
            }
            else if (Result.Text == "-")
            {
                Result.Text = "-0,";
            }
            else if (!Result.Text.Contains(","))
            {
                Result.Text += ",";
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            button1.Focus();

            Result.Text = "";
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            button1.Focus();

            op = (sender as Button).Text;
            if (Result.Text != "" && Result.Text != "x" && Result.Text != "+" && Result.Text != "-" && Result.Text != "÷")
            {
                EersteNummer = Convert.ToDouble(Result.Text); //Wordt opgeslagen voordat de tekst verandert in het symbool van de operator. En zo kunnen er ook meerdere operators in één berekening worden gebruikt.
                Result.Text = op;
            }
            if (op == "-")
            {
                Result.Text = "-";
            }
        }

        private void Is_Click(object sender, EventArgs e)
        {
            button1.Focus();

            if (Result.Text != "" && Result.Text != "x" && Result.Text != "+" && Result.Text != "-" && Result.Text != "÷")
            {
                TweedeNummer = Convert.ToDouble(Result.Text);
                Result.Text = Convert.ToString(calculation.Berekenen(op, EersteNummer, TweedeNummer));
                op = "..."; //Zodat het resultaat blijft staan wanneer je gelijk nog een keer op "=" drukt.
            }
        }
    }
}
