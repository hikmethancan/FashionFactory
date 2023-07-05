using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
