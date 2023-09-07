namespace Ncontracts_CodeChallenge
{
    internal class GroceryStoreCheckoutCalculator
    {
        public decimal Calculate(List<CartItem> carts, DateTime checkOutDate, IDiscountStrategy? discountStrategy)
        {
            decimal itemTotal = 0m;

            foreach (var item in carts)
            {
                if (discountStrategy == null)
                    itemTotal += item.Price * item.Quantity;
                else
                    itemTotal += discountStrategy.ApplyDiscount(item, checkOutDate);
            }

            return itemTotal;
        }
    }
}
