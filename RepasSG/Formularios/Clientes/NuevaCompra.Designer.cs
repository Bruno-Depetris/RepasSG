namespace RepasSG.Formularios.Clientes {
    partial class NuevaCompra {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaCompra));
            this.panel_Cliente = new System.Windows.Forms.Panel();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.hopeTextBox_Nombre = new ReaLTaiizor.Controls.HopeTextBox();
            this.hopeTextBox_Direcion = new ReaLTaiizor.Controls.HopeTextBox();
            this.hopeTextBox_Telefono = new ReaLTaiizor.Controls.HopeTextBox();
            this.parrotButton_CargarNuevo = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Comprobar = new ReaLTaiizor.Controls.ParrotButton();
            this.airSeparator1 = new ReaLTaiizor.Controls.AirSeparator();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.dataGridView_Secciones = new System.Windows.Forms.DataGridView();
            this.Column_SeccionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.hopeComboBox_Tipo = new ReaLTaiizor.Controls.HopeComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hopeComboBox_Delivery = new ReaLTaiizor.Controls.HopeComboBox();
            this.panel_LateralControl = new System.Windows.Forms.Panel();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.parrotButton_Agregar = new ReaLTaiizor.Controls.ParrotButton();
            this.hopeTextBox3 = new ReaLTaiizor.Controls.HopeTextBox();
            this.hopeTextBox_Detalles = new ReaLTaiizor.Controls.HopeTextBox();
            this.panel_DetallePedido = new System.Windows.Forms.Panel();
            this.moonLabel_Cliente = new ReaLTaiizor.Controls.MoonLabel();
            this.labelEdit_Pedido = new ReaLTaiizor.Controls.LabelEdit();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.panel_Total = new System.Windows.Forms.Panel();
            this.foxLabel_Total = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            this.parrotButton_Cargar = new ReaLTaiizor.Controls.ParrotButton();
            this.hopeTextBox_Cantidad = new ReaLTaiizor.Controls.HopeTextBox();
            this.panel_Cliente.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.panel_Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Secciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_LateralControl.SuspendLayout();
            this.panel_DetallePedido.SuspendLayout();
            this.panel_Total.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Cliente
            // 
            this.panel_Cliente.Controls.Add(this.airSeparator1);
            this.panel_Cliente.Controls.Add(this.parrotButton_Comprobar);
            this.panel_Cliente.Controls.Add(this.parrotButton_CargarNuevo);
            this.panel_Cliente.Controls.Add(this.hopeTextBox_Telefono);
            this.panel_Cliente.Controls.Add(this.hopeTextBox_Direcion);
            this.panel_Cliente.Controls.Add(this.hopeTextBox_Nombre);
            this.panel_Cliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Cliente.Location = new System.Drawing.Point(0, 0);
            this.panel_Cliente.Name = "panel_Cliente";
            this.panel_Cliente.Size = new System.Drawing.Size(807, 64);
            this.panel_Cliente.TabIndex = 1;
            this.panel_Cliente.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Cliente_Paint);
            // 
            // panel_Menu
            // 
            this.panel_Menu.Controls.Add(this.panel_Contenedor);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Menu.Location = new System.Drawing.Point(1, 65);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(807, 501);
            this.panel_Menu.TabIndex = 3;
            // 
            // hopeTextBox_Nombre
            // 
            this.hopeTextBox_Nombre.BackColor = System.Drawing.Color.White;
            this.hopeTextBox_Nombre.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTextBox_Nombre.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.hopeTextBox_Nombre.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBox_Nombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopeTextBox_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBox_Nombre.Hint = "Nombre";
            this.hopeTextBox_Nombre.Location = new System.Drawing.Point(11, 12);
            this.hopeTextBox_Nombre.MaxLength = 32767;
            this.hopeTextBox_Nombre.Multiline = false;
            this.hopeTextBox_Nombre.Name = "hopeTextBox_Nombre";
            this.hopeTextBox_Nombre.PasswordChar = '\0';
            this.hopeTextBox_Nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox_Nombre.SelectedText = "";
            this.hopeTextBox_Nombre.SelectionLength = 0;
            this.hopeTextBox_Nombre.SelectionStart = 0;
            this.hopeTextBox_Nombre.Size = new System.Drawing.Size(217, 36);
            this.hopeTextBox_Nombre.TabIndex = 4;
            this.hopeTextBox_Nombre.TabStop = false;
            this.hopeTextBox_Nombre.UseSystemPasswordChar = false;
            // 
            // hopeTextBox_Direcion
            // 
            this.hopeTextBox_Direcion.BackColor = System.Drawing.Color.White;
            this.hopeTextBox_Direcion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTextBox_Direcion.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.hopeTextBox_Direcion.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBox_Direcion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopeTextBox_Direcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBox_Direcion.Hint = "Direccion";
            this.hopeTextBox_Direcion.Location = new System.Drawing.Point(235, 12);
            this.hopeTextBox_Direcion.MaxLength = 32767;
            this.hopeTextBox_Direcion.Multiline = false;
            this.hopeTextBox_Direcion.Name = "hopeTextBox_Direcion";
            this.hopeTextBox_Direcion.PasswordChar = '\0';
            this.hopeTextBox_Direcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox_Direcion.SelectedText = "";
            this.hopeTextBox_Direcion.SelectionLength = 0;
            this.hopeTextBox_Direcion.SelectionStart = 0;
            this.hopeTextBox_Direcion.Size = new System.Drawing.Size(217, 36);
            this.hopeTextBox_Direcion.TabIndex = 5;
            this.hopeTextBox_Direcion.TabStop = false;
            this.hopeTextBox_Direcion.UseSystemPasswordChar = false;
            // 
            // hopeTextBox_Telefono
            // 
            this.hopeTextBox_Telefono.BackColor = System.Drawing.Color.White;
            this.hopeTextBox_Telefono.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTextBox_Telefono.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.hopeTextBox_Telefono.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBox_Telefono.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopeTextBox_Telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBox_Telefono.Hint = "Telefono";
            this.hopeTextBox_Telefono.Location = new System.Drawing.Point(458, 12);
            this.hopeTextBox_Telefono.MaxLength = 32767;
            this.hopeTextBox_Telefono.Multiline = false;
            this.hopeTextBox_Telefono.Name = "hopeTextBox_Telefono";
            this.hopeTextBox_Telefono.PasswordChar = '\0';
            this.hopeTextBox_Telefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox_Telefono.SelectedText = "";
            this.hopeTextBox_Telefono.SelectionLength = 0;
            this.hopeTextBox_Telefono.SelectionStart = 0;
            this.hopeTextBox_Telefono.Size = new System.Drawing.Size(217, 36);
            this.hopeTextBox_Telefono.TabIndex = 6;
            this.hopeTextBox_Telefono.TabStop = false;
            this.hopeTextBox_Telefono.UseSystemPasswordChar = false;
            // 
            // parrotButton_CargarNuevo
            // 
            this.parrotButton_CargarNuevo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.parrotButton_CargarNuevo.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_CargarNuevo.ButtonImage")));
            this.parrotButton_CargarNuevo.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_CargarNuevo.ButtonText = "";
            this.parrotButton_CargarNuevo.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.parrotButton_CargarNuevo.ClickTextColor = System.Drawing.Color.White;
            this.parrotButton_CargarNuevo.CornerRadius = 5;
            this.parrotButton_CargarNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_CargarNuevo.Font = new System.Drawing.Font("Arboria Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_CargarNuevo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_CargarNuevo.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.parrotButton_CargarNuevo.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.parrotButton_CargarNuevo.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_CargarNuevo.Location = new System.Drawing.Point(734, 12);
            this.parrotButton_CargarNuevo.Name = "parrotButton_CargarNuevo";
            this.parrotButton_CargarNuevo.Size = new System.Drawing.Size(47, 36);
            this.parrotButton_CargarNuevo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_CargarNuevo.TabIndex = 8;
            this.parrotButton_CargarNuevo.TextColor = System.Drawing.Color.White;
            this.parrotButton_CargarNuevo.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_CargarNuevo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // parrotButton_Comprobar
            // 
            this.parrotButton_Comprobar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.parrotButton_Comprobar.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Comprobar.ButtonImage")));
            this.parrotButton_Comprobar.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Comprobar.ButtonText = "";
            this.parrotButton_Comprobar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.parrotButton_Comprobar.ClickTextColor = System.Drawing.Color.White;
            this.parrotButton_Comprobar.CornerRadius = 5;
            this.parrotButton_Comprobar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Comprobar.Font = new System.Drawing.Font("Arboria Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Comprobar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Comprobar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.parrotButton_Comprobar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.parrotButton_Comprobar.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Comprobar.Location = new System.Drawing.Point(681, 12);
            this.parrotButton_Comprobar.Name = "parrotButton_Comprobar";
            this.parrotButton_Comprobar.Size = new System.Drawing.Size(36, 36);
            this.parrotButton_Comprobar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Comprobar.TabIndex = 9;
            this.parrotButton_Comprobar.TextColor = System.Drawing.Color.White;
            this.parrotButton_Comprobar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Comprobar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // airSeparator1
            // 
            this.airSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.airSeparator1.Colors = new ReaLTaiizor.Util.BloomAir[0];
            this.airSeparator1.Customization = "";
            this.airSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.airSeparator1.Font = new System.Drawing.Font("Verdana", 8F);
            this.airSeparator1.Image = null;
            this.airSeparator1.Location = new System.Drawing.Point(0, 63);
            this.airSeparator1.Name = "airSeparator1";
            this.airSeparator1.NoRounding = false;
            this.airSeparator1.Size = new System.Drawing.Size(807, 1);
            this.airSeparator1.TabIndex = 10;
            this.airSeparator1.Text = "airSeparator1";
            this.airSeparator1.Transparent = false;
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Contenedor.Controls.Add(this.dataGridView_Secciones);
            this.panel_Contenedor.Controls.Add(this.dataGridView1);
            this.panel_Contenedor.Controls.Add(this.panel_LateralControl);
            this.panel_Contenedor.Location = new System.Drawing.Point(11, 0);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(783, 488);
            this.panel_Contenedor.TabIndex = 0;
            // 
            // dataGridView_Secciones
            // 
            this.dataGridView_Secciones.AllowUserToAddRows = false;
            this.dataGridView_Secciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView_Secciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Secciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_SeccionID,
            this.Column_Seccion,
            this.Column_Imagen});
            this.dataGridView_Secciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView_Secciones.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Secciones.Name = "dataGridView_Secciones";
            this.dataGridView_Secciones.RowHeadersVisible = false;
            this.dataGridView_Secciones.Size = new System.Drawing.Size(101, 488);
            this.dataGridView_Secciones.TabIndex = 3;
            // 
            // Column_SeccionID
            // 
            this.Column_SeccionID.HeaderText = "SeccionID";
            this.Column_SeccionID.Name = "Column_SeccionID";
            this.Column_SeccionID.Visible = false;
            // 
            // Column_Seccion
            // 
            this.Column_Seccion.HeaderText = "Seccion";
            this.Column_Seccion.Name = "Column_Seccion";
            this.Column_Seccion.Visible = false;
            // 
            // Column_Imagen
            // 
            this.Column_Imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Imagen.HeaderText = "Imagen";
            this.Column_Imagen.Name = "Column_Imagen";
            // 
            // hopeComboBox_Tipo
            // 
            this.hopeComboBox_Tipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBox_Tipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBox_Tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBox_Tipo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeComboBox_Tipo.FormattingEnabled = true;
            this.hopeComboBox_Tipo.ItemHeight = 30;
            this.hopeComboBox_Tipo.Location = new System.Drawing.Point(13, 6);
            this.hopeComboBox_Tipo.Name = "hopeComboBox_Tipo";
            this.hopeComboBox_Tipo.Size = new System.Drawing.Size(256, 36);
            this.hopeComboBox_Tipo.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 488);
            this.dataGridView1.TabIndex = 4;
            // 
            // hopeComboBox_Delivery
            // 
            this.hopeComboBox_Delivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBox_Delivery.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBox_Delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBox_Delivery.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeComboBox_Delivery.FormattingEnabled = true;
            this.hopeComboBox_Delivery.ItemHeight = 30;
            this.hopeComboBox_Delivery.Location = new System.Drawing.Point(13, 132);
            this.hopeComboBox_Delivery.Name = "hopeComboBox_Delivery";
            this.hopeComboBox_Delivery.Size = new System.Drawing.Size(256, 36);
            this.hopeComboBox_Delivery.TabIndex = 17;
            // 
            // panel_LateralControl
            // 
            this.panel_LateralControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel_LateralControl.Controls.Add(this.parrotGradientPanel1);
            this.panel_LateralControl.Controls.Add(this.hopeComboBox_Delivery);
            this.panel_LateralControl.Controls.Add(this.hopeComboBox_Tipo);
            this.panel_LateralControl.Controls.Add(this.parrotButton_Agregar);
            this.panel_LateralControl.Controls.Add(this.hopeTextBox3);
            this.panel_LateralControl.Controls.Add(this.hopeTextBox_Detalles);
            this.panel_LateralControl.Controls.Add(this.panel_DetallePedido);
            this.panel_LateralControl.Controls.Add(this.panel_Total);
            this.panel_LateralControl.Controls.Add(this.parrotButton_Cargar);
            this.panel_LateralControl.Controls.Add(this.hopeTextBox_Cantidad);
            this.panel_LateralControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_LateralControl.Location = new System.Drawing.Point(502, 0);
            this.panel_LateralControl.Name = "panel_LateralControl";
            this.panel_LateralControl.Size = new System.Drawing.Size(281, 488);
            this.panel_LateralControl.TabIndex = 5;
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.Fuchsia;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 253);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(281, 10);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            this.parrotGradientPanel1.TabIndex = 18;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.White;
            // 
            // parrotButton_Agregar
            // 
            this.parrotButton_Agregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.parrotButton_Agregar.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Agregar.ButtonImage")));
            this.parrotButton_Agregar.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Agregar.ButtonText = "Agregar";
            this.parrotButton_Agregar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.parrotButton_Agregar.ClickTextColor = System.Drawing.Color.White;
            this.parrotButton_Agregar.CornerRadius = 5;
            this.parrotButton_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Agregar.Font = new System.Drawing.Font("Arboria Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Agregar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Agregar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.parrotButton_Agregar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.parrotButton_Agregar.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Agregar.Location = new System.Drawing.Point(56, 201);
            this.parrotButton_Agregar.Name = "parrotButton_Agregar";
            this.parrotButton_Agregar.Size = new System.Drawing.Size(155, 46);
            this.parrotButton_Agregar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Agregar.TabIndex = 15;
            this.parrotButton_Agregar.TextColor = System.Drawing.Color.White;
            this.parrotButton_Agregar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Agregar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // hopeTextBox3
            // 
            this.hopeTextBox3.BackColor = System.Drawing.Color.White;
            this.hopeTextBox3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTextBox3.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.hopeTextBox3.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopeTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBox3.Hint = "Precio";
            this.hopeTextBox3.Location = new System.Drawing.Point(127, 90);
            this.hopeTextBox3.MaxLength = 32767;
            this.hopeTextBox3.Multiline = false;
            this.hopeTextBox3.Name = "hopeTextBox3";
            this.hopeTextBox3.PasswordChar = '\0';
            this.hopeTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox3.SelectedText = "";
            this.hopeTextBox3.SelectionLength = 0;
            this.hopeTextBox3.SelectionStart = 0;
            this.hopeTextBox3.Size = new System.Drawing.Size(142, 36);
            this.hopeTextBox3.TabIndex = 14;
            this.hopeTextBox3.TabStop = false;
            this.hopeTextBox3.UseSystemPasswordChar = false;
            // 
            // hopeTextBox_Detalles
            // 
            this.hopeTextBox_Detalles.BackColor = System.Drawing.Color.White;
            this.hopeTextBox_Detalles.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTextBox_Detalles.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.hopeTextBox_Detalles.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBox_Detalles.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopeTextBox_Detalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBox_Detalles.Hint = "Detalles";
            this.hopeTextBox_Detalles.Location = new System.Drawing.Point(13, 48);
            this.hopeTextBox_Detalles.MaxLength = 32767;
            this.hopeTextBox_Detalles.Multiline = false;
            this.hopeTextBox_Detalles.Name = "hopeTextBox_Detalles";
            this.hopeTextBox_Detalles.PasswordChar = '\0';
            this.hopeTextBox_Detalles.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox_Detalles.SelectedText = "";
            this.hopeTextBox_Detalles.SelectionLength = 0;
            this.hopeTextBox_Detalles.SelectionStart = 0;
            this.hopeTextBox_Detalles.Size = new System.Drawing.Size(256, 36);
            this.hopeTextBox_Detalles.TabIndex = 13;
            this.hopeTextBox_Detalles.TabStop = false;
            this.hopeTextBox_Detalles.UseSystemPasswordChar = false;
            // 
            // panel_DetallePedido
            // 
            this.panel_DetallePedido.BackColor = System.Drawing.Color.White;
            this.panel_DetallePedido.Controls.Add(this.moonLabel_Cliente);
            this.panel_DetallePedido.Controls.Add(this.labelEdit_Pedido);
            this.panel_DetallePedido.Controls.Add(this.bigLabel1);
            this.panel_DetallePedido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_DetallePedido.Location = new System.Drawing.Point(0, 263);
            this.panel_DetallePedido.Name = "panel_DetallePedido";
            this.panel_DetallePedido.Size = new System.Drawing.Size(281, 166);
            this.panel_DetallePedido.TabIndex = 12;
            // 
            // moonLabel_Cliente
            // 
            this.moonLabel_Cliente.AutoSize = true;
            this.moonLabel_Cliente.BackColor = System.Drawing.Color.Transparent;
            this.moonLabel_Cliente.ForeColor = System.Drawing.Color.Gray;
            this.moonLabel_Cliente.Location = new System.Drawing.Point(117, 10);
            this.moonLabel_Cliente.Name = "moonLabel_Cliente";
            this.moonLabel_Cliente.Size = new System.Drawing.Size(65, 13);
            this.moonLabel_Cliente.TabIndex = 2;
            this.moonLabel_Cliente.Text = "moonLabel1";
            // 
            // labelEdit_Pedido
            // 
            this.labelEdit_Pedido.AutoSize = true;
            this.labelEdit_Pedido.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit_Pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelEdit_Pedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelEdit_Pedido.Location = new System.Drawing.Point(10, 44);
            this.labelEdit_Pedido.Name = "labelEdit_Pedido";
            this.labelEdit_Pedido.Size = new System.Drawing.Size(101, 15);
            this.labelEdit_Pedido.TabIndex = 1;
            this.labelEdit_Pedido.Text = "labelEdit_Pedido";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.Black;
            this.bigLabel1.Location = new System.Drawing.Point(12, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(99, 32);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Detalles";
            // 
            // panel_Total
            // 
            this.panel_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_Total.Controls.Add(this.foxLabel_Total);
            this.panel_Total.Controls.Add(this.foxLabel1);
            this.panel_Total.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Total.Location = new System.Drawing.Point(0, 429);
            this.panel_Total.Name = "panel_Total";
            this.panel_Total.Size = new System.Drawing.Size(281, 23);
            this.panel_Total.TabIndex = 11;
            // 
            // foxLabel_Total
            // 
            this.foxLabel_Total.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel_Total.Font = new System.Drawing.Font("Arboria Book", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foxLabel_Total.ForeColor = System.Drawing.Color.White;
            this.foxLabel_Total.Location = new System.Drawing.Point(56, 3);
            this.foxLabel_Total.Name = "foxLabel_Total";
            this.foxLabel_Total.Size = new System.Drawing.Size(65, 19);
            this.foxLabel_Total.TabIndex = 9;
            this.foxLabel_Total.Text = "11600";
            // 
            // foxLabel1
            // 
            this.foxLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel1.Font = new System.Drawing.Font("Arboria Book", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foxLabel1.ForeColor = System.Drawing.Color.White;
            this.foxLabel1.Location = new System.Drawing.Point(3, 3);
            this.foxLabel1.Name = "foxLabel1";
            this.foxLabel1.Size = new System.Drawing.Size(65, 19);
            this.foxLabel1.TabIndex = 8;
            this.foxLabel1.Text = "Total: $";
            // 
            // parrotButton_Cargar
            // 
            this.parrotButton_Cargar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.parrotButton_Cargar.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Cargar.ButtonImage")));
            this.parrotButton_Cargar.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Cargar.ButtonText = "CARGAR";
            this.parrotButton_Cargar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.parrotButton_Cargar.ClickTextColor = System.Drawing.Color.White;
            this.parrotButton_Cargar.CornerRadius = 5;
            this.parrotButton_Cargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Cargar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.parrotButton_Cargar.Font = new System.Drawing.Font("Arboria Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Cargar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Cargar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.parrotButton_Cargar.HoverTextColor = System.Drawing.Color.White;
            this.parrotButton_Cargar.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Cargar.Location = new System.Drawing.Point(0, 452);
            this.parrotButton_Cargar.Name = "parrotButton_Cargar";
            this.parrotButton_Cargar.Size = new System.Drawing.Size(281, 36);
            this.parrotButton_Cargar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Cargar.TabIndex = 9;
            this.parrotButton_Cargar.TextColor = System.Drawing.Color.Black;
            this.parrotButton_Cargar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Cargar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // hopeTextBox_Cantidad
            // 
            this.hopeTextBox_Cantidad.BackColor = System.Drawing.Color.White;
            this.hopeTextBox_Cantidad.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTextBox_Cantidad.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.hopeTextBox_Cantidad.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBox_Cantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopeTextBox_Cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBox_Cantidad.Hint = "Cantidad";
            this.hopeTextBox_Cantidad.Location = new System.Drawing.Point(13, 90);
            this.hopeTextBox_Cantidad.MaxLength = 32767;
            this.hopeTextBox_Cantidad.Multiline = false;
            this.hopeTextBox_Cantidad.Name = "hopeTextBox_Cantidad";
            this.hopeTextBox_Cantidad.PasswordChar = '\0';
            this.hopeTextBox_Cantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox_Cantidad.SelectedText = "";
            this.hopeTextBox_Cantidad.SelectionLength = 0;
            this.hopeTextBox_Cantidad.SelectionStart = 0;
            this.hopeTextBox_Cantidad.Size = new System.Drawing.Size(108, 36);
            this.hopeTextBox_Cantidad.TabIndex = 6;
            this.hopeTextBox_Cantidad.TabStop = false;
            this.hopeTextBox_Cantidad.UseSystemPasswordChar = false;
            // 
            // NuevaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(807, 565);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaCompra";
            this.Text = "NuevaCompra";
            this.panel_Cliente.ResumeLayout(false);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Secciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_LateralControl.ResumeLayout(false);
            this.panel_DetallePedido.ResumeLayout(false);
            this.panel_DetallePedido.PerformLayout();
            this.panel_Total.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Cliente;
        private System.Windows.Forms.Panel panel_Menu;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox_Telefono;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox_Direcion;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox_Nombre;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_CargarNuevo;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Comprobar;
        private ReaLTaiizor.Controls.AirSeparator airSeparator1;
        private System.Windows.Forms.Panel panel_Contenedor;
        private System.Windows.Forms.DataGridView dataGridView_Secciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SeccionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Seccion;
        private System.Windows.Forms.DataGridViewImageColumn Column_Imagen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_LateralControl;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox_Delivery;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox_Tipo;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Agregar;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox3;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox_Detalles;
        private System.Windows.Forms.Panel panel_DetallePedido;
        private ReaLTaiizor.Controls.MoonLabel moonLabel_Cliente;
        private ReaLTaiizor.Controls.LabelEdit labelEdit_Pedido;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Panel panel_Total;
        private ReaLTaiizor.Controls.FoxLabel foxLabel_Total;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Cargar;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox_Cantidad;
    }
}