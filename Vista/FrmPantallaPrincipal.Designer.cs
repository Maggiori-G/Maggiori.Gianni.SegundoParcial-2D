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
			this.cmb_PrimerJugador = new System.Windows.Forms.ComboBox();
			this.cmb_SegundoJugador = new System.Windows.Forms.ComboBox();
			this.grp_NuevaMesa = new System.Windows.Forms.GroupBox();
			this.btn_CerrarMesa = new System.Windows.Forms.Button();
			this.lbl_JugadorDos = new System.Windows.Forms.Label();
			this.lbl_JugadorUno = new System.Windows.Forms.Label();
			this.lbl_Titulo = new System.Windows.Forms.Label();
			this.btn_ExportarJugadoresJSON = new System.Windows.Forms.Button();
			this.grp_ExportarDatos = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btn_ExportarPartidasJSON = new System.Windows.Forms.Button();
			this.btn_ExportarJugadoresTXT = new System.Windows.Forms.Button();
			this.btn_ExportarJugadoresXML = new System.Windows.Forms.Button();
			this.brn_Salir = new System.Windows.Forms.Button();
			this.grp_ImportarBaseDeDatos = new System.Windows.Forms.GroupBox();
			this.btm_JugadoresSQL = new System.Windows.Forms.Button();
			this.btn_ImportarPartidasXML = new System.Windows.Forms.Button();
			this.btn_ImportarPartidasJSON = new System.Windows.Forms.Button();
			this.btn_ImportarJugadoresXML = new System.Windows.Forms.Button();
			this.btn_ImportarJugadoresJSON = new System.Windows.Forms.Button();
			this.btn_NuevoJugador = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgw_Partidas)).BeginInit();
			this.grp_Mesas.SuspendLayout();
			this.grp_NuevaMesa.SuspendLayout();
			this.grp_ExportarDatos.SuspendLayout();
			this.grp_ImportarBaseDeDatos.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_CrearMesa
			// 
			this.btn_CrearMesa.BackColor = System.Drawing.Color.Snow;
			this.btn_CrearMesa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_CrearMesa.Location = new System.Drawing.Point(6, 122);
			this.btn_CrearMesa.Name = "btn_CrearMesa";
			this.btn_CrearMesa.Size = new System.Drawing.Size(162, 33);
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
			this.dgw_Partidas.ColumnHeadersVisible = false;
			this.dgw_Partidas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgw_Partidas.Location = new System.Drawing.Point(3, 27);
			this.dgw_Partidas.Name = "dgw_Partidas";
			this.dgw_Partidas.RowTemplate.Height = 25;
			this.dgw_Partidas.Size = new System.Drawing.Size(377, 167);
			this.dgw_Partidas.TabIndex = 1;
			// 
			// grp_Mesas
			// 
			this.grp_Mesas.Controls.Add(this.dgw_Partidas);
			this.grp_Mesas.Location = new System.Drawing.Point(478, 112);
			this.grp_Mesas.Name = "grp_Mesas";
			this.grp_Mesas.Size = new System.Drawing.Size(383, 197);
			this.grp_Mesas.TabIndex = 2;
			this.grp_Mesas.TabStop = false;
			this.grp_Mesas.Text = "Mesas Disponibles";
			// 
			// cmb_PrimerJugador
			// 
			this.cmb_PrimerJugador.FormattingEnabled = true;
			this.cmb_PrimerJugador.Location = new System.Drawing.Point(147, 41);
			this.cmb_PrimerJugador.Name = "cmb_PrimerJugador";
			this.cmb_PrimerJugador.Size = new System.Drawing.Size(195, 30);
			this.cmb_PrimerJugador.TabIndex = 0;
			// 
			// cmb_SegundoJugador
			// 
			this.cmb_SegundoJugador.FormattingEnabled = true;
			this.cmb_SegundoJugador.Location = new System.Drawing.Point(147, 85);
			this.cmb_SegundoJugador.Name = "cmb_SegundoJugador";
			this.cmb_SegundoJugador.Size = new System.Drawing.Size(195, 30);
			this.cmb_SegundoJugador.TabIndex = 1;
			// 
			// grp_NuevaMesa
			// 
			this.grp_NuevaMesa.Controls.Add(this.btn_CerrarMesa);
			this.grp_NuevaMesa.Controls.Add(this.lbl_JugadorDos);
			this.grp_NuevaMesa.Controls.Add(this.lbl_JugadorUno);
			this.grp_NuevaMesa.Controls.Add(this.cmb_SegundoJugador);
			this.grp_NuevaMesa.Controls.Add(this.cmb_PrimerJugador);
			this.grp_NuevaMesa.Controls.Add(this.btn_CrearMesa);
			this.grp_NuevaMesa.Location = new System.Drawing.Point(513, 386);
			this.grp_NuevaMesa.Name = "grp_NuevaMesa";
			this.grp_NuevaMesa.Size = new System.Drawing.Size(348, 161);
			this.grp_NuevaMesa.TabIndex = 5;
			this.grp_NuevaMesa.TabStop = false;
			this.grp_NuevaMesa.Text = "Crear Mesa de Juego";
			// 
			// btn_CerrarMesa
			// 
			this.btn_CerrarMesa.BackColor = System.Drawing.Color.Snow;
			this.btn_CerrarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_CerrarMesa.Location = new System.Drawing.Point(174, 122);
			this.btn_CerrarMesa.Name = "btn_CerrarMesa";
			this.btn_CerrarMesa.Size = new System.Drawing.Size(168, 33);
			this.btn_CerrarMesa.TabIndex = 3;
			this.btn_CerrarMesa.Text = "Cerrar Mesa";
			this.btn_CerrarMesa.UseVisualStyleBackColor = false;
			// 
			// lbl_JugadorDos
			// 
			this.lbl_JugadorDos.AutoSize = true;
			this.lbl_JugadorDos.Location = new System.Drawing.Point(9, 88);
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
			this.btn_ExportarJugadoresJSON.BackColor = System.Drawing.Color.Snow;
			this.btn_ExportarJugadoresJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_ExportarJugadoresJSON.Location = new System.Drawing.Point(9, 40);
			this.btn_ExportarJugadoresJSON.Name = "btn_ExportarJugadoresJSON";
			this.btn_ExportarJugadoresJSON.Size = new System.Drawing.Size(183, 35);
			this.btn_ExportarJugadoresJSON.TabIndex = 5;
			this.btn_ExportarJugadoresJSON.Text = "Jugadores JSON";
			this.btn_ExportarJugadoresJSON.UseVisualStyleBackColor = false;
			this.btn_ExportarJugadoresJSON.Click += new System.EventHandler(this.btn_ExportarJugadoresJSON_Click);
			// 
			// grp_ExportarDatos
			// 
			this.grp_ExportarDatos.Controls.Add(this.button3);
			this.grp_ExportarDatos.Controls.Add(this.button2);
			this.grp_ExportarDatos.Controls.Add(this.btn_ExportarPartidasJSON);
			this.grp_ExportarDatos.Controls.Add(this.btn_ExportarJugadoresTXT);
			this.grp_ExportarDatos.Controls.Add(this.btn_ExportarJugadoresXML);
			this.grp_ExportarDatos.Controls.Add(this.btn_ExportarJugadoresJSON);
			this.grp_ExportarDatos.Location = new System.Drawing.Point(25, 349);
			this.grp_ExportarDatos.Name = "grp_ExportarDatos";
			this.grp_ExportarDatos.Size = new System.Drawing.Size(199, 389);
			this.grp_ExportarDatos.TabIndex = 8;
			this.grp_ExportarDatos.TabStop = false;
			this.grp_ExportarDatos.Text = "Exportar Datos:";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Snow;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Location = new System.Drawing.Point(9, 245);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(183, 35);
			this.button3.TabIndex = 15;
			this.button3.Text = "Partidas TXT";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Snow;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Location = new System.Drawing.Point(9, 204);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(183, 35);
			this.button2.TabIndex = 13;
			this.button2.Text = "Partidas XML";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// btn_ExportarPartidasJSON
			// 
			this.btn_ExportarPartidasJSON.BackColor = System.Drawing.Color.Snow;
			this.btn_ExportarPartidasJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_ExportarPartidasJSON.Location = new System.Drawing.Point(9, 163);
			this.btn_ExportarPartidasJSON.Name = "btn_ExportarPartidasJSON";
			this.btn_ExportarPartidasJSON.Size = new System.Drawing.Size(183, 35);
			this.btn_ExportarPartidasJSON.TabIndex = 11;
			this.btn_ExportarPartidasJSON.Text = "Partidas JSON";
			this.btn_ExportarPartidasJSON.UseVisualStyleBackColor = false;
			// 
			// btn_ExportarJugadoresTXT
			// 
			this.btn_ExportarJugadoresTXT.BackColor = System.Drawing.Color.Snow;
			this.btn_ExportarJugadoresTXT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_ExportarJugadoresTXT.Location = new System.Drawing.Point(9, 122);
			this.btn_ExportarJugadoresTXT.Name = "btn_ExportarJugadoresTXT";
			this.btn_ExportarJugadoresTXT.Size = new System.Drawing.Size(183, 35);
			this.btn_ExportarJugadoresTXT.TabIndex = 9;
			this.btn_ExportarJugadoresTXT.Text = "Jugadores TXT";
			this.btn_ExportarJugadoresTXT.UseVisualStyleBackColor = false;
			// 
			// btn_ExportarJugadoresXML
			// 
			this.btn_ExportarJugadoresXML.BackColor = System.Drawing.Color.Snow;
			this.btn_ExportarJugadoresXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_ExportarJugadoresXML.Location = new System.Drawing.Point(9, 81);
			this.btn_ExportarJugadoresXML.Name = "btn_ExportarJugadoresXML";
			this.btn_ExportarJugadoresXML.Size = new System.Drawing.Size(183, 35);
			this.btn_ExportarJugadoresXML.TabIndex = 7;
			this.btn_ExportarJugadoresXML.Text = "Jugadores XML";
			this.btn_ExportarJugadoresXML.UseVisualStyleBackColor = false;
			this.btn_ExportarJugadoresXML.Click += new System.EventHandler(this.btn_ExportarJugadoresXML_Click);
			// 
			// brn_Salir
			// 
			this.brn_Salir.BackColor = System.Drawing.Color.Snow;
			this.brn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.brn_Salir.Location = new System.Drawing.Point(747, 553);
			this.brn_Salir.Name = "brn_Salir";
			this.brn_Salir.Size = new System.Drawing.Size(114, 39);
			this.brn_Salir.TabIndex = 19;
			this.brn_Salir.Text = "Salir";
			this.brn_Salir.UseVisualStyleBackColor = false;
			this.brn_Salir.Click += new System.EventHandler(this.brn_Salir_Click);
			// 
			// grp_ImportarBaseDeDatos
			// 
			this.grp_ImportarBaseDeDatos.Controls.Add(this.btm_JugadoresSQL);
			this.grp_ImportarBaseDeDatos.Controls.Add(this.btn_ImportarPartidasXML);
			this.grp_ImportarBaseDeDatos.Controls.Add(this.btn_ImportarPartidasJSON);
			this.grp_ImportarBaseDeDatos.Controls.Add(this.btn_ImportarJugadoresXML);
			this.grp_ImportarBaseDeDatos.Controls.Add(this.btn_ImportarJugadoresJSON);
			this.grp_ImportarBaseDeDatos.Location = new System.Drawing.Point(230, 349);
			this.grp_ImportarBaseDeDatos.Name = "grp_ImportarBaseDeDatos";
			this.grp_ImportarBaseDeDatos.Size = new System.Drawing.Size(277, 389);
			this.grp_ImportarBaseDeDatos.TabIndex = 10;
			this.grp_ImportarBaseDeDatos.TabStop = false;
			this.grp_ImportarBaseDeDatos.Text = "Importar Datos:";
			// 
			// btm_JugadoresSQL
			// 
			this.btm_JugadoresSQL.BackColor = System.Drawing.Color.Snow;
			this.btm_JugadoresSQL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btm_JugadoresSQL.Location = new System.Drawing.Point(6, 204);
			this.btm_JugadoresSQL.Name = "btm_JugadoresSQL";
			this.btm_JugadoresSQL.Size = new System.Drawing.Size(265, 76);
			this.btm_JugadoresSQL.TabIndex = 18;
			this.btm_JugadoresSQL.Text = "Jugadores de la Base de Datos";
			this.btm_JugadoresSQL.UseVisualStyleBackColor = false;
			this.btm_JugadoresSQL.Click += new System.EventHandler(this.btm_JugadoresSQL_Click);
			// 
			// btn_ImportarPartidasXML
			// 
			this.btn_ImportarPartidasXML.BackColor = System.Drawing.Color.Snow;
			this.btn_ImportarPartidasXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_ImportarPartidasXML.Location = new System.Drawing.Point(6, 163);
			this.btn_ImportarPartidasXML.Name = "btn_ImportarPartidasXML";
			this.btn_ImportarPartidasXML.Size = new System.Drawing.Size(265, 35);
			this.btn_ImportarPartidasXML.TabIndex = 14;
			this.btn_ImportarPartidasXML.Text = "Partidas XML";
			this.btn_ImportarPartidasXML.UseVisualStyleBackColor = false;
			// 
			// btn_ImportarPartidasJSON
			// 
			this.btn_ImportarPartidasJSON.BackColor = System.Drawing.Color.Snow;
			this.btn_ImportarPartidasJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_ImportarPartidasJSON.Location = new System.Drawing.Point(6, 122);
			this.btn_ImportarPartidasJSON.Name = "btn_ImportarPartidasJSON";
			this.btn_ImportarPartidasJSON.Size = new System.Drawing.Size(265, 35);
			this.btn_ImportarPartidasJSON.TabIndex = 12;
			this.btn_ImportarPartidasJSON.Text = "Partidas JSON";
			this.btn_ImportarPartidasJSON.UseVisualStyleBackColor = false;
			// 
			// btn_ImportarJugadoresXML
			// 
			this.btn_ImportarJugadoresXML.BackColor = System.Drawing.Color.Snow;
			this.btn_ImportarJugadoresXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_ImportarJugadoresXML.Location = new System.Drawing.Point(6, 81);
			this.btn_ImportarJugadoresXML.Name = "btn_ImportarJugadoresXML";
			this.btn_ImportarJugadoresXML.Size = new System.Drawing.Size(265, 35);
			this.btn_ImportarJugadoresXML.TabIndex = 8;
			this.btn_ImportarJugadoresXML.Text = "Jugadores XML";
			this.btn_ImportarJugadoresXML.UseVisualStyleBackColor = false;
			this.btn_ImportarJugadoresXML.Click += new System.EventHandler(this.btn_ImportarJugadoresXML_Click);
			// 
			// btn_ImportarJugadoresJSON
			// 
			this.btn_ImportarJugadoresJSON.BackColor = System.Drawing.Color.Snow;
			this.btn_ImportarJugadoresJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_ImportarJugadoresJSON.Location = new System.Drawing.Point(6, 40);
			this.btn_ImportarJugadoresJSON.Name = "btn_ImportarJugadoresJSON";
			this.btn_ImportarJugadoresJSON.Size = new System.Drawing.Size(265, 35);
			this.btn_ImportarJugadoresJSON.TabIndex = 6;
			this.btn_ImportarJugadoresJSON.Text = "Jugadores JSON";
			this.btn_ImportarJugadoresJSON.UseVisualStyleBackColor = false;
			this.btn_ImportarJugadoresJSON.Click += new System.EventHandler(this.btn_ImportarJugadoresJSON_Click);
			// 
			// btn_NuevoJugador
			// 
			this.btn_NuevoJugador.BackColor = System.Drawing.Color.Snow;
			this.btn_NuevoJugador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_NuevoJugador.Location = new System.Drawing.Point(513, 553);
			this.btn_NuevoJugador.Name = "btn_NuevoJugador";
			this.btn_NuevoJugador.Size = new System.Drawing.Size(228, 39);
			this.btn_NuevoJugador.TabIndex = 4;
			this.btn_NuevoJugador.Text = "Nuevo Jugador";
			this.btn_NuevoJugador.UseVisualStyleBackColor = false;
			this.btn_NuevoJugador.Click += new System.EventHandler(this.btn_NuevoJugador_Click);
			// 
			// FrmPantallaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSalmon;
			this.ClientSize = new System.Drawing.Size(888, 736);
			this.Controls.Add(this.btn_NuevoJugador);
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
		private Button btn_CerrarMesa;
		private Label lbl_JugadorDos;
		private Label lbl_JugadorUno;
		private Label lbl_Titulo;
		private Button btn_ExportarJugadoresJSON;
		private GroupBox grp_ExportarDatos;
		private Button button3;
		private Button button2;
		private Button btn_ExportarPartidasJSON;
		private Button btn_ExportarJugadoresTXT;
		private Button btn_ExportarJugadoresXML;
		private Button brn_Salir;
		private GroupBox grp_ImportarBaseDeDatos;
		private Button btm_JugadoresSQL;
		private Button btn_ImportarJugadoresJSON;
		private Button btn_ImportarJugadoresXML;
		private Button btn_ImportarPartidasXML;
		private Button btn_ImportarPartidasJSON;
		private Button btn_NuevoJugador;
	}
}