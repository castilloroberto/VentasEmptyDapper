using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace VentasEmptyDapper.Models
{
    [Table("categorias")]
    public class Categorias
    {
        [Key]
        public int ID { get; set; }
        public string Categoria { get; set; }


    }
}
