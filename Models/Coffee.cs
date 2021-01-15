using System;
using System.Collections.Generic;

namespace CoffeeAdmin.Models
{
    public partial class Coffee
    {
        public int Id { get; set; }
        public string NamaKopi { get; set; }
        public string AsalKopi { get; set; }
        public string JenisKopi { get; set; }
        public string DeskripsiKopi { get; set; }
    }
}
