using System.ComponentModel;

namespace C968_Software_Project.Models
{
    public class Product
    {
        private BindingList<Part> _associatedParts;
        private int _productId;
        private string _name;
        private decimal _price;
        private int _inStock;
        private int _min;
        private int _max;

        public BindingList<Part> AssociatedParts => _associatedParts;
        public int ProductId => _productId;
        public  string Name => _name;
        public decimal Price => _price;
        public int InStock => _inStock;
        public int Min => _min;
        public int Max => _max;

        public void addAssociatedPart (Part partToAdd)
        {
            if (_associatedParts == null) throw new NullReferenceException("_associatedParts");

            _associatedParts.Add (partToAdd);
        }
        public bool removeAssociatedPart (int index)
        {
            try
            {
                _associatedParts.RemoveAt(index);
                return true;
            }
            catch { return false; }
        }
        public Part lookupAssociatedPart (int index)
        {
            return _associatedParts [index];
        }
    }
}