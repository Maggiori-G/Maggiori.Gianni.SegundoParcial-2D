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
	public partial class FrmRankingVictorias:Form {
		public FrmRankingVictorias() {
			InitializeComponent();
		}

		private void FrmRankingVictorias_Load(object sender,EventArgs e) {
			dgw_RankingJugadores.DataSource=null;
			dgw_RankingJugadores.DataSource=JugadorDAO.CrearRankingDeVictorias();
		}

		private void btn_Salir_Click(object sender,EventArgs e) {
			this.Close();
		}
	}
}
