using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MVCVraboteni.Models
{
    public class VraboteniClass
    {
        [Key]
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumNaVrabotuvanje { get; set; }
        public decimal Plata { get; set; }
    }
}



