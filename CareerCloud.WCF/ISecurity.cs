using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.WCF
{
	[ServiceContract]
	public interface ISecurity
	{
		[OperationContract]
		void AddSecurityLogin(SecurityLoginPoco[] item);
        [OperationContract]
        List<SecurityLoginPoco> GetAllSecurityLogin();
        [OperationContract]
        SecurityLoginPoco GetSingleSecurityLogin(String Id);
        [OperationContract]
        void RemoveSecurityLogin(SecurityLoginPoco[] item);
        [OperationContract]
        void UpdateSecurityLogin(SecurityLoginPoco[] item);


		[OperationContract]
		void AddSecurityLoginsLog(SecurityLoginsLogPoco[] item);
        [OperationContract]
        List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog();
        [OperationContract]
        SecurityLoginsLogPoco GetSingleSecurityLoginsLog(String Id);
        [OperationContract]
        void RemoveSecurityLoginsLog(SecurityLoginsLogPoco[] item);
        [OperationContract]
        void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] item);


		[OperationContract]
		void AddSecurityLoginsRole(SecurityLoginsRolePoco[] item);
        [OperationContract]
        List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole();
        [OperationContract]
        SecurityLoginsRolePoco GetSingleSecurityLoginsRole(String Id);
        [OperationContract]
        void RemoveSecurityLoginsRole(SecurityLoginsRolePoco[] item);
        [OperationContract]
        void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] item);



		[OperationContract]
		void AddSecurityRole(SecurityRolePoco[] item);
        [OperationContract]
        List<SecurityRolePoco> GetAllSecurityRole();
        [OperationContract]
        SecurityRolePoco GetSingleSecurityRole(String Id);
        [OperationContract]
        void RemoveSecurityRole(SecurityRolePoco[] item);
        [OperationContract]
        void UpdateSecurityRole(SecurityRolePoco[] item);


	}
}
