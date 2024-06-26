﻿using System.ComponentModel;

namespace C968_Software_Project.Models
{
    public class Inventory
    {
        private BindingList<Product> _products;
        private BindingList<Part> _allParts;
        private int _nextPartId = 0;
        private int _nextProductId = 0;

        public BindingList<Product> Products => _products;
        public BindingList <Part> AllParts => _allParts;

        public int NextProductId 
        { 
            get
            {
                _nextProductId++;
                return _nextProductId;
            }
        }
        public int NextPartId
        {
            get
            {
                _nextPartId++;
                return _nextPartId;
            }
        }

        // Product functions
        public void addProduct (Product productToAdd)
        {
            _products.Add (productToAdd);
        }
        public bool removeProduct (int index)
        {
            try
            {
                _products.RemoveAt(index);
                return true;
            }
            catch { return false; }
        }
        public Product lookupProduct (int index)
        {
            return default;
        }
        public void updateProduct (int index, Product update)
        {

        }

        // Part Functions
        public void addPart (Part partToAdd)
        {
            _allParts.Add (partToAdd);
        }
        public bool deletePart (int index)
        {
            try
            {
                _allParts.RemoveAt(index);
                return true;
            }
            catch { return false; }
        }
        public Part lookupPart (int index)
        {
            return default;
        }
        public void updatePart (int index, Part update)
        {

        }
    }
}
