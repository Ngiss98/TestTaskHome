using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrjHome
{
	/// <summary>
	/// Обект для хранения информации о погоде.
	/// </summary>
	public class ResponseWeather
	{
		public List<Weather> weather { get; set; }
		public Main main { get; set; }
		public Wind wind { get; set; }
		public string name { get; set; }
	}
}
