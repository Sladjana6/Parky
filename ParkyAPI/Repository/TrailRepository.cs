using Microsoft.EntityFrameworkCore;
using ParkyAPI.Data;
using ParkyAPI.Models;
using ParkyAPI.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyAPI.Repository
{
    public class TrailRepository : ITrailRepository
    {
        private readonly ApplicationDbContext _db;

        public TrailRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool CreateTrail(Trail Trail)
        {
            _db.Trail.Add(Trail);
            return Save();
        }

        public bool DeleteTrail(Trail Trail)
        {
            _db.Trail.Remove(Trail);
            return Save();
        }

        public Trail GetTrail(int TrailId)
        {
            return _db.Trail.Include(t => t.NationalPark).FirstOrDefault(np => np.Id == TrailId);
        }

        public ICollection<Trail> GetTrails()
        {
            return _db.Trail.Include(t => t.NationalPark).OrderBy(np => np.Name).ToList();
        }

        public bool TrailExists(int TrailId)
        {
            return _db.Trail.Any(np => np.Id == TrailId);
        }

        public bool TrailExists(string name)
        {
            bool value = _db.Trail.Any(np => np.Name.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;

        }

        public bool UpdateTrail(Trail Trail)
        {
            _db.Trail.Update(Trail);
            return Save();
        }

        public ICollection<Trail> GetTrailsInNationalPark(int nationalParkId)
        {
            return _db.Trail.Include(t => t.NationalPark).Where(c => c.NationalParkId == nationalParkId).ToList();
        }
    }
}
