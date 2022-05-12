using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class EntityBase
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; }
    }
}
