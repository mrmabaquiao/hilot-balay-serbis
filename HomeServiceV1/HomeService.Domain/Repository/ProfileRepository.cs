using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.Domain.Repository
{
    public class ProfileRepository : IProfileRepository, IDisposable
    {
        private HomeServiceEntities context;

        public ProfileRepository(HomeServiceEntities context)
        {
            this.context = context;
        }
        public IEnumerable<Profile> GetProfiles()
        {
            return context.Profiles.ToList();
        }

        public Profile GetProfileById(int profileId)
        {
            return context.Profiles.Find(profileId);
        }

        public void InsertProfile(Profile profile)
        {
            context.Profiles.Add(profile);
        }

        public void DeleteProfile(int profileId)
        {
            Profile profile = context.Profiles.Find(profileId);
            context.Profiles.Remove(profile);
        }

        public void UpdateProfile(Profile profile)
        {
            context.Entry(profile).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
