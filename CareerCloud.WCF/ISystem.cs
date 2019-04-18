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
	public interface ISystem
	{
		[OperationContract]
		void AddSystemCountryCode(SystemCountryCodePoco[] item);
        [OperationContract]
        List<SystemCountryCodePoco> GetAllSystemCountryCode();
        [OperationContract]
        SystemCountryCodePoco GetSingleSystemCountryCode(String Id);
        [OperationContract]
        void RemoveSystemCountryCode(SystemCountryCodePoco[] item);
        [OperationContract]
        void UpdateSystemCountryCode(SystemCountryCodePoco[] item);



		[OperationContract]
		void AddSystemLanguageCode(SystemLanguageCodePoco[] item);
        [OperationContract]
        List<SystemLanguageCodePoco> GetAllSystemLanguageCode();
        [OperationContract]
        SystemLanguageCodePoco GetSingleSystemLanguageCode(String Id);
        [OperationContract]
        void RemoveSystemLanguageCode(SystemLanguageCodePoco[] item);
        [OperationContract]
        void UpdateSystemLanguageCode(SystemLanguageCodePoco[] item);
	}
}
