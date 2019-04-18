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
	class Security : ISecurity
	{
		public void AddSecurityLogin(SecurityLoginPoco[] item)
		{
			EFGenericRepository<SecurityLoginPoco> securityloginrepo = new EFGenericRepository<SecurityLoginPoco>(false);
			SecurityLoginLogic _securityLoginLogic = new SecurityLoginLogic(securityloginrepo);
			_securityLoginLogic.Add(item);
		}

		public void AddSecurityLoginsLog(SecurityLoginsLogPoco[] item)
		{
			EFGenericRepository<SecurityLoginsLogPoco> securityloginlogrepo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
			SecurityLoginsLogLogic _securityLoginLogLogic = new SecurityLoginsLogLogic(securityloginlogrepo);
			_securityLoginLogLogic.Add(item);
		}

		public void AddSecurityLoginsRole(SecurityLoginsRolePoco[] item)
		{
			EFGenericRepository<SecurityLoginsRolePoco> securityloginrolerepo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
			SecurityLoginsRoleLogic _securityLoginsRoleLogic = new SecurityLoginsRoleLogic(securityloginrolerepo);
			_securityLoginsRoleLogic.Add(item);
		}

		public void AddSecurityRole(SecurityRolePoco[] item)
		{
			EFGenericRepository<SecurityRolePoco> securityrolerepo = new EFGenericRepository<SecurityRolePoco>(false);
			SecurityRoleLogic _securityRoleLogic = new SecurityRoleLogic(securityrolerepo);
			_securityRoleLogic.Add(item);
		}

		public List<SecurityLoginPoco> GetAllSecurityLogin()
		{
			EFGenericRepository<SecurityLoginPoco> securityloginrepo = new EFGenericRepository<SecurityLoginPoco>(false);
			SecurityLoginLogic _securityLoginLogic = new SecurityLoginLogic(securityloginrepo);
			return _securityLoginLogic.GetAll();
		}

		public List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog()
		{
			EFGenericRepository<SecurityLoginsLogPoco> securityloginlogrepo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
			SecurityLoginsLogLogic _securityLoginLogLogic = new SecurityLoginsLogLogic(securityloginlogrepo);
			return _securityLoginLogLogic.GetAll();
		}

		public List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole()
		{
			EFGenericRepository<SecurityLoginsRolePoco> securityloginrolerepo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
			SecurityLoginsRoleLogic _securityLoginsRoleLogic = new SecurityLoginsRoleLogic(securityloginrolerepo);
			return _securityLoginsRoleLogic.GetAll();
		}

		public List<SecurityRolePoco> GetAllSecurityRole()
		{
			EFGenericRepository<SecurityRolePoco> securityrolerepo = new EFGenericRepository<SecurityRolePoco>(false);
			SecurityRoleLogic _securityRoleLogic = new SecurityRoleLogic(securityrolerepo);
			return _securityRoleLogic.GetAll();
		}

		public SecurityLoginPoco GetSingleSecurityLogin(String Id)
		{
			EFGenericRepository<SecurityLoginPoco> securityloginrepo = new EFGenericRepository<SecurityLoginPoco>(false);
			SecurityLoginLogic _securityLoginLogic = new SecurityLoginLogic(securityloginrepo);
			return _securityLoginLogic.Get(Guid.Parse(Id));
		}

		public SecurityLoginsLogPoco GetSingleSecurityLoginsLog(String Id)
		{
			EFGenericRepository<SecurityLoginsLogPoco> securityloginlogrepo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
			SecurityLoginsLogLogic _securityLoginLogLogic = new SecurityLoginsLogLogic(securityloginlogrepo);
			return _securityLoginLogLogic.Get(Guid.Parse(Id));
		}

		public SecurityLoginsRolePoco GetSingleSecurityLoginsRole(String Id)
		{
			EFGenericRepository<SecurityLoginsRolePoco> securityloginrolerepo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
			SecurityLoginsRoleLogic _securityLoginsRoleLogic = new SecurityLoginsRoleLogic(securityloginrolerepo);
			return _securityLoginsRoleLogic.Get(Guid.Parse(Id));
		}

		public SecurityRolePoco GetSingleSecurityRole(String Id)
		{
			EFGenericRepository<SecurityRolePoco> securityrolerepo = new EFGenericRepository<SecurityRolePoco>(false);
			SecurityRoleLogic _securityRoleLogic = new SecurityRoleLogic(securityrolerepo);
			return _securityRoleLogic.Get(Guid.Parse(Id));
		}

		public void RemoveSecurityLogin(SecurityLoginPoco[] item)
		{
			EFGenericRepository<SecurityLoginPoco> securityloginrepo = new EFGenericRepository<SecurityLoginPoco>(false);
			SecurityLoginLogic _securityLoginLogic = new SecurityLoginLogic(securityloginrepo);
			 _securityLoginLogic.Delete(item);
		}

		public void RemoveSecurityLoginsLog(SecurityLoginsLogPoco[] item)
		{
			EFGenericRepository<SecurityLoginsLogPoco> securityloginlogrepo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
			SecurityLoginsLogLogic _securityLoginLogLogic = new SecurityLoginsLogLogic(securityloginlogrepo);
			 _securityLoginLogLogic.Delete(item);
		}

		public void RemoveSecurityLoginsRole(SecurityLoginsRolePoco[] item)
		{
			EFGenericRepository<SecurityLoginsRolePoco> securityloginrolerepo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
			SecurityLoginsRoleLogic _securityLoginsRoleLogic = new SecurityLoginsRoleLogic(securityloginrolerepo);
			 _securityLoginsRoleLogic.Delete(item);
		}

		public void RemoveSecurityRole(SecurityRolePoco[] item)
		{
			EFGenericRepository<SecurityRolePoco> securityrolerepo = new EFGenericRepository<SecurityRolePoco>(false);
			SecurityRoleLogic _securityRoleLogic = new SecurityRoleLogic(securityrolerepo);
			 _securityRoleLogic.Delete(item);
		}

		public void UpdateSecurityLogin(SecurityLoginPoco[] item)
		{
			EFGenericRepository<SecurityLoginPoco> securityloginrepo = new EFGenericRepository<SecurityLoginPoco>(false);
			SecurityLoginLogic _securityLoginLogic = new SecurityLoginLogic(securityloginrepo);
			 _securityLoginLogic.Update(item);
		}

		public void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] item)
		{
			EFGenericRepository<SecurityLoginsLogPoco> securityloginlogrepo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
			SecurityLoginsLogLogic _securityLoginLogLogic = new SecurityLoginsLogLogic(securityloginlogrepo);
			 _securityLoginLogLogic.Update(item);
		}

		public void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] item)
		{
			EFGenericRepository<SecurityLoginsRolePoco> securityloginrolerepo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
			SecurityLoginsRoleLogic _securityLoginsRoleLogic = new SecurityLoginsRoleLogic(securityloginrolerepo);
			 _securityLoginsRoleLogic.Update(item);
		}

		public void UpdateSecurityRole(SecurityRolePoco[] item)
		{
			EFGenericRepository<SecurityRolePoco> securityrolerepo = new EFGenericRepository<SecurityRolePoco>(false);
			SecurityRoleLogic _securityRoleLogic = new SecurityRoleLogic(securityrolerepo);
			 _securityRoleLogic.Update(item);
		}
	}
}
