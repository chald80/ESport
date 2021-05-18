using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESport.Model;
using ESport.Services.Interface;

namespace ESport.Services.EFServices
{
    public class EFProfileService : IProfileService
    {
        ESportContext context;
        public EFProfileService(ESportContext service)
        {
            context = service;
        }
        public IEnumerable<Profile> GetProfiles()
        {
            return context.Profiles.ToList();
        }

        public void AddProfile(Profile profile)
        {
            context.Profiles.Add(profile);
            context.SaveChanges();
        }

        public void DeleteProfile(Profile profile)
        {
            context.Profiles.Remove(profile);
            context.SaveChanges();
        }

        public Profile GetProfile(int id)
        {
            var profile = context.Profiles.FirstOrDefault(p => p.ProfileId == id);
            return profile;
        }
        public void EditProfile(Profile profile)
        {
            context.Profiles.Update(profile);
            context.SaveChanges();
        }
    }
}
