using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Weather
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnGetTemperature_Click(object sender, EventArgs e)
        {
            string temperature = getTemperature();
            lblTemperature.Text = $"{temperature}";
        }

        private string getTemperature()
        {
            string location0 = txtLocation.Text;
            string location1 = txtLocation1.Text;
            var http = new HttpClient();
            http.DefaultRequestHeaders.Add("User-Agent", "Hisham");
            try
            {
                var str = http.GetAsync($"https://api.met.no/weatherapi/nowcast/2.0/complete?lat={location0}&lon={location1}");
                var result = str.Result.Content.ReadAsStringAsync().Result;
                dynamic data = JObject.Parse(result.ToString());
                string temperature = data.properties.timeseries[0].data.instant.details.air_temperature;
                return $"{temperature} &deg;C";
            }
            catch (Exception)
            {
                return $"Fail";
            }
        }

        protected void btnGetOslo_Click(object sender, EventArgs e)
        {
            string location0 = "59.913995";
            string location1 = "10.748619";
            string temperature = getTemperature(location0, location1);
            lblTemperature.Text = $"{temperature} &deg;C";
            // use the temperature value as required
        }

        private string getTemperature(string location0, string location1)
        {
            var http = new HttpClient();
            http.DefaultRequestHeaders.Add("User-Agent", "Hisham");
            var str = http.GetAsync($"https://api.met.no/weatherapi/nowcast/2.0/complete?lat={location0}&lon={location1}");
            var result = str.Result.Content.ReadAsStringAsync().Result;
            dynamic data = JObject.Parse(result.ToString());
            string temperature = data.properties.timeseries[0].data.instant.details.air_temperature;
            return temperature;
        }
    }
}


