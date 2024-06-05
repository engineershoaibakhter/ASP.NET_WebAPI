using Microsoft.EntityFrameworkCore;
using WebApplication10.DbContexts;
using WebApplication10.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication10.Repository
{

    public class ProfileRepository:IProfileRepository
    {
        private readonly ProductContext _dbContext;

        public ProfileRepository(ProfileContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteProfile(string userName)
        {
            var profile = _dbContext.Profile.Find(userName);
            if (profile != null)
            {
                _dbContext.Products.Remove(profile);
                Save();
            }
        }

        public Profile GetProfileByUserName(string userName)
        {
            return _dbContext.Profiles.Find(userName);
        }

        public IEnumerable<Profile> GetProfiles()
        {
            return _dbContext.Profiles.ToList();
        }

        public void InsertProfile(Profile profile)
        {
            _dbContext.Add(profile);
            Save();
        }

        public void UpdateProfile(Profile profile)
        {
            _dbContext.Entry(profile).State = EntityState.Modified;
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
