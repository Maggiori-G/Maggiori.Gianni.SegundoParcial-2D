namespace Vista {
	partial class FrmNuevoUsuario {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoUsuario));
			this.grp_Datos = new System.Windows.Forms.GroupBox();
			this.btn_Cancelar = new System.Windows.Forms.Button();
			this.btn_Registrarse = new System.Windows.Forms.Button();
			this.lbl_Email = new System.Windows.Forms.Label();
			this.txt_Email = new System.Windows.Forms.TextBox();
			this.txt_NombreUsuario = new System.Windows.Forms.TextBox();
			this.lbl_ConfirmarContraseña = new System.Windows.Forms.Label();
			this.txt_Contraseña = new System.Windows.Forms.TextBox();
			this.lbl_Contraseña = new System.Windows.Forms.Label();
			this.txt_Nombre = new System.Windows.Forms.TextBox();
			this.txt_ConfirmarContraseña = new System.Windows.Forms.TextBox();
			this.lbl_NombreUsuario = new System.Windows.Forms.Label();
			this.lbl_Nombre = new System.Windows.Forms.Label();
			this.lbl_Titulo = new System.Windows.Forms.Label();
			this.grp_Datos.SuspendLayout();
			this.SuspendLayout();
			// 
			// grp_Datos
			// 
			this.grp_Datos.Controls.Add(this.btn_Cancelar);
			this.grp_Datos.Controls.Add(this.btn_Registrarse);
			this.grp_Datos.Controls.Add(this.lbl_Email);
			this.grp_Datos.Controls.Add(this.txt_Email);
			this.grp_Datos.Controls.Add(this.txt_NombreUsuario);
			this.grp_Datos.Controls.Add(this.lbl_ConfirmarContraseña);
			this.grp_Datos.Controls.Add(this.txt_Contraseña);
			this.grp_Datos.Controls.Add(this.lbl_Contraseña);
			this.grp_Datos.Controls.Add(this.txt_Nombre);
			this.grp_Datos.Controls.Add(this.txt_ConfirmarContraseña);
			this.grp_Datos.Controls.Add(this.lbl_NombreUsuario);
			this.grp_Datos.Controls.Add(this.lbl_Nombre);
			this.grp_Datos.Location = new System.Drawing.Point(12, 86);
			this.grp_Datos.Name = "grp_Datos";
			this.grp_Datos.Size = new System.Drawing.Size(490, 320);
			this.grp_Datos.TabIndex = 0;
			this.grp_Datos.TabStop = false;
			this.grp_Datos.Text = "Registrate";
			// 
			// btn_Cancelar
			// 
			this.btn_Cancelar.BackColor = System.Drawing.Color.Snow;
			this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Cancelar.Location = new System.Drawing.Point(249, 252);
			this.btn_Cancelar.Name = "btn_Cancelar";
			this.btn_Cancelar.Size = new System.Drawing.Size(140, 36);
			this.btn_Cancelar.TabIndex = 9;
			this.btn_Cancelar.Text = "Cancelar";
			this.btn_Cancelar.UseVisualStyleBackColor = false;
			this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
			// 
			// btn_Registrarse
			// 
			this.btn_Registrarse.BackColor = System.Drawing.Color.Snow;
			this.btn_Registrarse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Registrarse.Location = new System.Drawing.Point(103, 252);
			this.btn_Registrarse.Name = "btn_Registrarse";
			this.btn_Registrarse.Size = new System.Drawing.Size(140, 36);
			this.btn_Registrarse.TabIndex = 8;
			this.btn_Registrarse.Text = "Registrarme!";
			this.btn_Registrarse.UseVisualStyleBackColor = false;
			this.btn_Registrarse.Click += new System.EventHandler(this.btn_Registrarse_Click);
			// 
			// lbl_Email
			// 
			this.lbl_Email.AutoSize = true;
			this.lbl_Email.Location = new System.Drawing.Point(38, 204);
			this.lbl_Email.Name = "lbl_Email";
			this.lbl_Email.Size = new System.Drawing.Size(56, 22);
			this.lbl_Email.TabIndex = 7;
			this.lbl_Email.Text = "Email";
			// 
			// txt_Email
			// 
			this.txt_Email.Location = new System.Drawing.Point(255, 201);
			this.txt_Email.Name = "txt_Email";
			this.txt_Email.Size = new System.Drawing.Size(185, 30);
			this.txt_Email.TabIndex = 4;
			// 
			// txt_NombreUsuario
			// 
			this.txt_NombreUsuario.Location = new System.Drawing.Point(255, 92);
			this.txt_NombreUsuario.Name = "txt_NombreUsuario";
			this.txt_NombreUsuario.Size = new System.Drawing.Size(185, 30);
			this.txt_NombreUsuario.TabIndex = 1;
			// 
			// lbl_ConfirmarContraseña
			// 
			this.lbl_ConfirmarContraseña.AutoSize = true;
			this.lbl_ConfirmarContraseña.Location = new System.Drawing.Point(38, 167);
			this.lbl_ConfirmarContraseña.Name = "lbl_ConfirmarContraseña";
			this.lbl_ConfirmarContraseña.Size = new System.Drawing.Size(214, 22);
			this.lbl_ConfirmarContraseña.TabIndex = 2;
			this.lbl_ConfirmarContraseña.Text = "Confirmar Contraseña";
			// 
			// txt_Contraseña
			// 
			this.txt_Contraseña.Location = new System.Drawing.Point(255, 128);
			this.txt_Contraseña.Name = "txt_Contraseña";
			this.txt_Contraseña.PasswordChar = '*';
			this.txt_Contraseña.Size = new System.Drawing.Size(185, 30);
			this.txt_Contraseña.TabIndex = 2;
			// 
			// lbl_Contraseña
			// 
			this.lbl_Contraseña.AutoSize = true;
			this.lbl_Contraseña.Location = new System.Drawing.Point(38, 131);
			this.lbl_Contraseña.Name = "lbl_Contraseña";
			this.lbl_Contraseña.Size = new System.Drawing.Size(119, 22);
			this.lbl_Contraseña.TabIndex = 2;
			this.lbl_Contraseña.Text = "Contraseña";
			// 
			// txt_Nombre
			// 
			this.txt_Nombre.Location = new System.Drawing.Point(255, 56);
			this.txt_Nombre.Name = "txt_Nombre";
			this.txt_Nombre.Size = new System.Drawing.Size(185, 30);
			this.txt_Nombre.TabIndex = 0;
			// 
			// txt_ConfirmarContraseña
			// 
			this.txt_ConfirmarContraseña.Location = new System.Drawing.Point(255, 164);
			this.txt_ConfirmarContraseña.Name = "txt_ConfirmarContraseña";
			this.txt_ConfirmarContraseña.PasswordChar = '*';
			this.txt_ConfirmarContraseña.Size = new System.Drawing.Size(185, 30);
			this.txt_ConfirmarContraseña.TabIndex = 3;
			// 
			// lbl_NombreUsuario
			// 
			this.lbl_NombreUsuario.AutoSize = true;
			this.lbl_NombreUsuario.Location = new System.Drawing.Point(38, 95);
			this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
			this.lbl_NombreUsuario.Size = new System.Drawing.Size(184, 22);
			this.lbl_NombreUsuario.TabIndex = 1;
			this.lbl_NombreUsuario.Text = "Nombre de Usuario";
			// 
			// lbl_Nombre
			// 
			this.lbl_Nombre.AutoSize = true;
			this.lbl_Nombre.Location = new System.Drawing.Point(38, 59);
			this.lbl_Nombre.Name = "lbl_Nombre";
			this.lbl_Nombre.Size = new System.Drawing.Size(185, 22);
			this.lbl_Nombre.TabIndex = 0;
			this.lbl_Nombre.Text = "Nombre Completo:";
			// 
			// lbl_Titulo
			// 
			this.lbl_Titulo.AutoSize = true;
			this.lbl_Titulo.Font = new System.Drawing.Font("Jokerman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_Titulo.Location = new System.Drawing.Point(115, 31);
			this.lbl_Titulo.Name = "lbl_Titulo";
			this.lbl_Titulo.Size = new System.Drawing.Size(277, 43);
			this.lbl_Titulo.TabIndex = 2;
			this.lbl_Titulo.Text = "La Generala Fruta";
			// 
			// FrmNuevoUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSalmon;
			this.ClientSize = new System.Drawing.Size(516, 421);
			this.Controls.Add(this.lbl_Titulo);
			this.Controls.Add(this.grp_Datos);
			this.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.MaximizeBox = false;
			this.Name = "FrmNuevoUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Formulario de Registro";
			this.grp_Datos.ResumeLayout(false);
			this.grp_Datos.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GroupBox grp_Datos;
		private Label lbl_NombreUsuario;
		private Label lbl_Nombre;
		private Label lbl_ConfirmarContraseña;
		private Label lbl_Contraseña;
		private TextBox txt_NombreUsuario;
		private TextBox txt_Contraseña;
		private TextBox txt_Nombre;
		private TextBox txt_ConfirmarContraseña;
		private Label lbl_Email;
		private TextBox txt_Email;
		private Button btn_Cancelar;
		private Button btn_Registrarse;
		private Label lbl_Titulo;
	}
}