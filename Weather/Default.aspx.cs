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
            // Get the location entered by the user
            

            // Call the getTemperature method to retrieve the temperature for the location
            string temperature = getTemperature();

            // Display the temperature on the web page
            lblTemperature.Text = $"{temperature} &deg;C";
        }

        private string getTemperature()
        {
            string location0 = txtLocation.Text;
            string location1 = txtLocation1.Text;
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


