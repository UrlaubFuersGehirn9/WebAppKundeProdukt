using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WebAppKundeProdukt.Models
{
    public class Kunde
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        [NotMapped]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        public double Endpreis { get; set; }
        public List<Warenkorbposition> Warenkorbpositionen { get; set; } = new List<Warenkorbposition>();
    }
}
