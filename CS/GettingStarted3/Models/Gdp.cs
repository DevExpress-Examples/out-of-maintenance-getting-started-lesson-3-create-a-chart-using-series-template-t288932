namespace GettingStarted3.Models {
    public class Gdp {
        public string Country { get; private set; }
        public int Year { get; private set; }
        public double Product { get; private set; }

        public Gdp(string country, int year, double product) {
            this.Country = country;
            this.Year = year;
            this.Product = product;
        }
    }
}