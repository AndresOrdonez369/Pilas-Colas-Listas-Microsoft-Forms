using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto3
{
	public class PilaGas
	{
		public int referencia { get; set; }
		public string nombre { get; set; }
		public string direccion { get; set; }
		public int estrato { get; set; }
		public string categoria { get; set; }
		public string mes { get; set; }
		public int consumo { get; set; }
		public int pago { get; set; }

		public string fecha { get; set; }

		public int[] acumulado;
		public int i=0;
		public decimal CalcularPago(int consumo)
		{
			pago = consumo * 2000;
			i++;
			return pago;
		}



	}
}
