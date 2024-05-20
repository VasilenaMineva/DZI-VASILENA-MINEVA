namespace DP_Vasilena12a.Presenter
{
    partial class LogIn_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn_Admin));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.типНаПродуктDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видАртикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНаСъздаванеНаПоръчкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.начинНаПлащанеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусНаПоръчкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDпродуктDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dP_Vasilena_DataBaseDataSet = new DP_Vasilena12a.Model.DP_Vasilena_DataBaseDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.typeArtikulLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.paymentLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDproductsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.китариDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.синтезаториDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пианаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.барабаниDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тонколониDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.басКолониDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пултовеУсилвателиИМиксериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контролериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.микрофониDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.професионалноОсветлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dataTableAdapter = new DP_Vasilena12a.Model.DP_Vasilena_DataBaseDataSetTableAdapters.DataTableAdapter();
            this.productsTableAdapter = new DP_Vasilena12a.Model.DP_Vasilena_DataBaseDataSetTableAdapters.ProductsTableAdapter();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dP_Vasilena_DataBaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.типНаПродуктDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.видАртикулDataGridViewTextBoxColumn,
            this.датаНаСъздаванеНаПоръчкаDataGridViewTextBoxColumn,
            this.начинНаПлащанеDataGridViewTextBoxColumn,
            this.статусНаПоръчкаDataGridViewTextBoxColumn,
            this.iDпродуктDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dataBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(-101, 664);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 102;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.Size = new System.Drawing.Size(1846, 327);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // типНаПродуктDataGridViewTextBoxColumn
            // 
            this.типНаПродуктDataGridViewTextBoxColumn.DataPropertyName = "Тип на продукт";
            this.типНаПродуктDataGridViewTextBoxColumn.HeaderText = "Тип на продукт";
            this.типНаПродуктDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.типНаПродуктDataGridViewTextBoxColumn.Name = "типНаПродуктDataGridViewTextBoxColumn";
            this.типНаПродуктDataGridViewTextBoxColumn.Width = 250;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.Width = 250;
            // 
            // видАртикулDataGridViewTextBoxColumn
            // 
            this.видАртикулDataGridViewTextBoxColumn.DataPropertyName = "Вид артикул";
            this.видАртикулDataGridViewTextBoxColumn.HeaderText = "Вид артикул";
            this.видАртикулDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.видАртикулDataGridViewTextBoxColumn.Name = "видАртикулDataGridViewTextBoxColumn";
            this.видАртикулDataGridViewTextBoxColumn.Width = 250;
            // 
            // датаНаСъздаванеНаПоръчкаDataGridViewTextBoxColumn
            // 
            this.датаНаСъздаванеНаПоръчкаDataGridViewTextBoxColumn.DataPropertyName = "Дата на създаване на поръчка";
            this.датаНаСъздаванеНаПоръчкаDataGridViewTextBoxColumn.HeaderText = "Дата на създаване на поръчка";
            this.датаНаСъздаванеНаПоръчкаDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.датаНаСъздаванеНаПоръчкаDataGridViewTextBoxColumn.Name = "датаНаСъздаванеНаПоръчкаDataGridViewTextBoxColumn";
            this.датаНаСъздаванеНаПоръчкаDataGridViewTextBoxColumn.Width = 250;
            // 
            // начинНаПлащанеDataGridViewTextBoxColumn
            // 
            this.начинНаПлащанеDataGridViewTextBoxColumn.DataPropertyName = "Начин на плащане";
            this.начинНаПлащанеDataGridViewTextBoxColumn.HeaderText = "Начин на плащане";
            this.начинНаПлащанеDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.начинНаПлащанеDataGridViewTextBoxColumn.Name = "начинНаПлащанеDataGridViewTextBoxColumn";
            this.начинНаПлащанеDataGridViewTextBoxColumn.Width = 250;
            // 
            // статусНаПоръчкаDataGridViewTextBoxColumn
            // 
            this.статусНаПоръчкаDataGridViewTextBoxColumn.DataPropertyName = "Статус на поръчка";
            this.статусНаПоръчкаDataGridViewTextBoxColumn.HeaderText = "Статус на поръчка";
            this.статусНаПоръчкаDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.статусНаПоръчкаDataGridViewTextBoxColumn.Name = "статусНаПоръчкаDataGridViewTextBoxColumn";
            this.статусНаПоръчкаDataGridViewTextBoxColumn.Width = 250;
            // 
            // iDпродуктDataGridViewTextBoxColumn
            // 
            this.iDпродуктDataGridViewTextBoxColumn.DataPropertyName = "ID_продукт";
            this.iDпродуктDataGridViewTextBoxColumn.HeaderText = "ID_продукт";
            this.iDпродуктDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.iDпродуктDataGridViewTextBoxColumn.Name = "iDпродуктDataGridViewTextBoxColumn";
            this.iDпродуктDataGridViewTextBoxColumn.Width = 250;
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataMember = "Data";
            this.dataBindingSource.DataSource = this.dP_Vasilena_DataBaseDataSet;
            // 
            // dP_Vasilena_DataBaseDataSet
            // 
            this.dP_Vasilena_DataBaseDataSet.DataSetName = "DP_Vasilena_DataBaseDataSet";
            this.dP_Vasilena_DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.priceLbl);
            this.groupBox1.Controls.Add(this.typeArtikulLbl);
            this.groupBox1.Controls.Add(this.dateLbl);
            this.groupBox1.Controls.Add(this.paymentLbl);
            this.groupBox1.Controls.Add(this.statusLbl);
            this.groupBox1.Controls.Add(this.typeLbl);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 656);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(524, 315);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(461, 47);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.Value = new System.DateTime(2024, 3, 26, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(524, 55);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(461, 47);
            this.comboBox4.TabIndex = 23;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(524, 558);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(461, 47);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(524, 481);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(461, 47);
            this.comboBox3.TabIndex = 19;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 12.9F);
            this.label1.Location = new System.Drawing.Point(26, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 57);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID на продукт";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(524, 410);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(461, 47);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(524, 206);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(461, 47);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(524, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 47);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Sylfaen", 12.9F);
            this.priceLbl.Location = new System.Drawing.Point(26, 120);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(121, 57);
            this.priceLbl.TabIndex = 13;
            this.priceLbl.Text = "Цена";
            // 
            // typeArtikulLbl
            // 
            this.typeArtikulLbl.AutoSize = true;
            this.typeArtikulLbl.Font = new System.Drawing.Font("Sylfaen", 12.9F);
            this.typeArtikulLbl.Location = new System.Drawing.Point(26, 196);
            this.typeArtikulLbl.Name = "typeArtikulLbl";
            this.typeArtikulLbl.Size = new System.Drawing.Size(262, 57);
            this.typeArtikulLbl.TabIndex = 12;
            this.typeArtikulLbl.Text = "Вид артикул";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Sylfaen", 12.9F);
            this.dateLbl.Location = new System.Drawing.Point(22, 274);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(363, 114);
            this.dateLbl.TabIndex = 11;
            this.dateLbl.Text = "Дата на създаване\r\nна поръчка";
            // 
            // paymentLbl
            // 
            this.paymentLbl.AutoSize = true;
            this.paymentLbl.Font = new System.Drawing.Font("Sylfaen", 12.9F);
            this.paymentLbl.Location = new System.Drawing.Point(26, 401);
            this.paymentLbl.Name = "paymentLbl";
            this.paymentLbl.Size = new System.Drawing.Size(379, 57);
            this.paymentLbl.TabIndex = 10;
            this.paymentLbl.Text = "Начин на плащане";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Sylfaen", 12.9F);
            this.statusLbl.Location = new System.Drawing.Point(26, 471);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(372, 57);
            this.statusLbl.TabIndex = 9;
            this.statusLbl.Text = "Статус на поръчка";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Sylfaen", 12.9F);
            this.typeLbl.Location = new System.Drawing.Point(26, 45);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(320, 57);
            this.typeLbl.TabIndex = 8;
            this.typeLbl.Text = "Тип на продукт";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Location = new System.Drawing.Point(3, 43);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 60);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Purple;
            this.addBtn.Font = new System.Drawing.Font("Sylfaen", 15.9F, System.Drawing.FontStyle.Bold);
            this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBtn.Location = new System.Drawing.Point(1073, 32);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(378, 100);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Добави";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Purple;
            this.clearBtn.Font = new System.Drawing.Font("Sylfaen", 15.9F, System.Drawing.FontStyle.Bold);
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearBtn.Location = new System.Drawing.Point(1073, 155);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(378, 100);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Изчисти";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Purple;
            this.deleteBtn.Font = new System.Drawing.Font("Sylfaen", 15.9F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteBtn.Location = new System.Drawing.Point(1073, 284);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(378, 100);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Изтрий";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDproductsDataGridViewTextBoxColumn,
            this.китариDataGridViewTextBoxColumn,
            this.синтезаториDataGridViewTextBoxColumn,
            this.пианаDataGridViewTextBoxColumn,
            this.барабаниDataGridViewTextBoxColumn,
            this.тонколониDataGridViewTextBoxColumn,
            this.басКолониDataGridViewTextBoxColumn,
            this.пултовеУсилвателиИМиксериDataGridViewTextBoxColumn,
            this.контролериDataGridViewTextBoxColumn,
            this.микрофониDataGridViewTextBoxColumn,
            this.професионалноОсветлениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-101, 997);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1846, 327);
            this.dataGridView1.TabIndex = 14;
            // 
            // iDproductsDataGridViewTextBoxColumn
            // 
            this.iDproductsDataGridViewTextBoxColumn.DataPropertyName = "ID_products";
            this.iDproductsDataGridViewTextBoxColumn.HeaderText = "ID_products";
            this.iDproductsDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.iDproductsDataGridViewTextBoxColumn.Name = "iDproductsDataGridViewTextBoxColumn";
            this.iDproductsDataGridViewTextBoxColumn.Width = 250;
            // 
            // китариDataGridViewTextBoxColumn
            // 
            this.китариDataGridViewTextBoxColumn.DataPropertyName = "Китари";
            this.китариDataGridViewTextBoxColumn.HeaderText = "Китари";
            this.китариDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.китариDataGridViewTextBoxColumn.Name = "китариDataGridViewTextBoxColumn";
            this.китариDataGridViewTextBoxColumn.Width = 250;
            // 
            // синтезаториDataGridViewTextBoxColumn
            // 
            this.синтезаториDataGridViewTextBoxColumn.DataPropertyName = "Синтезатори";
            this.синтезаториDataGridViewTextBoxColumn.HeaderText = "Синтезатори";
            this.синтезаториDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.синтезаториDataGridViewTextBoxColumn.Name = "синтезаториDataGridViewTextBoxColumn";
            this.синтезаториDataGridViewTextBoxColumn.Width = 250;
            // 
            // пианаDataGridViewTextBoxColumn
            // 
            this.пианаDataGridViewTextBoxColumn.DataPropertyName = "Пиана";
            this.пианаDataGridViewTextBoxColumn.HeaderText = "Пиана";
            this.пианаDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.пианаDataGridViewTextBoxColumn.Name = "пианаDataGridViewTextBoxColumn";
            this.пианаDataGridViewTextBoxColumn.Width = 250;
            // 
            // барабаниDataGridViewTextBoxColumn
            // 
            this.барабаниDataGridViewTextBoxColumn.DataPropertyName = "Барабани";
            this.барабаниDataGridViewTextBoxColumn.HeaderText = "Барабани";
            this.барабаниDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.барабаниDataGridViewTextBoxColumn.Name = "барабаниDataGridViewTextBoxColumn";
            this.барабаниDataGridViewTextBoxColumn.Width = 250;
            // 
            // тонколониDataGridViewTextBoxColumn
            // 
            this.тонколониDataGridViewTextBoxColumn.DataPropertyName = "Тонколони";
            this.тонколониDataGridViewTextBoxColumn.HeaderText = "Тонколони";
            this.тонколониDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.тонколониDataGridViewTextBoxColumn.Name = "тонколониDataGridViewTextBoxColumn";
            this.тонколониDataGridViewTextBoxColumn.Width = 250;
            // 
            // басКолониDataGridViewTextBoxColumn
            // 
            this.басКолониDataGridViewTextBoxColumn.DataPropertyName = "Бас колони";
            this.басКолониDataGridViewTextBoxColumn.HeaderText = "Бас колони";
            this.басКолониDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.басКолониDataGridViewTextBoxColumn.Name = "басКолониDataGridViewTextBoxColumn";
            this.басКолониDataGridViewTextBoxColumn.Width = 250;
            // 
            // пултовеУсилвателиИМиксериDataGridViewTextBoxColumn
            // 
            this.пултовеУсилвателиИМиксериDataGridViewTextBoxColumn.DataPropertyName = "Пултове, Усилватели и Миксери";
            this.пултовеУсилвателиИМиксериDataGridViewTextBoxColumn.HeaderText = "Пултове, Усилватели и Миксери";
            this.пултовеУсилвателиИМиксериDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.пултовеУсилвателиИМиксериDataGridViewTextBoxColumn.Name = "пултовеУсилвателиИМиксериDataGridViewTextBoxColumn";
            this.пултовеУсилвателиИМиксериDataGridViewTextBoxColumn.Width = 250;
            // 
            // контролериDataGridViewTextBoxColumn
            // 
            this.контролериDataGridViewTextBoxColumn.DataPropertyName = "Контролери";
            this.контролериDataGridViewTextBoxColumn.HeaderText = "Контролери";
            this.контролериDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.контролериDataGridViewTextBoxColumn.Name = "контролериDataGridViewTextBoxColumn";
            this.контролериDataGridViewTextBoxColumn.Width = 250;
            // 
            // микрофониDataGridViewTextBoxColumn
            // 
            this.микрофониDataGridViewTextBoxColumn.DataPropertyName = "Микрофони";
            this.микрофониDataGridViewTextBoxColumn.HeaderText = "Микрофони";
            this.микрофониDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.микрофониDataGridViewTextBoxColumn.Name = "микрофониDataGridViewTextBoxColumn";
            this.микрофониDataGridViewTextBoxColumn.Width = 250;
            // 
            // професионалноОсветлениеDataGridViewTextBoxColumn
            // 
            this.професионалноОсветлениеDataGridViewTextBoxColumn.DataPropertyName = "Професионално осветление";
            this.професионалноОсветлениеDataGridViewTextBoxColumn.HeaderText = "Професионално осветление";
            this.професионалноОсветлениеDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.професионалноОсветлениеDataGridViewTextBoxColumn.Name = "професионалноОсветлениеDataGridViewTextBoxColumn";
            this.професионалноОсветлениеDataGridViewTextBoxColumn.Width = 250;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.dP_Vasilena_DataBaseDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("Sylfaen", 15.9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1073, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 100);
            this.button1.TabIndex = 15;
            this.button1.Text = "Запиши";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataTableAdapter
            // 
            this.dataTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Purple;
            this.closeBtn.Font = new System.Drawing.Font("Sylfaen", 15.9F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeBtn.Location = new System.Drawing.Point(1073, 535);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(378, 100);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.Text = "Затвори";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // LogIn_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1777, 1361);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LogIn_Admin";
            this.Text = "LogIn_Admin";
            this.Load += new System.EventHandler(this.LogIn_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dP_Vasilena_DataBaseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label typeArtikulLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label paymentLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Model.DP_Vasilena_DataBaseDataSet dP_Vasilena_DataBaseDataSet;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private Model.DP_Vasilena_DataBaseDataSetTableAdapters.DataTableAdapter dataTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private Model.DP_Vasilena_DataBaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproductsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn китариDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn синтезаториDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пианаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn барабаниDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тонколониDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn басКолониDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пултовеУсилвателиИМиксериDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn контролериDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn микрофониDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn професионалноОсветлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn типНаПродуктDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видАртикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНаСъздаванеНаПоръчкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn начинНаПлащанеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусНаПоръчкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDпродуктDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button closeBtn;
    }
}