namespace RepasSG.Formularios {
    partial class Listado {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_Fijos = new System.Windows.Forms.DataGridView();
            this.materialButton_CargarNuevo = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton_Borrar = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton_Editar = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton3 = new ReaLTaiizor.Controls.MaterialButton();
            this.hopeTextBox_Comida = new ReaLTaiizor.Controls.HopeTextBox();
            this.materialButton_Actualizar = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton_Novedad = new ReaLTaiizor.Controls.MaterialButton();
            this.hopeComboBox_Dias = new ReaLTaiizor.Controls.HopeComboBox();
            this.Column_ClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NoCome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DiasNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Novedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Acumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Accion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fijos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView_Fijos);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 429);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_Fijos
            // 
            this.dataGridView_Fijos.AllowUserToAddRows = false;
            this.dataGridView_Fijos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView_Fijos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arboria Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Fijos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Fijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Fijos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ClienteID,
            this.Column_FechaIngreso,
            this.Column_Nombre,
            this.Column_Direccion,
            this.Column_Telefono,
            this.Column_NoCome,
            this.Column_DiasNo,
            this.Column_Menu,
            this.Column_Estado,
            this.Column_Novedad,
            this.Column_Acumulado,
            this.Column_Precio,
            this.Column_TipoPago,
            this.Column_Detalles,
            this.Column_Accion});
            this.dataGridView_Fijos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Fijos.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Fijos.Name = "dataGridView_Fijos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arboria Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Fijos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Fijos.RowHeadersVisible = false;
            this.dataGridView_Fijos.Size = new System.Drawing.Size(783, 429);
            this.dataGridView_Fijos.TabIndex = 0;
            // 
            // materialButton_CargarNuevo
            // 
            this.materialButton_CargarNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButton_CargarNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_CargarNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_CargarNuevo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_CargarNuevo.Depth = 0;
            this.materialButton_CargarNuevo.HighEmphasis = true;
            this.materialButton_CargarNuevo.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton_CargarNuevo.Icon")));
            this.materialButton_CargarNuevo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton_CargarNuevo.Location = new System.Drawing.Point(13, 514);
            this.materialButton_CargarNuevo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_CargarNuevo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton_CargarNuevo.Name = "materialButton_CargarNuevo";
            this.materialButton_CargarNuevo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_CargarNuevo.Size = new System.Drawing.Size(159, 36);
            this.materialButton_CargarNuevo.TabIndex = 1;
            this.materialButton_CargarNuevo.Text = "Cargar Nuevo";
            this.materialButton_CargarNuevo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_CargarNuevo.UseAccentColor = false;
            this.materialButton_CargarNuevo.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton1.Location = new System.Drawing.Point(612, 514);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(87, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Imprimir";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialButton_Borrar
            // 
            this.materialButton_Borrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton_Borrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_Borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_Borrar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_Borrar.Depth = 0;
            this.materialButton_Borrar.HighEmphasis = true;
            this.materialButton_Borrar.Icon = null;
            this.materialButton_Borrar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton_Borrar.Location = new System.Drawing.Point(707, 514);
            this.materialButton_Borrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_Borrar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton_Borrar.Name = "materialButton_Borrar";
            this.materialButton_Borrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_Borrar.Size = new System.Drawing.Size(78, 36);
            this.materialButton_Borrar.TabIndex = 3;
            this.materialButton_Borrar.Text = "Borrar";
            this.materialButton_Borrar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton_Borrar.UseAccentColor = true;
            this.materialButton_Borrar.UseVisualStyleBackColor = true;
            // 
            // materialButton_Editar
            // 
            this.materialButton_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton_Editar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_Editar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_Editar.Depth = 0;
            this.materialButton_Editar.HighEmphasis = true;
            this.materialButton_Editar.Icon = null;
            this.materialButton_Editar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton_Editar.Location = new System.Drawing.Point(533, 514);
            this.materialButton_Editar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_Editar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton_Editar.Name = "materialButton_Editar";
            this.materialButton_Editar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_Editar.Size = new System.Drawing.Size(71, 36);
            this.materialButton_Editar.TabIndex = 4;
            this.materialButton_Editar.Text = "Editar";
            this.materialButton_Editar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton_Editar.UseAccentColor = true;
            this.materialButton_Editar.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            this.materialButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton3.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton3.Icon")));
            this.materialButton3.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton3.Location = new System.Drawing.Point(305, 514);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(106, 36);
            this.materialButton3.TabIndex = 6;
            this.materialButton3.Text = "Cobrar";
            this.materialButton3.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // hopeTextBox_Comida
            // 
            this.hopeTextBox_Comida.BackColor = System.Drawing.Color.White;
            this.hopeTextBox_Comida.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTextBox_Comida.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.hopeTextBox_Comida.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBox_Comida.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBox_Comida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBox_Comida.Hint = "Comida";
            this.hopeTextBox_Comida.Location = new System.Drawing.Point(233, 10);
            this.hopeTextBox_Comida.MaxLength = 32767;
            this.hopeTextBox_Comida.Multiline = false;
            this.hopeTextBox_Comida.Name = "hopeTextBox_Comida";
            this.hopeTextBox_Comida.PasswordChar = '\0';
            this.hopeTextBox_Comida.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox_Comida.SelectedText = "";
            this.hopeTextBox_Comida.SelectionLength = 0;
            this.hopeTextBox_Comida.SelectionStart = 0;
            this.hopeTextBox_Comida.Size = new System.Drawing.Size(130, 38);
            this.hopeTextBox_Comida.TabIndex = 31;
            this.hopeTextBox_Comida.TabStop = false;
            this.hopeTextBox_Comida.UseSystemPasswordChar = false;
            // 
            // materialButton_Actualizar
            // 
            this.materialButton_Actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButton_Actualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_Actualizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_Actualizar.Depth = 0;
            this.materialButton_Actualizar.HighEmphasis = true;
            this.materialButton_Actualizar.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton_Actualizar.Icon")));
            this.materialButton_Actualizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton_Actualizar.Location = new System.Drawing.Point(373, 12);
            this.materialButton_Actualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_Actualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton_Actualizar.Name = "materialButton_Actualizar";
            this.materialButton_Actualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_Actualizar.Size = new System.Drawing.Size(137, 36);
            this.materialButton_Actualizar.TabIndex = 32;
            this.materialButton_Actualizar.Text = "ACTUALIZAR";
            this.materialButton_Actualizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_Actualizar.UseAccentColor = false;
            this.materialButton_Actualizar.UseVisualStyleBackColor = true;
            // 
            // materialButton_Novedad
            // 
            this.materialButton_Novedad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButton_Novedad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_Novedad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_Novedad.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_Novedad.Depth = 0;
            this.materialButton_Novedad.HighEmphasis = true;
            this.materialButton_Novedad.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton_Novedad.Icon")));
            this.materialButton_Novedad.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton_Novedad.Location = new System.Drawing.Point(180, 514);
            this.materialButton_Novedad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_Novedad.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton_Novedad.Name = "materialButton_Novedad";
            this.materialButton_Novedad.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_Novedad.Size = new System.Drawing.Size(117, 36);
            this.materialButton_Novedad.TabIndex = 33;
            this.materialButton_Novedad.Text = "Novedad";
            this.materialButton_Novedad.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_Novedad.UseAccentColor = false;
            this.materialButton_Novedad.UseVisualStyleBackColor = true;
            // 
            // hopeComboBox_Dias
            // 
            this.hopeComboBox_Dias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBox_Dias.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBox_Dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBox_Dias.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopeComboBox_Dias.FormattingEnabled = true;
            this.hopeComboBox_Dias.ItemHeight = 30;
            this.hopeComboBox_Dias.Location = new System.Drawing.Point(13, 12);
            this.hopeComboBox_Dias.Name = "hopeComboBox_Dias";
            this.hopeComboBox_Dias.Size = new System.Drawing.Size(214, 36);
            this.hopeComboBox_Dias.TabIndex = 34;
            // 
            // Column_ClienteID
            // 
            this.Column_ClienteID.HeaderText = "ClienteID";
            this.Column_ClienteID.Name = "Column_ClienteID";
            this.Column_ClienteID.ReadOnly = true;
            this.Column_ClienteID.Visible = false;
            // 
            // Column_FechaIngreso
            // 
            this.Column_FechaIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_FechaIngreso.HeaderText = "Fecha ingreso";
            this.Column_FechaIngreso.Name = "Column_FechaIngreso";
            this.Column_FechaIngreso.ReadOnly = true;
            // 
            // Column_Nombre
            // 
            this.Column_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Nombre.HeaderText = "Nombre";
            this.Column_Nombre.Name = "Column_Nombre";
            this.Column_Nombre.ReadOnly = true;
            // 
            // Column_Direccion
            // 
            this.Column_Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Direccion.HeaderText = "Direccion";
            this.Column_Direccion.Name = "Column_Direccion";
            // 
            // Column_Telefono
            // 
            this.Column_Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Telefono.HeaderText = "Telefono";
            this.Column_Telefono.Name = "Column_Telefono";
            // 
            // Column_NoCome
            // 
            this.Column_NoCome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_NoCome.HeaderText = "No Come";
            this.Column_NoCome.Name = "Column_NoCome";
            this.Column_NoCome.ReadOnly = true;
            // 
            // Column_DiasNo
            // 
            this.Column_DiasNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_DiasNo.HeaderText = "Dias NO";
            this.Column_DiasNo.Name = "Column_DiasNo";
            this.Column_DiasNo.ReadOnly = true;
            // 
            // Column_Menu
            // 
            this.Column_Menu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Menu.HeaderText = "Menu";
            this.Column_Menu.Name = "Column_Menu";
            // 
            // Column_Estado
            // 
            this.Column_Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Estado.HeaderText = "Estado";
            this.Column_Estado.Name = "Column_Estado";
            // 
            // Column_Novedad
            // 
            this.Column_Novedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Novedad.HeaderText = "Novedad";
            this.Column_Novedad.Name = "Column_Novedad";
            // 
            // Column_Acumulado
            // 
            this.Column_Acumulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Acumulado.HeaderText = "Acumulado";
            this.Column_Acumulado.Name = "Column_Acumulado";
            // 
            // Column_Precio
            // 
            this.Column_Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Precio.HeaderText = "Precio";
            this.Column_Precio.Name = "Column_Precio";
            // 
            // Column_TipoPago
            // 
            this.Column_TipoPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_TipoPago.HeaderText = "TipoPago";
            this.Column_TipoPago.Name = "Column_TipoPago";
            // 
            // Column_Detalles
            // 
            this.Column_Detalles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Detalles.HeaderText = "Detalles";
            this.Column_Detalles.Name = "Column_Detalles";
            // 
            // Column_Accion
            // 
            this.Column_Accion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Accion.HeaderText = "Accion";
            this.Column_Accion.Name = "Column_Accion";
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(807, 565);
            this.Controls.Add(this.hopeComboBox_Dias);
            this.Controls.Add(this.materialButton_Novedad);
            this.Controls.Add(this.materialButton_Actualizar);
            this.Controls.Add(this.hopeTextBox_Comida);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton_Editar);
            this.Controls.Add(this.materialButton_Borrar);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialButton_CargarNuevo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado";
            this.Text = "Listado";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fijos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Fijos;
        private ReaLTaiizor.Controls.MaterialButton materialButton_CargarNuevo;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialButton materialButton_Borrar;
        private ReaLTaiizor.Controls.MaterialButton materialButton_Editar;
        private ReaLTaiizor.Controls.MaterialButton materialButton3;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox_Comida;
        private ReaLTaiizor.Controls.MaterialButton materialButton_Actualizar;
        private ReaLTaiizor.Controls.MaterialButton materialButton_Novedad;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox_Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NoCome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DiasNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Novedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Acumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Detalles;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_Accion;
    }
}