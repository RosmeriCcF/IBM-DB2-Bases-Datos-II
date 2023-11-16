namespace GFive.Tienda.Presentacion
{
    partial class FrmVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVender = new System.Windows.Forms.Button();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiarCarrito = new System.Windows.Forms.Button();
            this.grdCarrito = new System.Windows.Forms.DataGridView();
            this.cIdCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecioUnitarioCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSubtotalCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantidadCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDisminuir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CarritoDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaSubscripcion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreCompletoCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPuntosAcumulados = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grdProductos = new System.Windows.Forms.DataGridView();
            this.cIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdCategoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCategoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStockProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkCategoria = new System.Windows.Forms.CheckBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoDataSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 724F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1410, 892);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.grdCarrito, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(699, 886);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(243)))));
            this.panel3.Controls.Add(this.btnVender);
            this.panel3.Controls.Add(this.txtTotalAPagar);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnLimpiarCarrito);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 807);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(693, 76);
            this.panel3.TabIndex = 3;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.Location = new System.Drawing.Point(287, 21);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(100, 34);
            this.btnVender.TabIndex = 25;
            this.btnVender.Text = "Vender";
            this.btnVender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalAPagar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAPagar.Location = new System.Drawing.Point(185, 27);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.ReadOnly = true;
            this.txtTotalAPagar.Size = new System.Drawing.Size(80, 23);
            this.txtTotalAPagar.TabIndex = 21;
            this.txtTotalAPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(43, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total  a pagar (S./):";
            // 
            // btnLimpiarCarrito
            // 
            this.btnLimpiarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.btnLimpiarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCarrito.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCarrito.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCarrito.Location = new System.Drawing.Point(393, 21);
            this.btnLimpiarCarrito.Name = "btnLimpiarCarrito";
            this.btnLimpiarCarrito.Size = new System.Drawing.Size(100, 34);
            this.btnLimpiarCarrito.TabIndex = 19;
            this.btnLimpiarCarrito.TabStop = false;
            this.btnLimpiarCarrito.Text = "Limpiar";
            this.btnLimpiarCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarCarrito.UseVisualStyleBackColor = false;
            this.btnLimpiarCarrito.Click += new System.EventHandler(this.BtnLimpiarCarrito_Click);
            // 
            // grdCarrito
            // 
            this.grdCarrito.AllowUserToAddRows = false;
            this.grdCarrito.AllowUserToDeleteRows = false;
            this.grdCarrito.AllowUserToResizeColumns = false;
            this.grdCarrito.AllowUserToResizeRows = false;
            this.grdCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCarrito.AutoGenerateColumns = false;
            this.grdCarrito.BackgroundColor = System.Drawing.Color.White;
            this.grdCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdCarrito.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.grdCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grdCarrito.ColumnHeadersHeight = 36;
            this.grdCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdCarrito,
            this.cNombreCarrito,
            this.cPrecioUnitarioCarrito,
            this.cSubtotalCarrito,
            this.cCantidadCarrito,
            this.cDisminuir});
            this.grdCarrito.DataSource = this.CarritoDataSource;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCarrito.DefaultCellStyle = dataGridViewCellStyle22;
            this.grdCarrito.EnableHeadersVisualStyles = false;
            this.grdCarrito.GridColor = System.Drawing.Color.LightGray;
            this.grdCarrito.Location = new System.Drawing.Point(3, 203);
            this.grdCarrito.MultiSelect = false;
            this.grdCarrito.Name = "grdCarrito";
            this.grdCarrito.RowHeadersVisible = false;
            this.grdCarrito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdCarrito.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCarrito.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.grdCarrito.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.grdCarrito.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdCarrito.RowTemplate.Height = 20;
            this.grdCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdCarrito.ShowCellToolTips = false;
            this.grdCarrito.ShowEditingIcon = false;
            this.grdCarrito.Size = new System.Drawing.Size(693, 598);
            this.grdCarrito.TabIndex = 2;
            this.grdCarrito.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdCarrito_CellMouseClick);
            // 
            // cIdCarrito
            // 
            this.cIdCarrito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cIdCarrito.DataPropertyName = "IDPRODUCTO";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cIdCarrito.DefaultCellStyle = dataGridViewCellStyle16;
            this.cIdCarrito.HeaderText = "ID";
            this.cIdCarrito.MinimumWidth = 45;
            this.cIdCarrito.Name = "cIdCarrito";
            this.cIdCarrito.ReadOnly = true;
            this.cIdCarrito.Width = 45;
            // 
            // cNombreCarrito
            // 
            this.cNombreCarrito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNombreCarrito.DataPropertyName = "NOMBRE";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cNombreCarrito.DefaultCellStyle = dataGridViewCellStyle17;
            this.cNombreCarrito.HeaderText = "Nombre";
            this.cNombreCarrito.MinimumWidth = 160;
            this.cNombreCarrito.Name = "cNombreCarrito";
            this.cNombreCarrito.ReadOnly = true;
            // 
            // cPrecioUnitarioCarrito
            // 
            this.cPrecioUnitarioCarrito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cPrecioUnitarioCarrito.DataPropertyName = "PRECIO";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N2";
            this.cPrecioUnitarioCarrito.DefaultCellStyle = dataGridViewCellStyle18;
            this.cPrecioUnitarioCarrito.HeaderText = "P. Unitario (S/.)";
            this.cPrecioUnitarioCarrito.MinimumWidth = 85;
            this.cPrecioUnitarioCarrito.Name = "cPrecioUnitarioCarrito";
            this.cPrecioUnitarioCarrito.ReadOnly = true;
            this.cPrecioUnitarioCarrito.Width = 85;
            // 
            // cSubtotalCarrito
            // 
            this.cSubtotalCarrito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cSubtotalCarrito.DataPropertyName = "SUBTOTAL";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewCellStyle19.NullValue = null;
            this.cSubtotalCarrito.DefaultCellStyle = dataGridViewCellStyle19;
            this.cSubtotalCarrito.HeaderText = "P. Subtotal (S./)";
            this.cSubtotalCarrito.MinimumWidth = 85;
            this.cSubtotalCarrito.Name = "cSubtotalCarrito";
            this.cSubtotalCarrito.ReadOnly = true;
            this.cSubtotalCarrito.Width = 85;
            // 
            // cCantidadCarrito
            // 
            this.cCantidadCarrito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cCantidadCarrito.DataPropertyName = "CANTIDAD";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cCantidadCarrito.DefaultCellStyle = dataGridViewCellStyle20;
            this.cCantidadCarrito.HeaderText = "Cantidad";
            this.cCantidadCarrito.MinimumWidth = 75;
            this.cCantidadCarrito.Name = "cCantidadCarrito";
            this.cCantidadCarrito.ReadOnly = true;
            this.cCantidadCarrito.Width = 75;
            // 
            // cDisminuir
            // 
            this.cDisminuir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.cDisminuir.DefaultCellStyle = dataGridViewCellStyle21;
            this.cDisminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cDisminuir.HeaderText = "";
            this.cDisminuir.MinimumWidth = 85;
            this.cDisminuir.Name = "cDisminuir";
            this.cDisminuir.Text = "Disminuir";
            this.cDisminuir.UseColumnTextForButtonValue = true;
            this.cDisminuir.Width = 85;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(243)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtFechaSubscripcion);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtNombreCompletoCliente);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtDniCliente);
            this.panel2.Controls.Add(this.txtIdCliente);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtPuntosAcumulados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 194);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(220, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Fecha Subscripción:";
            // 
            // txtFechaSubscripcion
            // 
            this.txtFechaSubscripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFechaSubscripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaSubscripcion.Location = new System.Drawing.Point(223, 150);
            this.txtFechaSubscripcion.Name = "txtFechaSubscripcion";
            this.txtFechaSubscripcion.ReadOnly = true;
            this.txtFechaSubscripcion.Size = new System.Drawing.Size(135, 23);
            this.txtFechaSubscripcion.TabIndex = 25;
            this.txtFechaSubscripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(497, 143);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 34);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(391, 143);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 34);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(220, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Nombre Completo:";
            // 
            // txtNombreCompletoCliente
            // 
            this.txtNombreCompletoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreCompletoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompletoCliente.Location = new System.Drawing.Point(223, 90);
            this.txtNombreCompletoCliente.Name = "txtNombreCompletoCliente";
            this.txtNombreCompletoCliente.ReadOnly = true;
            this.txtNombreCompletoCliente.Size = new System.Drawing.Size(374, 23);
            this.txtNombreCompletoCliente.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(125, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "DNI:";
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDniCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniCliente.Location = new System.Drawing.Point(128, 90);
            this.txtDniCliente.MaxLength = 8;
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(64, 23);
            this.txtDniCliente.TabIndex = 20;
            this.txtDniCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(47, 90);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(50, 23);
            this.txtIdCliente.TabIndex = 0;
            this.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(44, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(45, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Puntos Acumulados:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.label6.Location = new System.Drawing.Point(76, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "REGISTRO DE VENTAS";
            // 
            // txtPuntosAcumulados
            // 
            this.txtPuntosAcumulados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPuntosAcumulados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntosAcumulados.Location = new System.Drawing.Point(48, 149);
            this.txtPuntosAcumulados.Name = "txtPuntosAcumulados";
            this.txtPuntosAcumulados.ReadOnly = true;
            this.txtPuntosAcumulados.Size = new System.Drawing.Size(144, 23);
            this.txtPuntosAcumulados.TabIndex = 1;
            this.txtPuntosAcumulados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.grdProductos, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(708, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(699, 886);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // grdProductos
            // 
            this.grdProductos.AllowUserToAddRows = false;
            this.grdProductos.AllowUserToDeleteRows = false;
            this.grdProductos.AllowUserToResizeColumns = false;
            this.grdProductos.AllowUserToResizeRows = false;
            this.grdProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProductos.BackgroundColor = System.Drawing.Color.White;
            this.grdProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdProductos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.grdProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.grdProductos.ColumnHeadersHeight = 36;
            this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdProducto,
            this.cNombreProducto,
            this.cDescripcionProducto,
            this.cIdCategoriaProducto,
            this.cCategoriaProducto,
            this.cPrecioProducto,
            this.cStockProducto});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProductos.DefaultCellStyle = dataGridViewCellStyle28;
            this.grdProductos.EnableHeadersVisualStyles = false;
            this.grdProductos.GridColor = System.Drawing.Color.LightGray;
            this.grdProductos.Location = new System.Drawing.Point(3, 203);
            this.grdProductos.MultiSelect = false;
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.RowHeadersVisible = false;
            this.grdProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdProductos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdProductos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.grdProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.grdProductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdProductos.RowTemplate.Height = 20;
            this.grdProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdProductos.ShowCellToolTips = false;
            this.grdProductos.ShowEditingIcon = false;
            this.grdProductos.Size = new System.Drawing.Size(693, 680);
            this.grdProductos.TabIndex = 2;
            // 
            // cIdProducto
            // 
            this.cIdProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cIdProducto.DataPropertyName = "ID_PRODUCTO";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cIdProducto.DefaultCellStyle = dataGridViewCellStyle24;
            this.cIdProducto.Frozen = true;
            this.cIdProducto.HeaderText = "ID";
            this.cIdProducto.MinimumWidth = 45;
            this.cIdProducto.Name = "cIdProducto";
            this.cIdProducto.ReadOnly = true;
            this.cIdProducto.Width = 45;
            // 
            // cNombreProducto
            // 
            this.cNombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNombreProducto.DataPropertyName = "NOMBRE";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cNombreProducto.DefaultCellStyle = dataGridViewCellStyle25;
            this.cNombreProducto.HeaderText = "Nombre";
            this.cNombreProducto.MinimumWidth = 100;
            this.cNombreProducto.Name = "cNombreProducto";
            this.cNombreProducto.ReadOnly = true;
            // 
            // cDescripcionProducto
            // 
            this.cDescripcionProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cDescripcionProducto.DataPropertyName = "DESCRIPCION";
            this.cDescripcionProducto.HeaderText = "Descripción";
            this.cDescripcionProducto.MinimumWidth = 100;
            this.cDescripcionProducto.Name = "cDescripcionProducto";
            this.cDescripcionProducto.ReadOnly = true;
            // 
            // cIdCategoriaProducto
            // 
            this.cIdCategoriaProducto.DataPropertyName = "ID_CATEGORIA";
            this.cIdCategoriaProducto.HeaderText = "ID Categoria";
            this.cIdCategoriaProducto.Name = "cIdCategoriaProducto";
            this.cIdCategoriaProducto.ReadOnly = true;
            this.cIdCategoriaProducto.Visible = false;
            // 
            // cCategoriaProducto
            // 
            this.cCategoriaProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cCategoriaProducto.DataPropertyName = "DESCRIPCION_CATEGORIA";
            this.cCategoriaProducto.HeaderText = "Categoria";
            this.cCategoriaProducto.MinimumWidth = 140;
            this.cCategoriaProducto.Name = "cCategoriaProducto";
            this.cCategoriaProducto.ReadOnly = true;
            this.cCategoriaProducto.Width = 140;
            // 
            // cPrecioProducto
            // 
            this.cPrecioProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cPrecioProducto.DataPropertyName = "PRECIO";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "N2";
            this.cPrecioProducto.DefaultCellStyle = dataGridViewCellStyle26;
            this.cPrecioProducto.HeaderText = "Precio (S/.)";
            this.cPrecioProducto.MinimumWidth = 85;
            this.cPrecioProducto.Name = "cPrecioProducto";
            this.cPrecioProducto.ReadOnly = true;
            this.cPrecioProducto.Width = 85;
            // 
            // cStockProducto
            // 
            this.cStockProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cStockProducto.DataPropertyName = "STOCK";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cStockProducto.DefaultCellStyle = dataGridViewCellStyle27;
            this.cStockProducto.HeaderText = "Stock";
            this.cStockProducto.MinimumWidth = 65;
            this.cStockProducto.Name = "cStockProducto";
            this.cStockProducto.ReadOnly = true;
            this.cStockProducto.Width = 65;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.chkCategoria);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.cboCategorias);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNombreProducto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 194);
            this.panel1.TabIndex = 1;
            // 
            // chkCategoria
            // 
            this.chkCategoria.AutoSize = true;
            this.chkCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkCategoria.ForeColor = System.Drawing.Color.DimGray;
            this.chkCategoria.Location = new System.Drawing.Point(38, 124);
            this.chkCategoria.Name = "chkCategoria";
            this.chkCategoria.Size = new System.Drawing.Size(95, 20);
            this.chkCategoria.TabIndex = 20;
            this.chkCategoria.TabStop = false;
            this.chkCategoria.Text = "Categoría:";
            this.chkCategoria.UseVisualStyleBackColor = true;
            this.chkCategoria.CheckedChanged += new System.EventHandler(this.ChkCategoria_CheckedChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(347, 143);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(125, 34);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Text = "Limpiar filtros";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // cboCategorias
            // 
            this.cboCategorias.Enabled = false;
            this.cboCategorias.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(38, 150);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(275, 24);
            this.cboCategorias.TabIndex = 16;
            this.cboCategorias.TabStop = false;
            this.cboCategorias.SelectionChangeCommitted += new System.EventHandler(this.CboCategorias_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(35, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.label4.Location = new System.Drawing.Point(80, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "NUESTROS PRODUCTOS";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(38, 90);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(275, 23);
            this.txtNombreProducto.TabIndex = 1;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.TxtNombreProducto_TextChanged);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 892);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoDataSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.TextBox txtTotalAPagar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLimpiarCarrito;
        private System.Windows.Forms.DataGridView grdCarrito;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreCompletoCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPuntosAcumulados;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView grdProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkCategoria;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cboCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.BindingSource CarritoDataSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdCategoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCategoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStockProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecioUnitarioCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSubtotalCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantidadCarrito;
        private System.Windows.Forms.DataGridViewButtonColumn cDisminuir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFechaSubscripcion;
    }
}