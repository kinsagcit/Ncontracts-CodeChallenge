// Ncontracts Code Challenge
//
//
// Please take a look at the code below.
// Even though the program runs and generates correct result, we consider the code to be bad.
// For example, if we want to expand the Christmas discount to January or if we want to introduce a first responder discount, the code can get really messy.
// We ask you to refactor the code so that it's easier to apply new changes to it.
// Once done, please send me a link to your gists.

namespace Ncontracts_CodeChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();

            program.ChristmasShoppingAtTheGroceryStore();
            program.BuyingFood();

            Console.ReadLine();
        }

        void ChristmasShoppingAtTheGroceryStore()
        {
            var carts = new List<CartItem>
            {
                new CartItem {ProductName = "Lights", Category = "Christmas", Price = 5.99m, Quantity = 10},
                new CartItem {ProductName = "Tree", Category = "Christmas", Price = 169m, Quantity = 1},
                new CartItem {ProductName = "Ornaments", Category = "Christmas", Price = 8m, Quantity = 15},
            };

            var calculator = new GroceryStoreCheckoutCalculator();
            var total = calculator.Calculate(carts, new DateTime(), null);
            Console.WriteLine(total);

            var totalAfterChristmas = calculator.Calculate(carts, new DateTime(2020, 12, 30), new ChristmasDiscountStrategy());
            Console.WriteLine(totalAfterChristmas);
        }

        void BuyingFood()
        {
            var carts = new List<CartItem>
            {
                new CartItem {ProductName = "Apple", Category = "Food", Price = 3.27m, Weight = 0.79m},
                new CartItem {ProductName = "Scallop", Category = "Food", Price = 18m, Weight = 1.5m},
                new CartItem {ProductName = "Salad", Category = "Food", Price = 6.99m, Quantity = 1},
                new CartItem {ProductName = "Ground Beef", Category = "Food", Price = 7.99m, Weight = 1.5m},
                new CartItem {ProductName = "Red Wine", Category = "Food", Price = 25.99m, Quantity = 1}
            };

            var calculator = new GroceryStoreCheckoutCalculator();
            var total = calculator.Calculate(carts, new DateTime(2020, 11, 30), null);
            Console.WriteLine(total);

            var seniorHourTotal = calculator.Calculate(carts, new DateTime(2020, 12, 30), new ChristmasDiscountStrategy()) ;
            Console.WriteLine(seniorHourTotal);
        }
    }


}