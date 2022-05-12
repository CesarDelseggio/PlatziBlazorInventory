using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class InputOutput : EntityBase
    {
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public decimal Count { get; set; }

        [Required]
        public bool IsInput { get; set; }

        public string StorageId { get; set; }
        public Storage Storage { get; set; }
    }
}
