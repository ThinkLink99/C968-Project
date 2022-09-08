namespace C968_Software_Project.Models
{
    public abstract class Part
    {
        protected int _partId;
        protected string _name = "";
        protected decimal _price;
        protected int _inStock;
        protected int _min;
        protected int _max;

        protected Part(int partId, string name, decimal price, int inStock, int min, int max)
        {
            _partId = partId;
            _name = name;
            _price = price;
            _inStock = inStock;
            _min = min;
            _max = max;
        }

        public int PartId => _partId;
        public string Name => _name;
        public decimal Price => _price;
        public int InStock => _inStock;
        public int Min => _min;
        public int Max => _max;
    }
}