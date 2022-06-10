using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class EventPlanner : Controller
    {
        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Listings()
        {
            return View();
        }

        public IActionResult Itinerary()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEvent(Event e)
        {
            e.ListOfEvents = Event.CreateListOfEvents(e);

            return View("Listings", e);
        }

        [HttpGet]
        public IActionResult ListActivities(string type, string audience, string location, string time)
        {
            IList<string> listOfActivities = new List<string>();

            switch (location)
            {
                case "Inside":
                    switch (audience)
                    {
                        case "Adults":
                            switch (type)
                            {
                                case "Party":
                                    listOfActivities.Add($"RollerSkating in the {time}");
                                    listOfActivities.Add($"DIY Wine Tasting in the {time}");
                                    listOfActivities.Add($"Destination Themed Food in the {time}");
                                    listOfActivities.Add($"Karaoke in the {time}");
                                    listOfActivities.Add($"Letter Theme in the {time}");
                                    break;

                                case "Social Gathering":
                                    listOfActivities.Add($"Murder Mystery in the {time}");
                                    listOfActivities.Add($"Great Gatsby Party in the {time}");
                                    listOfActivities.Add($"Homecraft DIY Night in the {time}");
                                    listOfActivities.Add($"Pickem Movie Night in the {time}");
                                    listOfActivities.Add($"Bake off in the {time}");
                                    break;
                            }

                            break;
                        
                        case "Kids":
                            switch (type)
                            {
                                case "Party":
                                    listOfActivities.Add($"Balancing Act in the {time}");
                                    listOfActivities.Add($"Fun Photobooth in the {time}");
                                    listOfActivities.Add($"Present Stack in the {time}");
                                    listOfActivities.Add($"Indoor Limbo in the {time}");
                                    listOfActivities.Add($"Slime Making in the {time}");
                                    break;

                                case "Social Gathering":
                                    listOfActivities.Add($"Painting in the {time}");
                                    listOfActivities.Add($"DIY Classic Games in the {time}");
                                    listOfActivities.Add($"Movie Night in the {time}");
                                    listOfActivities.Add($"Pizza & Game Night in the {time}");
                                    listOfActivities.Add($"Roller Skating in the {time}");
                                    break;
                            }

                            break;

                        case "All of the above":
                            switch (type)
                            {
                                case "Party":
                                    listOfActivities.Add($"Tie Dye in the {time}");
                                    listOfActivities.Add($"Theme Night in the {time}");
                                    listOfActivities.Add($"Roller Skating in the {time}");
                                    break;

                                case "Social Gathering":
                                    listOfActivities.Add($"Talent Show in the {time}");
                                    listOfActivities.Add($"Bake off in the {time}");
                                    listOfActivities.Add($"Art Show in the {time}");
                                    listOfActivities.Add($"Ice Cream Social in the {time}");
                                    listOfActivities.Add($"Make your own jewlery in the {time}");
                                    break;
                            }

                            break;
                    }

                    break;
                
                case "Outside":
                    switch (audience)
                    {
                        case "Adults":
                            switch (type)
                            {
                                case "Party":
                                    listOfActivities.Add($"DIY Wine Tasting in the {time}");
                                    listOfActivities.Add($"Barbeque in the {time}");
                                    listOfActivities.Add($"Pool Party in the {time}");
                                    listOfActivities.Add($"Brunch in the {time}");
                                    break;

                                case "Social Gathering":
                                    listOfActivities.Add($"Community Invovlement in the {time}");
                                    listOfActivities.Add($"Beach Day in the {time}");
                                    listOfActivities.Add($"Park Picnic in the {time}");
                                    listOfActivities.Add($"Bonfire in the {time}");
                                    break;
                            }

                            break;
                        
                        case "Kids":
                            switch (type)
                            {
                                case "Party":
                                    listOfActivities.Add($"Barbeque in the {time}");
                                    listOfActivities.Add($"Carnival in the {time}");
                                    listOfActivities.Add($"Party Crowns in the {time}");
                                    break;

                                case "Social Gathering":
                                    listOfActivities.Add($"Sidewalk painting in the {time}");
                                    listOfActivities.Add($"Sidewalk chalk in the {time}");
                                    listOfActivities.Add($"Flower Crowns in the {time}");
                                    break;
                            }

                            break;

                        case "All of the above":
                            switch (type)
                            {
                                case "Party":
                                    listOfActivities.Add($"Pinata in the{time}");
                                    listOfActivities.Add($"Limbo in the{time}");
                                    listOfActivities.Add($"Costume Party in the {time}");
                                    listOfActivities.Add($"Croquet in the {time}");
                                    break;

                                case "Social Gathering":
                                    listOfActivities.Add($"Talent Show in the {time}");
                                    listOfActivities.Add($"Potluck in the {time}");
                                    listOfActivities.Add($"Outdoor Tic Tac Toe in the {time}");
                                    listOfActivities.Add($"Outdoor can toss in the {time}");
                                    break;
                            }

                            break;
                    }

                    break;
            }

            return View("Itinerary", listOfActivities.ToList());
        }
    }
}