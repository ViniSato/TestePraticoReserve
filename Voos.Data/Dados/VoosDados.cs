using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voos.Data.Dados
{
    public class VoosDados
    {
        private readonly string apiUrl = "https://dev.reserve.com.br/airapi/gol/getavailability";
        private readonly HttpClient httpClient;

        public VoosDados()
        {
            httpClient = new HttpClient();
        }

        public async Task<string> ObterDisponibilidadeVoos(string origem, string destino, string data)
        {
            string url = $"{apiUrl}?origin={Uri.EscapeDataString(origem)}&destination={Uri.EscapeDataString(destino)}&date={Uri.EscapeDataString(data)}";

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    return $"Erro na solicitação: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                return $"Erro: {ex.Message}";
            }
        }
    }
}
