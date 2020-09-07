using System.Collections.Generic;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            ChildCategories = new HashSet<Category>();
            Code = "";
        }
        public string Code { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// Simply get if has parent its parent height + 1, else 0
        /// </summary>
        public byte Height { get; set; }
        public int? ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }
        public ICollection<Category> ChildCategories { get; set; }
    }
}
