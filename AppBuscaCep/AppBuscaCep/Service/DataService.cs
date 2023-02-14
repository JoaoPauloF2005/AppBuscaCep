using AppBuscaCep.Model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppBuscaCep.Service
{
    public class DataService
    {
        public static async Task<Endereco> GetEnderecoByCep(string cep)
        {
            Endereco end;

            using (HttpClient cliente = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("");

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                }
            }
        }
    }
}
