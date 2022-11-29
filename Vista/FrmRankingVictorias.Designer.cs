namespace Vista {
	partial class FrmRankingVictorias {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRankingVictorias));
			this.dgw_RankingJugadores = new System.Windows.Forms.DataGridView();
			this.lbl_ListaJugadores = new System.Windows.Forms.Label();
			this.btn_Salir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgw_RankingJugadores)).BeginInit();
			this.SuspendLayout();
			// 
			// dgw_RankingJugadores
			// 
			this.dgw_RankingJugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgw_RankingJugadores.BackgroundColor = System.Drawing.Color.LightSalmon;
			this.dgw_RankingJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_RankingJugadores.Location = new System.Drawing.Point(14, 55);
			this.dgw_RankingJugadores.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.dgw_RankingJugadores.MultiSelect = false;
			this.dgw_RankingJugadores.Name = "dgw_RankingJugadores";
			this.dgw_RankingJugadores.ReadOnly = true;
			this.dgw_RankingJugadores.RowHeadersVisible = false;
			this.dgw_RankingJugadores.RowTemplate.Height = 25;
			this.dgw_RankingJugadores.Size = new System.Drawing.Size(451, 538);
			this.dgw_RankingJugadores.TabIndex = 0;
			// 
			// lbl_ListaJugadores
			// 
			this.lbl_ListaJugadores.AutoSize = true;
			this.lbl_ListaJugadores.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_ListaJugadores.Location = new System.Drawing.Point(14, 9);
			this.lbl_ListaJugadores.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_ListaJugadores.Name = "lbl_ListaJugadores";
			this.lbl_ListaJugadores.Size = new System.Drawing.Size(304, 36);
			this.lbl_ListaJugadores.TabIndex = 1;
			this.lbl_ListaJugadores.Text = "Ranking de Victorias";
			// 
			// btn_Salir
			// 
			this.btn_Salir.BackColor = System.Drawing.Color.RosyBrown;
			this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Salir.Location = new System.Drawing.Point(336, 15);
			this.btn_Salir.Name = "btn_Salir";
			this.btn_Salir.Size = new System.Drawing.Size(129, 35);
			this.btn_Salir.TabIndex = 2;
			this.btn_Salir.Text = "Salir";
			this.btn_Salir.UseVisualStyleBackColor = false;
			this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
			// 
			// FrmRankingVictorias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSalmon;
			this.ClientSize = new System.Drawing.Size(479, 607);
			this.Controls.Add(this.btn_Salir);
			this.Controls.Add(this.lbl_ListaJugadores);
			this.Controls.Add(this.dgw_RankingJugadores);
			this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "FrmRankingVictorias";
			this.Text = "Ranking de Victorias en la Generala Fruta";
			this.Load += new System.EventHandler(this.FrmRankingVictorias_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgw_RankingJugadores)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dgw_RankingJugadores;
		private Label lbl_ListaJugadores;
		private Button btn_Salir;
	}
}