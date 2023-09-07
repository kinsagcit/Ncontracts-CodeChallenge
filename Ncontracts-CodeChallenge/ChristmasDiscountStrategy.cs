namespace Ncontracts_CodeChallenge
{
    internal class ChristmasDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(CartItem item, DateTime checkOutDate)
        {
            if (checkOutDate.Month == 12)
            {
                if (checkOutDate.Day < 15)
                    return item.Price * item.Quantity * 0.8m;
                else if (checkOutDate.Day <= 25)
                    return item.Price * item.Quantity * 0.4m;
                else
                    return item.Price * item.Quantity * 0.1m;
            }
            return item.Price * item.Quantity;
        }
    }
}
