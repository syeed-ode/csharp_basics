using System;
namespace ChefIngredients
{
    class Amy
    {
        // Amy’s 'GetSecretIngredient' property returns a new 
        // instance of the 'GetSecretIngredient' delegate. 
        // This delagate is pointing to her secret ingredient 
        // method.
        public GetSecretIngredient AmysSecretIngredientMethod {
            get {
                return new GetSecretIngredient(AmysSecretIngredient);
            }
        }

        // Amy’s secret ingredient method also takes an int called 
        // amount and returns a string, but it returns a different 
        // string from Suzanne’s
        private string AmysSecretIngredient(int amount) {
            if(amount < 10) {
                return amount.ToString() + " cans of sardines -- you need more!";
            } else {
                return amount.ToString() + " can of sardines";
            }
        }
    }
}
