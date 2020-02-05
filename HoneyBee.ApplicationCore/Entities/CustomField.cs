using HoneyBee.ApplicationCore.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class CustomField : BaseEntity
    {
        public CustomField()
        {
            CustomFieldListValues = new HashSet<CustomFieldListValue>();
        }
        public CustomFieldType OwnerType { get; set; }
        public string Label { get; set; }
        public CustomFieldDataType DataType { get; set; }
        public bool Required { get; set; }

        public ICollection<CustomFieldListValue> CustomFieldListValues { get; set; }
    }
}
