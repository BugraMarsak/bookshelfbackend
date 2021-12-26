using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Shelf:IEntity
    {
        public int ShelfId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
    }
}
