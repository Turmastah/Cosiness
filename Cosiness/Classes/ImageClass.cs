using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosiness.Commands
{
    public class ImageClass
    {
        //Получение данных о картинках
        public int Image_ID { get; set; } [Key]
        public byte[] Bytes { get; set; }
        public string ImagePath { get; set; }
    }
}