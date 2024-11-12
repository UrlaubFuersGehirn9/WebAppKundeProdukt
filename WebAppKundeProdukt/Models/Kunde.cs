using System.Runtime.Serialization;

namespace WebAppKundeProdukt.Models
{
    public class Kunde
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public double Endpreis { get; set; }
        public List<Warenkorbposition> Warenkorbpositionen { get; set; } = new List<Warenkorbposition>();
    }
}
