using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CareerCloud.WCF
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface IApplicant
	{
		[OperationContract]
		void AddApplicantEducation(ApplicantEducationPoco[] item);
		[OperationContract]
		List<ApplicantEducationPoco> GetAllApplicantEducation();
		[OperationContract]
		ApplicantEducationPoco GetSingleApplicantEducation(String Id);
		[OperationContract]
		void RemoveApplicantEducation(ApplicantEducationPoco[] item);
		[OperationContract]
		void UpdateApplicantEducation(ApplicantEducationPoco[] item);


		[OperationContract]
		void AddApplicantJobApplication(ApplicantJobApplicationPoco[] item);
        [OperationContract]
        List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication();
        [OperationContract]
        ApplicantJobApplicationPoco GetSingleApplicantJobApplication(String Id);
        [OperationContract]
        void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] item);
		[OperationContract]
		void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] items);

		[OperationContract]
		void AddApplicantProfile(ApplicantProfilePoco[] item);
		[OperationContract]
		List<ApplicantProfilePoco> GetAllApplicantProfile();
		[OperationContract]
		ApplicantProfilePoco GetSingleApplicantProfile(String Id);
		[OperationContract]
		void RemoveApplicantProfile(ApplicantProfilePoco[] item);
		[OperationContract]
		void UpdateApplicantProfile(ApplicantProfilePoco[] items);


		[OperationContract]
		void AddApplicantResume(ApplicantResumePoco[] item);
		[OperationContract]
		List<ApplicantResumePoco> GetAllApplicantResume();
		[OperationContract]
		ApplicantResumePoco GetSingleApplicantResume(String Id);
        [OperationContract]
        void RemoveApplicantResume(ApplicantResumePoco[] item);
        [OperationContract]
        void UpdateApplicantResume(ApplicantResumePoco[] items);


		[OperationContract]
		void AddApplicantSkill(ApplicantSkillPoco[] item);
        [OperationContract]
        List<ApplicantSkillPoco> GetAllApplicantSkill();
        [OperationContract]
        ApplicantSkillPoco GetSingleApplicantSkill(String Id);
        [OperationContract]
        void RemoveApplicantSkill(ApplicantSkillPoco[] item);
        [OperationContract]
        void UpdateApplicantSkill(ApplicantSkillPoco[] items);


		[OperationContract]
		void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] item);
        [OperationContract]
        List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory();
        [OperationContract]
        ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(String Id);
        [OperationContract]
        void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] item);
        [OperationContract]
        void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] items);


		}

	// Use a data contract as illustrated in the sample below to add composite types to service operations.
	// You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "CareerCloud.WCF.ContractType".
	 
}
