using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePolicyDemo
{
    public class PaymentIllustration : PolicyDetails
    {
        public Guid Id { get; set; }
        public Payment[] PaymentSchedule { get; set; }

    }
}
