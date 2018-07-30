using System;
namespace ChefIngredients
{
    /**
     * This class keeps track of the first chef’s secret ingredient. 
     * 
     **/
    class Suzanne
    {
        /** 
         * This is a read-only property. It has the type of type. 
         * It returns a 'GetSecretIngredient'.
        **/ 
        public GetSecretIngredient MySecretIngredientMethod {   
            get {
                return new GetSecretIngredient(SuzannesSecretIngredient);  
            } 
        }

        /** 
         * This private method matches the signature of 
         * GetSecretIngredient, the delegate dfined in a file
         * with the same name.
         * 
         * Suzanne’s secret ingredient method takes an int called 
         * amount and returns a string that describes her secret 
         * ingredient.
        **/
        private string SuzannesSecretIngredient(int amount) 
        {
            return amount.ToString() + " ounce of cloves";
        }
    }
}
