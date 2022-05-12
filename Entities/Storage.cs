using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Storage : EntityBase
    {
        [Required]
        public DateTime LastUpdate { get; set; }
        
        [Required]
        public decimal PartianlCount { get; set; }

        public string ProductId { get; set; }

        public Product Product { get; set; }

        public string WereHouseId { get; set; }

        public WereHouse WereHouse { get; set; }

        public ICollection<InputOutput> InputsOutputs { get; set; }


    }
}
