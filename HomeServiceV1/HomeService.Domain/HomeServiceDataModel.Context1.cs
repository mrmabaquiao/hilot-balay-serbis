﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeService.Domain
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HomeServiceEntities : DbContext
    {
        public HomeServiceEntities()
            : base("name=HomeServiceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Profession> Professions { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ProfileProfession> ProfileProfessions { get; set; }
        public virtual DbSet<vw_GetProfileDetails> vw_GetProfileDetails { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<vw_GetProfileAddress> vw_GetProfileAddress { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
    
        public virtual int InsertProfileDetails(string name, string contactNumber, string profession)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var contactNumberParameter = contactNumber != null ?
                new ObjectParameter("ContactNumber", contactNumber) :
                new ObjectParameter("ContactNumber", typeof(string));
    
            var professionParameter = profession != null ?
                new ObjectParameter("Profession", profession) :
                new ObjectParameter("Profession", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertProfileDetails", nameParameter, contactNumberParameter, professionParameter);
        }
    
        public virtual ObjectResult<sp_Get_ProfileDetails_Username_Result> sp_Get_ProfileDetails_Username(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Get_ProfileDetails_Username_Result>("sp_Get_ProfileDetails_Username", usernameParameter);
        }
    
        public virtual int sp_Insert_ProfileDetails_Username(string name, string contactNumber, string profession, string username)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var contactNumberParameter = contactNumber != null ?
                new ObjectParameter("ContactNumber", contactNumber) :
                new ObjectParameter("ContactNumber", typeof(string));
    
            var professionParameter = profession != null ?
                new ObjectParameter("Profession", profession) :
                new ObjectParameter("Profession", typeof(string));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Insert_ProfileDetails_Username", nameParameter, contactNumberParameter, professionParameter, usernameParameter);
        }
    
        public virtual ObjectResult<sp_Get_ProfileDetails_Username_Result> GetProfileDetailsByUsername(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Get_ProfileDetails_Username_Result>("GetProfileDetailsByUsername", usernameParameter);
        }
    
        public virtual int InsertProfileDetailsByUsername(string name, string contactNumber, string profession, string username)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var contactNumberParameter = contactNumber != null ?
                new ObjectParameter("ContactNumber", contactNumber) :
                new ObjectParameter("ContactNumber", typeof(string));
    
            var professionParameter = profession != null ?
                new ObjectParameter("Profession", profession) :
                new ObjectParameter("Profession", typeof(string));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertProfileDetailsByUsername", nameParameter, contactNumberParameter, professionParameter, usernameParameter);
        }
    
        public virtual int sp_Update_ProfileDetails_Username(string name, string contactNumber, string profession, string username)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var contactNumberParameter = contactNumber != null ?
                new ObjectParameter("ContactNumber", contactNumber) :
                new ObjectParameter("ContactNumber", typeof(string));
    
            var professionParameter = profession != null ?
                new ObjectParameter("Profession", profession) :
                new ObjectParameter("Profession", typeof(string));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Update_ProfileDetails_Username", nameParameter, contactNumberParameter, professionParameter, usernameParameter);
        }
    
        public virtual int UpdateProfileDetailsByUsername(string name, string contactNumber, string profession, string username)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var contactNumberParameter = contactNumber != null ?
                new ObjectParameter("ContactNumber", contactNumber) :
                new ObjectParameter("ContactNumber", typeof(string));
    
            var professionParameter = profession != null ?
                new ObjectParameter("Profession", profession) :
                new ObjectParameter("Profession", typeof(string));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateProfileDetailsByUsername", nameParameter, contactNumberParameter, professionParameter, usernameParameter);
        }
    
        public virtual ObjectResult<sp_Get_ServiceLocation_Username_Result> sp_Get_ServiceLocation_Username(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Get_ServiceLocation_Username_Result>("sp_Get_ServiceLocation_Username", usernameParameter);
        }
    
        public virtual ObjectResult<sp_Get_ServiceLocation_Username_Result> GetServiceLocationByUsername(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Get_ServiceLocation_Username_Result>("GetServiceLocationByUsername", usernameParameter);
        }
    
        public virtual ObjectResult<sp_Get_CityBy_State_Result> sp_Get_CityBy_State(string stateName)
        {
            var stateNameParameter = stateName != null ?
                new ObjectParameter("StateName", stateName) :
                new ObjectParameter("StateName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Get_CityBy_State_Result>("sp_Get_CityBy_State", stateNameParameter);
        }
    
        public virtual ObjectResult<sp_Get_StateBy_CountryCode_Result> sp_Get_StateBy_CountryCode(string code)
        {
            var codeParameter = code != null ?
                new ObjectParameter("Code", code) :
                new ObjectParameter("Code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Get_StateBy_CountryCode_Result>("sp_Get_StateBy_CountryCode", codeParameter);
        }
    
        public virtual ObjectResult<sp_Get_StateBy_CountryCode_Result> GetStateByCountryCode(string code)
        {
            var codeParameter = code != null ?
                new ObjectParameter("Code", code) :
                new ObjectParameter("Code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Get_StateBy_CountryCode_Result>("GetStateByCountryCode", codeParameter);
        }
    
        public virtual ObjectResult<sp_Get_CityBy_State_Result> GetCityByState(string stateName)
        {
            var stateNameParameter = stateName != null ?
                new ObjectParameter("StateName", stateName) :
                new ObjectParameter("StateName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Get_CityBy_State_Result>("GetCityByState", stateNameParameter);
        }
    
        public virtual int sp_Insert_ServiceLocation_Profile(Nullable<int> cityId, string username)
        {
            var cityIdParameter = cityId.HasValue ?
                new ObjectParameter("CityId", cityId) :
                new ObjectParameter("CityId", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Insert_ServiceLocation_Profile", cityIdParameter, usernameParameter);
        }
    
        public virtual int InsertServiceLocationByProfileUsername(Nullable<int> cityId, string username)
        {
            var cityIdParameter = cityId.HasValue ?
                new ObjectParameter("CityId", cityId) :
                new ObjectParameter("CityId", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertServiceLocationByProfileUsername", cityIdParameter, usernameParameter);
        }
    
        public virtual ObjectResult<sp_Get_ProfileAddress_Username_Result> sp_Get_ProfileAddress_Username(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Get_ProfileAddress_Username_Result>("sp_Get_ProfileAddress_Username", usernameParameter);
        }
    
        public virtual ObjectResult<GetProfileAddressByUsernameResult> GetProfileAddressByUsername(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetProfileAddressByUsernameResult>("GetProfileAddressByUsername", usernameParameter);
        }
    
        public virtual int sp_Insert_ProfileAddress(string username, string address1, string address2, string address3, Nullable<int> cityId, Nullable<int> postalCode)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var address1Parameter = address1 != null ?
                new ObjectParameter("Address1", address1) :
                new ObjectParameter("Address1", typeof(string));
    
            var address2Parameter = address2 != null ?
                new ObjectParameter("Address2", address2) :
                new ObjectParameter("Address2", typeof(string));
    
            var address3Parameter = address3 != null ?
                new ObjectParameter("Address3", address3) :
                new ObjectParameter("Address3", typeof(string));
    
            var cityIdParameter = cityId.HasValue ?
                new ObjectParameter("CityId", cityId) :
                new ObjectParameter("CityId", typeof(int));
    
            var postalCodeParameter = postalCode.HasValue ?
                new ObjectParameter("PostalCode", postalCode) :
                new ObjectParameter("PostalCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Insert_ProfileAddress", usernameParameter, address1Parameter, address2Parameter, address3Parameter, cityIdParameter, postalCodeParameter);
        }
    
        public virtual int InsertProfileAddress(string username, string address1, string address2, string address3, Nullable<int> cityId, Nullable<int> postalCode)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var address1Parameter = address1 != null ?
                new ObjectParameter("Address1", address1) :
                new ObjectParameter("Address1", typeof(string));
    
            var address2Parameter = address2 != null ?
                new ObjectParameter("Address2", address2) :
                new ObjectParameter("Address2", typeof(string));
    
            var address3Parameter = address3 != null ?
                new ObjectParameter("Address3", address3) :
                new ObjectParameter("Address3", typeof(string));
    
            var cityIdParameter = cityId.HasValue ?
                new ObjectParameter("CityId", cityId) :
                new ObjectParameter("CityId", typeof(int));
    
            var postalCodeParameter = postalCode.HasValue ?
                new ObjectParameter("PostalCode", postalCode) :
                new ObjectParameter("PostalCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertProfileAddress", usernameParameter, address1Parameter, address2Parameter, address3Parameter, cityIdParameter, postalCodeParameter);
        }
    
        public virtual ObjectResult<sp_Get_PromotionDetails_Username_Result> sp_Get_PromotionDetails_Username(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Get_PromotionDetails_Username_Result>("sp_Get_PromotionDetails_Username", usernameParameter);
        }
    
        public virtual ObjectResult<PromotionDetails> GetPromotionDetailsByUsername(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PromotionDetails>("GetPromotionDetailsByUsername", usernameParameter);
        }
    
        public virtual ObjectResult<string> sp_Get_PromotionTags_PromotionId(Nullable<int> promotionId)
        {
            var promotionIdParameter = promotionId.HasValue ?
                new ObjectParameter("PromotionId", promotionId) :
                new ObjectParameter("PromotionId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_Get_PromotionTags_PromotionId", promotionIdParameter);
        }
    
        public virtual ObjectResult<PromotionTag> GetPromotionTagsByPromotionId(Nullable<int> promotionId)
        {
            var promotionIdParameter = promotionId.HasValue ?
                new ObjectParameter("PromotionId", promotionId) :
                new ObjectParameter("PromotionId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PromotionTag>("GetPromotionTagsByPromotionId", promotionIdParameter);
        }
    }
}
