using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ImageDetailDto:IDto
    {
        public int Id { get; set; }
        public int CarName { get; set; }
        public string ImagePath { get; set; }
    }
}
