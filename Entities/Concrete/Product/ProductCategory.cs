using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete.Product
{
	public class ProductCategory
	{
        public int Id { get; set; }
        // A dictionary of name in different languages
        public required Dictionary<string, string> Names { get; set; }
        // A dictionary of descriptions in different languages
        public Dictionary<string, string>? Descriptions { get; set; }
        public int? ParentCategoryId { get; set; } // Reference to the parent category
	}
}

