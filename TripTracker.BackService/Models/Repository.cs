using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.BackService.Models
{
    public class Repository
    {
        private List<Trip> MyTrips = new List<Trip>
        {
            new Trip
            {
                Id=1,
                Name ="MVP Summit",
                StartDate =new DateTime(2018,3,5),
                EndDate=new DateTime(2018,3,8)

            },
            new Trip
            {
                Id=2,
                Name ="DeviceIntersection Orlando 2018",
                StartDate =new DateTime(2018,5,15),
                EndDate=new DateTime(2018,5,20)

            },

            new Trip
            {
                Id=3,
                Name ="Build 2018",
                StartDate =new DateTime(2018,8,18),
                EndDate=new DateTime(2018,8,22)

            }
        };

        public List<Trip> Get()
        {
            return MyTrips;
        }

        public Trip Get(int id)
        {
            return MyTrips.First(t=> t.Id==id);
        }

        public void Add(Trip newTrip)
        {
            MyTrips.Add(newTrip);
        }

        public void Update(Trip tripToUpdate)
        {
            MyTrips.Remove(MyTrips.First(t=> t.Id ==tripToUpdate.Id));
            Add(tripToUpdate);
        }


        public void Remove(int id)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == id));
            
        }

    }
}
