using C968_Software_Project.Models;

namespace C968_Software_Project.Forms
{
    public partial class AddPart : Form
    {
        private Inventory _inv;

        public AddPart()
        {
            InitializeComponent();
        }

        private void ResetForm ()
        {
            radInHouse.Checked = true;

            txtName.Text = string.Empty;
            txtInventory.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtMax.Text = string.Empty;
            txtMin.Text = string.Empty;

            txtCompanyName.Text = string.Empty;
            txtMachineId.Text = string.Empty;
        }

        private void radInHouse_CheckedChanged(object sender, EventArgs e)
        {
            txtCompanyName.Visible = radOutsourced.Checked;
            lblCompanyName.Visible = radOutsourced.Checked;
            lblMachineId.Visible = radInHouse.Checked;
            txtMachineId.Visible = radInHouse.Checked;
        }

        public void SetInventory(Inventory inventory)
        {
            _inv = inventory;

            txtId.Text = _inv.NextPartId.ToString();
        }
        private bool InventoryIsNull ()
        {
            if (_inv == null)
                return true;
            else return false;
        }

        private void radOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            txtCompanyName.Visible = radOutsourced.Checked;
            lblCompanyName.Visible = radOutsourced.Checked;
            lblMachineId.Visible = radInHouse.Checked;
            txtMachineId.Visible = radInHouse.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int partId = 0;
            int inventory = 0;
            int price = 0;
            int max = 0;
            int min = 0;
            int machineId = 0;

            bool isValid = true;
            if (InventoryIsNull()) return;

            if (isValid)
            {
                if (radInHouse.Checked)
                {
                    _inv.addPart(new Inhouse(partId, txtName.Text, price, inventory, min, max, machineId));
                }
                else if (radOutsourced.Checked)
                {
                    _inv.addPart(new Outsourced (partId, txtName.Text, price, inventory, min, max, txtCompanyName.Text));
                }


                Close();
            }
        }
    }
}
