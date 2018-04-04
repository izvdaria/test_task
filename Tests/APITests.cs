using System.Net.Http;
using Newtonsoft.Json;
using Xunit;

namespace Tests
{
    public class APITests
    {
        private const string requestUrl =
            "http://samples.openweathermap.org/data/2.5/weather?q=London,uk&appid=b1b15e88fa797225412429c1c50c122a1";

        [Fact]
        public void VerifyCoordinates()
        {
            var body = GetResponseBody(requestUrl);
            var response = JsonConvert.DeserializeObject<ResponseObject>(body);

            Assert.True(response.Coord.Lon == -0.13f);
            Assert.True(response.Coord.Lat == 51.51f);
        }

        [Fact]
        public void VerifyTemperature()
        {
            var body = GetResponseBody(requestUrl);
            var response = JsonConvert.DeserializeObject<ResponseObject>(body);

            Assert.True(response.Main.Temp < 315f);
        }

        private string GetResponseBody(string url)
        {
            var client = new HttpClient();
            var response = client.GetAsync(url).Result;

            response.EnsureSuccessStatusCode();

            var body = response.Content.ReadAsStringAsync().Result;
            return body;
        }
    }
}

