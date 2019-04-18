using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
	public class System : ISystem
	{
		public void AddSystemCountryCode(SystemCountryCodePoco[] item)
		{

			EFGenericRepository<SystemCountryCodePoco> systemcountrycoderepo = new EFGenericRepository<SystemCountryCodePoco>(false);
			SystemCountryCodeLogic _systemCountryCodeLogic = new SystemCountryCodeLogic(systemcountrycoderepo);
			_systemCountryCodeLogic.Add(item);
		}

		public void AddSystemLanguageCode(SystemLanguageCodePoco[] item)
		{
			EFGenericRepository<SystemLanguageCodePoco> systemlanguagecoderepo = new EFGenericRepository<SystemLanguageCodePoco>(false);
			SystemLanguageCodeLogic _systemLanguageCodeLogic = new SystemLanguageCodeLogic(systemlanguagecoderepo);
			_systemLanguageCodeLogic.Add(item);
		}

		public List<SystemCountryCodePoco> GetAllSystemCountryCode()
		{
			EFGenericRepository<SystemCountryCodePoco> systemcountrycoderepo = new EFGenericRepository<SystemCountryCodePoco>(false);
			SystemCountryCodeLogic _systemCountryCodeLogic = new SystemCountryCodeLogic(systemcountrycoderepo);
			return _systemCountryCodeLogic.GetAll();
		}

		public List<SystemLanguageCodePoco> GetAllSystemLanguageCode()
		{
			EFGenericRepository<SystemLanguageCodePoco> systemlanguagecoderepo = new EFGenericRepository<SystemLanguageCodePoco>(false);
			SystemLanguageCodeLogic _systemLanguageCodeLogic = new SystemLanguageCodeLogic(systemlanguagecoderepo);
			return _systemLanguageCodeLogic.GetAll();
		}

		public SystemCountryCodePoco GetSingleSystemCountryCode(String Code)
		{
			EFGenericRepository<SystemCountryCodePoco> systemcountrycoderepo = new EFGenericRepository<SystemCountryCodePoco>(false);
			SystemCountryCodeLogic _systemCountryCodeLogic = new SystemCountryCodeLogic(systemcountrycoderepo);
			return _systemCountryCodeLogic.Get(Code);
		}

		public SystemLanguageCodePoco GetSingleSystemLanguageCode(String LanguageId)
		{
			EFGenericRepository<SystemLanguageCodePoco> systemlanguagecoderepo = new EFGenericRepository<SystemLanguageCodePoco>(false);
			SystemLanguageCodeLogic _systemLanguageCodeLogic = new SystemLanguageCodeLogic(systemlanguagecoderepo);
			return _systemLanguageCodeLogic.Get(LanguageId);
		}

		public void RemoveSystemCountryCode(SystemCountryCodePoco[] item)
		{
			EFGenericRepository<SystemCountryCodePoco> systemcountrycoderepo = new EFGenericRepository<SystemCountryCodePoco>(false);
			SystemCountryCodeLogic _systemCountryCodeLogic = new SystemCountryCodeLogic(systemcountrycoderepo);
			 _systemCountryCodeLogic.Delete(item);
		}

		public void RemoveSystemLanguageCode(SystemLanguageCodePoco[] item)
		{
			EFGenericRepository<SystemLanguageCodePoco> systemlanguagecoderepo = new EFGenericRepository<SystemLanguageCodePoco>(false);
			SystemLanguageCodeLogic _systemLanguageCodeLogic = new SystemLanguageCodeLogic(systemlanguagecoderepo);
			 _systemLanguageCodeLogic.Delete(item);
		}

		public void UpdateSystemCountryCode(SystemCountryCodePoco[] item)
		{
			EFGenericRepository<SystemCountryCodePoco> systemcountrycoderepo = new EFGenericRepository<SystemCountryCodePoco>(false);
			SystemCountryCodeLogic _systemCountryCodeLogic = new SystemCountryCodeLogic(systemcountrycoderepo);
			 _systemCountryCodeLogic.Update(item);
		}

		public void UpdateSystemLanguageCode(SystemLanguageCodePoco[] item)
		{
			EFGenericRepository<SystemLanguageCodePoco> systemlanguagecoderepo = new EFGenericRepository<SystemLanguageCodePoco>(false);
			SystemLanguageCodeLogic _systemLanguageCodeLogic = new SystemLanguageCodeLogic(systemlanguagecoderepo);
			 _systemLanguageCodeLogic.Update(item);
		}
	}
}
