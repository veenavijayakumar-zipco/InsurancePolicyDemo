namespace InsurancePolicyDemo
{
    public class Payment
    {
        public Guid Id { get; set; }
        public DateTime PaymentDate { get; set; }

        public decimal PremiumAmount { get; set; }

        public decimal PayoutAmount { get; set; }
    }
}