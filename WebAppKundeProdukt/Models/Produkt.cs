using System.ComponentModel.DataAnnotations;

namespace WebAppKundeProdukt.Models
{
    public class Produkt
    {
        public int Id { get; set; }
        public string Beschreibung { get; set; }
        public string? Kategorie {  get; set; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        public double Preis {  get; set; }
        public List<Warenkorbposition> Warenkorbpositionen { get; set; } = new List<Warenkorbposition>();
    }
}
