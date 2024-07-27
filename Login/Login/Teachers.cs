using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmTeachers : Form
    {
        public frmTeachers()
        {
            InitializeComponent();
        }

        private void tblTeachersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblTeachersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbHRMTeachersDataSet);

        }

        private void frmTeachers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbHRMTeachersDataSet.tblTeachers' table. You can move, or remove it, as needed.
           // this.tblTeachersTableAdapter.Fill(this.dbHRMTeachersDataSet.tblTeachers);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblTeachersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbHRMTeachersDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tblTeachersBindingSource.AddNew();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblTeachersBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.dbHRMTeachersDataSet);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu Teachers = new frmMenu();
            Teachers.Show();
            this.Hide();
        }
    }
}
