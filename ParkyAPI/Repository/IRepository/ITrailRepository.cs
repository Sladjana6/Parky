using ParkyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyAPI.Repository.IRepository
{
    public interface ITrailRepository
    {
        ICollection<Trail> GetTrails();
        ICollection<Trail> GetTrailsInNationalPark(int nationalParkId);
        Trail GetTrail(int nationalParkId);
        bool TrailExists(int nationalParkId);
        bool TrailExists(string name);
        bool CreateTrail(Trail nationalPark);
        bool UpdateTrail(Trail nationalPark);
        bool DeleteTrail(Trail nationalPark);
        bool Save();
    }
}
