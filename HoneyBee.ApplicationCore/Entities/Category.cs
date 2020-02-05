using HoneyBee.ApplicationCore.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            ChildCategories = new HashSet<Category>();
            Code = "";
        }
        //public CategoryType CategoryType { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid? ParentCategoryId { get; set; }
        public bool InActive { get; set; }
        public Category ParentCategory { get; set; }
        public ICollection<Category> ChildCategories { get; set; }
    }
}
