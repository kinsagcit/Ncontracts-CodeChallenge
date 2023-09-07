namespace Ncontracts_CodeChallenge
{
    internal interface IDiscountStrategy
    {
        decimal ApplyDiscount(CartItem item, DateTime checkOutDate);
    }
}
