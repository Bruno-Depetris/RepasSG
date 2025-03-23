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
            this.panel2 = new System.Windows.Forms.Panel();
            this.airSeparator1 = new ReaLTaiizor.Controls.AirSeparator();
            this.parrotButton_CargarNuevo = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.hopeComboBox_Dias = new ReaLTaiizor.Controls.HopeComboBox();
            this.hopeTextBox_Texto = new ReaLTaiizor.Controls.HopeTextBox();
            this.airSeparator2 = new ReaLTaiizor.Controls.AirSeparator();
            this.parrotButton_Imprimir = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Editar = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Borrar = new ReaLTaiizor.Controls.ParrotButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(693, 488);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(693, 488);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.parrotButton_Borrar);
            this.panel2.Controls.Add(this.parrotButton_Editar);
            this.panel2.Controls.Add(this.parrotButton_Imprimir);
            this.panel2.Controls.Add(this.airSeparator2);
            this.panel2.Controls.Add(this.airSeparator1);
            this.panel2.Controls.Add(this.parrotButton_CargarNuevo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(723, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(84, 565);
            this.panel2.TabIndex = 1;
            // 
            // airSeparator1
            // 
            this.airSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.airSeparator1.Colors = new ReaLTaiizor.Util.BloomAir[0];
            this.airSeparator1.Customization = "";
            this.airSeparator1.Font = new System.Drawing.Font("Verdana", 8F);
            this.airSeparator1.Image = null;
            this.airSeparator1.Location = new System.Drawing.Point(12, 86);
            this.airSeparator1.Name = "airSeparator1";
            this.airSeparator1.NoRounding = false;
            this.airSeparator1.Size = new System.Drawing.Size(60, 1);
            this.airSeparator1.TabIndex = 8;
            this.airSeparator1.Text = "airSeparator1";
            this.airSeparator1.Transparent = false;
            // 
            // parrotButton_CargarNuevo
            // 
            this.parrotButton_CargarNuevo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_CargarNuevo.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_CargarNuevo.ButtonImage")));
            this.parrotButton_CargarNuevo.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_CargarNuevo.ButtonText = "";
            this.parrotButton_CargarNuevo.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_CargarNuevo.ClickTextColor = System.Drawing.Color.White;
            this.parrotButton_CargarNuevo.CornerRadius = 5;
            this.parrotButton_CargarNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_CargarNuevo.Font = new System.Drawing.Font("Arboria Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_CargarNuevo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_CargarNuevo.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_CargarNuevo.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.parrotButton_CargarNuevo.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_CargarNuevo.Location = new System.Drawing.Point(12, 22);
            this.parrotButton_CargarNuevo.Name = "parrotButton_CargarNuevo";
            this.parrotButton_CargarNuevo.Size = new System.Drawing.Size(60, 58);
            this.parrotButton_CargarNuevo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_CargarNuevo.TabIndex = 7;
            this.parrotButton_CargarNuevo.TextColor = System.Drawing.Color.White;
            this.parrotButton_CargarNuevo.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_CargarNuevo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.Fuchsia;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(711, 0);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(12, 565);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Vertical;
            this.parrotGradientPanel1.TabIndex = 2;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            // 
            // hopeComboBox_Dias
            // 
            this.hopeComboBox_Dias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBox_Dias.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBox_Dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBox_Dias.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeComboBox_Dias.FormattingEnabled = true;
            this.hopeComboBox_Dias.ItemHeight = 30;
            this.hopeComboBox_Dias.Location = new System.Drawing.Point(12, 23);
            this.hopeComboBox_Dias.Name = "hopeComboBox_Dias";
            this.hopeComboBox_Dias.Size = new System.Drawing.Size(248, 36);
            this.hopeComboBox_Dias.TabIndex = 1;
            // 
            // hopeTextBox_Texto
            // 
            this.hopeTextBox_Texto.BackColor = System.Drawing.Color.White;
            this.hopeTextBox_Texto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTextBox_Texto.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTextBox_Texto.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBox_Texto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopeTextBox_Texto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBox_Texto.Hint = "";
            this.hopeTextBox_Texto.Location = new System.Drawing.Point(266, 23);
            this.hopeTextBox_Texto.MaxLength = 32767;
            this.hopeTextBox_Texto.Multiline = false;
            this.hopeTextBox_Texto.Name = "hopeTextBox_Texto";
            this.hopeTextBox_Texto.PasswordChar = '\0';
            this.hopeTextBox_Texto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox_Texto.SelectedText = "";
            this.hopeTextBox_Texto.SelectionLength = 0;
            this.hopeTextBox_Texto.SelectionStart = 0;
            this.hopeTextBox_Texto.Size = new System.Drawing.Size(237, 36);
            this.hopeTextBox_Texto.TabIndex = 3;
            this.hopeTextBox_Texto.TabStop = false;
            this.hopeTextBox_Texto.UseSystemPasswordChar = false;
            // 
            // airSeparator2
            // 
            this.airSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.airSeparator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.airSeparator2.Colors = new ReaLTaiizor.Util.BloomAir[0];
            this.airSeparator2.Customization = "";
            this.airSeparator2.Font = new System.Drawing.Font("Verdana", 8F);
            this.airSeparator2.Image = null;
            this.airSeparator2.Location = new System.Drawing.Point(12, 364);
            this.airSeparator2.Name = "airSeparator2";
            this.airSeparator2.NoRounding = false;
            this.airSeparator2.Size = new System.Drawing.Size(60, 1);
            this.airSeparator2.TabIndex = 9;
            this.airSeparator2.Text = "airSeparator2";
            this.airSeparator2.Transparent = false;
            // 
            // parrotButton_Imprimir
            // 
            this.parrotButton_Imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.parrotButton_Imprimir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Imprimir.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Imprimir.ButtonImage")));
            this.parrotButton_Imprimir.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Imprimir.ButtonText = "";
            this.parrotButton_Imprimir.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Imprimir.ClickTextColor = System.Drawing.Color.White;
            this.parrotButton_Imprimir.CornerRadius = 5;
            this.parrotButton_Imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Imprimir.Font = new System.Drawing.Font("Arboria Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Imprimir.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Imprimir.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Imprimir.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.parrotButton_Imprimir.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Imprimir.Location = new System.Drawing.Point(12, 371);
            this.parrotButton_Imprimir.Name = "parrotButton_Imprimir";
            this.parrotButton_Imprimir.Size = new System.Drawing.Size(60, 58);
            this.parrotButton_Imprimir.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Imprimir.TabIndex = 10;
            this.parrotButton_Imprimir.TextColor = System.Drawing.Color.White;
            this.parrotButton_Imprimir.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Imprimir.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // parrotButton_Editar
            // 
            this.parrotButton_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.parrotButton_Editar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Editar.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Editar.ButtonImage")));
            this.parrotButton_Editar.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Editar.ButtonText = "";
            this.parrotButton_Editar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Editar.ClickTextColor = System.Drawing.Color.White;
            this.parrotButton_Editar.CornerRadius = 5;
            this.parrotButton_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Editar.Font = new System.Drawing.Font("Arboria Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Editar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Editar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Editar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.parrotButton_Editar.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Editar.Location = new System.Drawing.Point(12, 435);
            this.parrotButton_Editar.Name = "parrotButton_Editar";
            this.parrotButton_Editar.Size = new System.Drawing.Size(60, 58);
            this.parrotButton_Editar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Editar.TabIndex = 11;
            this.parrotButton_Editar.TextColor = System.Drawing.Color.White;
            this.parrotButton_Editar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Editar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // parrotButton_Borrar
            // 
            this.parrotButton_Borrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.parrotButton_Borrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Borrar.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Borrar.ButtonImage")));
            this.parrotButton_Borrar.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Borrar.ButtonText = "";
            this.parrotButton_Borrar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Borrar.ClickTextColor = System.Drawing.Color.White;
            this.parrotButton_Borrar.CornerRadius = 5;
            this.parrotButton_Borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Borrar.Font = new System.Drawing.Font("Arboria Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Borrar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Borrar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotButton_Borrar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.parrotButton_Borrar.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Borrar.Location = new System.Drawing.Point(12, 499);
            this.parrotButton_Borrar.Name = "parrotButton_Borrar";
            this.parrotButton_Borrar.Size = new System.Drawing.Size(60, 58);
            this.parrotButton_Borrar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Borrar.TabIndex = 12;
            this.parrotButton_Borrar.TextColor = System.Drawing.Color.White;
            this.parrotButton_Borrar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Borrar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // ListadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(807, 565);
            this.Controls.Add(this.hopeTextBox_Texto);
            this.Controls.Add(this.hopeComboBox_Dias);
            this.Controls.Add(this.parrotGradientPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoForm";
            this.Text = "ListadoForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
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
        private ReaLTaiizor.Controls.AirSeparator airSeparator1;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_CargarNuevo;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox_Dias;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox_Texto;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Borrar;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Editar;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Imprimir;
        private ReaLTaiizor.Controls.AirSeparator airSeparator2;
    }
}