using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeoCoordinatePortable;
using WebApplication1.Models;

namespace WebApplication1
{
    public class filterUsers
    {
        private double latitude = 51.509865; // latitude of London
        private double longitude = -0.118092; // longitude of London
         
        public List<User> filterUsersWithin50Miles(List<User> Users)
        {
            var usersFound = new List<User>();
            GeoCoordinate London = new GeoCoordinate(latitude, longitude);
            double distance = 50;
            foreach (var user in Users)
            {
                var city = new GeoCoordinate((double)user.Latitude, (double)user.Longitude);
                var found = city.GetDistanceTo(London) < distance * 1609.344;
                if (found)
                    usersFound.Add(user);
               
            }
            return usersFound;
        }

    }
}
