﻿namespace Vista {
	partial class FrmMesa {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMesa));
			this.grp_JugadorUno = new System.Windows.Forms.GroupBox();
			this.lbl_Puntos1 = new System.Windows.Forms.Label();
			this.grp_Tiradas1 = new System.Windows.Forms.GroupBox();
			this.grp_J1 = new System.Windows.Forms.GroupBox();
			this.dgw_JugadasJugadorUno = new System.Windows.Forms.DataGridView();
			this.grp_T2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.grp_Tiradas2 = new System.Windows.Forms.GroupBox();
			this.grp_J2 = new System.Windows.Forms.GroupBox();
			this.dgw_JugadasJugadorDos = new System.Windows.Forms.DataGridView();
			this.lbl_Vs = new System.Windows.Forms.Label();
			this.lbl_PuntosJugadorUno = new System.Windows.Forms.Label();
			this.lbl_PuntosJugadorDos = new System.Windows.Forms.Label();
			this.rtb_RegistroJugadorUno = new System.Windows.Forms.RichTextBox();
			this.rtb_RegistroJugadorDos = new System.Windows.Forms.RichTextBox();
			this.lbl_QuienGano = new System.Windows.Forms.Label();
			this.lbl_Ganador = new System.Windows.Forms.Label();
			this.grp_JugadorUno.SuspendLayout();
			this.grp_Tiradas1.SuspendLayout();
			this.grp_J1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_JugadasJugadorUno)).BeginInit();
			this.grp_T2.SuspendLayout();
			this.grp_Tiradas2.SuspendLayout();
			this.grp_J2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_JugadasJugadorDos)).BeginInit();
			this.SuspendLayout();
			// 
			// grp_JugadorUno
			// 
			this.grp_JugadorUno.Controls.Add(this.lbl_PuntosJugadorUno);
			this.grp_JugadorUno.Controls.Add(this.lbl_Puntos1);
			this.grp_JugadorUno.Controls.Add(this.grp_Tiradas1);
			this.grp_JugadorUno.Controls.Add(this.grp_J1);
			this.grp_JugadorUno.Location = new System.Drawing.Point(12, 12);
			this.grp_JugadorUno.Name = "grp_JugadorUno";
			this.grp_JugadorUno.Size = new System.Drawing.Size(428, 418);
			this.grp_JugadorUno.TabIndex = 4;
			this.grp_JugadorUno.TabStop = false;
			this.grp_JugadorUno.Text = "Jugador Uno:  ";
			// 
			// lbl_Puntos1
			// 
			this.lbl_Puntos1.AutoSize = true;
			this.lbl_Puntos1.Location = new System.Drawing.Point(6, 375);
			this.lbl_Puntos1.Name = "lbl_Puntos1";
			this.lbl_Puntos1.Size = new System.Drawing.Size(200, 22);
			this.lbl_Puntos1.TabIndex = 2;
			this.lbl_Puntos1.Text = "Puntos Jugador Uno:";
			// 
			// grp_Tiradas1
			// 
			this.grp_Tiradas1.Controls.Add(this.rtb_RegistroJugadorUno);
			this.grp_Tiradas1.Location = new System.Drawing.Point(212, 48);
			this.grp_Tiradas1.Name = "grp_Tiradas1";
			this.grp_Tiradas1.Size = new System.Drawing.Size(210, 293);
			this.grp_Tiradas1.TabIndex = 1;
			this.grp_Tiradas1.TabStop = false;
			this.grp_Tiradas1.Text = "Tiradas:";
			// 
			// grp_J1
			// 
			this.grp_J1.Controls.Add(this.dgw_JugadasJugadorUno);
			this.grp_J1.Location = new System.Drawing.Point(6, 48);
			this.grp_J1.Name = "grp_J1";
			this.grp_J1.Size = new System.Drawing.Size(200, 293);
			this.grp_J1.TabIndex = 0;
			this.grp_J1.TabStop = false;
			this.grp_J1.Text = "Jugadas:";
			// 
			// dgw_JugadasJugadorUno
			// 
			this.dgw_JugadasJugadorUno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgw_JugadasJugadorUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_JugadasJugadorUno.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgw_JugadasJugadorUno.Location = new System.Drawing.Point(3, 27);
			this.dgw_JugadasJugadorUno.Name = "dgw_JugadasJugadorUno";
			this.dgw_JugadasJugadorUno.RowTemplate.Height = 25;
			this.dgw_JugadasJugadorUno.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgw_JugadasJugadorUno.Size = new System.Drawing.Size(194, 263);
			this.dgw_JugadasJugadorUno.TabIndex = 0;
			// 
			// grp_T2
			// 
			this.grp_T2.Controls.Add(this.lbl_PuntosJugadorDos);
			this.grp_T2.Controls.Add(this.label1);
			this.grp_T2.Controls.Add(this.grp_Tiradas2);
			this.grp_T2.Controls.Add(this.grp_J2);
			this.grp_T2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.grp_T2.Location = new System.Drawing.Point(634, 12);
			this.grp_T2.Name = "grp_T2";
			this.grp_T2.Size = new System.Drawing.Size(428, 418);
			this.grp_T2.TabIndex = 5;
			this.grp_T2.TabStop = false;
			this.grp_T2.Text = "Jugador Dos:  ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 375);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 22);
			this.label1.TabIndex = 3;
			this.label1.Text = "Puntos Jugador Uno:";
			// 
			// grp_Tiradas2
			// 
			this.grp_Tiradas2.Controls.Add(this.rtb_RegistroJugadorDos);
			this.grp_Tiradas2.Location = new System.Drawing.Point(212, 48);
			this.grp_Tiradas2.Name = "grp_Tiradas2";
			this.grp_Tiradas2.Size = new System.Drawing.Size(210, 293);
			this.grp_Tiradas2.TabIndex = 2;
			this.grp_Tiradas2.TabStop = false;
			this.grp_Tiradas2.Text = "Tiradas:";
			// 
			// grp_J2
			// 
			this.grp_J2.Controls.Add(this.dgw_JugadasJugadorDos);
			this.grp_J2.Location = new System.Drawing.Point(6, 48);
			this.grp_J2.Name = "grp_J2";
			this.grp_J2.Size = new System.Drawing.Size(200, 293);
			this.grp_J2.TabIndex = 1;
			this.grp_J2.TabStop = false;
			this.grp_J2.Text = "Jugadas:";
			// 
			// dgw_JugadasJugadorDos
			// 
			this.dgw_JugadasJugadorDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_JugadasJugadorDos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgw_JugadasJugadorDos.Location = new System.Drawing.Point(3, 27);
			this.dgw_JugadasJugadorDos.Name = "dgw_JugadasJugadorDos";
			this.dgw_JugadasJugadorDos.RowTemplate.Height = 25;
			this.dgw_JugadasJugadorDos.Size = new System.Drawing.Size(194, 263);
			this.dgw_JugadasJugadorDos.TabIndex = 0;
			// 
			// lbl_Vs
			// 
			this.lbl_Vs.AutoSize = true;
			this.lbl_Vs.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_Vs.Location = new System.Drawing.Point(467, 158);
			this.lbl_Vs.Name = "lbl_Vs";
			this.lbl_Vs.Size = new System.Drawing.Size(138, 82);
			this.lbl_Vs.TabIndex = 6;
			this.lbl_Vs.Text = "VS";
			// 
			// lbl_PuntosJugadorUno
			// 
			this.lbl_PuntosJugadorUno.AutoSize = true;
			this.lbl_PuntosJugadorUno.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_PuntosJugadorUno.Location = new System.Drawing.Point(212, 375);
			this.lbl_PuntosJugadorUno.Name = "lbl_PuntosJugadorUno";
			this.lbl_PuntosJugadorUno.Size = new System.Drawing.Size(96, 23);
			this.lbl_PuntosJugadorUno.TabIndex = 3;
			this.lbl_PuntosJugadorUno.Text = "Puntos P1";
			// 
			// lbl_PuntosJugadorDos
			// 
			this.lbl_PuntosJugadorDos.AutoSize = true;
			this.lbl_PuntosJugadorDos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_PuntosJugadorDos.Location = new System.Drawing.Point(212, 375);
			this.lbl_PuntosJugadorDos.Name = "lbl_PuntosJugadorDos";
			this.lbl_PuntosJugadorDos.Size = new System.Drawing.Size(96, 23);
			this.lbl_PuntosJugadorDos.TabIndex = 4;
			this.lbl_PuntosJugadorDos.Text = "Puntos P2";
			// 
			// rtb_RegistroJugadorUno
			// 
			this.rtb_RegistroJugadorUno.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtb_RegistroJugadorUno.Location = new System.Drawing.Point(3, 27);
			this.rtb_RegistroJugadorUno.Name = "rtb_RegistroJugadorUno";
			this.rtb_RegistroJugadorUno.Size = new System.Drawing.Size(204, 263);
			this.rtb_RegistroJugadorUno.TabIndex = 0;
			this.rtb_RegistroJugadorUno.Text = "";
			// 
			// rtb_RegistroJugadorDos
			// 
			this.rtb_RegistroJugadorDos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtb_RegistroJugadorDos.Location = new System.Drawing.Point(3, 27);
			this.rtb_RegistroJugadorDos.Name = "rtb_RegistroJugadorDos";
			this.rtb_RegistroJugadorDos.Size = new System.Drawing.Size(204, 263);
			this.rtb_RegistroJugadorDos.TabIndex = 0;
			this.rtb_RegistroJugadorDos.Text = "";
			// 
			// lbl_QuienGano
			// 
			this.lbl_QuienGano.AutoSize = true;
			this.lbl_QuienGano.Font = new System.Drawing.Font("Snap ITC", 42.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_QuienGano.Location = new System.Drawing.Point(12, 463);
			this.lbl_QuienGano.Name = "lbl_QuienGano";
			this.lbl_QuienGano.Size = new System.Drawing.Size(317, 74);
			this.lbl_QuienGano.TabIndex = 7;
			this.lbl_QuienGano.Text = "Ganador:";
			// 
			// lbl_Ganador
			// 
			this.lbl_Ganador.AutoSize = true;
			this.lbl_Ganador.Font = new System.Drawing.Font("Snap ITC", 42.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_Ganador.Location = new System.Drawing.Point(335, 463);
			this.lbl_Ganador.Name = "lbl_Ganador";
			this.lbl_Ganador.Size = new System.Drawing.Size(704, 74);
			this.lbl_Ganador.TabIndex = 8;
			this.lbl_Ganador.Text = "And The Winner Is...";
			// 
			// FrmMesa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSalmon;
			this.ClientSize = new System.Drawing.Size(1074, 551);
			this.Controls.Add(this.lbl_Ganador);
			this.Controls.Add(this.lbl_QuienGano);
			this.Controls.Add(this.lbl_Vs);
			this.Controls.Add(this.grp_T2);
			this.Controls.Add(this.grp_JugadorUno);
			this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "FrmMesa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Mesa de Juegos";
			this.grp_JugadorUno.ResumeLayout(false);
			this.grp_JugadorUno.PerformLayout();
			this.grp_Tiradas1.ResumeLayout(false);
			this.grp_J1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgw_JugadasJugadorUno)).EndInit();
			this.grp_T2.ResumeLayout(false);
			this.grp_T2.PerformLayout();
			this.grp_Tiradas2.ResumeLayout(false);
			this.grp_J2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgw_JugadasJugadorDos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private GroupBox grp_JugadorUno;
		private GroupBox grp_T2;
		private Label lbl_Vs;
		private GroupBox grp_Tiradas1;
		private GroupBox grp_J1;
		private DataGridView dgw_JugadasJugadorUno;
		private GroupBox grp_Tiradas2;
		private GroupBox grp_J2;
		private DataGridView dgw_JugadasJugadorDos;
		private Label lbl_Puntos1;
		private Label label1;
		private Label lbl_PuntosJugadorUno;
		private RichTextBox rtb_RegistroJugadorUno;
		private Label lbl_PuntosJugadorDos;
		private RichTextBox rtb_RegistroJugadorDos;
		private Label lbl_QuienGano;
		private Label lbl_Ganador;
	}
}