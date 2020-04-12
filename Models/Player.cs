using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace knowYourPlayer.Models
{
    public class Player
    {
        [Key]

        [DisplayName("Enter Player ID")]
        public  string playerID { get; set; }
        public string playerName{ get; set; }
        public string playerAge { get; set; }
       
    }
    public class Team
    {
        [Key]
        public  string teamIG { get; set; }
        public string teamName { get; set; }
    }

    public class Rank
    {
        [Key]
        public string rankID{ get; set; }
        public string numgoals { get; set; }
    }


    public class PlayerTeamRank
    {
        [Key]
        public string playerID { get; set; }
        public string playerName { get; set; }
        public string playerAge { get; set; }
    
    

        public string teamIG{ get; set; }
        public string teamName { get; set; }
    

   
        public string rankID { get; set; }
        public string numgoals { get; set; }
    }


    public class baseViewmodel
    {
        public List<Player> player { get; set; }
        public List<Team> team { get; set; }
        public List<Rank> rank { get; set; }
        
    }


}

