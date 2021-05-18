using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESport.Model;

namespace ESport.Services.Interface
{
    public interface IProfileService
    {
        IEnumerable<Profile> GetProfiles();
        void AddProfile(Profile profile);
        void DeleteProfile(Profile profile);
        Profile GetProfile(int id);
        public void EditProfile(Profile profile);

    }
}
