using System;
using System.Windows.Forms;

namespace Delegates_In_Action
{
    public partial class Form1 : Form
    {
        GetSecretIngredient ingredientMethod = null;
        Suzanne suzanne = new Suzanne();
        Amy amy = new Amy();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AmountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SuzannesButton_Click(object sender, EventArgs e)
        {
            ingredientMethod = new GetSecretIngredient(suzanne.MySecretIngredientMethod);
        }

        private void IngredientButton_Click(object sender, EventArgs e)
        {
            if (ingredientMethod != null)
                MessageBox.Show("I'll add " + ingredientMethod((int)amountNumericUpDown.Value));
            else
                MessageBox.Show("I don't have a secret ingredient");
         }

        private void AmysButton_Click(object sender, EventArgs e)
        {
            ingredientMethod = new GetSecretIngredient(amy.AmysSecretIngredientMethod);
        }
    }
}
