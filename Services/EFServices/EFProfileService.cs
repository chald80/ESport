using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESport.Model;
using ESport.Services.Interface;
using Microsoft.EntityFrameworkCore;

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
            var profile = context.Profiles
                .Include(i =>i.Info)
                .FirstOrDefault(p => p.ProfileId == id);
            return profile;
        }

        //public Profile GetProfile(int id)
        //{
        //    var profile = context.Profiles.FirstOrDefault(p => p.ProfileId == id);
        //    return profile;
        //}
        public void EditProfile(Profile profile)
        {
            context.Profiles.Update(profile);
            context.SaveChanges();
        }

        public Profile GetScore(int id)
        {
            var profile = context.Profiles
                .Include(g => g.Game)
                .ThenInclude(m => m.Maps)
                .ThenInclude(s => s.Scores)
                .FirstOrDefault(p => p.ProfileId == id);
            return profile;
        }
        //var student = context.Students
        //        .Include(s => s.Enrollments).ThenInclude(c => c.Course)
        //        .AsNoTracking()
        //        .FirstOrDefault(m => m.StudentId == id);
        //    return student;

    }
}
