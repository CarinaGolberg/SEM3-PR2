namespace PR1_SEM3_WinForm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvPlants = new System.Windows.Forms.DataGridView();
            this.poisonousPlantsDBBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._SEM3_PR1_DataDataSet1 = new PR1_SEM3_WinForm._SEM3_PR1_DataDataSet1();
            this.poisonousPlantsDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poisonousPlantsDBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._SEM3_PR1_DataDataSet = new PR1_SEM3_WinForm._SEM3_PR1_DataDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLatinName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSymptoms = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNativeRegion = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchToxin = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.btnSearchId = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbToxins = new System.Windows.Forms.ComboBox();
            this.cbDangerLevel = new System.Windows.Forms.ComboBox();
            this.cbSearchToxin = new System.Windows.Forms.ComboBox();
            this.poisonousPlantsDBTableAdapter = new PR1_SEM3_WinForm._SEM3_PR1_DataDataSetTableAdapters.PoisonousPlantsDBTableAdapter();
            this.sEM3PR1DataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poisonousPlantsDBTableAdapter1 = new PR1_SEM3_WinForm._SEM3_PR1_DataDataSet1TableAdapters.PoisonousPlantsDBTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latinNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nativeRegionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toxinDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dangerLevelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptomsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisonousPlantsDBBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SEM3_PR1_DataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisonousPlantsDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisonousPlantsDBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SEM3_PR1_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEM3PR1DataDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlants
            // 
            this.dgvPlants.AutoGenerateColumns = false;
            this.dgvPlants.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvPlants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.latinNameDataGridViewTextBoxColumn1,
            this.nativeRegionDataGridViewTextBoxColumn1,
            this.toxinDataGridViewTextBoxColumn1,
            this.dangerLevelDataGridViewTextBoxColumn1,
            this.symptomsDataGridViewTextBoxColumn1});
            this.dgvPlants.DataSource = this.poisonousPlantsDBBindingSource2;
            this.dgvPlants.Location = new System.Drawing.Point(13, 54);
            this.dgvPlants.Name = "dgvPlants";
            this.dgvPlants.RowHeadersWidth = 51;
            this.dgvPlants.RowTemplate.Height = 24;
            this.dgvPlants.Size = new System.Drawing.Size(630, 326);
            this.dgvPlants.TabIndex = 0;
            this.dgvPlants.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // poisonousPlantsDBBindingSource2
            // 
            this.poisonousPlantsDBBindingSource2.DataMember = "PoisonousPlantsDB";
            this.poisonousPlantsDBBindingSource2.DataSource = this._SEM3_PR1_DataDataSet1;
            // 
            // _SEM3_PR1_DataDataSet1
            // 
            this._SEM3_PR1_DataDataSet1.DataSetName = "_SEM3_PR1_DataDataSet1";
            this._SEM3_PR1_DataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poisonousPlantsDBBindingSource
            // 
            this.poisonousPlantsDBBindingSource.CurrentChanged += new System.EventHandler(this.poisonousPlantsDBBindingSource_CurrentChanged);
            // 
            // poisonousPlantsDBBindingSource1
            // 
            this.poisonousPlantsDBBindingSource1.DataMember = "PoisonousPlantsDB";
            this.poisonousPlantsDBBindingSource1.DataSource = this._SEM3_PR1_DataDataSet;
            this.poisonousPlantsDBBindingSource1.CurrentChanged += new System.EventHandler(this.poisonousPlantsDBBindingSource1_CurrentChanged);
            // 
            // _SEM3_PR1_DataDataSet
            // 
            this._SEM3_PR1_DataDataSet.DataSetName = "_SEM3_PR1_DataDataSet";
            this._SEM3_PR1_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(669, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.AliceBlue;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtId.Location = new System.Drawing.Point(671, 57);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(57, 26);
            this.txtId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(669, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(671, 106);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 26);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(669, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Латинское название:";
            // 
            // txtLatinName
            // 
            this.txtLatinName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtLatinName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLatinName.Location = new System.Drawing.Point(671, 159);
            this.txtLatinName.Multiline = true;
            this.txtLatinName.Name = "txtLatinName";
            this.txtLatinName.Size = new System.Drawing.Size(229, 26);
            this.txtLatinName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(669, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Наиболее ядовитая часть:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SkyBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(673, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Класс опасности:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(669, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Симптомы отравления:";
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSymptoms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSymptoms.Location = new System.Drawing.Point(671, 401);
            this.txtSymptoms.Multiline = true;
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(229, 26);
            this.txtSymptoms.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SkyBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(668, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Семейство:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNativeRegion
            // 
            this.txtNativeRegion.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNativeRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNativeRegion.Location = new System.Drawing.Point(671, 217);
            this.txtNativeRegion.Multiline = true;
            this.txtNativeRegion.Name = "txtNativeRegion";
            this.txtNativeRegion.Size = new System.Drawing.Size(229, 26);
            this.txtNativeRegion.TabIndex = 14;
            this.txtNativeRegion.TextChanged += new System.EventHandler(this.txtNativeRegion_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(600, 457);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 52);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SkyBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(209, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Список растений сада Алник:";
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.SkyBlue;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowAll.Location = new System.Drawing.Point(712, 457);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(121, 52);
            this.btnShowAll.TabIndex = 17;
            this.btnShowAll.Text = "Показать все";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SkyBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(368, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Найти растение по наиболее ядовитой части:";
            // 
            // btnSearchToxin
            // 
            this.btnSearchToxin.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearchToxin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchToxin.Location = new System.Drawing.Point(183, 507);
            this.btnSearchToxin.Name = "btnSearchToxin";
            this.btnSearchToxin.Size = new System.Drawing.Size(99, 37);
            this.btnSearchToxin.TabIndex = 20;
            this.btnSearchToxin.Text = "Найти";
            this.btnSearchToxin.UseVisualStyleBackColor = false;
            this.btnSearchToxin.Click += new System.EventHandler(this.btnSearchToxin_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SkyBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(10, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Найти растение по Id:";
            // 
            // txtSearchId
            // 
            this.txtSearchId.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSearchId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchId.Location = new System.Drawing.Point(15, 435);
            this.txtSearchId.Multiline = true;
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(57, 26);
            this.txtSearchId.TabIndex = 22;
            // 
            // btnSearchId
            // 
            this.btnSearchId.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchId.Location = new System.Drawing.Point(89, 426);
            this.btnSearchId.Name = "btnSearchId";
            this.btnSearchId.Size = new System.Drawing.Size(99, 37);
            this.btnSearchId.TabIndex = 23;
            this.btnSearchId.Text = "Найти";
            this.btnSearchId.UseVisualStyleBackColor = false;
            this.btnSearchId.Click += new System.EventHandler(this.btnSearchId_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGroup.Location = new System.Drawing.Point(779, 515);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(173, 72);
            this.btnGroup.TabIndex = 24;
            this.btnGroup.Text = "Группировка по классам опасности";
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(600, 515);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(173, 72);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Редактировать растение";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(853, 619);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 37);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(839, 457);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 52);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PR1_SEM3_WinForm.Properties.Resources.alnwick_garden_summer_map;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(978, 670);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbToxins
            // 
            this.cbToxins.BackColor = System.Drawing.Color.AliceBlue;
            this.cbToxins.FormattingEnabled = true;
            this.cbToxins.Location = new System.Drawing.Point(671, 280);
            this.cbToxins.Name = "cbToxins";
            this.cbToxins.Size = new System.Drawing.Size(121, 24);
            this.cbToxins.TabIndex = 32;
            // 
            // cbDangerLevel
            // 
            this.cbDangerLevel.BackColor = System.Drawing.Color.AliceBlue;
            this.cbDangerLevel.FormattingEnabled = true;
            this.cbDangerLevel.Location = new System.Drawing.Point(671, 345);
            this.cbDangerLevel.Name = "cbDangerLevel";
            this.cbDangerLevel.Size = new System.Drawing.Size(121, 24);
            this.cbDangerLevel.TabIndex = 33;
            // 
            // cbSearchToxin
            // 
            this.cbSearchToxin.FormattingEnabled = true;
            this.cbSearchToxin.Location = new System.Drawing.Point(12, 515);
            this.cbSearchToxin.Name = "cbSearchToxin";
            this.cbSearchToxin.Size = new System.Drawing.Size(140, 24);
            this.cbSearchToxin.TabIndex = 34;
            // 
            // poisonousPlantsDBTableAdapter
            // 
            this.poisonousPlantsDBTableAdapter.ClearBeforeFill = true;
            // 
            // sEM3PR1DataDataSetBindingSource
            // 
            this.sEM3PR1DataDataSetBindingSource.DataSource = this._SEM3_PR1_DataDataSet;
            this.sEM3PR1DataDataSetBindingSource.Position = 0;
            // 
            // poisonousPlantsDBTableAdapter1
            // 
            this.poisonousPlantsDBTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // latinNameDataGridViewTextBoxColumn1
            // 
            this.latinNameDataGridViewTextBoxColumn1.DataPropertyName = "LatinName";
            this.latinNameDataGridViewTextBoxColumn1.HeaderText = "LatinName";
            this.latinNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.latinNameDataGridViewTextBoxColumn1.Name = "latinNameDataGridViewTextBoxColumn1";
            this.latinNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nativeRegionDataGridViewTextBoxColumn1
            // 
            this.nativeRegionDataGridViewTextBoxColumn1.DataPropertyName = "NativeRegion";
            this.nativeRegionDataGridViewTextBoxColumn1.HeaderText = "NativeRegion";
            this.nativeRegionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nativeRegionDataGridViewTextBoxColumn1.Name = "nativeRegionDataGridViewTextBoxColumn1";
            this.nativeRegionDataGridViewTextBoxColumn1.Width = 125;
            // 
            // toxinDataGridViewTextBoxColumn1
            // 
            this.toxinDataGridViewTextBoxColumn1.DataPropertyName = "Toxin";
            this.toxinDataGridViewTextBoxColumn1.HeaderText = "Toxin";
            this.toxinDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.toxinDataGridViewTextBoxColumn1.Name = "toxinDataGridViewTextBoxColumn1";
            this.toxinDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dangerLevelDataGridViewTextBoxColumn1
            // 
            this.dangerLevelDataGridViewTextBoxColumn1.DataPropertyName = "DangerLevel";
            this.dangerLevelDataGridViewTextBoxColumn1.HeaderText = "DangerLevel";
            this.dangerLevelDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dangerLevelDataGridViewTextBoxColumn1.Name = "dangerLevelDataGridViewTextBoxColumn1";
            this.dangerLevelDataGridViewTextBoxColumn1.Width = 125;
            // 
            // symptomsDataGridViewTextBoxColumn1
            // 
            this.symptomsDataGridViewTextBoxColumn1.DataPropertyName = "Symptoms";
            this.symptomsDataGridViewTextBoxColumn1.HeaderText = "Symptoms";
            this.symptomsDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.symptomsDataGridViewTextBoxColumn1.Name = "symptomsDataGridViewTextBoxColumn1";
            this.symptomsDataGridViewTextBoxColumn1.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(976, 668);
            this.Controls.Add(this.cbSearchToxin);
            this.Controls.Add(this.cbDangerLevel);
            this.Controls.Add(this.cbToxins);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.btnSearchId);
            this.Controls.Add(this.txtSearchId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSearchToxin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNativeRegion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSymptoms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLatinName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPlants);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ядовитый сад \"Alnwick\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisonousPlantsDBBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SEM3_PR1_DataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisonousPlantsDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisonousPlantsDBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SEM3_PR1_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEM3PR1DataDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLatinName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSymptoms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNativeRegion;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearchToxin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Button btnSearchId;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbToxins;
        private System.Windows.Forms.ComboBox cbDangerLevel;
        private System.Windows.Forms.ComboBox cbSearchToxin;
        private _SEM3_PR1_DataDataSet _SEM3_PR1_DataDataSet;
        private System.Windows.Forms.BindingSource poisonousPlantsDBBindingSource1;
        private _SEM3_PR1_DataDataSetTableAdapters.PoisonousPlantsDBTableAdapter poisonousPlantsDBTableAdapter;
        private System.Windows.Forms.BindingSource poisonousPlantsDBBindingSource;
        private System.Windows.Forms.BindingSource sEM3PR1DataDataSetBindingSource;
        private _SEM3_PR1_DataDataSet1 _SEM3_PR1_DataDataSet1;
        private System.Windows.Forms.BindingSource poisonousPlantsDBBindingSource2;
        private _SEM3_PR1_DataDataSet1TableAdapters.PoisonousPlantsDBTableAdapter poisonousPlantsDBTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn latinNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nativeRegionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn toxinDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dangerLevelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptomsDataGridViewTextBoxColumn1;
    }
}

