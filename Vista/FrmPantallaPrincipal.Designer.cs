namespace Vista {
	partial class FrmPantallaPrincipal {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing&&(components!=null)) {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPantallaPrincipal));
			this.btn_CrearMesa = new System.Windows.Forms.Button();
			this.dgw_Partidas = new System.Windows.Forms.DataGridView();
			this.grp_Mesas = new System.Windows.Forms.GroupBox();
			this.btn_AbrirMesa = new System.Windows.Forms.Button();
			this.cmb_PrimerJugador = new System.Windows.Forms.ComboBox();
			this.cmb_SegundoJugador = new System.Windows.Forms.ComboBox();
			this.grp_NuevaMesa = new System.Windows.Forms.GroupBox();
			this.btn_NuevoJugador = new System.Windows.Forms.Button();
			this.lbl_JugadorDos = new System.Windows.Forms.Label();
			this.lbl_JugadorUno = new System.Windows.Forms.Label();
			this.lbl_Titulo = new System.Windows.Forms.Label();
			this.btn_ExportarJugadoresJSON = new System.Windows.Forms.Button();
			this.grp_ExportarDatos = new System.Windows.Forms.GroupBox();
			this.btn_ExportarJugadoresXML = new System.Windows.Forms.Button();
			this.brn_Salir = new System.Windows.Forms.Button();
			this.grp_ImportarBaseDeDatos = new System.Windows.Forms.GroupBox();
			this.btn_ImportarJugadoresJSON = new System.Windows.Forms.Button();
			this.btm_JugadoresSQL = new System.Windows.Forms.Button();
			this.btn_ImportarJugadoresXML = new System.Windows.Forms.Button();
			this.btn_RankingVictorias = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgw_Partidas)).BeginInit();
			this.grp_Mesas.SuspendLayout();
			this.grp_NuevaMesa.SuspendLayout();
			this.grp_ExportarDatos.SuspendLayout();
			this.grp_ImportarBaseDeDatos.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_CrearMesa
			// 
			this.btn_CrearMesa.BackColor = System.Drawing.Color.RosyBrown;
			this.btn_CrearMesa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_CrearMesa.Location = new System.Drawing.Point(6, 105);
			this.btn_CrearMesa.Name = "btn_CrearMesa";
			this.btn_CrearMesa.Size = new System.Drawing.Size(251, 56);
			this.btn_CrearMesa.TabIndex = 2;
			this.btn_CrearMesa.Text = "Crear Mesa";
			this.btn_CrearMesa.UseVisualStyleBackColor = false;
			this.btn_CrearMesa.Click += new System.EventHandler(this.btn_CrearMesa_Click);
			// 
			// dgw_Partidas
			// 
			this.dgw_Partidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgw_Partidas.BackgroundColor = System.Drawing.Color.LightSalmon;
			this.dgw_Partidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgw_Partidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_Partidas.Location = new System.Drawing.Point(6, 24);
			this.dgw_Partidas.MultiSelect = false;
			this.dgw_Partidas.Name = "dgw_Partidas";
			this.dgw_Partidas.ReadOnly = true;
			this.dgw_Partidas.RowHeadersVisible = false;
			this.dgw_Partidas.RowTemplate.Height = 25;
			this.dgw_Partidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgw_Partidas.Size = new System.Drawing.Size(669, 150);
			this.dgw_Partidas.TabIndex = 1;
			// 
			// grp_Mesas
			// 
			this.grp_Mesas.Controls.Add(this.btn_AbrirMesa);
			this.grp_Mesas.Controls.Add(this.dgw_Partidas);
			this.grp_Mesas.Location = new System.Drawing.Point(12, 112);
			this.grp_Mesas.Name = "grp_Mesas";
			this.grp_Mesas.Size = new System.Drawing.Size(860, 180);
			this.grp_Mesas.TabIndex = 2;
			this.grp_Mesas.TabStop = false;
			this.grp_Mesas.Text = "Mesas De Juego";
			// 
			// btn_AbrirMesa
			// 
			this.btn_AbrirMesa.BackColor = System.Drawing.Color.RosyBrown;
			this.btn_AbrirMesa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_AbrirMesa.Location = new System.Drawing.Point(681, 24);
			this.btn_AbrirMesa.Name = "btn_AbrirMesa";
			this.btn_AbrirMesa.Size = new System.Drawing.Size(171, 56);
			this.btn_AbrirMesa.TabIndex = 5;
			this.btn_AbrirMesa.Text = "Abrir Mesa ";
			this.btn_AbrirMesa.UseVisualStyleBackColor = false;
			this.btn_AbrirMesa.Click += new System.EventHandler(this.btn_AbrirMesa_Click);
			// 
			// cmb_PrimerJugador
			// 
			this.cmb_PrimerJugador.BackColor = System.Drawing.Color.RosyBrown;
			this.cmb_PrimerJugador.FormattingEnabled = true;
			this.cmb_PrimerJugador.Location = new System.Drawing.Point(6, 69);
			this.cmb_PrimerJugador.Name = "cmb_PrimerJugador";
			this.cmb_PrimerJugador.Size = new System.Drawing.Size(251, 30);
			this.cmb_PrimerJugador.TabIndex = 0;
			// 
			// cmb_SegundoJugador
			// 
			this.cmb_SegundoJugador.BackColor = System.Drawing.Color.RosyBrown;
			this.cmb_SegundoJugador.FormattingEnabled = true;
			this.cmb_SegundoJugador.Location = new System.Drawing.Point(263, 69);
			this.cmb_SegundoJugador.Name = "cmb_SegundoJugador";
			this.cmb_SegundoJugador.Size = new System.Drawing.Size(251, 30);
			this.cmb_SegundoJugador.TabIndex = 1;
			// 
			// grp_NuevaMesa
			// 
			this.grp_NuevaMesa.Controls.Add(this.btn_NuevoJugador);
			this.grp_NuevaMesa.Controls.Add(this.lbl_JugadorDos);
			this.grp_NuevaMesa.Controls.Add(this.lbl_JugadorUno);
			this.grp_NuevaMesa.Controls.Add(this.cmb_SegundoJugador);
			this.grp_NuevaMesa.Controls.Add(this.cmb_PrimerJugador);
			this.grp_NuevaMesa.Controls.Add(this.btn_CrearMesa);
			this.grp_NuevaMesa.Location = new System.Drawing.Point(408, 298);
			this.grp_NuevaMesa.Name = "grp_NuevaMesa";
			this.grp_NuevaMesa.Size = new System.Drawing.Size(520, 167);
			this.grp_NuevaMesa.TabIndex = 5;
			this.grp_NuevaMesa.TabStop = false;
			this.grp_NuevaMesa.Text = "Crear Mesa de Juego";
			// 
			// btn_NuevoJugador
			// 
			this.btn_NuevoJugador.BackColor = System.Drawing.Color.RosyBrown;
			this.btn_NuevoJugador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_NuevoJugador.Location = new System.Drawing.Point(263, 105);
			this.btn_NuevoJugador.Name = "btn_NuevoJugador";
			this.btn_NuevoJugador.Size = new System.Drawing.Size(251, 56);
			this.btn_NuevoJugador.TabIndex = 4;
			this.btn_NuevoJugador.Text = "Nuevo Jugador";
			this.btn_NuevoJugador.UseVisualStyleBackColor = false;
			this.btn_NuevoJugador.Click += new System.EventHandler(this.btn_NuevoJugador_Click);
			// 
			// lbl_JugadorDos
			// 
			this.lbl_JugadorDos.AutoSize = true;
			this.lbl_JugadorDos.Location = new System.Drawing.Point(263, 44);
			this.lbl_JugadorDos.Name = "lbl_JugadorDos";
			this.lbl_JugadorDos.Size = new System.Drawing.Size(129, 22);
			this.lbl_JugadorDos.TabIndex = 6;
			this.lbl_JugadorDos.Text = "Jugador Dos:";
			// 
			// lbl_JugadorUno
			// 
			this.lbl_JugadorUno.AutoSize = true;
			this.lbl_JugadorUno.Location = new System.Drawing.Point(6, 44);
			this.lbl_JugadorUno.Name = "lbl_JugadorUno";
			this.lbl_JugadorUno.Size = new System.Drawing.Size(132, 22);
			this.lbl_JugadorUno.TabIndex = 5;
			this.lbl_JugadorUno.Text = "Jugador Uno:";
			// 
			// lbl_Titulo
			// 
			this.lbl_Titulo.AutoSize = true;
			this.lbl_Titulo.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lbl_Titulo.Location = new System.Drawing.Point(161, 39);
			this.lbl_Titulo.Name = "lbl_Titulo";
			this.lbl_Titulo.Size = new System.Drawing.Size(565, 70);
			this.lbl_Titulo.TabIndex = 6;
			this.lbl_Titulo.Text = "LA GENERALA FRUTA";
			// 
			// btn_ExportarJugadoresJSON
			// 
			this.btn_ExportarJugadoresJSON.BackColor = System.Drawing.Color.RosyBrown;
			this.btn_ExportarJugadoresJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_ExportarJugadoresJSON.Location = new System.Drawing.Point(9, 30);
			this.btn_ExportarJugadoresJSON.Name = "btn_ExportarJugadoresJSON";
			this.btn_ExportarJugadoresJSON.Size = new System.Drawing.Size(183, 131);
			this.btn_ExportarJugadoresJSON.TabIndex = 5;
			this.btn_ExportarJugadoresJSON.Text = "Jugadores JSON";
			this.btn_ExportarJugadoresJSON.UseVisualStyleBackColor = false;
			this.btn_ExportarJugadoresJSON.Click += new System.EventHandler(this.btn_ExportarJugadoresJSON_Click);
			// 
			// grp_ExportarDatos
			// 
			this.grp_ExportarDatos.Controls.Add(this.btn_ExportarJugadoresXML);
			this.grp_ExportarDatos.Controls.Add(this.btn_ExportarJugadoresJSON);
			this.grp_ExportarDatos.Location = new System.Drawing.Point(12, 298);
			this.grp_ExportarDatos.Name = "grp_ExportarDatos";
			this.grp_ExportarDatos.Size = new System.Drawing.Size(390, 167);
			this.grp_ExportarDatos.TabIndex = 8;
			this.grp_ExportarDatos.TabStop = false;
			this.grp_ExportarDatos.Text = "Exportar Datos:";
			// 
			// btn_ExportarJugadoresXML
			// 
			this.btn_ExportarJugadoresXML.BackColor = System.Drawing.Color.RosyBrown;
			this.btn_ExportarJugadoresXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_ExportarJugadoresXML.Location = new System.Drawing.Point(198, 30);
			this.btn_ExportarJugadoresXML.Name = "btn_ExportarJugadoresXML";
			this.btn_ExportarJugadoresXML.Size = new System.Drawing.Size(183, 131);
			this.btn_ExportarJugadoresXML.TabIndex = 7;
			this.btn_ExportarJugadoresXML.Text = "Jugadores XML";
			this.btn_ExportarJugadoresXML.UseVisualStyleBackColor = false;
			this.btn_ExportarJugadoresXML.Click += new System.EventHandler(this.btn_ExportarJugadoresXML_Click);
			// 
			// brn_Salir
			// 
			this.brn_Salir.BackColor = System.Drawing.Color.RosyBrown;
			this.brn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.brn_Salir.Location = new System.Drawing.Point(671, 530);
			this.brn_Salir.Name = "brn_Salir";
			this.brn_Salir.Size = new System.Drawing.Size(257, 44);
			this.brn_Salir.TabIndex = 19;
			this.brn_Salir.Text = "Salir";
			this.brn_Salir.UseVisualStyleBackColor = false;
			this.brn_Salir.Click += new System.EventHandler(this.brn_Salir_Click);
			// 
			// grp_ImportarBaseDeDatos
			// 
			this.grp_ImportarBaseDeDatos.Controls.Add(this.btn_ImportarJugadoresJSON);
			this.grp_ImportarBaseDeDatos.Controls.Add(this.btm_JugadoresSQL);
			this.grp_ImportarBaseDeDatos.Controls.Add(this.btn_ImportarJugadoresXML);
			this.grp_ImportarBaseDeDatos.Location = new System.Drawing.Point(12, 471);
			this.grp_ImportarBaseDeDatos.Name = "grp_ImportarBaseDeDatos";
			this.grp_ImportarBaseDeDatos.Size = new System.Drawing.Size(653, 103);
			this.grp_ImportarBaseDeDatos.TabIndex = 10;
			this.grp_ImportarBaseDeDatos.TabStop = false;
			this.grp_ImportarBaseDeDatos.Text = "Importar Datos:";
			// 
			// btn_ImportarJugadoresJSON
			// 
			this.btn_ImportarJugadoresJSON.BackColor = System.Drawing.Color.RosyBrown;
			this.btn_ImportarJugadoresJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_ImportarJugadoresJSON.Location = new System.Drawing.Point(464, 30);
			this.btn_ImportarJugadoresJSON.Name = "btn_ImportarJugadoresJSON";
			this.btn_ImportarJugadoresJSON.Size = new System.Drawing.Size(183, 65);
			this.btn_ImportarJugadoresJSON.TabIndex = 6;
			this.btn_ImportarJugadoresJSON.Text = "Jugadores JSON";
			this.btn_ImportarJugadoresJSON.UseVisualStyleBackColor = false;
			this.btn_ImportarJugadoresJSON.Click += new System.EventHandler(this.btn_ImportarJugadoresJSON_Click);
			// 
			// btm_JugadoresSQL
			// 
			this.btm_JugadoresSQL.BackColor = System.Drawing.Color.RosyBrown;
			this.btm_JugadoresSQL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btm_JugadoresSQL.Location = new System.Drawing.Point(6, 30);
			this.btm_JugadoresSQL.Name = "btm_JugadoresSQL";
			this.btm_JugadoresSQL.Size = new System.Drawing.Size(281, 65);
			this.btm_JugadoresSQL.TabIndex = 18;
			this.btm_JugadoresSQL.Text = "Jugadores de la Base de Datos";
			this.btm_JugadoresSQL.UseVisualStyleBackColor = false;
			this.btm_JugadoresSQL.Click += new System.EventHandler(this.btm_JugadoresSQL_Click);
			// 
			// btn_ImportarJugadoresXML
			// 
			this.btn_ImportarJugadoresXML.BackColor = System.Drawing.Color.RosyBrown;
			this.btn_ImportarJugadoresXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_ImportarJugadoresXML.Location = new System.Drawing.Point(293, 30);
			this.btn_ImportarJugadoresXML.Name = "btn_ImportarJugadoresXML";
			this.btn_ImportarJugadoresXML.Size = new System.Drawing.Size(165, 65);
			this.btn_ImportarJugadoresXML.TabIndex = 8;
			this.btn_ImportarJugadoresXML.Text = "Jugadores XML";
			this.btn_ImportarJugadoresXML.UseVisualStyleBackColor = false;
			this.btn_ImportarJugadoresXML.Click += new System.EventHandler(this.btn_ImportarJugadoresXML_Click);
			// 
			// btn_RankingVictorias
			// 
			this.btn_RankingVictorias.BackColor = System.Drawing.Color.RosyBrown;
			this.btn_RankingVictorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_RankingVictorias.Location = new System.Drawing.Point(671, 480);
			this.btn_RankingVictorias.Name = "btn_RankingVictorias";
			this.btn_RankingVictorias.Size = new System.Drawing.Size(258, 44);
			this.btn_RankingVictorias.TabIndex = 20;
			this.btn_RankingVictorias.Text = "Ranking de Victorias";
			this.btn_RankingVictorias.UseVisualStyleBackColor = false;
			this.btn_RankingVictorias.Click += new System.EventHandler(this.btn_RankingVictorias_Click);
			// 
			// FrmPantallaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSalmon;
			this.ClientSize = new System.Drawing.Size(941, 586);
			this.Controls.Add(this.btn_RankingVictorias);
			this.Controls.Add(this.grp_ImportarBaseDeDatos);
			this.Controls.Add(this.brn_Salir);
			this.Controls.Add(this.grp_ExportarDatos);
			this.Controls.Add(this.lbl_Titulo);
			this.Controls.Add(this.grp_NuevaMesa);
			this.Controls.Add(this.grp_Mesas);
			this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.MaximizeBox = false;
			this.Name = "FrmPantallaPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmPantallaPrincipal";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPantallaPrincipal_FormClosed);
			this.Load += new System.EventHandler(this.FrmPantallaPrincipal_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgw_Partidas)).EndInit();
			this.grp_Mesas.ResumeLayout(false);
			this.grp_NuevaMesa.ResumeLayout(false);
			this.grp_NuevaMesa.PerformLayout();
			this.grp_ExportarDatos.ResumeLayout(false);
			this.grp_ImportarBaseDeDatos.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btn_CrearMesa;
		private DataGridView dgw_Partidas;
		private GroupBox grp_Mesas;
		private ComboBox cmb_PrimerJugador;
		private ComboBox cmb_SegundoJugador;
		private GroupBox grp_NuevaMesa;
		private Label lbl_JugadorDos;
		private Label lbl_JugadorUno;
		private Label lbl_Titulo;
		private Button btn_ExportarJugadoresJSON;
		private GroupBox grp_ExportarDatos;
		private Button btn_ExportarJugadoresXML;
		private Button brn_Salir;
		private GroupBox grp_ImportarBaseDeDatos;
		private Button btm_JugadoresSQL;
		private Button btn_ImportarJugadoresJSON;
		private Button btn_ImportarJugadoresXML;
		private Button btn_NuevoJugador;
		private Button btn_RankingVictorias;
		private Button btn_AbrirMesa;
	}
}