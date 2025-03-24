namespace RepasSG.Formularios.Listado {
    partial class ListadoForm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_ClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SuscripcionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_RepartidorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MenuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TipoPagoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NoCome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NoDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Novedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Repartidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_FormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PrecioDiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Acumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Accion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hopeComboBox_Dias = new ReaLTaiizor.Controls.HopeComboBox();
            this.hopeTextBox_Texto = new ReaLTaiizor.Controls.HopeTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.parrotButton_Eliminar = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Editar = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Imprimir = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Novedades = new ReaLTaiizor.Controls.ParrotButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.parrotButton_Agregar = new ReaLTaiizor.Controls.ParrotButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 553);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arboria Book", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ClienteID,
            this.Column_SuscripcionID,
            this.Column_RepartidorID,
            this.Column_MenuID,
            this.Column_TipoPagoID,
            this.Column_Cliente,
            this.Column_Menu,
            this.Column_NoCome,
            this.Column_NoDias,
            this.Column_Novedad,
            this.Column_Detalles,
            this.Column_Repartidor,
            this.Column_FormaPago,
            this.Column_TipoPago,
            this.Column_PrecioDiario,
            this.Column_Acumulado,
            this.Column_Accion});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(892, 553);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column_ClienteID
            // 
            this.Column_ClienteID.HeaderText = "ClienteID";
            this.Column_ClienteID.Name = "Column_ClienteID";
            this.Column_ClienteID.Visible = false;
            // 
            // Column_SuscripcionID
            // 
            this.Column_SuscripcionID.HeaderText = "SuscripcionID";
            this.Column_SuscripcionID.Name = "Column_SuscripcionID";
            this.Column_SuscripcionID.Visible = false;
            // 
            // Column_RepartidorID
            // 
            this.Column_RepartidorID.HeaderText = "RepartidorID";
            this.Column_RepartidorID.Name = "Column_RepartidorID";
            this.Column_RepartidorID.Visible = false;
            // 
            // Column_MenuID
            // 
            this.Column_MenuID.HeaderText = "MenuID";
            this.Column_MenuID.Name = "Column_MenuID";
            this.Column_MenuID.Visible = false;
            // 
            // Column_TipoPagoID
            // 
            this.Column_TipoPagoID.HeaderText = "TipoPagoID";
            this.Column_TipoPagoID.Name = "Column_TipoPagoID";
            this.Column_TipoPagoID.Visible = false;
            // 
            // Column_Cliente
            // 
            this.Column_Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Cliente.HeaderText = "Cliente";
            this.Column_Cliente.Name = "Column_Cliente";
            // 
            // Column_Menu
            // 
            this.Column_Menu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Menu.HeaderText = "Menu";
            this.Column_Menu.Name = "Column_Menu";
            // 
            // Column_NoCome
            // 
            this.Column_NoCome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_NoCome.HeaderText = "No Come";
            this.Column_NoCome.Name = "Column_NoCome";
            // 
            // Column_NoDias
            // 
            this.Column_NoDias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_NoDias.HeaderText = "No Dias";
            this.Column_NoDias.Name = "Column_NoDias";
            // 
            // Column_Novedad
            // 
            this.Column_Novedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Novedad.HeaderText = "Novedad";
            this.Column_Novedad.Name = "Column_Novedad";
            // 
            // Column_Detalles
            // 
            this.Column_Detalles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Detalles.HeaderText = "Detalles";
            this.Column_Detalles.Name = "Column_Detalles";
            // 
            // Column_Repartidor
            // 
            this.Column_Repartidor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Repartidor.HeaderText = "Repartidor";
            this.Column_Repartidor.Name = "Column_Repartidor";
            // 
            // Column_FormaPago
            // 
            this.Column_FormaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_FormaPago.HeaderText = "FormaPago";
            this.Column_FormaPago.Name = "Column_FormaPago";
            // 
            // Column_TipoPago
            // 
            this.Column_TipoPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_TipoPago.HeaderText = "TipoPago";
            this.Column_TipoPago.Name = "Column_TipoPago";
            // 
            // Column_PrecioDiario
            // 
            this.Column_PrecioDiario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_PrecioDiario.HeaderText = "Precio Diario";
            this.Column_PrecioDiario.Name = "Column_PrecioDiario";
            // 
            // Column_Acumulado
            // 
            this.Column_Acumulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Acumulado.HeaderText = "Acumulado";
            this.Column_Acumulado.Name = "Column_Acumulado";
            // 
            // Column_Accion
            // 
            this.Column_Accion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Accion.HeaderText = "Accion";
            this.Column_Accion.Name = "Column_Accion";
            // 
            // hopeComboBox_Dias
            // 
            this.hopeComboBox_Dias.BackColor = System.Drawing.Color.White;
            this.hopeComboBox_Dias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBox_Dias.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBox_Dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBox_Dias.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeComboBox_Dias.FormattingEnabled = true;
            this.hopeComboBox_Dias.ItemHeight = 30;
            this.hopeComboBox_Dias.Location = new System.Drawing.Point(12, 12);
            this.hopeComboBox_Dias.Name = "hopeComboBox_Dias";
            this.hopeComboBox_Dias.Size = new System.Drawing.Size(248, 36);
            this.hopeComboBox_Dias.TabIndex = 1;
            // 
            // hopeTextBox_Texto
            // 
            this.hopeTextBox_Texto.BackColor = System.Drawing.Color.White;
            this.hopeTextBox_Texto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hopeTextBox_Texto.BorderColorA = System.Drawing.Color.White;
            this.hopeTextBox_Texto.BorderColorB = System.Drawing.Color.White;
            this.hopeTextBox_Texto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopeTextBox_Texto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBox_Texto.Hint = "Buscar";
            this.hopeTextBox_Texto.Location = new System.Drawing.Point(266, 12);
            this.hopeTextBox_Texto.MaxLength = 32767;
            this.hopeTextBox_Texto.Multiline = false;
            this.hopeTextBox_Texto.Name = "hopeTextBox_Texto";
            this.hopeTextBox_Texto.PasswordChar = '\0';
            this.hopeTextBox_Texto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox_Texto.SelectedText = "";
            this.hopeTextBox_Texto.SelectionLength = 0;
            this.hopeTextBox_Texto.SelectionStart = 0;
            this.hopeTextBox_Texto.Size = new System.Drawing.Size(286, 36);
            this.hopeTextBox_Texto.TabIndex = 4;
            this.hopeTextBox_Texto.TabStop = false;
            this.hopeTextBox_Texto.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(558, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 36);
            this.panel2.TabIndex = 5;
            // 
            // parrotButton_Eliminar
            // 
            this.parrotButton_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.parrotButton_Eliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Eliminar.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Eliminar.ButtonImage")));
            this.parrotButton_Eliminar.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.parrotButton_Eliminar.ButtonText = "";
            this.parrotButton_Eliminar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Eliminar.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.parrotButton_Eliminar.CornerRadius = 5;
            this.parrotButton_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Eliminar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Eliminar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Eliminar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Eliminar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.parrotButton_Eliminar.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Eliminar.Location = new System.Drawing.Point(864, 12);
            this.parrotButton_Eliminar.Name = "parrotButton_Eliminar";
            this.parrotButton_Eliminar.Size = new System.Drawing.Size(40, 39);
            this.parrotButton_Eliminar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Eliminar.TabIndex = 23;
            this.parrotButton_Eliminar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.parrotButton_Eliminar.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.parrotButton_Eliminar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // parrotButton_Editar
            // 
            this.parrotButton_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.parrotButton_Editar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Editar.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Editar.ButtonImage")));
            this.parrotButton_Editar.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.parrotButton_Editar.ButtonText = "";
            this.parrotButton_Editar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Editar.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.parrotButton_Editar.CornerRadius = 5;
            this.parrotButton_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Editar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Editar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Editar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Editar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.parrotButton_Editar.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Editar.Location = new System.Drawing.Point(772, 12);
            this.parrotButton_Editar.Name = "parrotButton_Editar";
            this.parrotButton_Editar.Size = new System.Drawing.Size(40, 39);
            this.parrotButton_Editar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Editar.TabIndex = 24;
            this.parrotButton_Editar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.parrotButton_Editar.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.parrotButton_Editar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // parrotButton_Imprimir
            // 
            this.parrotButton_Imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.parrotButton_Imprimir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Imprimir.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Imprimir.ButtonImage")));
            this.parrotButton_Imprimir.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.parrotButton_Imprimir.ButtonText = "";
            this.parrotButton_Imprimir.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Imprimir.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.parrotButton_Imprimir.CornerRadius = 5;
            this.parrotButton_Imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Imprimir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Imprimir.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Imprimir.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Imprimir.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.parrotButton_Imprimir.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Imprimir.Location = new System.Drawing.Point(726, 12);
            this.parrotButton_Imprimir.Name = "parrotButton_Imprimir";
            this.parrotButton_Imprimir.Size = new System.Drawing.Size(40, 39);
            this.parrotButton_Imprimir.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Imprimir.TabIndex = 25;
            this.parrotButton_Imprimir.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.parrotButton_Imprimir.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.parrotButton_Imprimir.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // parrotButton_Novedades
            // 
            this.parrotButton_Novedades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.parrotButton_Novedades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Novedades.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Novedades.ButtonImage")));
            this.parrotButton_Novedades.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.parrotButton_Novedades.ButtonText = "";
            this.parrotButton_Novedades.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Novedades.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.parrotButton_Novedades.CornerRadius = 5;
            this.parrotButton_Novedades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Novedades.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Novedades.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Novedades.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Novedades.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.parrotButton_Novedades.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Novedades.Location = new System.Drawing.Point(818, 12);
            this.parrotButton_Novedades.Name = "parrotButton_Novedades";
            this.parrotButton_Novedades.Size = new System.Drawing.Size(40, 39);
            this.parrotButton_Novedades.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Novedades.TabIndex = 26;
            this.parrotButton_Novedades.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.parrotButton_Novedades.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.parrotButton_Novedades.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(719, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 36);
            this.panel3.TabIndex = 6;
            // 
            // parrotButton_Agregar
            // 
            this.parrotButton_Agregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Agregar.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Agregar.ButtonImage")));
            this.parrotButton_Agregar.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.parrotButton_Agregar.ButtonText = "";
            this.parrotButton_Agregar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Agregar.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.parrotButton_Agregar.CornerRadius = 5;
            this.parrotButton_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Agregar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Agregar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Agregar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Agregar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.parrotButton_Agregar.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Agregar.Location = new System.Drawing.Point(565, 12);
            this.parrotButton_Agregar.Name = "parrotButton_Agregar";
            this.parrotButton_Agregar.Size = new System.Drawing.Size(40, 39);
            this.parrotButton_Agregar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Agregar.TabIndex = 28;
            this.parrotButton_Agregar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.parrotButton_Agregar.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.parrotButton_Agregar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Agregar.Click += new System.EventHandler(this.parrotButton_Agregar_Click);
            // 
            // ListadoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(916, 630);
            this.Controls.Add(this.parrotButton_Agregar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.parrotButton_Novedades);
            this.Controls.Add(this.parrotButton_Imprimir);
            this.Controls.Add(this.parrotButton_Editar);
            this.Controls.Add(this.parrotButton_Eliminar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.hopeTextBox_Texto);
            this.Controls.Add(this.hopeComboBox_Dias);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoForm";
            this.Text = "ListadoForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SuscripcionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_RepartidorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MenuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TipoPagoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NoCome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NoDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Novedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Repartidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PrecioDiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Acumulado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_Accion;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox_Dias;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox_Texto;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Eliminar;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Editar;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Imprimir;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Novedades;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Agregar;
    }
}