using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Event
    {
        [Required]
        public string Title {get; set;}
        [Required]
        public DateTime Date {get; set;}
        [Required]
        public string Address {get; set;}
        public string Description {get; set;}
        [Required]
        public string CoordinatorName {get; set;}
        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}", ErrorMessage = "Characters are not allowed.")]
        [Required]
        public string CoordinatorPhone {get; set;}
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Characters are not allowed.")]
        [Required]
        public string CoordinatorEmail {get; set;}
        [Range(1, 100, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int NumberOfGuests {get; set;}
        public IList<Event> ListOfEvents {get; set;} = new List<Event>();

        public static IList<Event> CreateListOfEvents(Event e)
        {
            IList<Event> newListOfEvents = new List<Event>();

            newListOfEvents.Add(e);

            return newListOfEvents;
        }
    }
}