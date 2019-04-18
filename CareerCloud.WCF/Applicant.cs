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
	public class Applicant : IApplicant
	{
	
		public void AddApplicantEducation(ApplicantEducationPoco[] item)

		{
			EFGenericRepository<ApplicantEducationPoco> applicanteducationrepo = new EFGenericRepository<ApplicantEducationPoco>(false);
			ApplicantEducationLogic _applicantEducationLogic = new ApplicantEducationLogic(applicanteducationrepo);
			_applicantEducationLogic.Add(item);
		}

		
		public void AddApplicantJobApplication(ApplicantJobApplicationPoco[] item)
		{
			EFGenericRepository<ApplicantJobApplicationPoco> applicantjobapplicationrepo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
			ApplicantJobApplicationLogic _applicantJobApplicationLogic = new ApplicantJobApplicationLogic(applicantjobapplicationrepo);
			_applicantJobApplicationLogic.Add(item);
		}

		public void AddApplicantProfile(ApplicantProfilePoco[] item)
		{
			EFGenericRepository<ApplicantProfilePoco> applicantprofilerepo = new EFGenericRepository<ApplicantProfilePoco>(false);
			ApplicantProfileLogic _applicantProfileLogic = new ApplicantProfileLogic(applicantprofilerepo);
			_applicantProfileLogic.Add(item);
		}

		public void AddApplicantResume(ApplicantResumePoco[] item)
		{
			EFGenericRepository<ApplicantResumePoco> applicantresumerepo = new EFGenericRepository<ApplicantResumePoco>(false);
			ApplicantResumeLogic _applicantResumeLogic = new ApplicantResumeLogic(applicantresumerepo);
			_applicantResumeLogic.Add(item);
		}

		public void AddApplicantSkill(ApplicantSkillPoco[] item)
		{
			EFGenericRepository<ApplicantSkillPoco> applicantskillrepo = new EFGenericRepository<ApplicantSkillPoco>(false);
			ApplicantSkillLogic _applicantSkillLogic = new ApplicantSkillLogic(applicantskillrepo);
			_applicantSkillLogic.Add(item);
		}

		public void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] item)
		{
			EFGenericRepository<ApplicantWorkHistoryPoco> applicantworkhistoryrepo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
			ApplicantWorkHistoryLogic _applicantWorkHistoryLogic = new ApplicantWorkHistoryLogic(applicantworkhistoryrepo);
			_applicantWorkHistoryLogic.Add(item);
		}

		public List<ApplicantEducationPoco> GetAllApplicantEducation()
		{
			EFGenericRepository<ApplicantEducationPoco> applicanteducationrepo = new EFGenericRepository<ApplicantEducationPoco>(false);
			ApplicantEducationLogic _applicantEducationLogic = new ApplicantEducationLogic(applicanteducationrepo);
			return _applicantEducationLogic.GetAll();
		}

		public List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication()
		{
			EFGenericRepository<ApplicantJobApplicationPoco> applicantjobapplicationrepo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
			ApplicantJobApplicationLogic _applicantJobApplicationLogic = new ApplicantJobApplicationLogic(applicantjobapplicationrepo);
			return _applicantJobApplicationLogic.GetAll();
		}

		public List<ApplicantProfilePoco> GetAllApplicantProfile()
		{
			EFGenericRepository<ApplicantProfilePoco> applicantprofilerepo = new EFGenericRepository<ApplicantProfilePoco>(false);
			ApplicantProfileLogic _applicantProfileLogic = new ApplicantProfileLogic(applicantprofilerepo);
			return _applicantProfileLogic.GetAll();
		}

		public List<ApplicantResumePoco> GetAllApplicantResume()
		{
			EFGenericRepository<ApplicantResumePoco> applicantresumerepo = new EFGenericRepository<ApplicantResumePoco>(false);
			ApplicantResumeLogic _applicantResumeLogic = new ApplicantResumeLogic(applicantresumerepo);
			return _applicantResumeLogic.GetAll();
		}

		public List<ApplicantSkillPoco> GetAllApplicantSkill()
		{
			EFGenericRepository<ApplicantSkillPoco> applicantskillrepo = new EFGenericRepository<ApplicantSkillPoco>(false);
			ApplicantSkillLogic _applicantSkillLogic = new ApplicantSkillLogic(applicantskillrepo);
			return _applicantSkillLogic.GetAll();
		}

		public List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory()
		{
			EFGenericRepository<ApplicantWorkHistoryPoco> applicantworkhistoryrepo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
			ApplicantWorkHistoryLogic _applicantWorkHistoryLogic = new ApplicantWorkHistoryLogic(applicantworkhistoryrepo);
			return _applicantWorkHistoryLogic.GetAll();
		}

		public ApplicantEducationPoco GetSingleApplicantEducation(String Id)
		{
			EFGenericRepository<ApplicantEducationPoco> applicanteducationrepo = new EFGenericRepository<ApplicantEducationPoco>(false);
			ApplicantEducationLogic _applicantEducationLogic = new ApplicantEducationLogic(applicanteducationrepo);
			return _applicantEducationLogic.Get(Guid.Parse(Id));
		}

		public ApplicantJobApplicationPoco GetSingleApplicantJobApplication(String Id)
		{
			EFGenericRepository<ApplicantJobApplicationPoco> applicantjobapplicationrepo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
			ApplicantJobApplicationLogic _applicantJobApplicationLogic = new ApplicantJobApplicationLogic(applicantjobapplicationrepo);
			return _applicantJobApplicationLogic.Get(Guid.Parse(Id));
		}

		public ApplicantProfilePoco GetSingleApplicantProfile(String Id)
		{
			EFGenericRepository<ApplicantProfilePoco> applicantprofilerepo = new EFGenericRepository<ApplicantProfilePoco>(false);
			ApplicantProfileLogic _applicantProfileLogic = new ApplicantProfileLogic(applicantprofilerepo);
			return _applicantProfileLogic.Get(Guid.Parse(Id));
		}

		public ApplicantResumePoco GetSingleApplicantResume(String Id)
		{
			EFGenericRepository<ApplicantResumePoco> applicantresumerepo = new EFGenericRepository<ApplicantResumePoco>(false);
			ApplicantResumeLogic _applicantResumeLogic = new ApplicantResumeLogic(applicantresumerepo);
			return _applicantResumeLogic.Get(Guid.Parse(Id));
		}

		public ApplicantSkillPoco GetSingleApplicantSkill(String Id)
		{
			EFGenericRepository<ApplicantSkillPoco> applicantskillrepo = new EFGenericRepository<ApplicantSkillPoco>(false);
			ApplicantSkillLogic _applicantSkillLogic = new ApplicantSkillLogic(applicantskillrepo);
			return _applicantSkillLogic.Get(Guid.Parse(Id));
		}

		public ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(String Id)
		{
			EFGenericRepository<ApplicantWorkHistoryPoco> applicantworkhistoryrepo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
			ApplicantWorkHistoryLogic _applicantWorkHistoryLogic = new ApplicantWorkHistoryLogic(applicantworkhistoryrepo);
		    return _applicantWorkHistoryLogic.Get(Guid.Parse(Id));
		}

		public void RemoveApplicantEducation(ApplicantEducationPoco[] item)
		{
			EFGenericRepository<ApplicantEducationPoco> applicanteducationrepo = new EFGenericRepository<ApplicantEducationPoco>(false);
			ApplicantEducationLogic _applicantEducationLogic = new ApplicantEducationLogic(applicanteducationrepo);
			_applicantEducationLogic.Delete(item);
		}

		public void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] item)
		{
			EFGenericRepository<ApplicantJobApplicationPoco> applicantjobapplicationrepo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
			ApplicantJobApplicationLogic _applicantJobApplicationLogic = new ApplicantJobApplicationLogic(applicantjobapplicationrepo);
			 _applicantJobApplicationLogic.Delete(item);
		}

		public void RemoveApplicantProfile(ApplicantProfilePoco[] item)
		{
			EFGenericRepository<ApplicantProfilePoco> applicantprofilerepo = new EFGenericRepository<ApplicantProfilePoco>(false);
			ApplicantProfileLogic _applicantProfileLogic = new ApplicantProfileLogic(applicantprofilerepo);
			 _applicantProfileLogic.Delete(item);
		}

		public void RemoveApplicantResume(ApplicantResumePoco[] item)
		{
			EFGenericRepository<ApplicantResumePoco> applicantresumerepo = new EFGenericRepository<ApplicantResumePoco>(false);
			ApplicantResumeLogic _applicantResumeLogic = new ApplicantResumeLogic(applicantresumerepo);
			_applicantResumeLogic.Delete(item);
		}

		public void RemoveApplicantSkill(ApplicantSkillPoco[] item)
		{
			EFGenericRepository<ApplicantSkillPoco> applicantskillrepo = new EFGenericRepository<ApplicantSkillPoco>(false);
			ApplicantSkillLogic _applicantSkillLogic = new ApplicantSkillLogic(applicantskillrepo);
			_applicantSkillLogic.Delete(item);
		}

		public void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] item)
		{
			EFGenericRepository<ApplicantWorkHistoryPoco> applicantworkhistoryrepo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
			ApplicantWorkHistoryLogic _applicantWorkHistoryLogic = new ApplicantWorkHistoryLogic(applicantworkhistoryrepo);
			_applicantWorkHistoryLogic.Delete(item);
		}

		public void UpdateApplicantEducation(ApplicantEducationPoco[] item)
		{
			EFGenericRepository<ApplicantEducationPoco> applicanteducationrepo = new EFGenericRepository<ApplicantEducationPoco>(false);
			ApplicantEducationLogic _applicantEducationLogic = new ApplicantEducationLogic(applicanteducationrepo);
			_applicantEducationLogic.Update(item);
		}

		public void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] item)
		{
			EFGenericRepository<ApplicantJobApplicationPoco> applicantjobapplicationrepo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
			ApplicantJobApplicationLogic _applicantJobApplicationLogic = new ApplicantJobApplicationLogic(applicantjobapplicationrepo);
			 _applicantJobApplicationLogic.Update(item);
		}

		public void UpdateApplicantProfile(ApplicantProfilePoco[] item)
		{
			EFGenericRepository<ApplicantProfilePoco> applicantprofilerepo = new EFGenericRepository<ApplicantProfilePoco>(false);
			ApplicantProfileLogic _applicantProfileLogic = new ApplicantProfileLogic(applicantprofilerepo);
			 _applicantProfileLogic.Update(item);
		}

		public void UpdateApplicantResume(ApplicantResumePoco[] item)
		{
			EFGenericRepository<ApplicantResumePoco> applicantresumerepo = new EFGenericRepository<ApplicantResumePoco>(false);
			ApplicantResumeLogic _applicantResumeLogic = new ApplicantResumeLogic(applicantresumerepo);
			_applicantResumeLogic.Update(item);
		}

		public void UpdateApplicantSkill(ApplicantSkillPoco[] item)
		{
			EFGenericRepository<ApplicantSkillPoco> applicantskillrepo = new EFGenericRepository<ApplicantSkillPoco>(false);
			ApplicantSkillLogic _applicantSkillLogic = new ApplicantSkillLogic(applicantskillrepo);
			_applicantSkillLogic.Update(item);
		}

		public void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] item)
		{
			EFGenericRepository<ApplicantWorkHistoryPoco> applicantworkhistoryrepo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
			ApplicantWorkHistoryLogic _applicantWorkHistoryLogic = new ApplicantWorkHistoryLogic(applicantworkhistoryrepo);
			_applicantWorkHistoryLogic.Update(item);
		}
	}
}
