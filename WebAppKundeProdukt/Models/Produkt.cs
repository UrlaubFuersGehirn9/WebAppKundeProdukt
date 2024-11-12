namespace WebAppKundeProdukt.Models
{
    public class Produkt
    {
        public int Id { get; set; }
        public string Beschreibung { get; set; }
        public string? Kategorie {  get; set; }
        public List<Warenkorbposition> Warenkorbpositionen { get; set; } = new List<Warenkorbposition>();
    }
}
