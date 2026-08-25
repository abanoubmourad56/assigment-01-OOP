using System.Security.Principal;

namespace assigment_01_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            //DeliveryAddress is a struct (value type). When copied, a new independent copy is created.Modifying the copy does not affect the original variable.

            //b) What happens when a Customer variable is copied into another variable and one variable modifies the object
            //Customer is a class (reference type). When copied, both variables refer to the same object. Modifying the object through one variable affects the other variable.

            //a) Identify at least three problems with this design from an encapsulation perspective
            //The fields are public, so they can be modified directly from outside the struct.
            // There is no control or validation over the values.
            //The internal data is exposed, which breaks encapsulation.



    }
    }
}
