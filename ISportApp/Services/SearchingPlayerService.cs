using ISportApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISportApp.Services
{
    class SearchingPlayerService
    {

        public static string _baseUrl = Constants.baseUrl;

        public async static Task<SearchedPlayer> getSearchedPlayer(string playerName)
        {
            SearchedPlayer searchedPlayer;

            using (var httpClient = new HttpClient())
            {
                try
                {


                    //TO-DO : Check example steps from S. Poteau

                    string siteLink = $"{_baseUrl}searchplayers.php?p={playerName}";

                    var response = await httpClient.GetAsync(siteLink);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();


                        searchedPlayer = JsonConvert.DeserializeObject<SearchedPlayer>(jsonResponse);

                        return searchedPlayer;
                    }
                    else
                    {
                        //To-DO : ....
                        throw new HttpRequestException($"{response.StatusCode} - HTTP REQUEST EXCEPTION");
                    }

                }
                catch (Exception ex)
                {

                    throw new Exception("Une erreur s'est produite !", ex);
                }
            }

        }
    }
}
