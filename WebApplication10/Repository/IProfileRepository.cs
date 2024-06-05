using WebApplication10.Models;
using System.Collections.Generic;

namespace WebApplication10.Repository
{
    public interface IProfileRepository
    {
        Profile GetProfileByUserName(int userName);
        IEnumerable<Profile> GetProfiles();
        void DeleteProfile(int userName);
        void InsertProfile(Profile profile);
        void UpdateProfile(Profile Profile);
        void Save();
    }
}

