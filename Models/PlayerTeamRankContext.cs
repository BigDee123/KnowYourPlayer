using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace knowYourPlayer.Models
{
    class PlayerTeamRankContext:DbContext
    {
        public PlayerTeamRankContext():base("playerTeamdb")
        {

        }


        public DbSet<Player> play { get; set; }
        public DbSet<Team> tem { get; set; }
        public DbSet<Rank> ran { get; set; }



        public System.Data.Entity.DbSet<PlayerTeamRank> playerView { get; set; }
   
    }
}
