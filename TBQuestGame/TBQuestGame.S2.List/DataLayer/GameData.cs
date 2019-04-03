using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;

namespace TBQuestGame.DataLayer
{
    /// <summary>
    /// static class to store the game data set
    /// </summary>
    public static class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                Id = 1,
                Name = "Hitman",
                Age = 43,
                JobTitle = Player.JobTitleName.Explorer,
                Race = Character.RaceType.Human,
                Health = 100,
                Lives = 3,
                PerformancePoints = 10,
                LocationId = 0
            };
        }

        public static Map GameMap()
        {
            Map gameMap = new Map();

            gameMap.Locations.Add
                (new Location()
                {
                    Id = 1,
                    Name = "The Space Mission Headquarters",
                    Description = "The Space Mission Headquarters is located in just outside of Grand Rapids " +
                            "Michigan.Space, founded in 1885 as a bio-tech company, is now a 60 billion dollar company with " +
                            "huge holdings in defense and space research and development.",
                    Accessible = true,
                    ModifiyPerformancePoints = 10,
                    Message = "\"\tYou have been hired by the Space Mission Corporation to participate in its latest endeavor, the Space Mission Project. Your mission is to travel different location in Galaxy and report back to the Corporation."+
                    "You will begin by choosing a new location and using Space ship to travel to that point in the Galaxy."
                }
                );

            gameMap.Locations.Add
                (new Location()
                {
                    Id = 2,
                    Name = "Space Base Lab",
                    Description = "The Space Mission research facility located in the city of Heraklion on " +
                            "the north coast of Crete and the top secret research lab for the Aion Project.\nThe lab is a large, " + "" +
                            "well lit room, and staffed by a small number of scientists, all wearing light blue uniforms with the hydra-like Norlan Corporation logo.",
                    Accessible = true,
                    ModifiyPerformancePoints = 10,
                    Message = "Traveler, to move from location to location, simply touch the name of the desired location on your forearm."
                }
                );

            gameMap.Locations.Add
                (new Location()
                {
                    Id = 3,
                    Name = "Felandrian Plains",
                    Description = "The Felandrian Plains are a common destination for tourist. Located just north of the " +
                            "equatorial line on the planet of Corlon, they provide excellent habitat for a rich ecosystem of flora and fauna.",
                    Accessible = true,
                    ModifiyPerformancePoints = 10
                }
                );

            gameMap.Locations.Add
                (new Location()
                {
                    Id = 4,
                    Name = "Epitoria's Reading Room",
                    Description = "Queen Epitoria, the Torian Monarh of the 5th Dynasty, was know for her passion for " +
                            "galactic history. The room has a tall vaulted ceiling, open in the middle  with four floors of wrapping " +
                            "balconies filled with scrolls, texts, and infocrystals. As you enter the room a red fog desends from the ceiling " +
                            "and you begin feeling your life energy slip away slowly until you are dead.",
                    Accessible = false,
                    ModifiyPerformancePoints = 50,
                    ModifyLives = -1,
                    RequiredExperiencePoints = 40
                }
                );

            gameMap.Locations.Add
                (new Location()
                {
                    Id = 5,
                    Name = "Emergency Weapons Market",
                    Description = "Emergency Weapons Market, once controlled by the Thorian elite, is now an open market managed " +
                            "by the Xantorian Commerce Coop. It is a place where many races from various systems trade goods." +
                            "You purchase a blue potion in a thin, clear flask, drink it and receive 50 points of health.",
                    Accessible = false,
                    ModifiyPerformancePoints = 30,
                    ModifyHealth = 50,
                    Message = "Traveler, our telemetry places you at the Xantoria Market. We have reports of local health potions."
                }
                );

            gameMap.Locations.Add
                (new Location()
                {
                    Id = 6,
                    Name = "The Mission Research Academy",
                    Description = "The Mission Research Academy was founded in the early 4th galactic metachron. " +
                            "You are currently in the library, standing next to the protoplasmic encabulator that stores all " +
                            "recorded information of the galactic history.",
                    Accessible = true,
                    ModifiyPerformancePoints = 10
                }
                );

            //
            // set the initial location for the player
            //
            gameMap.CurrentLocation = gameMap.Locations.FirstOrDefault(l => l.Id == 1);

            return gameMap;
        }
    }
}
