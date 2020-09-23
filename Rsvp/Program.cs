using System;
using Rsvp.Models;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Rsvp
{
    class Program
    {
        private static DataContext db = new DataContext();
        public static IConfigurationRoot configuration;

        private static void addResponses()
        {
            var response1 = new GuestResponse {
                Name = "User 1",
                Email = "user1@rsvp.com",
                Phone = "555-55-55",
                WillAttend = true
            };

            var response2 = new GuestResponse {
                Name = "User 2",
                Email = "user2@rsvp.com",
                Phone = "777-77-77",
                WillAttend = false
            };
            db.GuestResponses.Add(response1);
            db.GuestResponses.Add(response2);
            db.SaveChanges();
        }

        private static void getResponses()
        {
            foreach (var resp in db.GuestResponses)
            {
                Console.WriteLine(resp.Id + " " + resp.Name + " : " + resp.WillAttend);   
            }
        }

        private static void editResponses()
        {
            var resp = db.GuestResponses.FirstOrDefault(r => r.Id == 1);
            if (resp is null) return;
            resp.Name = "User 11";
            db.SaveChanges();
        }
        static void Main(string[] args)
        {
//            addResponses();
//            getResponses();
//            Console.WriteLine("----");
//            editResponses();
            getResponses();
        }
    }
}
