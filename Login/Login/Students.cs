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
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbHRMStudentDataSet.tblHRMStudents' table. You can move, or remove it, as needed.
            //this.tblHRMStudentsTableAdapter.Fill(this.dbHRMStudentDataSet.tblHRMStudents);

        }

        private void tblHRMStudentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblHRMStudentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbHRMStudentDataSet);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
           // this.tblHRMStudentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbHRMStudentDataSet);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //this.tblHRMStudentsBindingSource.AddNew();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.tblHRMStudentsBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.dbHRMStudentDataSet);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu Students = new frmMenu();
            Students.Show();
            this.Hide();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
        
        }
    }
}
