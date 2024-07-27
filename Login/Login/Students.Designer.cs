namespace Login
{
    partial class frmStudents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label sudent_IDLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label date_Of_BirthLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label gradeLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label date_Of_AdmissionLabel;
            System.Windows.Forms.Label guardian_s_NameLabel;
            System.Windows.Forms.Label phone_NumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudents));
            this.dbHRMStudentDataSet = new Login.dbHRMStudentDataSet();
            this.tblHRMStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHRMStudentsTableAdapter = new Login.dbHRMStudentDataSetTableAdapters.tblHRMStudentsTableAdapter();
            this.tableAdapterManager = new Login.dbHRMStudentDataSetTableAdapters.TableAdapterManager();
            this.tblHRMStudentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblHRMStudentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sudent_IDTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.date_Of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.date_Of_AdmissionTextBox = new System.Windows.Forms.TextBox();
            this.guardian_s_NameTextBox = new System.Windows.Forms.TextBox();
            this.phone_NumberTextBox = new System.Windows.Forms.TextBox();
            this.tblHRMStudentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            sudent_IDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            date_Of_BirthLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            gradeLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            date_Of_AdmissionLabel = new System.Windows.Forms.Label();
            guardian_s_NameLabel = new System.Windows.Forms.Label();
            phone_NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbHRMStudentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHRMStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHRMStudentsBindingNavigator)).BeginInit();
            this.tblHRMStudentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHRMStudentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sudent_IDLabel
            // 
            sudent_IDLabel.AutoSize = true;
            sudent_IDLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            sudent_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sudent_IDLabel.Location = new System.Drawing.Point(30, 59);
            sudent_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sudent_IDLabel.Name = "sudent_IDLabel";
            sudent_IDLabel.Size = new System.Drawing.Size(74, 15);
            sudent_IDLabel.TabIndex = 1;
            sudent_IDLabel.Text = "Sudent ID:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            first_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            first_NameLabel.Location = new System.Drawing.Point(30, 89);
            first_NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(81, 15);
            first_NameLabel.TabIndex = 3;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            last_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            last_NameLabel.Location = new System.Drawing.Point(30, 119);
            last_NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(80, 15);
            last_NameLabel.TabIndex = 5;
            last_NameLabel.Text = "Last Name:";
            // 
            // date_Of_BirthLabel
            // 
            date_Of_BirthLabel.AutoSize = true;
            date_Of_BirthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            date_Of_BirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_Of_BirthLabel.Location = new System.Drawing.Point(30, 151);
            date_Of_BirthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            date_Of_BirthLabel.Name = "date_Of_BirthLabel";
            date_Of_BirthLabel.Size = new System.Drawing.Size(93, 15);
            date_Of_BirthLabel.TabIndex = 7;
            date_Of_BirthLabel.Text = "Date Of Birth:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(30, 179);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(62, 15);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "Address:";
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gradeLabel.Location = new System.Drawing.Point(30, 209);
            gradeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new System.Drawing.Size(50, 15);
            gradeLabel.TabIndex = 11;
            gradeLabel.Text = "Grade:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ageLabel.Location = new System.Drawing.Point(503, 62);
            ageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(35, 15);
            ageLabel.TabIndex = 13;
            ageLabel.Text = "Age:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(503, 92);
            genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(58, 15);
            genderLabel.TabIndex = 15;
            genderLabel.Text = "Gender:";
            // 
            // date_Of_AdmissionLabel
            // 
            date_Of_AdmissionLabel.AutoSize = true;
            date_Of_AdmissionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            date_Of_AdmissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_Of_AdmissionLabel.Location = new System.Drawing.Point(503, 122);
            date_Of_AdmissionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            date_Of_AdmissionLabel.Name = "date_Of_AdmissionLabel";
            date_Of_AdmissionLabel.Size = new System.Drawing.Size(129, 15);
            date_Of_AdmissionLabel.TabIndex = 17;
            date_Of_AdmissionLabel.Text = "Date Of Admission:";
            // 
            // guardian_s_NameLabel
            // 
            guardian_s_NameLabel.AutoSize = true;
            guardian_s_NameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            guardian_s_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            guardian_s_NameLabel.Location = new System.Drawing.Point(503, 152);
            guardian_s_NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            guardian_s_NameLabel.Name = "guardian_s_NameLabel";
            guardian_s_NameLabel.Size = new System.Drawing.Size(123, 15);
            guardian_s_NameLabel.TabIndex = 19;
            guardian_s_NameLabel.Text = "Guardian\'s Name:";
            // 
            // phone_NumberLabel
            // 
            phone_NumberLabel.AutoSize = true;
            phone_NumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            phone_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phone_NumberLabel.Location = new System.Drawing.Point(503, 182);
            phone_NumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phone_NumberLabel.Name = "phone_NumberLabel";
            phone_NumberLabel.Size = new System.Drawing.Size(107, 15);
            phone_NumberLabel.TabIndex = 21;
            phone_NumberLabel.Text = "Phone Number:";
            // 
            // dbHRMStudentDataSet
            // 
            this.dbHRMStudentDataSet.DataSetName = "dbHRMStudentDataSet";
            this.dbHRMStudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHRMStudentsBindingSource
            // 
            this.tblHRMStudentsBindingSource.DataMember = "tblHRMStudents";
            this.tblHRMStudentsBindingSource.DataSource = this.dbHRMStudentDataSet;
            // 
            // tblHRMStudentsTableAdapter
            // 
            this.tblHRMStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblHRMStudentsTableAdapter = this.tblHRMStudentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Login.dbHRMStudentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblHRMStudentsBindingNavigator
            // 
            this.tblHRMStudentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblHRMStudentsBindingNavigator.BindingSource = this.tblHRMStudentsBindingSource;
            this.tblHRMStudentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblHRMStudentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblHRMStudentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblHRMStudentsBindingNavigatorSaveItem});
            this.tblHRMStudentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblHRMStudentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblHRMStudentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblHRMStudentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblHRMStudentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblHRMStudentsBindingNavigator.Name = "tblHRMStudentsBindingNavigator";
            this.tblHRMStudentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblHRMStudentsBindingNavigator.Size = new System.Drawing.Size(938, 25);
            this.tblHRMStudentsBindingNavigator.TabIndex = 0;
            this.tblHRMStudentsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblHRMStudentsBindingNavigatorSaveItem
            // 
            this.tblHRMStudentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblHRMStudentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblHRMStudentsBindingNavigatorSaveItem.Image")));
            this.tblHRMStudentsBindingNavigatorSaveItem.Name = "tblHRMStudentsBindingNavigatorSaveItem";
            this.tblHRMStudentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblHRMStudentsBindingNavigatorSaveItem.Text = "Save Data";
            this.tblHRMStudentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblHRMStudentsBindingNavigatorSaveItem_Click);
            // 
            // sudent_IDTextBox
            // 
            this.sudent_IDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sudent_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHRMStudentsBindingSource, "Sudent ID", true));
            this.sudent_IDTextBox.Location = new System.Drawing.Point(168, 56);
            this.sudent_IDTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sudent_IDTextBox.Name = "sudent_IDTextBox";
            this.sudent_IDTextBox.Size = new System.Drawing.Size(265, 21);
            this.sudent_IDTextBox.TabIndex = 2;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHRMStudentsBindingSource, "First Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(168, 86);
            this.first_NameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(265, 21);
            this.first_NameTextBox.TabIndex = 4;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHRMStudentsBindingSource, "Last Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(168, 116);
            this.last_NameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(265, 21);
            this.last_NameTextBox.TabIndex = 6;
            // 
            // date_Of_BirthDateTimePicker
            // 
            this.date_Of_BirthDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.date_Of_BirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblHRMStudentsBindingSource, "Date Of Birth", true));
            this.date_Of_BirthDateTimePicker.Location = new System.Drawing.Point(168, 146);
            this.date_Of_BirthDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.date_Of_BirthDateTimePicker.Name = "date_Of_BirthDateTimePicker";
            this.date_Of_BirthDateTimePicker.Size = new System.Drawing.Size(265, 21);
            this.date_Of_BirthDateTimePicker.TabIndex = 8;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHRMStudentsBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(168, 176);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(265, 21);
            this.addressTextBox.TabIndex = 10;
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHRMStudentsBindingSource, "Grade", true));
            this.gradeTextBox.Location = new System.Drawing.Point(168, 206);
            this.gradeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(265, 21);
            this.gradeTextBox.TabIndex = 12;
            // 
            // ageTextBox
            // 
            this.ageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHRMStudentsBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(640, 59);
            this.ageTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(265, 21);
            this.ageTextBox.TabIndex = 14;
            // 
            // genderTextBox
            // 
            this.genderTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHRMStudentsBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(640, 89);
            this.genderTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(265, 21);
            this.genderTextBox.TabIndex = 16;
            // 
            // date_Of_AdmissionTextBox
            // 
            this.date_Of_AdmissionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.date_Of_AdmissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHRMStudentsBindingSource, "Date Of Admission", true));
            this.date_Of_AdmissionTextBox.Location = new System.Drawing.Point(640, 119);
            this.date_Of_AdmissionTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.date_Of_AdmissionTextBox.Name = "date_Of_AdmissionTextBox";
            this.date_Of_AdmissionTextBox.Size = new System.Drawing.Size(265, 21);
            this.date_Of_AdmissionTextBox.TabIndex = 18;
            // 
            // guardian_s_NameTextBox
            // 
            this.guardian_s_NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guardian_s_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHRMStudentsBindingSource, "Guardian\'s Name", true));
            this.guardian_s_NameTextBox.Location = new System.Drawing.Point(640, 149);
            this.guardian_s_NameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guardian_s_NameTextBox.Name = "guardian_s_NameTextBox";
            this.guardian_s_NameTextBox.Size = new System.Drawing.Size(265, 21);
            this.guardian_s_NameTextBox.TabIndex = 20;
            // 
            // phone_NumberTextBox
            // 
            this.phone_NumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.phone_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHRMStudentsBindingSource, "Phone Number", true));
            this.phone_NumberTextBox.Location = new System.Drawing.Point(640, 179);
            this.phone_NumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phone_NumberTextBox.Name = "phone_NumberTextBox";
            this.phone_NumberTextBox.Size = new System.Drawing.Size(265, 21);
            this.phone_NumberTextBox.TabIndex = 22;
            // 
            // tblHRMStudentsDataGridView
            // 
            this.tblHRMStudentsDataGridView.AutoGenerateColumns = false;
            this.tblHRMStudentsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tblHRMStudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblHRMStudentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.tblHRMStudentsDataGridView.DataSource = this.tblHRMStudentsBindingSource;
            this.tblHRMStudentsDataGridView.Location = new System.Drawing.Point(22, 280);
            this.tblHRMStudentsDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tblHRMStudentsDataGridView.Name = "tblHRMStudentsDataGridView";
            this.tblHRMStudentsDataGridView.Size = new System.Drawing.Size(895, 125);
            this.tblHRMStudentsDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Sudent ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Sudent ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date Of Birth";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date Of Birth";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Grade";
            this.dataGridViewTextBoxColumn6.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn7.HeaderText = "Age";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn8.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Date Of Admission";
            this.dataGridViewTextBoxColumn9.HeaderText = "Date Of Admission";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Guardian\'s Name";
            this.dataGridViewTextBoxColumn10.HeaderText = "Guardian\'s Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Phone Number";
            this.dataGridViewTextBoxColumn11.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(325, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 36);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(459, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 36);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(591, 238);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 36);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(821, 420);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 36);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(706, 420);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 36);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Login.Properties.Resources.Students_back_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 468);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tblHRMStudentsDataGridView);
            this.Controls.Add(sudent_IDLabel);
            this.Controls.Add(this.sudent_IDTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(date_Of_BirthLabel);
            this.Controls.Add(this.date_Of_BirthDateTimePicker);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(gradeLabel);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(date_Of_AdmissionLabel);
            this.Controls.Add(this.date_Of_AdmissionTextBox);
            this.Controls.Add(guardian_s_NameLabel);
            this.Controls.Add(this.guardian_s_NameTextBox);
            this.Controls.Add(phone_NumberLabel);
            this.Controls.Add(this.phone_NumberTextBox);
            this.Controls.Add(this.tblHRMStudentsBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.frmStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbHRMStudentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHRMStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHRMStudentsBindingNavigator)).EndInit();
            this.tblHRMStudentsBindingNavigator.ResumeLayout(false);
            this.tblHRMStudentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHRMStudentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbHRMStudentDataSet dbHRMStudentDataSet;
        private System.Windows.Forms.BindingSource tblHRMStudentsBindingSource;
        private dbHRMStudentDataSetTableAdapters.tblHRMStudentsTableAdapter tblHRMStudentsTableAdapter;
        private dbHRMStudentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblHRMStudentsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblHRMStudentsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox sudent_IDTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.DateTimePicker date_Of_BirthDateTimePicker;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox date_Of_AdmissionTextBox;
        private System.Windows.Forms.TextBox guardian_s_NameTextBox;
        private System.Windows.Forms.TextBox phone_NumberTextBox;
        private System.Windows.Forms.DataGridView tblHRMStudentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
    }
}