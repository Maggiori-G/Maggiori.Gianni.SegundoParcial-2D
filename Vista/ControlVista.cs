using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista {
	public static class ControlVista {

		public static bool ValidarTextBox(Form form) {
			foreach(Control	control in form.Controls) {
				if(control is TextBox && string.IsNullOrEmpty(control.Text)) {
					return false;
				}
			}
			return true;
		}

		
	}
}
