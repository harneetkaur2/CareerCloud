using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    [ServiceContract]
    public interface ICompany
    {
        [OperationContract]
        void AddCompanyDescription(CompanyDescriptionPoco[] item);
        [OperationContract]
        List<CompanyDescriptionPoco> GetAllCompanyDescription();
        [OperationContract]
        CompanyDescriptionPoco GetSingleCompanyDescription(String Id);
        [OperationContract]
        void RemoveCompanyDescription(CompanyDescriptionPoco[] item);
        [OperationContract]
        void UpdateCompanyDescription(CompanyDescriptionPoco[] item);


        [OperationContract]
        void AddCompanyJobDescription(CompanyJobDescriptionPoco[] item);
        [OperationContract]
        List<CompanyJobDescriptionPoco> GetAllCompanyJobDescription();
        [OperationContract]
        CompanyJobDescriptionPoco GetSingleCompanyJobDescription(String Id);
        [OperationContract]
        void RemoveCompanyJobDescription(CompanyJobDescriptionPoco[] item);
        [OperationContract]
        void UpdateCompanyJobDescription(CompanyJobDescriptionPoco[] item);

        [OperationContract]
        void AddCompanyJobEducation(CompanyJobEducationPoco[] item);
        [OperationContract]
        List<CompanyJobEducationPoco> GetAllCompanyJobEducation();
        [OperationContract]
        CompanyJobEducationPoco GetSingleCompanyJobEducation(String Id);
        [OperationContract]
        void RemoveCompanyJobEducation(CompanyJobEducationPoco[] item);
        [OperationContract]
        void UpdateCompanyJobEducation(CompanyJobEducationPoco[] item);


        [OperationContract]
        void AddCompanyJob(CompanyJobPoco[] item);
        [OperationContract]
        List<CompanyJobPoco> GetAllCompanyJob();
        [OperationContract]
        CompanyJobPoco GetSingleCompanyJob(String Id);
        [OperationContract]
        void RemoveCompanyJob(CompanyJobPoco[] item);
        [OperationContract]
        void UpdateCompanyJob(CompanyJobPoco[] item);


        [OperationContract]
        void AddCompanyJobSkill(CompanyJobSkillPoco[] item);
        [OperationContract]
        List<CompanyJobSkillPoco> GetAllCompanyJobSkill();
        [OperationContract]
        CompanyJobSkillPoco GetSingleCompanyJobSkill(String Id);
        [OperationContract]
        void RemoveCompanyJobSkill(CompanyJobSkillPoco[] item);
        [OperationContract]
        void UpdateCompanyJobSkill(CompanyJobSkillPoco[] item);


        [OperationContract]
        void AddCompanyLocation(CompanyLocationPoco[] item);
        [OperationContract]
        List<CompanyLocationPoco> GetAllCompanyLocation();
        [OperationContract]
        CompanyLocationPoco GetSingleCompanyLocation(String Id);
        [OperationContract]
        void RemoveCompanyLocation(CompanyLocationPoco[] item);
        [OperationContract]
        void UpdateCompanyLocation(CompanyLocationPoco[] item);

        [OperationContract]
        void AddCompanyProfile(CompanyProfilePoco[] item);
        [OperationContract]
        List<CompanyProfilePoco> GetAllCompanyProfile();
        [OperationContract]
        CompanyProfilePoco GetSingleCompanyProfile(String Id);
        [OperationContract]
        void RemoveCompanyProfile(CompanyProfilePoco[] item);
        [OperationContract]
        void UpdateCompanyProfile(CompanyProfilePoco[] item);

    }
}
