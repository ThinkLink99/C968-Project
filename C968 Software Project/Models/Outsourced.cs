namespace C968_Software_Project.Models
{
    public class Outsourced : Part
    {
        private string _companyName = "";

        public Outsourced(int partId, string name, decimal price, int inStock, int min, int max, string companyName) : 
            base(partId, name, price, inStock, min, max)
        {
            _companyName = companyName;
        }

        public string CompanyName => _companyName;
    }
}