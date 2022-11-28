namespace Vista {
	partial class FrmLogin {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
			this.grb_IngresarDatos = new System.Windows.Forms.GroupBox();
			this.btn_Autocompletar = new System.Windows.Forms.Button();
			this.txt_Contraseña = new System.Windows.Forms.TextBox();
			this.txt_NombreUsuario = new System.Windows.Forms.TextBox();
			this.lbl_NombreUsuario = new System.Windows.Forms.Label();
			this.lbl_Contraseña = new System.Windows.Forms.Label();
			this.btn_Ingresar = new System.Windows.Forms.Button();
			this.btn_NuevoUsuario = new System.Windows.Forms.Button();
			this.btn_Salir = new System.Windows.Forms.Button();
			this.lbl_Titulo = new System.Windows.Forms.Label();
			this.grb_IngresarDatos.SuspendLayout();
			this.SuspendLayout();
			// 
			// grb_IngresarDatos
			// 
			this.grb_IngresarDatos.Controls.Add(this.btn_Autocompletar);
			this.grb_IngresarDatos.Controls.Add(this.txt_Contraseña);
			this.grb_IngresarDatos.Controls.Add(this.txt_NombreUsuario);
			this.grb_IngresarDatos.Controls.Add(this.lbl_NombreUsuario);
			this.grb_IngresarDatos.Controls.Add(this.lbl_Contraseña);
			this.grb_IngresarDatos.Controls.Add(this.btn_Ingresar);
			this.grb_IngresarDatos.Location = new System.Drawing.Point(34, 101);
			this.grb_IngresarDatos.Name = "grb_IngresarDatos";
			this.grb_IngresarDatos.Size = new System.Drawing.Size(339, 188);
			this.grb_IngresarDatos.TabIndex = 0;
			this.grb_IngresarDatos.TabStop = false;
			this.grb_IngresarDatos.Text = "Ingrese:";
			// 
			// btn_Autocompletar
			// 
			this.btn_Autocompletar.BackColor = System.Drawing.Color.Snow;
			this.btn_Autocompletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Autocompletar.Location = new System.Drawing.Point(160, 139);
			this.btn_Autocompletar.Name = "btn_Autocompletar";
			this.btn_Autocompletar.Size = new System.Drawing.Size(163, 32);
			this.btn_Autocompletar.TabIndex = 3;
			this.btn_Autocompletar.Text = "Acceso Rapido";
			this.btn_Autocompletar.UseVisualStyleBackColor = false;
			this.btn_Autocompletar.Click += new System.EventHandler(this.btn_Autocompletar_Click);
			// 
			// txt_Contraseña
			// 
			this.txt_Contraseña.Location = new System.Drawing.Point(144, 84);
			this.txt_Contraseña.Name = "txt_Contraseña";
			this.txt_Contraseña.PasswordChar = '*';
			this.txt_Contraseña.Size = new System.Drawing.Size(180, 31);
			this.txt_Contraseña.TabIndex = 1;
			// 
			// txt_NombreUsuario
			// 
			this.txt_NombreUsuario.Location = new System.Drawing.Point(144, 39);
			this.txt_NombreUsuario.Name = "txt_NombreUsuario";
			this.txt_NombreUsuario.Size = new System.Drawing.Size(180, 31);
			this.txt_NombreUsuario.TabIndex = 0;
			// 
			// lbl_NombreUsuario
			// 
			this.lbl_NombreUsuario.AutoSize = true;
			this.lbl_NombreUsuario.Location = new System.Drawing.Point(17, 42);
			this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
			this.lbl_NombreUsuario.Size = new System.Drawing.Size(75, 22);
			this.lbl_NombreUsuario.TabIndex = 2;
			this.lbl_NombreUsuario.Text = "Usuario";
			// 
			// lbl_Contraseña
			// 
			this.lbl_Contraseña.AutoSize = true;
			this.lbl_Contraseña.Location = new System.Drawing.Point(15, 87);
			this.lbl_Contraseña.Name = "lbl_Contraseña";
			this.lbl_Contraseña.Size = new System.Drawing.Size(119, 22);
			this.lbl_Contraseña.TabIndex = 1;
			this.lbl_Contraseña.Text = "Contraseña";
			// 
			// btn_Ingresar
			// 
			this.btn_Ingresar.BackColor = System.Drawing.Color.Snow;
			this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Ingresar.Location = new System.Drawing.Point(17, 139);
			this.btn_Ingresar.Name = "btn_Ingresar";
			this.btn_Ingresar.Size = new System.Drawing.Size(137, 32);
			this.btn_Ingresar.TabIndex = 2;
			this.btn_Ingresar.Text = "Ingresar";
			this.btn_Ingresar.UseVisualStyleBackColor = false;
			this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
			// 
			// btn_NuevoUsuario
			// 
			this.btn_NuevoUsuario.BackColor = System.Drawing.Color.Snow;
			this.btn_NuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_NuevoUsuario.Location = new System.Drawing.Point(169, 295);
			this.btn_NuevoUsuario.Name = "btn_NuevoUsuario";
			this.btn_NuevoUsuario.Size = new System.Drawing.Size(123, 32);
			this.btn_NuevoUsuario.TabIndex = 4;
			this.btn_NuevoUsuario.Text = "Registrarse";
			this.btn_NuevoUsuario.UseVisualStyleBackColor = false;
			this.btn_NuevoUsuario.Click += new System.EventHandler(this.btn_NuevoUsuario_Click);
			// 
			// btn_Salir
			// 
			this.btn_Salir.BackColor = System.Drawing.Color.Snow;
			this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Salir.Location = new System.Drawing.Point(298, 295);
			this.btn_Salir.Name = "btn_Salir";
			this.btn_Salir.Size = new System.Drawing.Size(75, 32);
			this.btn_Salir.TabIndex = 5;
			this.btn_Salir.Text = "Salir";
			this.btn_Salir.UseVisualStyleBackColor = false;
			this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
			// 
			// lbl_Titulo
			// 
			this.lbl_Titulo.AutoSize = true;
			this.lbl_Titulo.Font = new System.Drawing.Font("Jokerman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_Titulo.Location = new System.Drawing.Point(62, 35);
			this.lbl_Titulo.Name = "lbl_Titulo";
			this.lbl_Titulo.Size = new System.Drawing.Size(277, 43);
			this.lbl_Titulo.TabIndex = 1;
			this.lbl_Titulo.Text = "La Generala Fruta";
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSalmon;
			this.ClientSize = new System.Drawing.Size(410, 341);
			this.Controls.Add(this.lbl_Titulo);
			this.Controls.Add(this.grb_IngresarDatos);
			this.Controls.Add(this.btn_NuevoUsuario);
			this.Controls.Add(this.btn_Salir);
			this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.MaximizeBox = false;
			this.Name = "FrmLogin";
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login - La Generala Fruta";
			this.Load += new System.EventHandler(this.FrmLogin_Load);
			this.grb_IngresarDatos.ResumeLayout(false);
			this.grb_IngresarDatos.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GroupBox grb_IngresarDatos;
		private TextBox txt_Contraseña;
		private Button btn_NuevoUsuario;
		private TextBox txt_NombreUsuario;
		private Button btn_Salir;
		private Label lbl_NombreUsuario;
		private Label lbl_Contraseña;
		private Button btn_Ingresar;
		private Label lbl_Titulo;
		private Button btn_Autocompletar;
	}
}