namespace Vista {
	partial class FrmNuevoJugador {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoJugador));
			this.grp_NuevoUsuario = new System.Windows.Forms.GroupBox();
			this.btn_Aceptar = new System.Windows.Forms.Button();
			this.btn_Cancelar = new System.Windows.Forms.Button();
			this.txt_NuevoJugador = new System.Windows.Forms.TextBox();
			this.lbl_Nombre = new System.Windows.Forms.Label();
			this.grp_NuevoUsuario.SuspendLayout();
			this.SuspendLayout();
			// 
			// grp_NuevoUsuario
			// 
			this.grp_NuevoUsuario.Controls.Add(this.btn_Aceptar);
			this.grp_NuevoUsuario.Controls.Add(this.btn_Cancelar);
			this.grp_NuevoUsuario.Controls.Add(this.txt_NuevoJugador);
			this.grp_NuevoUsuario.Controls.Add(this.lbl_Nombre);
			this.grp_NuevoUsuario.Location = new System.Drawing.Point(12, 12);
			this.grp_NuevoUsuario.Name = "grp_NuevoUsuario";
			this.grp_NuevoUsuario.Size = new System.Drawing.Size(327, 160);
			this.grp_NuevoUsuario.TabIndex = 0;
			this.grp_NuevoUsuario.TabStop = false;
			this.grp_NuevoUsuario.Text = "Nuevo Usuario";
			// 
			// btn_Aceptar
			// 
			this.btn_Aceptar.Location = new System.Drawing.Point(31, 102);
			this.btn_Aceptar.Name = "btn_Aceptar";
			this.btn_Aceptar.Size = new System.Drawing.Size(119, 40);
			this.btn_Aceptar.TabIndex = 1;
			this.btn_Aceptar.Text = "Aceptar";
			this.btn_Aceptar.UseVisualStyleBackColor = true;
			this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
			// 
			// btn_Cancelar
			// 
			this.btn_Cancelar.Location = new System.Drawing.Point(156, 102);
			this.btn_Cancelar.Name = "btn_Cancelar";
			this.btn_Cancelar.Size = new System.Drawing.Size(119, 40);
			this.btn_Cancelar.TabIndex = 2;
			this.btn_Cancelar.Text = "Cancelar";
			this.btn_Cancelar.UseVisualStyleBackColor = true;
			this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
			// 
			// txt_NuevoJugador
			// 
			this.txt_NuevoJugador.Location = new System.Drawing.Point(101, 51);
			this.txt_NuevoJugador.Name = "txt_NuevoJugador";
			this.txt_NuevoJugador.Size = new System.Drawing.Size(200, 31);
			this.txt_NuevoJugador.TabIndex = 0;
			// 
			// lbl_Nombre
			// 
			this.lbl_Nombre.AutoSize = true;
			this.lbl_Nombre.Location = new System.Drawing.Point(6, 54);
			this.lbl_Nombre.Name = "lbl_Nombre";
			this.lbl_Nombre.Size = new System.Drawing.Size(89, 22);
			this.lbl_Nombre.TabIndex = 0;
			this.lbl_Nombre.Text = "Nombre:";
			// 
			// FrmNuevoJugador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSalmon;
			this.ClientSize = new System.Drawing.Size(353, 186);
			this.Controls.Add(this.grp_NuevoUsuario);
			this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.MaximizeBox = false;
			this.Name = "FrmNuevoJugador";
			this.Text = "Nuevo Jugador";
			this.grp_NuevoUsuario.ResumeLayout(false);
			this.grp_NuevoUsuario.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox grp_NuevoUsuario;
		private Button btn_Aceptar;
		private Button btn_Cancelar;
		private TextBox txt_NuevoJugador;
		private Label lbl_Nombre;
	}
}