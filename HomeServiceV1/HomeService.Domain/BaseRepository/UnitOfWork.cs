using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.Domain
{
    public class UnitOfWork : IDisposable
    {
        private HomeServiceEntities context = new HomeServiceEntities();
        private GenericRepository<Profile> profileRepository;
        private GenericRepository<Profession> professionRepository;
        private GenericRepository<Contact> contactRepository;
        private GenericRepository<ProfileProfession> profileProfessionRepository;
        private GenericRepository<vw_GetProfileDetails> profileDetailsRepository;
        private GenericRepository<Country> countryRepository;

        public GenericRepository<Country> CountryRepository
        {
            get
            {

                if (this.profileDetailsRepository == null)
                {
                    this.countryRepository = new GenericRepository<Country>(context);
                }
                return countryRepository;
            }
        }

        public GenericRepository<vw_GetProfileDetails> ProfileDetailsRepository
        {
            get
            {
                if (this.profileDetailsRepository == null)
                {
                    this.profileDetailsRepository = new GenericRepository<vw_GetProfileDetails>(context);
                }
                return profileDetailsRepository;
            }
        }

        public GenericRepository<ProfileProfession> ProfileProffesionRepository
        {
            get
            {

                if (this.profileProfessionRepository == null)
                {
                    this.profileProfessionRepository = new GenericRepository<ProfileProfession>(context);
                }
                return profileProfessionRepository;
            }
        }

        public GenericRepository<Profile> ProfileRepository
        {
            get
            {

                if (this.profileRepository == null)
                {
                    this.profileRepository = new GenericRepository<Profile>(context);
                }
                return profileRepository;
            }
        }

        public GenericRepository<Profession> ProfessionRepository
        {
            get
            {

                if (this.professionRepository == null)
                {
                    this.professionRepository = new GenericRepository<Profession>(context);
                }
                return professionRepository;
            }
        }

        public GenericRepository<Contact> ContactRepository
        {
            get
            {

                if (this.contactRepository == null)
                {
                    this.contactRepository = new GenericRepository<Contact>(context);
                }
                return contactRepository;
            }
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

        public void InsertProfileDetails(string name, string contactNumber, string profession)
        {
            context.InsertProfileDetails(name, contactNumber, profession);
        }

        public void InserProfileDetailsByUsername(string name, string contactNumber, string profession,string username)
        {
            context.InsertProfileDetailsByUsername(name, contactNumber, profession, username);
        }

        public sp_Get_ProfileDetails_Username_Result GetProfileDetailsByUsername(string username)
        {
            return context.GetProfileDetailsByUsername(username).FirstOrDefault();         
        }

        public void UpdateProfileDetailsByUsername(string name, string contactNumber, string profession, string username)
        {
            context.UpdateProfileDetailsByUsername(name, contactNumber, profession, username);
        }

        public List<sp_Get_ServiceLocation_Username_Result> GetServiceLocationByUsername(string username)
        {
           return context.GetServiceLocationByUsername(username).ToList();
        }

        public IQueryable<sp_Get_StateBy_CountryCode_Result> GetStateByCountryCode(string code)
        {
            return context.GetStateByCountryCode(code).AsQueryable();
        }

        public IQueryable<sp_Get_CityBy_State_Result> GetCityByState(string stateName)
        {
            return context.GetCityByState(stateName).AsQueryable();
        }

        public void InsertServiceLocationByProfileUsername(Nullable<int> cityId, string username)
        {
             context.InsertServiceLocationByProfileUsername(cityId, username);
        }

        public IQueryable<GetProfileAddressByUsernameResult> GetProfileAddressByUsername(string username)
        {            
            return context.GetProfileAddressByUsername(username).AsQueryable();
        }

        public void InsertProfileAddress(string username, string address1, string address2, string address3, Nullable<int> cityId, Nullable<int> postalCode)
        {
            context.InsertProfileAddress(username, address1, address2, address3, cityId, postalCode);
        }

        public IQueryable<PromotionDetails> GetPromotionDetailsByUsername(string username)
        {
           return context.GetPromotionDetailsByUsername(username).AsQueryable();
        }

        public PromotionDetails GetPromotionDetailByUsername(string username)
        {
            return context.GetPromotionDetailsByUsername(username).FirstOrDefault();
        }

        public IQueryable<PromotionTag> GetPromotionTagsByPromotionId(Nullable<int> promotionId)
        {
            return context.GetPromotionTagsByPromotionId(promotionId).AsQueryable();
        }


    }
}
