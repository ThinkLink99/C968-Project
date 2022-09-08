namespace C968_Software_Project.Models
{
    public class Inhouse : Part
    {
        private int _machineId;

        public Inhouse(int partId, string name, decimal price, int inStock, int min, int max, int machineId) : 
            base(partId, name, price, inStock, min, max)
        {
            _machineId = machineId;
        }

        public int MachineId => _machineId;
    }
}