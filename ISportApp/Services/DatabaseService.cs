using ISportApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISportApp.Services
{
    public class DatabaseService
    {
        SQLiteAsyncConnection Database;

        public DatabaseService() { }

        /// <summary>
        ///     Méthode pour créer la base de donnée s'il n'existe pas encore
        /// </summary>
        /// <returns> Task: La base de donnée </returns>
        async Task Init()
        {
            if (Database is not null)
                return;
            try
            {
                Database = new SQLiteAsyncConnection(Constants.DtabasePath, Constants.Flags);
                var result = await Database.CreateTableAsync<Player>();
                //var result = await Database.CreateTableAsync<Testt>();
            }
            catch (Exception ex) { Debug.WriteLine(ex); }

        }


        /// <summary>
        /// Equivalent à SELECT * FROM Players
        /// </summary>
        /// <returns>Une liste de personne </returns>
        public async Task<List<Player>> GetPlayersAsync()
        {
            await Init();
            return await Database.Table<Player>().ToListAsync();
        }

        /// <summary>
        ///     Ajoute ou Update une personne dans la base de données
        /// </summary>
        /// <param name="player"> Le joueur à insérer </param>
        /// <returns>Int</returns>
        public async Task<int> SavePlayerAsync(Player player)
        {
            await Init();

            //if (player.id != 0)
            //{
            //    //We'll update
            //    return await Database.UpdateAsync(player);
            //}
            //else
            //{
                //We'll create
            return await Database.InsertAsync(player);
            //}

        }

    }
}
