using HoneyBee.ApplicationCore.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class PaymentMethod : BaseEntity
    {
        public PaymentMethodType PaymentMethodType { get; set; }
        public string Description { get; set; }
    }
}
