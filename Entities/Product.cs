using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Product : EntityBase
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public decimal Count { get; set; }

        public string CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Storage> Storages { get; set; }
    }
}
