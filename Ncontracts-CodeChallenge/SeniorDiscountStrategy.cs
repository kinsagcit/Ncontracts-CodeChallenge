namespace Ncontracts_CodeChallenge
{
    internal class SeniorDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(CartItem item, DateTime checkOutDate)
        {
            if (item.Category == "Food" && (checkOutDate.Hour > 6 && checkOutDate.Hour <= 8))
                return item.Price * item.Quantity * 0.9m;
            return item.Price * item.Quantity;
        }
    }
}
