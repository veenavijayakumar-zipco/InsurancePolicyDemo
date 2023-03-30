using InsurancePolicyDemo;

namespace InsurancePolicyDemoTest
{
    public class PaymentIllustrationGeneratorTest
    {
        [Fact]
        public void GeneratePaymentIllustrationTest()
        {
            var input = new PolicyDetails()
            {
                SumAssured = 1000000M,
                PremiumFrequency = PremiumFrequencyType.Yearly,
                PolicyPayingTerm = 2,
                PolicyPayoutTerm = 4,
                PolicyStartDate = DateTime.Parse("1-1-2023")
            };

            var expected = new PaymentIllustration()
            {
                PaymentSchedule = new Payment[]
                {
                    new Payment()
                    {
                        PremiumAmount = 500000M,
                        PayoutAmount = 0M,
                        PaymentDate = DateTime.Parse("1-1-2023")
                    },
                    new Payment()
                    {
                        PremiumAmount = 500000M,
                        PayoutAmount = 0M,
                        PaymentDate = DateTime.Parse("1-1-2024")
                    },
                    new Payment()
                    {
                        PremiumAmount = 0M,
                        PayoutAmount = 250000M,
                        PaymentDate = DateTime.Parse("1-1-2025")
                    },
                    new Payment()
                    {
                        PremiumAmount = 0M,
                        PayoutAmount = 250000M,
                        PaymentDate = DateTime.Parse("1-1-2026")
                    },
                    new Payment()
                    {
                        PremiumAmount = 0M,
                        PayoutAmount = 250000M,
                        PaymentDate = DateTime.Parse("1-1-2027")
                    },
                    new Payment()
                    {
                        PremiumAmount = 0M,
                        PayoutAmount = 250000M,
                        PaymentDate = DateTime.Parse("1-1-2028")
                    }
                }
            };
        }
    }
}