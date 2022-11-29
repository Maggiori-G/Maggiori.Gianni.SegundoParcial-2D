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
			this.dgw_RankingJugadores = new System.Windows.Forms.DataGridView();
			this.lbl_ListaJugadores = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgw_RankingJugadores)).BeginInit();
			this.SuspendLayout();
			// 
			// dgw_RankingJugadores
			// 
			this.dgw_RankingJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_RankingJugadores.Location = new System.Drawing.Point(115, 71);
			this.dgw_RankingJugadores.Name = "dgw_RankingJugadores";
			this.dgw_RankingJugadores.RowTemplate.Height = 25;
			this.dgw_RankingJugadores.Size = new System.Drawing.Size(284, 367);
			this.dgw_RankingJugadores.TabIndex = 0;
			// 
			// lbl_ListaJugadores
			// 
			this.lbl_ListaJugadores.AutoSize = true;
			this.lbl_ListaJugadores.Location = new System.Drawing.Point(119, 28);
			this.lbl_ListaJugadores.Name = "lbl_ListaJugadores";
			this.lbl_ListaJugadores.Size = new System.Drawing.Size(114, 15);
			this.lbl_ListaJugadores.TabIndex = 1;
			this.lbl_ListaJugadores.Text = "Ranking de Victorias";
			// 
			// FrmRankingVictorias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 498);
			this.Controls.Add(this.lbl_ListaJugadores);
			this.Controls.Add(this.dgw_RankingJugadores);
			this.Name = "FrmRankingVictorias";
			this.Text = "FrmRankingVictorias";
			this.Load += new System.EventHandler(this.FrmRankingVictorias_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgw_RankingJugadores)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dgw_RankingJugadores;
		private Label lbl_ListaJugadores;
	}
}