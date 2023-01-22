using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // If you pass this function the name of a textbox,
        // it will grab the current value of the textbox that matches
        // the name e.g. given 'A', returns the value of TextBoxA

        // Note:  if the text box is empty or you pass a character
        // that isn't a textbox name, this will return 0.

        private double getValue(char boxName)
        {
            string value;
            switch (boxName)
            {
                case 'A':
                    value = textBoxA.Text;
                    break;
                case 'B':
                    value = textBoxB.Text;
                    break;
                case 'C':
                    value = textBoxC.Text;
                    break;
                case 'D':
                    value = textBoxD.Text;
                    break;
                default:
                    value = "0";
                    break;
            }

            if (value == "") { value = "0"; }

            return Convert.ToDouble(value);

        }

        // If you pass this function a textbox, it will
        // look in the textbox, and it will pull out the 
        // first character and the third character, which 
        // should both be textbox names

        // It will pull out the second character as the operator

        // It will return the 'name' of the textbox in the formula
        // in either the first position or the second position.

        private char parseFormula(TextBox formulaBox, int n)
        {
            // grab the formula from the textbox
            string formula = formulaBox.Text;

            // If there aren't 3 characters in the formula, do nothing,
            // this isn't a valid formula
            if(formula.Length < 3)
            {
                return ' ';
            }

            // First character is the first value, and third character
            // is the second value.   the operator is in the second spot

            char firstValue = formula[0];
            char secondValue = formula[2];
            char op = formula[1];  // for core assignment, op is always +

            char textBoxName = firstValue;
            if (n==2)
            {
                textBoxName = secondValue;
            }

            return textBoxName;

        }

        // get the first name from a formula in a formula box (e.g. 'C' from C+D)
        private char getFirstFormulaBoxName(TextBox formulaBox)
        {
            return parseFormula(formulaBox, 1);
        }

        // get the second name from a formula in a formula box (e.g. 'D' from C+D)
        private char getSecondFormulaBoxName(TextBox formulaBox)
        {
            return parseFormula(formulaBox, 2);
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            recalculate();
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            recalculate();
        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {
            recalculate();
        }

        private void textBoxD_TextChanged(object sender, EventArgs e)
        {
            recalculate();
        }

        private void recalculate()
        {
            // check if the formula in textBoxFormulaW is using input box A
            char firstBox = getFirstFormulaBoxName(TextBoxFormulaW);
            if (firstBox == 'A')
            {
                // get the value of the second input box used in the formula
                char secondBox = getSecondFormulaBoxName(TextBoxFormulaW);
                double secondValue = getValue(secondBox);
                // get the value of input box A
                double firstValue = getValue('A');
                // perform the calculation and update the result box
                double result = firstValue + secondValue;
                textBoxW.Text = result.ToString();
            }
            // check if the formula in textBoxFormulaX is using input box A
            firstBox = getFirstFormulaBoxName(textBoxFormulaX);
            if (firstBox == 'A')
            {
                // get the value of the second input box used in the formula
                char secondBox = getSecondFormulaBoxName(textBoxFormulaX);
                double secondValue = getValue(secondBox);
                // get the value of input box A
                double firstValue = getValue('A');
                // perform the calculation and update the result box
                double result = firstValue + secondValue;
                textBoxX.Text = result.ToString();
            }
            // check if the formula in textBoxFormulaY is using input box A
            firstBox = getFirstFormulaBoxName(textBoxFormulaY);
            if (firstBox == 'A')
            {
                // get the value of the second input box used in the formula
                char secondBox = getSecondFormulaBoxName(textBoxFormulaY);
                double secondValue = getValue(secondBox);
                // get the value of input box A
                double firstValue = getValue('A');
                // perform the calculation and update the result box
                double result = firstValue + secondValue;
                textBoxY.Text = result.ToString();
            }
            // check if the formula in textBoxFormulaZ is using input box A
            firstBox = getFirstFormulaBoxName(textBoxFormulaZ);
            if (firstBox == 'A')
            {
                // get the value of the second input box used in the formula
                char secondBox = getSecondFormulaBoxName(textBoxFormulaZ);
                double secondValue = getValue(secondBox);
                // get the value of input box A
                double firstValue = getValue('A');
                // perform the calculation and update the result box
                double result = firstValue + secondValue;
                textBoxZ.Text = result.ToString();
            }
        }






    }

}
