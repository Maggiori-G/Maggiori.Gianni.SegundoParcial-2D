using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista {
	public partial class FrmMesa:Form {
		Jugador? jugadorUno;
		Jugador? jugadorDos;
		public FrmMesa(Jugador j1, Jugador j2) {
			InitializeComponent();
			jugadorUno = j1;
			jugadorDos = j2;
			grp_JugadorUno.Text+=jugadorUno.Nombre;
			grp_T2.Text+=jugadorDos.Nombre;
			lbl_PuntosJugadorUno.Visible=false;
			lbl_PuntosJugadorDos.Visible=false;
		}

		
	}
}
