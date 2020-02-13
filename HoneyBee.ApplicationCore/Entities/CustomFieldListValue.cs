using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class CustomFieldListValue : BaseEntity
    {
        public int CustomFieldId { get; set; }
        public string Value { get; set; }

        public CustomField CustomField { get; set; }
    }
}
