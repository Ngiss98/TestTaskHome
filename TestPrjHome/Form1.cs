using Newtonsoft.Json;
using System.Net;

namespace TestPrjHome
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// Функция для получения иформации по погоде.
		/// </summary>
		/// <param name="cityName">Название города.</param>
		/// <returns>Объект с информацией о погоде в городе.</returns>
		private ResponseWeather GetWeather(string cityName)
		{
			string response;

			//API ссылка на получение информации о погоде.
			string url = "https://api.openweathermap.org/data/2.5/weather?q=" + cityName + "&units=metric&lang=ru&appid=962513c1701ae5db2e25520a418c9627";

			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

				using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
				{
					response = streamReader.ReadToEnd();
				}

				var i = 0;

				ResponseWeather weatherRes = JsonConvert.DeserializeObject<ResponseWeather>(response);

				return weatherRes;
			}
			catch(Exception ex)
			{
				return null;
			}
		}

		/// <summary>
		/// Функция для очистки экрана от записей.
		/// </summary>
		private void CleanForm()
		{
			label1.Text = "";
			label3.Text = "";
			label4.Text = "";
			label5.Text = "";
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CleanForm();
		}

		/// <summary>
		/// Узнать погоду по городу.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			CleanForm();

			var weatherRes = GetWeather(textBox1.Text);
			
			//Проверка на корректный ввод города.
			if (weatherRes != null)
			{
				label1.Text = "Город: " + weatherRes.name;
				label3.Text = "Температура: " + weatherRes.main.temp + " C";
				label4.Text = "Описание: " + weatherRes.weather[0].description;
				label5.Text = "Скорость ветра: " + weatherRes.wind.speed + "м\\с";
			}
			else
			{
				label1.Text = "Город не найден";
			}

		}
	}
}