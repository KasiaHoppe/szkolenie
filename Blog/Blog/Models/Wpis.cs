using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Wpis
    {
        public int Id { get; set; }
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public string Tresc { get; set; }
        public DateTime DataDodania { get; set; }
        public int IdKategoria { get; set; }
    }
}