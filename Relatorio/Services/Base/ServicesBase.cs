using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorio.Services.Base
{

    public abstract class ServicesBase<TEntity> where TEntity : class
    {
        private string _urlAPI = ConfigurationManager.AppSettings["UrlAPI"].ToString();

        public async Task<IList<TEntity>> GetAll(string url, string message)
        {
            Uri URI = new Uri(_urlAPI + url);

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        dynamic stringJson = JObject.Parse(jsonString);
                        var responseData = JArray.Parse(stringJson.GetValue("data").ToString());

                        if (stringJson == null)
                        {
                            return null;
                        }

                        var listEntity = JsonConvert.DeserializeObject<TEntity[]>(responseData.ToString());
                        return listEntity;
                    }
                    else
                    {
                        MessageBox.Show(message + response.StatusCode);
                    }
                    return null;
                }
            }
        }
    }
}