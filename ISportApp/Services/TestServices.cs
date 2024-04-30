using ISportApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISportApp.Services
{
    class TestServices
    {

        string downloadDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
        
        public TestServices() 
        {
            string jsonString = File.ReadAllText(Path.Combine(downloadDirectory, @"IFindSoccerInfos\searchplayers.json"));

            SearchedPlayer sP = JsonConvert.DeserializeObject<SearchedPlayer>(jsonString);

            var a = sP.player[0];
        }


    }
}
