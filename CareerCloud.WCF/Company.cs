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
	public class Company : ICompany
	{
		public void AddCompanyDescription(CompanyDescriptionPoco[] item)
		{
			EFGenericRepository<CompanyDescriptionPoco> companydescriptionrepo = new EFGenericRepository<CompanyDescriptionPoco>(false);
			CompanyDescriptionLogic _companyDescriptionLogic = new CompanyDescriptionLogic(companydescriptionrepo);
			_companyDescriptionLogic.Add(item);
		}

		public void AddCompanyJob(CompanyJobPoco[] item)
		{
			EFGenericRepository<CompanyJobPoco> companyjobrepo = new EFGenericRepository<CompanyJobPoco>(false);
			CompanyJobLogic _companyJobLogic = new CompanyJobLogic(companyjobrepo);
			_companyJobLogic.Add(item);
		}

		public void AddCompanyJobDescription(CompanyJobDescriptionPoco[] item)
		{
			EFGenericRepository<CompanyJobDescriptionPoco> companyjobdescriptionrepo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
			CompanyJobDescriptionLogic _companyJobDescriptionLogic = new CompanyJobDescriptionLogic(companyjobdescriptionrepo);
			_companyJobDescriptionLogic.Add(item);
		}

		public void AddCompanyJobEducation(CompanyJobEducationPoco[] item)
		{
			EFGenericRepository<CompanyJobEducationPoco> companyjobeducationrepo = new EFGenericRepository<CompanyJobEducationPoco>(false);
			CompanyJobEducationLogic _companyJobEducationLogic = new CompanyJobEducationLogic(companyjobeducationrepo);
			_companyJobEducationLogic.Add(item);
		}

		public void AddCompanyJobSkill(CompanyJobSkillPoco[] item)
		{
			EFGenericRepository<CompanyJobSkillPoco> companyjobskillrepo = new EFGenericRepository<CompanyJobSkillPoco>(false);
			CompanyJobSkillLogic _companyJobSkillLogic = new CompanyJobSkillLogic(companyjobskillrepo);
			_companyJobSkillLogic.Add(item);
		}

		public void AddCompanyLocation(CompanyLocationPoco[] item)
		{
			EFGenericRepository<CompanyLocationPoco> companylocationrepo = new EFGenericRepository<CompanyLocationPoco>(false);
			CompanyLocationLogic _companyLocationLogic = new CompanyLocationLogic(companylocationrepo);
			_companyLocationLogic.Add(item);
		}

		public void AddCompanyProfile(CompanyProfilePoco[] item)
		{
			EFGenericRepository<CompanyProfilePoco> companyprofilerepo = new EFGenericRepository<CompanyProfilePoco>(false);
			CompanyProfileLogic _companyProfileLogic = new CompanyProfileLogic(companyprofilerepo);
			_companyProfileLogic.Add(item);
		}

		public List<CompanyDescriptionPoco> GetAllCompanyDescription()
		{
			EFGenericRepository<CompanyDescriptionPoco> companydescriptionrepo = new EFGenericRepository<CompanyDescriptionPoco>(false);
			CompanyDescriptionLogic _companyDescriptionLogic = new CompanyDescriptionLogic(companydescriptionrepo);
			return _companyDescriptionLogic.GetAll();
		}

		public List<CompanyJobPoco> GetAllCompanyJob()
		{
			EFGenericRepository<CompanyJobPoco> companyjobrepo = new EFGenericRepository<CompanyJobPoco>(false);
			CompanyJobLogic _companyJobLogic = new CompanyJobLogic(companyjobrepo);
			return _companyJobLogic.GetAll();
		}

		public List<CompanyJobDescriptionPoco> GetAllCompanyJobDescription()
		{
			EFGenericRepository<CompanyJobDescriptionPoco> companyjobdescriptionrepo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
			CompanyJobDescriptionLogic _companyJobDescriptionLogic = new CompanyJobDescriptionLogic(companyjobdescriptionrepo);
			return _companyJobDescriptionLogic.GetAll();
		}

		public List<CompanyJobEducationPoco> GetAllCompanyJobEducation()
		{
			EFGenericRepository<CompanyJobEducationPoco> companyjobeducationrepo = new EFGenericRepository<CompanyJobEducationPoco>(false);
			CompanyJobEducationLogic _companyJobEducationLogic = new CompanyJobEducationLogic(companyjobeducationrepo);
			return _companyJobEducationLogic.GetAll();
		}

		public List<CompanyJobSkillPoco> GetAllCompanyJobSkill()
		{
			EFGenericRepository<CompanyJobSkillPoco> companyjobskillrepo = new EFGenericRepository<CompanyJobSkillPoco>(false);
			CompanyJobSkillLogic _companyJobSkillLogic = new CompanyJobSkillLogic(companyjobskillrepo);
			return _companyJobSkillLogic.GetAll();
		}

		public List<CompanyLocationPoco> GetAllCompanyLocation()
		{
			EFGenericRepository<CompanyLocationPoco> companylocationrepo = new EFGenericRepository<CompanyLocationPoco>(false);
			CompanyLocationLogic _companyLocationLogic = new CompanyLocationLogic(companylocationrepo);
			return _companyLocationLogic.GetAll();
		}

		public List<CompanyProfilePoco> GetAllCompanyProfile()
		{
			EFGenericRepository<CompanyProfilePoco> companyprofilerepo = new EFGenericRepository<CompanyProfilePoco>(false);
			CompanyProfileLogic _companyProfileLogic = new CompanyProfileLogic(companyprofilerepo);
			return _companyProfileLogic.GetAll();
		}

		public CompanyDescriptionPoco GetSingleCompanyDescription(String Id)
		{
			EFGenericRepository<CompanyDescriptionPoco> companydescriptionrepo = new EFGenericRepository<CompanyDescriptionPoco>(false);
			CompanyDescriptionLogic _companyDescriptionLogic = new CompanyDescriptionLogic(companydescriptionrepo);
			return _companyDescriptionLogic.Get(Guid.Parse(Id));
		}

		public CompanyJobPoco GetSingleCompanyJob(String Id)
		{
			EFGenericRepository<CompanyJobPoco> companyjobrepo = new EFGenericRepository<CompanyJobPoco>(false);
			CompanyJobLogic _companyJobLogic = new CompanyJobLogic(companyjobrepo);
			return _companyJobLogic.Get(Guid.Parse(Id));
		}

		public CompanyJobDescriptionPoco GetSingleCompanyJobDescription(String Id)
		{
			EFGenericRepository<CompanyJobDescriptionPoco> companyjobdescriptionrepo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
			CompanyJobDescriptionLogic _companyJobDescriptionLogic = new CompanyJobDescriptionLogic(companyjobdescriptionrepo);
			return _companyJobDescriptionLogic.Get(Guid.Parse(Id));
		}

		public CompanyJobEducationPoco GetSingleCompanyJobEducation(String Id)
		{
			EFGenericRepository<CompanyJobEducationPoco> companyjobeducationrepo = new EFGenericRepository<CompanyJobEducationPoco>(false);
			CompanyJobEducationLogic _companyJobEducationLogic = new CompanyJobEducationLogic(companyjobeducationrepo);
			return _companyJobEducationLogic.Get(Guid.Parse(Id));
		}

		public CompanyJobSkillPoco GetSingleCompanyJobSkill(String Id)
		{
			EFGenericRepository<CompanyJobSkillPoco> companyjobskillrepo = new EFGenericRepository<CompanyJobSkillPoco>(false);
			CompanyJobSkillLogic _companyJobSkillLogic = new CompanyJobSkillLogic(companyjobskillrepo);
			return _companyJobSkillLogic.Get(Guid.Parse(Id));
		}

		public CompanyLocationPoco GetSingleCompanyLocation(String Id)
		{
			EFGenericRepository<CompanyLocationPoco> companylocationrepo = new EFGenericRepository<CompanyLocationPoco>(false);
			CompanyLocationLogic _companyLocationLogic = new CompanyLocationLogic(companylocationrepo);
			return _companyLocationLogic.Get(Guid.Parse(Id));
		}

		public CompanyProfilePoco GetSingleCompanyProfile(String Id)
		{
			EFGenericRepository<CompanyProfilePoco> companyprofilerepo = new EFGenericRepository<CompanyProfilePoco>(false);
			CompanyProfileLogic _companyProfileLogic = new CompanyProfileLogic(companyprofilerepo);
			return _companyProfileLogic.Get(Guid.Parse(Id));
		}

		public void RemoveCompanyDescription(CompanyDescriptionPoco[] item)
		{
			EFGenericRepository<CompanyDescriptionPoco> companydescriptionrepo = new EFGenericRepository<CompanyDescriptionPoco>(false);
			CompanyDescriptionLogic _companyDescriptionLogic = new CompanyDescriptionLogic(companydescriptionrepo);
			 _companyDescriptionLogic.Delete(item);
		}

		public void RemoveCompanyJob(CompanyJobPoco[] item)
		{
			EFGenericRepository<CompanyJobPoco> companyjobrepo = new EFGenericRepository<CompanyJobPoco>(false);
			CompanyJobLogic _companyJobLogic = new CompanyJobLogic(companyjobrepo);
			 _companyJobLogic.Delete(item);
		}

		public void RemoveCompanyJobDescription(CompanyJobDescriptionPoco[] item)
		{
			EFGenericRepository<CompanyJobDescriptionPoco> companyjobdescriptionrepo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
			CompanyJobDescriptionLogic _companyJobDescriptionLogic = new CompanyJobDescriptionLogic(companyjobdescriptionrepo);
			 _companyJobDescriptionLogic.Delete(item);
		}

		public void RemoveCompanyJobEducation(CompanyJobEducationPoco[] item)
		{
			EFGenericRepository<CompanyJobEducationPoco> companyjobeducationrepo = new EFGenericRepository<CompanyJobEducationPoco>(false);
			CompanyJobEducationLogic _companyJobEducationLogic = new CompanyJobEducationLogic(companyjobeducationrepo);
			 _companyJobEducationLogic.Delete(item);
		}

		public void RemoveCompanyJobSkill(CompanyJobSkillPoco[] item)
		{
			EFGenericRepository<CompanyJobSkillPoco> companyjobskillrepo = new EFGenericRepository<CompanyJobSkillPoco>(false);
			CompanyJobSkillLogic _companyJobSkillLogic = new CompanyJobSkillLogic(companyjobskillrepo);
			 _companyJobSkillLogic.Delete(item);
		}

		public void RemoveCompanyLocation(CompanyLocationPoco[] item)
		{
			EFGenericRepository<CompanyLocationPoco> companylocationrepo = new EFGenericRepository<CompanyLocationPoco>(false);
			CompanyLocationLogic _companyLocationLogic = new CompanyLocationLogic(companylocationrepo);
			 _companyLocationLogic.Delete(item);
		}

		public void RemoveCompanyProfile(CompanyProfilePoco[] item)
		{
			EFGenericRepository<CompanyProfilePoco> companyprofilerepo = new EFGenericRepository<CompanyProfilePoco>(false);
			CompanyProfileLogic _companyProfileLogic = new CompanyProfileLogic(companyprofilerepo);
			 _companyProfileLogic.Delete(item);
		}

		public void UpdateCompanyDescription(CompanyDescriptionPoco[] item)
		{
			EFGenericRepository<CompanyDescriptionPoco> companydescriptionrepo = new EFGenericRepository<CompanyDescriptionPoco>(false);
			CompanyDescriptionLogic _companyDescriptionLogic = new CompanyDescriptionLogic(companydescriptionrepo);
			_companyDescriptionLogic.Update(item);
		}

		
		public void UpdateCompanyJob(CompanyJobPoco[] item)
		{
			EFGenericRepository<CompanyJobPoco> companyjobrepo = new EFGenericRepository<CompanyJobPoco>(false);
			CompanyJobLogic _companyJobLogic = new CompanyJobLogic(companyjobrepo);
			_companyJobLogic.Update(item);
		}

		public void UpdateCompanyJobDescription(CompanyJobDescriptionPoco[] item)
		{
			EFGenericRepository<CompanyJobDescriptionPoco> companyjobdescriptionrepo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
			CompanyJobDescriptionLogic _companyJobDescriptionLogic = new CompanyJobDescriptionLogic(companyjobdescriptionrepo);
			 _companyJobDescriptionLogic.Update(item);
		}

		public void UpdateCompanyJobEducation(CompanyJobEducationPoco[] item)
		{
			EFGenericRepository<CompanyJobEducationPoco> companyjobeducationrepo = new EFGenericRepository<CompanyJobEducationPoco>(false);
			CompanyJobEducationLogic _companyJobEducationLogic = new CompanyJobEducationLogic(companyjobeducationrepo);
			 _companyJobEducationLogic.Update(item);
		}

		public void UpdateCompanyJobSkill(CompanyJobSkillPoco[] item)
		{
			EFGenericRepository<CompanyJobSkillPoco> companyjobskillrepo = new EFGenericRepository<CompanyJobSkillPoco>(false);
			CompanyJobSkillLogic _companyJobSkillLogic = new CompanyJobSkillLogic(companyjobskillrepo);
			 _companyJobSkillLogic.Update(item);
		}

		public void UpdateCompanyLocation(CompanyLocationPoco[] item)
		{
			EFGenericRepository<CompanyLocationPoco> companylocationrepo = new EFGenericRepository<CompanyLocationPoco>(false);
			CompanyLocationLogic _companyLocationLogic = new CompanyLocationLogic(companylocationrepo);
			 _companyLocationLogic.Update(item);
		}
		public void UpdateCompanyProfile(CompanyProfilePoco[] item)
		{
			EFGenericRepository<CompanyProfilePoco> companyprofilerepo = new EFGenericRepository<CompanyProfilePoco>(false);
			CompanyProfileLogic _companyProfileLogic = new CompanyProfileLogic(companyprofilerepo);
			 _companyProfileLogic.Update(item);
		}
	}
}
