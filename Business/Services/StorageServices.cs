using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Services
{
    public class StorageServices : Services<Storage>
    {
        public override async void Add(Storage entity)
        {
            if (Exist(entity)) { return; }

            Add(entity);
        }

        public override bool Exist(Storage entity)
        {
            using (var db = new InventoryContext())
            {
                var count = db.Set<Storage>().Count(x => x.ProductId == entity.ProductId 
                    && x.WereHouseId == entity.WereHouseId);

                return count > 0;
            }
        }
    }
}
