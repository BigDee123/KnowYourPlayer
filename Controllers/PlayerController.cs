using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using knowYourPlayer.Models;

namespace knowYourPlayer.Controllers
{
    public class PlayerController : Controller
    {

        PlayerTeamRankContext db = new PlayerTeamRankContext();
        // GET: Player

        public ActionResult VSearch( string search )
        {

            var p = from x in db.play select x;

            p = p.Where(y => y.playerID.Equals(search));
            return View(p);
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegisterPlayer()
        {
            return View();
        }


        [HttpPost]
        public ActionResult RegisterPlayer(PlayerTeamRank ptr)
        {

            var p = new Player()
            {

                playerID = ptr.playerID,
                playerAge = ptr.playerAge,
                playerName = ptr.playerName,
               

            };

            var t = new Team()
            {

                teamIG=ptr.teamIG,
                teamName=ptr.teamName,


            };


            var r = new Rank()
            {
                rankID = ptr.rankID,
                numgoals = ptr.numgoals,


            };

            db.play.Add(p);
            db.tem.Add(t);
            db.ran.Add(r);
            db.SaveChanges();


            return View();
        }


        public ActionResult allData()
        {
            baseViewmodel alld = new baseViewmodel();
            alld.player = db.play.ToList();
            alld.team = db.tem.ToList();
            alld.rank = db.ran.ToList();


            return View(alld);
        }


        public ActionResult PlayerView()
        {
            return View(db.play.ToList());
        }
        public ActionResult TeamView()
        {
            return View(db.tem.ToList());
        }

        public ActionResult RankView()
        {
            return View(db.ran.ToList());
        }

    }
}