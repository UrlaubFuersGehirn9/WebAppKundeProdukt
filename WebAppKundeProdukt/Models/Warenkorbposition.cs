namespace WebAppKundeProdukt.Models
{
    public class Warenkorbposition
    {
        public int Id { get; set; }
        public int KundeId { get; set; }
        public int ProduktId { get; set; }
        public int Menge {  get; set; }
        public Kunde? Kunde { get; set; }
        public Produkt? Produkt { get; set; }
    }
}
