using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.DTO
{
    public class CarDetailDto:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
