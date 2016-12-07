using System;
using System.Windows.Forms;

namespace Census_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Add the new Person to the database
            this.personTableAdapter1.InsertPerson(FirstN.Text, LastN.Text, DToB.Value.Date.ToString());
            
            this.Validate();
            this.personAddressBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myTownDBDataSet);

            UpdateData();

            LastN.Clear();
            FirstN.Clear();
       }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Add the new Address to the database 
                this.addressTableAdapter1.InsertAddress(StNum.Text, City.Text, State.Text, Zip.Text);
                UpdateData();

                this.Validate();
                this.personAddressBindingSource.EndEdit();
                this.homelessPersonBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myTownDBDataSet);

                StNum.Clear();
                City.Clear();
                State.Clear();
                Zip.Clear();
            }
            catch
            {

                MessageBox.Show("Invalid/Missing Data", "Add Address Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateData()
        {
            // TODO: This line of code loads data into the 'myTownDBDataSet.HomelessPerson' table. You can move, or remove it, as needed.
            this.homelessPersonTableAdapter.HomelessPerson(this.myTownDBDataSet.HomelessPerson);
            // TODO: This line of code loads data into the 'myTownDBDataSet.PersonAddress' table. You can move, or remove it, as needed.
            this.personAddressTableAdapter.PersonAddress(this.myTownDBDataSet.PersonAddress);
            
        }
        
        private void personAddressBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personAddressBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myTownDBDataSet);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.homelessPersonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myTownDBDataSet);
        }
    }
}
