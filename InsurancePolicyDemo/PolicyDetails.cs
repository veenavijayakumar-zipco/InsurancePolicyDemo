namespace InsurancePolicyDemo
{
    public class PolicyDetails
    {
        public Guid Id { get; set; }
        public decimal SumAssured { get; set; }

        public PremiumFrequencyType PremiumFrequency { get; set; }

        public int PolicyPayingTerm { get; set; }

        public int PolicyPayoutTerm { get; set; }

        public DateTime PolicyStartDate { get; set; }
    }
}