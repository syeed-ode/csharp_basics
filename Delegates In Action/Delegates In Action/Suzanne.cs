using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_In_Action
{
    /** 
     * This class represents the first of two chef's. It
     * has a read-only property and a method
     */
    class Suzanne
    {

        /** 
         * This is a read-only property that has the same
         * type as 'GetSecretIngredient(int)'
         * 
         * The purpose of this property is so that other users
         * can get access to Suzanne's private method, 
         * 'SuzannesSecretIngredient()'.
         */
        public GetSecretIngredient MySecretIngredientMethod
        {
            get
            {
                return new GetSecretIngredient(SuzannesSecretIngredient);
            }
        }

        /**
         * Private method that matches the signature of 
         * 'GetSecretIngredient()'. 
         */
        private string SuzannesSecretIngredient(int amount)
        {
            return amount.ToString() + " ounces of cloves";
        }
    }
}
