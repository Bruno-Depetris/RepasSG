namespace RepasSG.Formularios.Principal {
    partial class Repas {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repas));
            this.RepasForm = new ReaLTaiizor.Forms.NightForm();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.panel_ContenedorLateral = new System.Windows.Forms.Panel();
            this.bigLabel_Fecha = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel_Dia = new ReaLTaiizor.Controls.BigLabel();
            this.airSeparator1 = new ReaLTaiizor.Controls.AirSeparator();
            this.parrotButton_Configuracion = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Suscripcion = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Movimientos = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Clientes = new ReaLTaiizor.Controls.ParrotButton();
            this.panel_Indicador = new ReaLTaiizor.Controls.Panel();
            this.parrotButton_Vender = new ReaLTaiizor.Controls.ParrotButton();
            this.pictureBox_ImagenLogo = new System.Windows.Forms.PictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.timer_FechaHora = new System.Windows.Forms.Timer(this.components);
            this.RepasForm.SuspendLayout();
            this.panel_ContenedorLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImagenLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // RepasForm
            // 
            this.RepasForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.RepasForm.Controls.Add(this.panel_Contenedor);
            this.RepasForm.Controls.Add(this.panel_ContenedorLateral);
            this.RepasForm.Controls.Add(this.nightControlBox1);
            this.RepasForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RepasForm.DrawIcon = false;
            this.RepasForm.Font = new System.Drawing.Font("Arboria Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepasForm.ForeColor = System.Drawing.Color.Black;
            this.RepasForm.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.RepasForm.Location = new System.Drawing.Point(0, 0);
            this.RepasForm.MinimumSize = new System.Drawing.Size(100, 42);
            this.RepasForm.Name = "RepasForm";
            this.RepasForm.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.RepasForm.Size = new System.Drawing.Size(1027, 661);
            this.RepasForm.TabIndex = 0;
            this.RepasForm.Text = "Repas";
            this.RepasForm.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            this.RepasForm.TitleBarTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Contenedor.Location = new System.Drawing.Point(256, 31);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(771, 630);
            this.panel_Contenedor.TabIndex = 2;
            // 
            // panel_ContenedorLateral
            // 
            this.panel_ContenedorLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel_ContenedorLateral.Controls.Add(this.bigLabel_Fecha);
            this.panel_ContenedorLateral.Controls.Add(this.bigLabel_Dia);
            this.panel_ContenedorLateral.Controls.Add(this.airSeparator1);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Configuracion);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Suscripcion);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Movimientos);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Clientes);
            this.panel_ContenedorLateral.Controls.Add(this.panel_Indicador);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Vender);
            this.panel_ContenedorLateral.Controls.Add(this.pictureBox_ImagenLogo);
            this.panel_ContenedorLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ContenedorLateral.Location = new System.Drawing.Point(0, 31);
            this.panel_ContenedorLateral.Name = "panel_ContenedorLateral";
            this.panel_ContenedorLateral.Size = new System.Drawing.Size(256, 630);
            this.panel_ContenedorLateral.TabIndex = 1;
            // 
            // bigLabel_Fecha
            // 
            this.bigLabel_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bigLabel_Fecha.AutoSize = true;
            this.bigLabel_Fecha.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel_Fecha.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bigLabel_Fecha.Location = new System.Drawing.Point(46, 577);
            this.bigLabel_Fecha.Name = "bigLabel_Fecha";
            this.bigLabel_Fecha.Size = new System.Drawing.Size(165, 46);
            this.bigLabel_Fecha.TabIndex = 29;
            this.bigLabel_Fecha.Text = "bigLabel2";
            this.bigLabel_Fecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bigLabel_Dia
            // 
            this.bigLabel_Dia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bigLabel_Dia.AutoSize = true;
            this.bigLabel_Dia.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel_Dia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bigLabel_Dia.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel_Dia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bigLabel_Dia.Location = new System.Drawing.Point(76, 531);
            this.bigLabel_Dia.Name = "bigLabel_Dia";
            this.bigLabel_Dia.Size = new System.Drawing.Size(106, 46);
            this.bigLabel_Dia.TabIndex = 28;
            this.bigLabel_Dia.Text = "Lunes";
            this.bigLabel_Dia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // airSeparator1
            // 
            this.airSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.airSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.airSeparator1.Colors = new ReaLTaiizor.Util.BloomAir[0];
            this.airSeparator1.Customization = "";
            this.airSeparator1.Font = new System.Drawing.Font("Verdana", 8F);
            this.airSeparator1.Image = null;
            this.airSeparator1.Location = new System.Drawing.Point(12, 516);
            this.airSeparator1.Name = "airSeparator1";
            this.airSeparator1.NoRounding = false;
            this.airSeparator1.Size = new System.Drawing.Size(231, 1);
            this.airSeparator1.TabIndex = 27;
            this.airSeparator1.Text = "airSeparator1";
            this.airSeparator1.Transparent = false;
            // 
            // parrotButton_Configuracion
            // 
            this.parrotButton_Configuracion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.parrotButton_Configuracion.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Configuracion.ButtonImage")));
            this.parrotButton_Configuracion.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.parrotButton_Configuracion.ButtonText = "CONFIGURACION";
            this.parrotButton_Configuracion.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.parrotButton_Configuracion.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.parrotButton_Configuracion.CornerRadius = 5;
            this.parrotButton_Configuracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Configuracion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Configuracion.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Configuracion.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.parrotButton_Configuracion.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.parrotButton_Configuracion.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Configuracion.Location = new System.Drawing.Point(7, 321);
            this.parrotButton_Configuracion.Name = "parrotButton_Configuracion";
            this.parrotButton_Configuracion.Size = new System.Drawing.Size(249, 39);
            this.parrotButton_Configuracion.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Configuracion.TabIndex = 26;
            this.parrotButton_Configuracion.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.parrotButton_Configuracion.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.parrotButton_Configuracion.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Configuracion.Click += new System.EventHandler(this.parrotButton_Configuracion_Click);
            // 
            // parrotButton_Suscripcion
            // 
            this.parrotButton_Suscripcion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.parrotButton_Suscripcion.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Suscripcion.ButtonImage")));
            this.parrotButton_Suscripcion.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.parrotButton_Suscripcion.ButtonText = "SUSCRIPCIONES";
            this.parrotButton_Suscripcion.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.parrotButton_Suscripcion.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.parrotButton_Suscripcion.CornerRadius = 5;
            this.parrotButton_Suscripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Suscripcion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Suscripcion.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Suscripcion.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.parrotButton_Suscripcion.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.parrotButton_Suscripcion.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Suscripcion.Location = new System.Drawing.Point(7, 276);
            this.parrotButton_Suscripcion.Name = "parrotButton_Suscripcion";
            this.parrotButton_Suscripcion.Size = new System.Drawing.Size(249, 39);
            this.parrotButton_Suscripcion.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Suscripcion.TabIndex = 25;
            this.parrotButton_Suscripcion.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.parrotButton_Suscripcion.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.parrotButton_Suscripcion.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Suscripcion.Click += new System.EventHandler(this.parrotButton_Suscripcion_Click);
            // 
            // parrotButton_Movimientos
            // 
            this.parrotButton_Movimientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.parrotButton_Movimientos.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Movimientos.ButtonImage")));
            this.parrotButton_Movimientos.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.parrotButton_Movimientos.ButtonText = "MOVIMIENTOS";
            this.parrotButton_Movimientos.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.parrotButton_Movimientos.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.parrotButton_Movimientos.CornerRadius = 5;
            this.parrotButton_Movimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Movimientos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Movimientos.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Movimientos.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.parrotButton_Movimientos.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.parrotButton_Movimientos.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Movimientos.Location = new System.Drawing.Point(7, 231);
            this.parrotButton_Movimientos.Name = "parrotButton_Movimientos";
            this.parrotButton_Movimientos.Size = new System.Drawing.Size(249, 39);
            this.parrotButton_Movimientos.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Movimientos.TabIndex = 24;
            this.parrotButton_Movimientos.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.parrotButton_Movimientos.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.parrotButton_Movimientos.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Movimientos.Click += new System.EventHandler(this.parrotButton_Movimientos_Click);
            // 
            // parrotButton_Clientes
            // 
            this.parrotButton_Clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.parrotButton_Clientes.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Clientes.ButtonImage")));
            this.parrotButton_Clientes.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.parrotButton_Clientes.ButtonText = "CLIENTES";
            this.parrotButton_Clientes.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.parrotButton_Clientes.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.parrotButton_Clientes.CornerRadius = 5;
            this.parrotButton_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Clientes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Clientes.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Clientes.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.parrotButton_Clientes.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.parrotButton_Clientes.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Clientes.Location = new System.Drawing.Point(7, 186);
            this.parrotButton_Clientes.Name = "parrotButton_Clientes";
            this.parrotButton_Clientes.Size = new System.Drawing.Size(249, 39);
            this.parrotButton_Clientes.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Clientes.TabIndex = 23;
            this.parrotButton_Clientes.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.parrotButton_Clientes.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.parrotButton_Clientes.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Clientes.Click += new System.EventHandler(this.parrotButton_Clientes_Click);
            // 
            // panel_Indicador
            // 
            this.panel_Indicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.panel_Indicador.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel_Indicador.Location = new System.Drawing.Point(-4, 141);
            this.panel_Indicador.Name = "panel_Indicador";
            this.panel_Indicador.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Indicador.Size = new System.Drawing.Size(10, 39);
            this.panel_Indicador.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel_Indicador.TabIndex = 22;
            this.panel_Indicador.Text = "panel1";
            // 
            // parrotButton_Vender
            // 
            this.parrotButton_Vender.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.parrotButton_Vender.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Vender.ButtonImage")));
            this.parrotButton_Vender.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.parrotButton_Vender.ButtonText = "VENDER";
            this.parrotButton_Vender.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.parrotButton_Vender.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.parrotButton_Vender.CornerRadius = 5;
            this.parrotButton_Vender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Vender.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Vender.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Vender.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.parrotButton_Vender.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.parrotButton_Vender.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Vender.Location = new System.Drawing.Point(7, 141);
            this.parrotButton_Vender.Name = "parrotButton_Vender";
            this.parrotButton_Vender.Size = new System.Drawing.Size(249, 39);
            this.parrotButton_Vender.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Vender.TabIndex = 21;
            this.parrotButton_Vender.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.parrotButton_Vender.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.parrotButton_Vender.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Vender.Click += new System.EventHandler(this.parrotButton_Vender_Click);
            // 
            // pictureBox_ImagenLogo
            // 
            this.pictureBox_ImagenLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_ImagenLogo.BackgroundImage")));
            this.pictureBox_ImagenLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_ImagenLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_ImagenLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_ImagenLogo.Name = "pictureBox_ImagenLogo";
            this.pictureBox_ImagenLogo.Size = new System.Drawing.Size(256, 135);
            this.pictureBox_ImagenLogo.TabIndex = 0;
            this.pictureBox_ImagenLogo.TabStop = false;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nightControlBox1.Location = new System.Drawing.Point(888, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 0;
            // 
            // timer_FechaHora
            // 
            this.timer_FechaHora.Enabled = true;
            this.timer_FechaHora.Tick += new System.EventHandler(this.timer_FechaHora_Tick);
            // 
            // Repas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 661);
            this.Controls.Add(this.RepasForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "Repas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTheme1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.RepasForm.ResumeLayout(false);
            this.panel_ContenedorLateral.ResumeLayout(false);
            this.panel_ContenedorLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImagenLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.NightForm RepasForm;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Panel panel_ContenedorLateral;
        private System.Windows.Forms.PictureBox pictureBox_ImagenLogo;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Vender;
        private ReaLTaiizor.Controls.Panel panel_Indicador;
        private ReaLTaiizor.Controls.AirSeparator airSeparator1;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Configuracion;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Suscripcion;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Movimientos;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Clientes;
        private ReaLTaiizor.Controls.BigLabel bigLabel_Dia;
        private ReaLTaiizor.Controls.BigLabel bigLabel_Fecha;
        private System.Windows.Forms.Timer timer_FechaHora;
        private System.Windows.Forms.Panel panel_Contenedor;
    }
}