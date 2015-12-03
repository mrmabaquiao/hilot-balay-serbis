using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.Domain.Repository
{
   public interface IProfileRepository : IDisposable
   {
       IEnumerable<Profile> GetProfiles();
       Profile GetProfileById(int profileId);
       void InsertProfile(Profile profile);
       void DeleteProfile(int profileId);
       void UpdateProfile(Profile profile);
       void Save();
   }
}
