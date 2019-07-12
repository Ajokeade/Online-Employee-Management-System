using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using Bilikis.HRManagementSystem;
/// <summary>
/// Summary description for HRMSController
/// </summary>
namespace Bilikis.HRManagementSystem
{
    public class HRMSController
    {
        public HRMSController()
        {
            //
            // TODO: Add constructor logic here
            //



        }
    }

    //ApplicantPersonalDetails Controller

    public class ApplicantPersonalDetailsController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public ApplicantPersonalDetailsInfo Get(int applicantID)
        {
            return (ApplicantPersonalDetailsInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantPersonalDetailsGet(applicantID), typeof(ApplicantPersonalDetailsInfo));
        }


        // get offer details 
        public ApplicantPersonalDetailsInfo GetOfferDetails(int applicantID)
        {
            return (ApplicantPersonalDetailsInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantPersonalDetailsGetOfferDetails(applicantID), typeof(ApplicantPersonalDetailsInfo));
        }

        // get by applicantnum
        public ApplicantPersonalDetailsInfo GetByApplicantNum(string applicantNum)
        {
            return (ApplicantPersonalDetailsInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantPersonalDetailsGetByApplicantNum(applicantNum), typeof(ApplicantPersonalDetailsInfo));
        }
        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsList(), typeof(ApplicantPersonalDetailsInfo));
        }
        // list by position applied for both shortlist and not shortlisted
        public ArrayList ListByPositionAppliedForAll(string positionAppliedFor)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsListByPositionAppliedForAll(positionAppliedFor), typeof(ApplicantPersonalDetailsInfo));
        }
        // list by position applied for and application status is null (notshortlisted)
        public ArrayList ListByPositionNotShortlisted(string positionAppliedFor)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsListByPositionNotShortlisted(positionAppliedFor), typeof(ApplicantPersonalDetailsInfo));
        }

        //list by position applied for and application Status is shortlisted but interviewer decision is null
        public ArrayList ListByPositionShortlisted(string positionAppliedFor)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsListByPositionShortlisted(positionAppliedFor), typeof(ApplicantPersonalDetailsInfo));
        }
        // /list by position applied for  and application Status is shortlisted and interviewer decision is hire
        public ArrayList ListByPositionHire(string positionAppliedFor)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsListByPositionHire(positionAppliedFor), typeof(ApplicantPersonalDetailsInfo));
        }

        // /list by position applied for, shortlisted and interviewer decision is hire or not hire(is null)
        public ArrayList ListByPositionHireOrNot(string positionAppliedFor)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsListByPositionHireAndNot(positionAppliedFor), typeof(ApplicantPersonalDetailsInfo));
        }

        // /list by position applied for  and management approved
        public ArrayList ListByPositionApprove(string positionAppliedFor)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsListByPositionApprove(positionAppliedFor), typeof(ApplicantPersonalDetailsInfo));
        }

        // /list all aapproved applicants
        public ArrayList ListAllApprovedApplicants()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsListAllApprovedApplicants(), typeof(ApplicantPersonalDetailsInfo));
        }


        public ArrayList GetByCountryTable(int countryID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsGetByCountryTable(countryID), typeof(ApplicantPersonalDetailsInfo));
        }
        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsGetByEmployeeDepartmentTable(deptID), typeof(ApplicantPersonalDetailsInfo));
        }
        public ArrayList GetByEmployeeLevel(int levelID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsGetByEmployeeLevel(levelID), typeof(ApplicantPersonalDetailsInfo));
        }
        public ArrayList GetByEmployeePositionTable(int positionID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsGetByEmployeePositionTable(positionID), typeof(ApplicantPersonalDetailsInfo));
        }
        public ArrayList GetByEmployeeWorkLocation(int workLocationID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsGetByEmployeeWorkLocation(workLocationID), typeof(ApplicantPersonalDetailsInfo));
        }
        public ArrayList GetByLGATable(int lgaID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsGetByLGATable(lgaID), typeof(ApplicantPersonalDetailsInfo));
        }
        public ArrayList GetByStateTable(int stateID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsGetByStateTable(stateID), typeof(ApplicantPersonalDetailsInfo));
        }

        //public int Add(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
        //{
        //    return (int)DataProvider.Instance().ApplicantPersonalDetailsAdd(objApplicantPersonalDetails.ApplicantNum, objApplicantPersonalDetails.PositionAppliedFor, objApplicantPersonalDetails.Title, objApplicantPersonalDetails.FirstName, objApplicantPersonalDetails.MiddleName, objApplicantPersonalDetails.LastName, objApplicantPersonalDetails.Gender, objApplicantPersonalDetails.DateOfBirth, objApplicantPersonalDetails.Age, objApplicantPersonalDetails.MaritalStatus, objApplicantPersonalDetails.Religion, objApplicantPersonalDetails.Nationality_FK, objApplicantPersonalDetails.StateOfOrigin_FK, objApplicantPersonalDetails.LGA_FK, objApplicantPersonalDetails.HomeTown, objApplicantPersonalDetails.PhoneNo, objApplicantPersonalDetails.Email, objApplicantPersonalDetails.ContactAddress, objApplicantPersonalDetails.Passport, objApplicantPersonalDetails.ApplicationStatus, objApplicantPersonalDetails.PositionApproved_FK, objApplicantPersonalDetails.DepartmentID_FK, objApplicantPersonalDetails.WorkLocationID_FK, objApplicantPersonalDetails.LevelID_FK, objApplicantPersonalDetails.InterviewerDecision, objApplicantPersonalDetails.ManagementDecision);
        //}

        public int Add(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
        {
            return (int)DataProvider.Instance().ApplicantPersonalDetailsAdd(objApplicantPersonalDetails.ApplicantNum, objApplicantPersonalDetails.PositionAppliedFor, objApplicantPersonalDetails.Title, objApplicantPersonalDetails.FirstName, objApplicantPersonalDetails.MiddleName, objApplicantPersonalDetails.LastName, objApplicantPersonalDetails.Gender, objApplicantPersonalDetails.DateOfBirth, objApplicantPersonalDetails.Age, objApplicantPersonalDetails.MaritalStatus, objApplicantPersonalDetails.Religion, objApplicantPersonalDetails.Nationality_FK, objApplicantPersonalDetails.StateOfOrigin_FK, objApplicantPersonalDetails.LGA_FK, objApplicantPersonalDetails.HomeTown, objApplicantPersonalDetails.PhoneNo, objApplicantPersonalDetails.Email, objApplicantPersonalDetails.ContactAddress, objApplicantPersonalDetails.Passport, objApplicantPersonalDetails.ApplicationStatus,  objApplicantPersonalDetails.InterviewerDecision, objApplicantPersonalDetails.ManagementDecision);
        }

        public void Update(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
        {
            DataProvider.Instance().ApplicantPersonalDetailsUpdate(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.ApplicantNum, objApplicantPersonalDetails.PositionAppliedFor, objApplicantPersonalDetails.Title, objApplicantPersonalDetails.FirstName, objApplicantPersonalDetails.MiddleName, objApplicantPersonalDetails.LastName, objApplicantPersonalDetails.Gender, objApplicantPersonalDetails.DateOfBirth, objApplicantPersonalDetails.Age, objApplicantPersonalDetails.MaritalStatus, objApplicantPersonalDetails.Religion, objApplicantPersonalDetails.Nationality_FK, objApplicantPersonalDetails.StateOfOrigin_FK, objApplicantPersonalDetails.LGA_FK, objApplicantPersonalDetails.HomeTown, objApplicantPersonalDetails.PhoneNo, objApplicantPersonalDetails.Email, objApplicantPersonalDetails.ContactAddress, objApplicantPersonalDetails.Passport, objApplicantPersonalDetails.ApplicationStatus, objApplicantPersonalDetails.PositionApproved_FK, objApplicantPersonalDetails.DepartmentID_FK, objApplicantPersonalDetails.WorkLocationID_FK, objApplicantPersonalDetails.LevelID_FK, objApplicantPersonalDetails.InterviewerDecision, objApplicantPersonalDetails.ManagementDecision);
        }

        //UpdateUsingApplicantNum
        public void UpdateUsingApplicantNum(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
        {
            DataProvider.Instance().ApplicantPersonalDetailsUpdateUsingApplicantNum(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.ApplicantNum, objApplicantPersonalDetails.PositionAppliedFor, objApplicantPersonalDetails.Title, objApplicantPersonalDetails.FirstName, objApplicantPersonalDetails.MiddleName, objApplicantPersonalDetails.LastName, objApplicantPersonalDetails.Gender, objApplicantPersonalDetails.DateOfBirth, objApplicantPersonalDetails.Age, objApplicantPersonalDetails.MaritalStatus, objApplicantPersonalDetails.Religion, objApplicantPersonalDetails.Nationality_FK, objApplicantPersonalDetails.StateOfOrigin_FK, objApplicantPersonalDetails.LGA_FK, objApplicantPersonalDetails.HomeTown, objApplicantPersonalDetails.PhoneNo, objApplicantPersonalDetails.Email, objApplicantPersonalDetails.ContactAddress, objApplicantPersonalDetails.Passport);
        }

        // update applicant num
        public void UpdateApplicantNum(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
        {
            DataProvider.Instance().ApplicantPersonalDetailsUpdateApplicantNum(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.ApplicantNum);

        }

        // update application status(shortlisted)
        public void UpdateApplicationStatus(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
        {
            DataProvider.Instance().ApplicantPersonalDetailsUpdateApplicationStatus(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.ApplicationStatus);

        }

        // update interviewer decision (hire)
        public void UpdateInterviewerDecision(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
        {
            DataProvider.Instance().ApplicantPersonalDetailsUpdateInterviewerDecision(objApplicantPersonalDetails.ApplicantID,objApplicantPersonalDetails.PositionApproved_FK, objApplicantPersonalDetails.DepartmentID_FK, objApplicantPersonalDetails.WorkLocationID_FK, objApplicantPersonalDetails.LevelID_FK,objApplicantPersonalDetails.ResumptionDate,objApplicantPersonalDetails.InterviewerDecision);

        }
        //ApplicantPersonalDetailsUpdateManagementDecision
        public void UpdateManagementDecision(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
        {
            DataProvider.Instance().ApplicantPersonalDetailsUpdateManagementDecision(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.ManagementDecision);

        }
        public void Delete(int applicantID)
        {
            DataProvider.Instance().ApplicantPersonalDetailsDelete(applicantID);
        }


        // copied from ola
        public ArrayList ManagementApprovedList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantManagementApprovedList(), typeof(ApplicantPersonalDetailsInfo));
        }

        public ArrayList AcceptanceAppList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsAcceptanceAppList(), typeof(ApplicantPersonalDetailsInfo));
        }
        public void SendingOfferUpdate(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
        {
            DataProvider.Instance().ApplicantPersonalDetailsSendingOfferUpdate(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.PositionApproved_FK, objApplicantPersonalDetails.DepartmentID_FK, objApplicantPersonalDetails.LevelID_FK, objApplicantPersonalDetails.WorkLocationID_FK);
        }

        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }





    //public class ApplicantPersonalDetailsController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    //{
    //    #region "Public Methods"
    //    public ApplicantPersonalDetailsInfo Get(int applicantID)
    //    {
    //        return (ApplicantPersonalDetailsInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantPersonalDetailsGet(applicantID), typeof(ApplicantPersonalDetailsInfo));
    //    }

    //    public ApplicantPersonalDetailsInfo GetByApplicantNum(string applicantNum)
    //    {
    //        return (ApplicantPersonalDetailsInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantPersonalDetailsGetByApplicantNum(applicantNum), typeof(ApplicantPersonalDetailsInfo));
    //    }
    //    public ArrayList List()
    //    {
    //        return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsList(), typeof(ApplicantPersonalDetailsInfo));
    //    }
    //    // list by position applied for both shortlist and not shortlisted
    //    public ArrayList ListByPositionAppliedForAll(string positionAppliedFor)
    //    {
    //        return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsListByPositionAppliedForAll(positionAppliedFor), typeof(ApplicantPersonalDetailsInfo));
    //    }
    //    // list by position applied for and application status is null
    //    public ArrayList ListByPositionAppliedFor(string positionAppliedFor)
    //    {
    //        return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsListByPositionAppliedFor(positionAppliedFor), typeof(ApplicantPersonalDetailsInfo));
    //    }

    //    //list by position applied for and application Status is shortlisted
    //    public ArrayList ListByPositionAndApplicationStatus(string positionAppliedFor)
    //    {
    //        return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsListByPositionAndApplicationStatus(positionAppliedFor), typeof(ApplicantPersonalDetailsInfo));
    //    }
    //    public ArrayList GetByCountryTable(int countryID)
    //    {
    //        return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsGetByCountryTable(countryID), typeof(ApplicantPersonalDetailsInfo));
    //    }
    //    public ArrayList GetByLGATable(int lgaID)
    //    {
    //        return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsGetByLGATable(lgaID), typeof(ApplicantPersonalDetailsInfo));
    //    }
    //    public ArrayList GetByStateTable(int stateID)
    //    {
    //        return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsGetByStateTable(stateID), typeof(ApplicantPersonalDetailsInfo));
    //    }
    //    public int Add(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
    //    {
    //        return (int)DataProvider.Instance().ApplicantPersonalDetailsAdd(objApplicantPersonalDetails.ApplicantNum, objApplicantPersonalDetails.PositionAppliedFor, objApplicantPersonalDetails.Title, objApplicantPersonalDetails.FirstName, objApplicantPersonalDetails.MiddleName, objApplicantPersonalDetails.LastName, objApplicantPersonalDetails.Gender, objApplicantPersonalDetails.DateOfBirth, objApplicantPersonalDetails.Age, objApplicantPersonalDetails.MaritalStatus, objApplicantPersonalDetails.Religion, objApplicantPersonalDetails.Nationality_FK, objApplicantPersonalDetails.StateOfOrigin_FK, objApplicantPersonalDetails.LGA_FK, objApplicantPersonalDetails.HomeTown, objApplicantPersonalDetails.PhoneNo, objApplicantPersonalDetails.Email, objApplicantPersonalDetails.ContactAddress, objApplicantPersonalDetails.Passport, objApplicantPersonalDetails.ApplicationStatus, objApplicantPersonalDetails.EmploymentStatus);
    //    }

    //    public void Update(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
    //    {
    //        DataProvider.Instance().ApplicantPersonalDetailsUpdate(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.ApplicantNum, objApplicantPersonalDetails.PositionAppliedFor, objApplicantPersonalDetails.Title, objApplicantPersonalDetails.FirstName, objApplicantPersonalDetails.MiddleName, objApplicantPersonalDetails.LastName, objApplicantPersonalDetails.Gender, objApplicantPersonalDetails.DateOfBirth, objApplicantPersonalDetails.Age, objApplicantPersonalDetails.MaritalStatus, objApplicantPersonalDetails.Religion, objApplicantPersonalDetails.Nationality_FK, objApplicantPersonalDetails.StateOfOrigin_FK, objApplicantPersonalDetails.LGA_FK, objApplicantPersonalDetails.HomeTown, objApplicantPersonalDetails.PhoneNo, objApplicantPersonalDetails.Email, objApplicantPersonalDetails.ContactAddress, objApplicantPersonalDetails.Passport, objApplicantPersonalDetails.ApplicationStatus, objApplicantPersonalDetails.EmploymentStatus);
    //    }

       

    //    //UpdateUsingApplicantNum
    //    public void UpdateUsingApplicantNum(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
    //    {
    //        DataProvider.Instance().ApplicantPersonalDetailsUpdateUsingApplicantNum(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.ApplicantNum, objApplicantPersonalDetails.PositionAppliedFor, objApplicantPersonalDetails.Title, objApplicantPersonalDetails.FirstName, objApplicantPersonalDetails.MiddleName, objApplicantPersonalDetails.LastName, objApplicantPersonalDetails.Gender, objApplicantPersonalDetails.DateOfBirth, objApplicantPersonalDetails.Age, objApplicantPersonalDetails.MaritalStatus, objApplicantPersonalDetails.Religion, objApplicantPersonalDetails.Nationality_FK, objApplicantPersonalDetails.StateOfOrigin_FK, objApplicantPersonalDetails.LGA_FK, objApplicantPersonalDetails.HomeTown, objApplicantPersonalDetails.PhoneNo, objApplicantPersonalDetails.Email, objApplicantPersonalDetails.ContactAddress, objApplicantPersonalDetails.Passport);
    //    }
        
    //    // update applicant num
    //    public void UpdateApplicantNum(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
    //    {
    //        DataProvider.Instance().ApplicantPersonalDetailsUpdateApplicantNum(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.ApplicantNum);

    //    }

    //    // update application status
    //    public void UpdateApplicationStatus(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
    //    {
    //        DataProvider.Instance().ApplicantPersonalDetailsUpdateApplicationStatus(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.ApplicationStatus);

    //    }

    //    // update Employment status
    //    public void UpdateEmploymentStatus(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
    //    {
    //        DataProvider.Instance().ApplicantPersonalDetailsUpdateEmploymentStatus(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.EmploymentStatus);

    //    }
    //    public void Delete(int applicantID)
    //    {
    //        DataProvider.Instance().ApplicantPersonalDetailsDelete(applicantID);
    //    }
    //    #endregion

    //    #region "Optional Interfaces"
    //    public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
    //    {
    //        return null;
    //    }

    //    public string ExportModule(int ModuleID)
    //    {
    //        return "";
    //    }

    //    public void ImportModule(int ModuleID, string Content, string Version, int UserId)
    //    {
    //    }
    //    #endregion
    //} 
    
   
   

  

    
    public class ApplicantQualificationController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public ApplicantQualificationInfo Get(int qualificationID)
        {
            return (ApplicantQualificationInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantQualificationGet(qualificationID), typeof(ApplicantQualificationInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantQualificationList(), typeof(ApplicantQualificationInfo));
        }

        public ArrayList GetByApplicantPersonalDetails(int applicantID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantQualificationGetByApplicantPersonalDetails(applicantID), typeof(ApplicantQualificationInfo));
        }

        public int Add(ApplicantQualificationInfo objApplicantQualification)
        {
            return (int)DataProvider.Instance().ApplicantQualificationAdd(objApplicantQualification.InstitutionName, objApplicantQualification.QualificationType, objApplicantQualification.Course, objApplicantQualification.Grade, objApplicantQualification.StartYear, objApplicantQualification.EndYear, objApplicantQualification.ApplicantID_FK);
        }

        public void Update(ApplicantQualificationInfo objApplicantQualification)
        {
            DataProvider.Instance().ApplicantQualificationUpdate(objApplicantQualification.QualificationID, objApplicantQualification.InstitutionName, objApplicantQualification.QualificationType, objApplicantQualification.Course, objApplicantQualification.Grade, objApplicantQualification.StartYear, objApplicantQualification.EndYear, objApplicantQualification.ApplicantID_FK);
        }

        public void Delete(int qualificationID)
        {
            DataProvider.Instance().ApplicantQualificationDelete(qualificationID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

    // ApplicantProfQualification Controller
    public class ApplicantProfQualificationController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public ApplicantProfQualificationInfo Get(int profQualificationID)
        {
            return (ApplicantProfQualificationInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantProfQualificationGet(profQualificationID), typeof(ApplicantProfQualificationInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantProfQualificationList(), typeof(ApplicantProfQualificationInfo));
        }

        public ArrayList GetByApplicantPersonalDetails(int applicantID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantProfQualificationGetByApplicantPersonalDetails(applicantID), typeof(ApplicantProfQualificationInfo));
        }

        public int Add(ApplicantProfQualificationInfo objApplicantProfQualification)
        {
            return (int)DataProvider.Instance().ApplicantProfQualificationAdd(objApplicantProfQualification.CertificationName, objApplicantProfQualification.CertificateNo, objApplicantProfQualification.Stage, objApplicantProfQualification.CertYear, objApplicantProfQualification.ApplicantID_FK);
        }

        public void Update(ApplicantProfQualificationInfo objApplicantProfQualification)
        {
            DataProvider.Instance().ApplicantProfQualificationUpdate(objApplicantProfQualification.ProfQualificationID, objApplicantProfQualification.CertificationName, objApplicantProfQualification.CertificateNo, objApplicantProfQualification.Stage, objApplicantProfQualification.CertYear, objApplicantProfQualification.ApplicantID_FK);
        }

        public void Delete(int profQualificationID)
        {
            DataProvider.Instance().ApplicantProfQualificationDelete(profQualificationID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }



    //Applicant WorkExperience Controller
    public class ApplicantWorkExperienceController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public ApplicantWorkExperienceInfo Get(int workExperienceID)
        {
            return (ApplicantWorkExperienceInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantWorkExperienceGet(workExperienceID), typeof(ApplicantWorkExperienceInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantWorkExperienceList(), typeof(ApplicantWorkExperienceInfo));
        }

        public ArrayList GetByApplicantPersonalDetails(int applicantID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantWorkExperienceGetByApplicantPersonalDetails(applicantID), typeof(ApplicantWorkExperienceInfo));
        }

        public int Add(ApplicantWorkExperienceInfo objApplicantWorkExperience)
        {
            return (int)DataProvider.Instance().ApplicantWorkExperienceAdd(objApplicantWorkExperience.CompanyName, objApplicantWorkExperience.PositionHeld, objApplicantWorkExperience.JobDescriprtion, objApplicantWorkExperience.SalaryReceived, objApplicantWorkExperience.StartYear, objApplicantWorkExperience.EndYear, objApplicantWorkExperience.ApplicantID_FK);
        }

        public void Update(ApplicantWorkExperienceInfo objApplicantWorkExperience)
        {
            DataProvider.Instance().ApplicantWorkExperienceUpdate(objApplicantWorkExperience.WorkExperienceID, objApplicantWorkExperience.CompanyName, objApplicantWorkExperience.PositionHeld, objApplicantWorkExperience.JobDescriprtion, objApplicantWorkExperience.SalaryReceived, objApplicantWorkExperience.StartYear, objApplicantWorkExperience.EndYear, objApplicantWorkExperience.ApplicantID_FK);
        }

        public void Delete(int workExperienceID)
        {
            DataProvider.Instance().ApplicantWorkExperienceDelete(workExperienceID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //ApplicantDocument Controller
    public class ApplicantDocumentController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public ApplicantDocumentInfo Get(int documentID)
        {
            return (ApplicantDocumentInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantDocumentGet(documentID), typeof(ApplicantDocumentInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantDocumentList(), typeof(ApplicantDocumentInfo));
        }

        public ArrayList GetByApplicantPersonalDetails(int applicantID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantDocumentGetByApplicantPersonalDetails(applicantID), typeof(ApplicantDocumentInfo));
        }

        public int Add(ApplicantDocumentInfo objApplicantDocument)
        {
            return (int)DataProvider.Instance().ApplicantDocumentAdd(objApplicantDocument.DocumentType, objApplicantDocument.DocumentPath, objApplicantDocument.ApplicantID_FK);
        }

        public void Update(ApplicantDocumentInfo objApplicantDocument)
        {
            DataProvider.Instance().ApplicantDocumentUpdate(objApplicantDocument.DocumentID, objApplicantDocument.DocumentType, objApplicantDocument.DocumentPath, objApplicantDocument.ApplicantID_FK);
        }

        public void Delete(int documentID)
        {
            DataProvider.Instance().ApplicantDocumentDelete(documentID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

    // Country table controller
    public class CountryTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public CountryTableInfo Get(int countryID)
        {
            return (CountryTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().CountryTableGet(countryID), typeof(CountryTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().CountryTableList(), typeof(CountryTableInfo));
        }


        public int Add(CountryTableInfo objCountryTable)
        {
            return (int)DataProvider.Instance().CountryTableAdd(objCountryTable.CountryName);
        }

        public void Update(CountryTableInfo objCountryTable)
        {
            DataProvider.Instance().CountryTableUpdate(objCountryTable.CountryID, objCountryTable.CountryName);
        }

        public void Delete(int countryID)
        {
            DataProvider.Instance().CountryTableDelete(countryID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }




    // State controller
    public class StateTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public StateTableInfo Get(int stateID)
        {
            return (StateTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().StateTableGet(stateID), typeof(StateTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().StateTableList(), typeof(StateTableInfo));
        }

        public ArrayList GetByCountryTable(int countryID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().StateTableGetByCountryTable(countryID), typeof(StateTableInfo));
        }

        public int Add(StateTableInfo objStateTable)
        {
            return (int)DataProvider.Instance().StateTableAdd(objStateTable.StateName, objStateTable.StateCode, objStateTable.CountryID);
        }

        public void Update(StateTableInfo objStateTable)
        {
            DataProvider.Instance().StateTableUpdate(objStateTable.StateID, objStateTable.StateName, objStateTable.StateCode, objStateTable.CountryID);
        }

        public void Delete(int stateID)
        {
            DataProvider.Instance().StateTableDelete(stateID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

    //lga controller
    public class LGATableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public LGATableInfo Get(int lgaID)
        {
            return (LGATableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().LGATableGet(lgaID), typeof(LGATableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().LGATableList(), typeof(LGATableInfo));
        }

        public ArrayList GetByStateTable(int stateID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().LGATableGetByStateTable(stateID), typeof(LGATableInfo));
        }

        public int Add(LGATableInfo objLGATable)
        {
            return (int)DataProvider.Instance().LGATableAdd(objLGATable.LgaName, objLGATable.StateID);
        }

        public void Update(LGATableInfo objLGATable)
        {
            DataProvider.Instance().LGATableUpdate(objLGATable.LgaID, objLGATable.LgaName, objLGATable.StateID);
        }

        public void Delete(int lgaID)
        {
            DataProvider.Instance().LGATableDelete(lgaID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

    // quaification table controller
    public class QualificationTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public QualificationTableInfo Get(int qualificationID)
        {
            return (QualificationTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().QualificationTableGet(qualificationID), typeof(QualificationTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().QualificationTableList(), typeof(QualificationTableInfo));
        }


        public int Add(QualificationTableInfo objQualificationTable)
        {
            return (int)DataProvider.Instance().QualificationTableAdd(objQualificationTable.QualificationName);
        }

        public void Update(QualificationTableInfo objQualificationTable)
        {
            DataProvider.Instance().QualificationTableUpdate(objQualificationTable.QualificationID, objQualificationTable.QualificationName);
        }

        public void Delete(int qualificationID)
        {
            DataProvider.Instance().QualificationTableDelete(qualificationID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

    // GradeTable Controller 

    public class GradeTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public GradeTableInfo Get(int gradeID)
        {
            return (GradeTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().GradeTableGet(gradeID), typeof(GradeTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().GradeTableList(), typeof(GradeTableInfo));
        }


        public int Add(GradeTableInfo objGradeTable)
        {
            return (int)DataProvider.Instance().GradeTableAdd(objGradeTable.GradeName);
        }

        public void Update(GradeTableInfo objGradeTable)
        {
            DataProvider.Instance().GradeTableUpdate(objGradeTable.GradeID, objGradeTable.GradeName);
        }

        public void Delete(int gradeID)
        {
            DataProvider.Instance().GradeTableDelete(gradeID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //AvailablePositionTable Controller
    public class AvailablePositionTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public AvailablePositionTableInfo Get(int positionID)
        {
            return (AvailablePositionTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().AvailablePositionTableGet(positionID), typeof(AvailablePositionTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().AvailablePositionTableList(), typeof(AvailablePositionTableInfo));
        }


        public int Add(AvailablePositionTableInfo objAvailablePositionTable)
        {
            return (int)DataProvider.Instance().AvailablePositionTableAdd(objAvailablePositionTable.positionName);
        }

        public void Update(AvailablePositionTableInfo objAvailablePositionTable)
        {
            DataProvider.Instance().AvailablePositionTableUpdate(objAvailablePositionTable.positionID, objAvailablePositionTable.positionName);
        }

        public void Delete(int positionID)
        {
            DataProvider.Instance().AvailablePositionTableDelete(positionID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //EmployeeDepartmentTable Controller
    public class EmployeeDepartmentTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeDepartmentTableInfo Get(int deptID)
        {
            return (EmployeeDepartmentTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeDepartmentTableGet(deptID), typeof(EmployeeDepartmentTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDepartmentTableList(), typeof(EmployeeDepartmentTableInfo));
        }


        public int Add(EmployeeDepartmentTableInfo objEmployeeDepartmentTable)
        {
            return (int)DataProvider.Instance().EmployeeDepartmentTableAdd(objEmployeeDepartmentTable.DeptName);
        }

        public void Update(EmployeeDepartmentTableInfo objEmployeeDepartmentTable)
        {
            DataProvider.Instance().EmployeeDepartmentTableUpdate(objEmployeeDepartmentTable.DeptID, objEmployeeDepartmentTable.DeptName);
        }

        public void Delete(int deptID)
        {
            DataProvider.Instance().EmployeeDepartmentTableDelete(deptID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }



    //EmployeePositionTable Controller
    public class EmployeePositionTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeePositionTableInfo Get(int positionID)
        {
            return (EmployeePositionTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeePositionTableGet(positionID), typeof(EmployeePositionTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePositionTableList(), typeof(EmployeePositionTableInfo));
        }

        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePositionTableGetByEmployeeDepartmentTable(deptID), typeof(EmployeePositionTableInfo));
        }

        public int Add(EmployeePositionTableInfo objEmployeePositionTable)
        {
            return (int)DataProvider.Instance().EmployeePositionTableAdd(objEmployeePositionTable.PositionName, objEmployeePositionTable.DeptID_FK);
        }

        public void Update(EmployeePositionTableInfo objEmployeePositionTable)
        {
            DataProvider.Instance().EmployeePositionTableUpdate(objEmployeePositionTable.PositionID, objEmployeePositionTable.PositionName, objEmployeePositionTable.DeptID_FK);
        }

        public void Delete(int positionID)
        {
            DataProvider.Instance().EmployeePositionTableDelete(positionID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }



    //EmployeeLevelTable Controller
    public class EmployeeLevelTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeLevelTableInfo Get(int levelID)
        {
            return (EmployeeLevelTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeLevelTableGet(levelID), typeof(EmployeeLevelTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLevelTableList(), typeof(EmployeeLevelTableInfo));
        }

        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLevelTableGetByEmployeeDepartmentTable(deptID), typeof(EmployeeLevelTableInfo));
        }

        public int Add(EmployeeLevelTableInfo objEmployeeLevelTable)
        {
            return (int)DataProvider.Instance().EmployeeLevelTableAdd(objEmployeeLevelTable.LevelName, objEmployeeLevelTable.DeptID_FK, objEmployeeLevelTable.Salary, objEmployeeLevelTable.SalaryDetails, objEmployeeLevelTable.LeaveEntitle);
        }

        public void Update(EmployeeLevelTableInfo objEmployeeLevelTable)
        {
            DataProvider.Instance().EmployeeLevelTableUpdate(objEmployeeLevelTable.LevelID, objEmployeeLevelTable.LevelName, objEmployeeLevelTable.DeptID_FK, objEmployeeLevelTable.Salary, objEmployeeLevelTable.SalaryDetails, objEmployeeLevelTable.LeaveEntitle);
        }

        public void Delete(int levelID)
        {
            DataProvider.Instance().EmployeeLevelTableDelete(levelID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //EmployeeWorkLocation Controller
    public class EmployeeWorkLocationController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeWorkLocationInfo Get(int workLocationID)
        {
            return (EmployeeWorkLocationInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeWorkLocationGet(workLocationID), typeof(EmployeeWorkLocationInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeWorkLocationList(), typeof(EmployeeWorkLocationInfo));
        }


        public int Add(EmployeeWorkLocationInfo objEmployeeWorkLocation)
        {
            return (int)DataProvider.Instance().EmployeeWorkLocationAdd(objEmployeeWorkLocation.LocationName, objEmployeeWorkLocation.LocationAddress);
        }

        public void Update(EmployeeWorkLocationInfo objEmployeeWorkLocation)
        {
            DataProvider.Instance().EmployeeWorkLocationUpdate(objEmployeeWorkLocation.WorkLocationID, objEmployeeWorkLocation.LocationName, objEmployeeWorkLocation.LocationAddress);
        }

        public void Delete(int workLocationID)
        {
            DataProvider.Instance().EmployeeWorkLocationDelete(workLocationID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //InterviewRatingKey1 Controller
    public class InterviewRatingKey1Controller : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public InterviewRatingKey1Info Get(int ratingKeyID)
        {
            return (InterviewRatingKey1Info)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().InterviewRatingKey1Get(ratingKeyID), typeof(InterviewRatingKey1Info));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().InterviewRatingKey1List(), typeof(InterviewRatingKey1Info));
        }


        public int Add(InterviewRatingKey1Info objInterviewRatingKey1)
        {
            return (int)DataProvider.Instance().InterviewRatingKey1Add(objInterviewRatingKey1.ratingDescription);
        }

        public void Update(InterviewRatingKey1Info objInterviewRatingKey1)
        {
            DataProvider.Instance().InterviewRatingKey1Update(objInterviewRatingKey1.ratingKeyID, objInterviewRatingKey1.ratingDescription);
        }

        public void Delete(int ratingKeyID)
        {
            DataProvider.Instance().InterviewRatingKey1Delete(ratingKeyID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //InterviewRatingKey2 Controller
    public class InterviewRatingKey2Controller : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public InterviewRatingKey2Info Get(int ratingKeyID)
        {
            return (InterviewRatingKey2Info)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().InterviewRatingKey2Get(ratingKeyID), typeof(InterviewRatingKey2Info));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().InterviewRatingKey2List(), typeof(InterviewRatingKey2Info));
        }


        public int Add(InterviewRatingKey2Info objInterviewRatingKey2)
        {
            return (int)DataProvider.Instance().InterviewRatingKey2Add(objInterviewRatingKey2.ratingKeyDescription);
        }

        public void Update(InterviewRatingKey2Info objInterviewRatingKey2)
        {
            DataProvider.Instance().InterviewRatingKey2Update(objInterviewRatingKey2.ratingKeyID, objInterviewRatingKey2.ratingKeyDescription);
        }

        public void Delete(int ratingKeyID)
        {
            DataProvider.Instance().InterviewRatingKey2Delete(ratingKeyID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

    //EmployeeDetailsControl
    public class EmployeeDetailsController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeDetailsInfo Get(int employeeID)
        {
            return (EmployeeDetailsInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeDetailsGet(employeeID), typeof(EmployeeDetailsInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsList(), typeof(EmployeeDetailsInfo));
        }

        public ArrayList HiredList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsHiredList(), typeof(EmployeeDetailsInfo));
        }
        public ArrayList UnconfirmedList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsUnconfirmedList(), typeof(EmployeeDetailsInfo));
        }
        public ArrayList ConfirmedEmployeeList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsConfirmedEmployeeList(), typeof(EmployeeDetailsInfo));
        }

        public ArrayList QualifUnApprovedList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsQualifUnApprovedList(), typeof(EmployeeDetailsInfo));
        }
        public ArrayList ProfQualifUnApprovedList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsProfQualifUnApprovedList(), typeof(EmployeeDetailsInfo));
        }
        public ArrayList DocUnApprovedList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsDocUnApprovedList(), typeof(EmployeeDetailsInfo));
        }


        public ArrayList GetByApplicantPersonalDetails(int applicantID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByApplicantPersonalDetails(applicantID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetByCountryTable(int countryID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByCountryTable(countryID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByEmployeeDepartmentTable(deptID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetByEmployeeLevel(int levelID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByEmployeeLevel(levelID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetByEmployeePositionTable(int positionID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByEmployeePositionTable(positionID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetByEmployeeWorkLocations(int workLocationID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByEmployeeWorkLocations(workLocationID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetByLGATable(int lgaID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByLGATable(lgaID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetByStateTable(int stateID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByStateTable(stateID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetBySupervisor(int supervisorID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetBySupervisor(supervisorID), typeof(EmployeeDetailsInfo));
        }

        public EmployeeDetailsInfo GetByUserID(int userID)
        {
            return (EmployeeDetailsInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeDetailsGetByUserID(userID), typeof(EmployeeDetailsInfo));
        }

        //public EmployeeDetailsInfo GetBySupervisor(int supervisorID)
        //{
        //    return (EmployeeDetailsInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeDetailsGetBySupervisor(supervisorID), typeof(EmployeeDetailsInfo));
        //}


        public int Add(EmployeeDetailsInfo objEmployeeDetails)
        {
            return (int)DataProvider.Instance().EmployeeDetailsAdd(objEmployeeDetails.EmployeeNum, objEmployeeDetails.Title, objEmployeeDetails.FirstName, objEmployeeDetails.MiiddleName, objEmployeeDetails.LastName, objEmployeeDetails.Gender, objEmployeeDetails.DateOfBirth, objEmployeeDetails.Age, objEmployeeDetails.MaritalStatus, objEmployeeDetails.Nationality_FK, objEmployeeDetails.StateOfOrigin_FK, objEmployeeDetails.LGA_FK, objEmployeeDetails.HomeTown, objEmployeeDetails.PhoneNo, objEmployeeDetails.Email, objEmployeeDetails.ContactAddress, objEmployeeDetails.Religion, objEmployeeDetails.Passport, objEmployeeDetails.AccountName, objEmployeeDetails.AccountNo, objEmployeeDetails.BankName, objEmployeeDetails.Department_FK, objEmployeeDetails.PositionHeld_FK, objEmployeeDetails.EmployeeLevel_FK, objEmployeeDetails.WorkLocation_FK, objEmployeeDetails.ConfirmationDate, objEmployeeDetails.ConfirmedBy, objEmployeeDetails.EmployeeStatus, objEmployeeDetails.StartDate, objEmployeeDetails.NxtOfKinFName, objEmployeeDetails.NxtOfKinMidName, objEmployeeDetails.NxtOfKinLName, objEmployeeDetails.NxtOfKinAddress, objEmployeeDetails.NxtOfKinPhoneNo, objEmployeeDetails.NxtOfKinEmail, objEmployeeDetails.NxtOfKinOccupation, objEmployeeDetails.NxtOfKinRelationship, objEmployeeDetails.SpouseNames, objEmployeeDetails.SpouseAddress, objEmployeeDetails.SpousePhoneNo, objEmployeeDetails.SpouseEmail, objEmployeeDetails.SpouseOccupation, objEmployeeDetails.SpouseEmployerNames, objEmployeeDetails.Refree1Names, objEmployeeDetails.Refree1Occupation, objEmployeeDetails.Refree1PhoneNum, objEmployeeDetails.Refree1Email, objEmployeeDetails.Refree1ContactAddr, objEmployeeDetails.Refree2Names, objEmployeeDetails.Refree2Occupation, objEmployeeDetails.Refree2PhoneNum, objEmployeeDetails.Refree2Email, objEmployeeDetails.Refree2ContactAddr, objEmployeeDetails.GuarrantorNames, objEmployeeDetails.GuarrantorFormPath, objEmployeeDetails.ApplicantID_FK);
        }
        //public int Add(EmployeeDetailsInfo objEmployeeDetails)
        //{
        //    return (int)DataProvider.Instance().EmployeeDetailsAdd(objEmployeeDetails.EmployeeNum, objEmployeeDetails.Title, objEmployeeDetails.FirstName, objEmployeeDetails.MiiddleName, objEmployeeDetails.LastName, objEmployeeDetails.Gender, objEmployeeDetails.DateOfBirth, objEmployeeDetails.Age, objEmployeeDetails.MaritalStatus, objEmployeeDetails.Nationality_FK, objEmployeeDetails.StateOfOrigin_FK, objEmployeeDetails.LGA_FK, objEmployeeDetails.HomeTown, objEmployeeDetails.PhoneNo, objEmployeeDetails.Email, objEmployeeDetails.ContactAddress, objEmployeeDetails.Religion, objEmployeeDetails.Passport, objEmployeeDetails.AccountName, objEmployeeDetails.AccountNo, objEmployeeDetails.BankName, objEmployeeDetails.Department_FK, objEmployeeDetails.PositionHeld_FK, objEmployeeDetails.EmployeeLevel_FK, objEmployeeDetails.WorkLocation_FK, objEmployeeDetails.ConfirmationDate, objEmployeeDetails.ConfirmedBy, objEmployeeDetails.EmployeeStatus, objEmployeeDetails.StartDate, objEmployeeDetails.NxtOfKinFName, objEmployeeDetails.NxtOfKinMidName, objEmployeeDetails.NxtOfKinLName, objEmployeeDetails.NxtOfKinAddress, objEmployeeDetails.NxtOfKinPhoneNo, objEmployeeDetails.NxtOfKinEmail, objEmployeeDetails.NxtOfKinOccupation, objEmployeeDetails.NxtOfKinRelationship, objEmployeeDetails.SpouseNames, objEmployeeDetails.SpouseAddress, objEmployeeDetails.SpousePhoneNo, objEmployeeDetails.SpouseOccupation, objEmployeeDetails.SpouseEmployerNames, objEmployeeDetails.Refree1Names, objEmployeeDetails.Refree1Occupation, objEmployeeDetails.Refree1PhoneNum, objEmployeeDetails.Refree1Email, objEmployeeDetails.Refree1ContactAddr, objEmployeeDetails.Refree2Names, objEmployeeDetails.Refree2Occupation, objEmployeeDetails.Refree2PhoneNum, objEmployeeDetails.Refree2Email, objEmployeeDetails.Refree2ContactAddr, objEmployeeDetails.GuarrantorNames, objEmployeeDetails.GuarrantorFormPath, objEmployeeDetails.ApplicantID_FK, objEmployeeDetails.EmployeeUserID_FK);
        //}
        public void Update(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.EmployeeNum, objEmployeeDetails.Title, objEmployeeDetails.FirstName, objEmployeeDetails.MiiddleName, objEmployeeDetails.LastName, objEmployeeDetails.Gender, objEmployeeDetails.DateOfBirth, objEmployeeDetails.Age, objEmployeeDetails.MaritalStatus, objEmployeeDetails.Nationality_FK, objEmployeeDetails.StateOfOrigin_FK, objEmployeeDetails.LGA_FK, objEmployeeDetails.HomeTown, objEmployeeDetails.PhoneNo, objEmployeeDetails.Email, objEmployeeDetails.ContactAddress, objEmployeeDetails.Religion, objEmployeeDetails.Passport, objEmployeeDetails.AccountName, objEmployeeDetails.AccountNo, objEmployeeDetails.BankName, objEmployeeDetails.Department_FK, objEmployeeDetails.PositionHeld_FK, objEmployeeDetails.EmployeeLevel_FK, objEmployeeDetails.WorkLocation_FK, objEmployeeDetails.ConfirmationDate, objEmployeeDetails.ConfirmedBy, objEmployeeDetails.EmployeeStatus, objEmployeeDetails.StartDate, objEmployeeDetails.NxtOfKinFName, objEmployeeDetails.NxtOfKinMidName, objEmployeeDetails.NxtOfKinLName, objEmployeeDetails.NxtOfKinAddress, objEmployeeDetails.NxtOfKinPhoneNo, objEmployeeDetails.NxtOfKinEmail, objEmployeeDetails.NxtOfKinOccupation, objEmployeeDetails.NxtOfKinRelationship, objEmployeeDetails.SpouseNames, objEmployeeDetails.SpouseAddress, objEmployeeDetails.SpousePhoneNo, objEmployeeDetails.SpouseEmail, objEmployeeDetails.SpouseOccupation, objEmployeeDetails.SpouseEmployerNames, objEmployeeDetails.Refree1Names, objEmployeeDetails.Refree1Occupation, objEmployeeDetails.Refree1PhoneNum, objEmployeeDetails.Refree1Email, objEmployeeDetails.Refree1ContactAddr, objEmployeeDetails.Refree2Names, objEmployeeDetails.Refree2Occupation, objEmployeeDetails.Refree2PhoneNum, objEmployeeDetails.Refree2Email, objEmployeeDetails.Refree2ContactAddr, objEmployeeDetails.GuarrantorNames, objEmployeeDetails.GuarrantorFormPath, objEmployeeDetails.ApplicantID_FK, objEmployeeDetails.EmployeeUserID_FK);
        }

        //public void Update(EmployeeDetailsInfo objEmployeeDetails)
        //{
        //    DataProvider.Instance().EmployeeDetailsUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.EmployeeNum, objEmployeeDetails.Title, objEmployeeDetails.FirstName, objEmployeeDetails.MiiddleName, objEmployeeDetails.LastName, objEmployeeDetails.Gender, objEmployeeDetails.DateOfBirth, objEmployeeDetails.Age, objEmployeeDetails.MaritalStatus, objEmployeeDetails.Nationality_FK, objEmployeeDetails.StateOfOrigin_FK, objEmployeeDetails.LGA_FK, objEmployeeDetails.HomeTown, objEmployeeDetails.PhoneNo, objEmployeeDetails.Email, objEmployeeDetails.ContactAddress, objEmployeeDetails.Religion, objEmployeeDetails.Passport, objEmployeeDetails.AccountName, objEmployeeDetails.AccountNo, objEmployeeDetails.BankName, objEmployeeDetails.Department_FK, objEmployeeDetails.PositionHeld_FK, objEmployeeDetails.EmployeeLevel_FK, objEmployeeDetails.WorkLocation_FK, objEmployeeDetails.ConfirmationDate, objEmployeeDetails.ConfirmedBy, objEmployeeDetails.EmployeeStatus, objEmployeeDetails.StartDate, objEmployeeDetails.NxtOfKinFName, objEmployeeDetails.NxtOfKinMidName, objEmployeeDetails.NxtOfKinLName, objEmployeeDetails.NxtOfKinAddress, objEmployeeDetails.NxtOfKinPhoneNo, objEmployeeDetails.NxtOfKinEmail, objEmployeeDetails.NxtOfKinOccupation, objEmployeeDetails.NxtOfKinRelationship, objEmployeeDetails.SpouseNames, objEmployeeDetails.SpouseAddress, objEmployeeDetails.SpousePhoneNo, objEmployeeDetails.SpouseEmail, objEmployeeDetails.SpouseOccupation, objEmployeeDetails.SpouseEmployerNames, objEmployeeDetails.Refree1Names, objEmployeeDetails.Refree1Occupation, objEmployeeDetails.Refree1PhoneNum, objEmployeeDetails.Refree1Email, objEmployeeDetails.Refree1ContactAddr, objEmployeeDetails.Refree2Names, objEmployeeDetails.Refree2Occupation, objEmployeeDetails.Refree2PhoneNum, objEmployeeDetails.Refree2Email, objEmployeeDetails.Refree2ContactAddr, objEmployeeDetails.GuarrantorNames, objEmployeeDetails.GuarrantorFormPath, objEmployeeDetails.ApplicantID_FK, objEmployeeDetails.EmployeeUserID_FK);
        //}

        public void UpdateEmployeeNum(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsUpdateEmployeeNum(objEmployeeDetails.EmployeeID, objEmployeeDetails.EmployeeNum);
        }

        public void UpdateEmployeeUserID(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsUpdateEmployeeUserID(objEmployeeDetails.EmployeeID, objEmployeeDetails.EmployeeUserID_FK);
        }


        public void NextOfKinUpdate(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsNextOfKinUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.NxtOfKinFName, objEmployeeDetails.NxtOfKinMidName, objEmployeeDetails.NxtOfKinLName, objEmployeeDetails.NxtOfKinAddress, objEmployeeDetails.NxtOfKinPhoneNo, objEmployeeDetails.NxtOfKinEmail, objEmployeeDetails.NxtOfKinOccupation, objEmployeeDetails.NxtOfKinRelationship, objEmployeeDetails.EmployeeUserID_FK);
        }

        public void SpouseUpdate(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsSpouseUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.SpouseNames, objEmployeeDetails.SpouseAddress, objEmployeeDetails.SpousePhoneNo, objEmployeeDetails.SpouseEmail, objEmployeeDetails.SpouseOccupation, objEmployeeDetails.SpouseEmployerNames, objEmployeeDetails.EmployeeUserID_FK);
        }

        public void RefereeUpdate(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsRefereeUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.Refree1Names, objEmployeeDetails.Refree1Occupation, objEmployeeDetails.Refree1PhoneNum, objEmployeeDetails.Refree1Email, objEmployeeDetails.Refree1ContactAddr, objEmployeeDetails.Refree2Names, objEmployeeDetails.Refree2Occupation, objEmployeeDetails.Refree2PhoneNum, objEmployeeDetails.Refree2Email, objEmployeeDetails.Refree2ContactAddr, objEmployeeDetails.EmployeeUserID_FK);
        }

        public void BankInfoUpdate(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsBankInfoUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.BankName, objEmployeeDetails.AccountName, objEmployeeDetails.AccountNo, objEmployeeDetails.EmployeeUserID_FK);
        }

        public void GuarantorUpdate(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsGuarantorUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.GuarrantorNames, objEmployeeDetails.GuarrantorFormPath, objEmployeeDetails.EmployeeUserID_FK);
        }
        public void UpdateConfirmation(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsUpdateConfirmation(objEmployeeDetails.EmployeeID, objEmployeeDetails.ConfirmationDate, objEmployeeDetails.ConfirmedBy);
        }
        public void TransferUpdate(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsTransferUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.Department_FK, objEmployeeDetails.WorkLocation_FK);
        }



        public void Delete(int employeeID)
        {
            DataProvider.Instance().EmployeeDetailsDelete(employeeID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //EmployeeQualificationTableController

    public class EmployeeQualificationTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeQualificationTableInfo Get(int qualificationID)
        {
            return (EmployeeQualificationTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeQualificationTableGet(qualificationID), typeof(EmployeeQualificationTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQualificationTableList(), typeof(EmployeeQualificationTableInfo));
        }
        public ArrayList QualificationUnApprovedList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQualificationTableUnApprovedList(), typeof(EmployeeQualificationTableInfo));
        }


        public ArrayList GetByApplicantPersonalDetails(int applicantID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQualificationTableGetByApplicantPersonalDetails(applicantID), typeof(EmployeeQualificationTableInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQualificationTableGetByEmployeeDetails(employeeID), typeof(EmployeeQualificationTableInfo));
        }
        public ArrayList QualificationUnApprovedGetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQualificationUnApprovedGetByEmployeeDetails(employeeID), typeof(EmployeeQualificationTableInfo));
        }
        public ArrayList ApprovedQualifGetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQualificationTableApprovedQualifGetByEmployeeDetails(employeeID), typeof(EmployeeQualificationTableInfo));
        }

        public int Add(EmployeeQualificationTableInfo objEmployeeQualificationTable)
        {
            return (int)DataProvider.Instance().EmployeeQualificationTableAdd(objEmployeeQualificationTable.InstitutionName, objEmployeeQualificationTable.QualificationType, objEmployeeQualificationTable.Course, objEmployeeQualificationTable.Grade, objEmployeeQualificationTable.StartYear, objEmployeeQualificationTable.EndYear, objEmployeeQualificationTable.ApplicantID_FK);
        }

        public int NewAdd(EmployeeQualificationTableInfo objEmployeeQualificationTable)
        {
            return (int)DataProvider.Instance().EmployeeQualificationTableNewAdd(objEmployeeQualificationTable.InstitutionName, objEmployeeQualificationTable.QualificationType, objEmployeeQualificationTable.Course, objEmployeeQualificationTable.Grade, objEmployeeQualificationTable.StartYear, objEmployeeQualificationTable.EndYear, objEmployeeQualificationTable.ApplicantID_FK, objEmployeeQualificationTable.EmployeeID_FK);
        }

        public void Update(EmployeeQualificationTableInfo objEmployeeQualificationTable)
        {
            DataProvider.Instance().EmployeeQualificationTableUpdate(objEmployeeQualificationTable.QualificationID, objEmployeeQualificationTable.InstitutionName, objEmployeeQualificationTable.QualificationType, objEmployeeQualificationTable.Course, objEmployeeQualificationTable.Grade, objEmployeeQualificationTable.StartYear, objEmployeeQualificationTable.EndYear, objEmployeeQualificationTable.ApplicantID_FK, objEmployeeQualificationTable.EmployeeID_FK);
        }
        public void QualificationTableEmpIDUpdate(EmployeeQualificationTableInfo objEmployeeQualificationTable)
        {
            DataProvider.Instance().EmployeeQualificationTableEmpIDUpdate(objEmployeeQualificationTable.ApplicantID_FK, objEmployeeQualificationTable.EmployeeID_FK);
        }
        public void HrApprovalUpdate(EmployeeQualificationTableInfo objEmployeeQualificationTable)
        {
            DataProvider.Instance().EmployeeQualificationTableHrApprovalUpdate(objEmployeeQualificationTable.EmployeeID_FK, objEmployeeQualificationTable.HrApproval);
        }

        public void Delete(int qualificationID)
        {
            DataProvider.Instance().EmployeeQualificationTableDelete(qualificationID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }



    //EmployeeProfQualificationTableController

    public class EmployeeProfQualificationTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeProfQualificationTableInfo Get(int profQualificationID)
        {
            return (EmployeeProfQualificationTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeProfQualificationTableGet(profQualificationID), typeof(EmployeeProfQualificationTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeProfQualificationTableList(), typeof(EmployeeProfQualificationTableInfo));
        }
        //public ArrayList ProfQualifUnApprovedList()
        //{
        //    return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsProfQualifUnApprovedList(), typeof(EmployeeProfQualificationTableInfo));
        //}


        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeProfQualificationTableGetByEmployeeDetails(employeeID), typeof(EmployeeProfQualificationTableInfo));
        }
        public ArrayList ApprovedProfQualifGetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeProfQualificationTableApprovedProfQualifGetByEmployeeDetails(employeeID), typeof(EmployeeProfQualificationTableInfo));
        }

        public ArrayList ProfQualificationUnApprovedGetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeProfQualificationUnApprovedGetByEmployeeDetails(employeeID), typeof(EmployeeProfQualificationTableInfo));
        }

        public ArrayList GetByApplicantPersonalDetails(int applicantID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeProfQualificationTableGetByApplicantPersonalDetails(applicantID), typeof(EmployeeProfQualificationTableInfo));
        }

        public int Add(EmployeeProfQualificationTableInfo objEmployeeProfQualificationTable)
        {
            return (int)DataProvider.Instance().EmployeeProfQualificationTableAdd(objEmployeeProfQualificationTable.CertificationName, objEmployeeProfQualificationTable.CertificateNo, objEmployeeProfQualificationTable.Stage, objEmployeeProfQualificationTable.CertYear, objEmployeeProfQualificationTable.ApplicantID_FK);
        }
        public int NewAdd(EmployeeProfQualificationTableInfo objEmployeeProfQualificationTable)
        {
            return (int)DataProvider.Instance().EmployeeProfQualificationTableNewAdd(objEmployeeProfQualificationTable.CertificationName, objEmployeeProfQualificationTable.CertificateNo, objEmployeeProfQualificationTable.Stage, objEmployeeProfQualificationTable.CertYear, objEmployeeProfQualificationTable.ApplicantID_FK, objEmployeeProfQualificationTable.employeeID_FK);
        }
        public void Update(EmployeeProfQualificationTableInfo objEmployeeProfQualificationTable)
        {
            DataProvider.Instance().EmployeeProfQualificationTableUpdate(objEmployeeProfQualificationTable.ProfQualificationID, objEmployeeProfQualificationTable.CertificationName, objEmployeeProfQualificationTable.CertificateNo, objEmployeeProfQualificationTable.Stage, objEmployeeProfQualificationTable.CertYear, objEmployeeProfQualificationTable.ApplicantID_FK, objEmployeeProfQualificationTable.employeeID_FK);
        }
        public void ProfQualificationTableEmpIDUpdate(EmployeeProfQualificationTableInfo objEmployeeProfQualificationTable)
        {
            DataProvider.Instance().EmployeeProfQualificationTableEmpIDUpdate(objEmployeeProfQualificationTable.ApplicantID_FK, objEmployeeProfQualificationTable.employeeID_FK);
        }
        public void HrApprovalUpdate(EmployeeProfQualificationTableInfo objEmployeeProfQualificationTable)
        {
            DataProvider.Instance().EmployeeProfQualificationTableHrApprovalUpdate(objEmployeeProfQualificationTable.employeeID_FK, objEmployeeProfQualificationTable.HrApproval);
        }

        public void Delete(int profQualificationID)
        {
            DataProvider.Instance().EmployeeProfQualificationTableDelete(profQualificationID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //EmployeeDocumentTableController

    public class EmployeeDocumentTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeDocumentTableInfo Get(int documentID)
        {
            return (EmployeeDocumentTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeDocumentTableGet(documentID), typeof(EmployeeDocumentTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDocumentTableList(), typeof(EmployeeDocumentTableInfo));
        }
        //public ArrayList DocUnApprovedList()
        //{
        //    return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsDocUnApprovedList(), typeof(EmployeeDocumentTableInfo));
        //}

        public ArrayList GetByApplicantPersonalDetails(int applicantID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDocumentTableGetByApplicantPersonalDetails(applicantID), typeof(EmployeeDocumentTableInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDocumentTableGetByEmployeeDetails(employeeID), typeof(EmployeeDocumentTableInfo));
        }
        public ArrayList ApprovedDocGetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDocumentTableApprovedDocGetByEmployeeDetails(employeeID), typeof(EmployeeDocumentTableInfo));
        }

        public ArrayList DocumentUnApprovedGetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDocumentUnApprovedGetByEmployeeDetails(employeeID), typeof(EmployeeDocumentTableInfo));
        }

        public int Add(EmployeeDocumentTableInfo objEmployeeDocumentTable)
        {
            return (int)DataProvider.Instance().EmployeeDocumentTableAdd(objEmployeeDocumentTable.DocumentType, objEmployeeDocumentTable.DocumentPath, objEmployeeDocumentTable.ApplicantID_FK);
        }
        public int NewAdd(EmployeeDocumentTableInfo objEmployeeDocumentTable)
        {
            return (int)DataProvider.Instance().EmployeeDocumentTableNewAdd(objEmployeeDocumentTable.DocumentType, objEmployeeDocumentTable.DocumentPath, objEmployeeDocumentTable.ApplicantID_FK, objEmployeeDocumentTable.EmployeeID_Fk);
        }

        public void Update(EmployeeDocumentTableInfo objEmployeeDocumentTable)
        {
            DataProvider.Instance().EmployeeDocumentTableUpdate(objEmployeeDocumentTable.DocumentID, objEmployeeDocumentTable.DocumentType, objEmployeeDocumentTable.DocumentPath, objEmployeeDocumentTable.ApplicantID_FK, objEmployeeDocumentTable.EmployeeID_Fk);
        }
        public void DocumentTableEmpIDUpdate(EmployeeDocumentTableInfo objEmployeeDocumentTable)
        {
            DataProvider.Instance().EmployeeDocumentTableEmpIDUpdate(objEmployeeDocumentTable.ApplicantID_FK, objEmployeeDocumentTable.EmployeeID_Fk);
        }
        public void HrApprovalUpdate(EmployeeDocumentTableInfo objEmployeeDocumentTable)
        {
            DataProvider.Instance().EmployeeDocumentTableHrApprovalUpdate(objEmployeeDocumentTable.EmployeeID_Fk, objEmployeeDocumentTable.HrApproval);
        }


        public void Delete(int documentID)
        {
            DataProvider.Instance().EmployeeDocumentTableDelete(documentID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //EmployeeTransferTable Controller

    public class EmployeeTransferTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeTransferTableInfo Get(int transferID)
        {
            return (EmployeeTransferTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeTransferTableGet(transferID), typeof(EmployeeTransferTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableList(), typeof(EmployeeTransferTableInfo));
        }

        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableGetByEmployeeDepartmentTable(deptID), typeof(EmployeeTransferTableInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableGetByEmployeeDetails(employeeID), typeof(EmployeeTransferTableInfo));
        }
        public ArrayList GetByEmployeeWorkLocations(int workLocationID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableGetByEmployeeWorkLocations(workLocationID), typeof(EmployeeTransferTableInfo));
        }
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableGetByUsers(userID), typeof(EmployeeTransferTableInfo));
        }

        public int Add(EmployeeTransferTableInfo objEmployeeTransferTable)
        {
            return (int)DataProvider.Instance().EmployeeTransferTableAdd(objEmployeeTransferTable.PreviousDept, objEmployeeTransferTable.NewDept, objEmployeeTransferTable.PrevWorkLocation, objEmployeeTransferTable.NewWorkLcation, objEmployeeTransferTable.EmployeeID_FK, objEmployeeTransferTable.TransferDate, objEmployeeTransferTable.TransferedBy);
        }

        public void Update(EmployeeTransferTableInfo objEmployeeTransferTable)
        {
            DataProvider.Instance().EmployeeTransferTableUpdate(objEmployeeTransferTable.TransferID, objEmployeeTransferTable.PreviousDept, objEmployeeTransferTable.NewDept, objEmployeeTransferTable.PrevWorkLocation, objEmployeeTransferTable.NewWorkLcation, objEmployeeTransferTable.EmployeeID_FK, objEmployeeTransferTable.TransferDate, objEmployeeTransferTable.TransferedBy);
        }

        public void Delete(int transferID)
        {
            DataProvider.Instance().EmployeeTransferTableDelete(transferID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }



    //EmployeeQueryTable  Controller
    public class EmployeeQueryTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeQueryTableInfo Get(int queryID)
        {
            return (EmployeeQueryTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeQueryTableGet(queryID), typeof(EmployeeQueryTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQueryTableList(), typeof(EmployeeQueryTableInfo));
        }

        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQueryTableGetByEmployeeDetails(employeeID), typeof(EmployeeQueryTableInfo));
        }
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQueryTableGetByUsers(userID), typeof(EmployeeQueryTableInfo));
        }

        public int Add(EmployeeQueryTableInfo objEmployeeQueryTable)
        {
            return (int)DataProvider.Instance().EmployeeQueryTableAdd(objEmployeeQueryTable.QueryTitle, objEmployeeQueryTable.Description, objEmployeeQueryTable.QueryReceivedBy, objEmployeeQueryTable.IssueDate, objEmployeeQueryTable.QueryIssuedBy, objEmployeeQueryTable.QueryLetter, objEmployeeQueryTable.EmployeeResponse, objEmployeeQueryTable.ResponseDate, objEmployeeQueryTable.EmpResponseLetter, objEmployeeQueryTable.DiscipliineType_FK, objEmployeeQueryTable.DisciplineDetails, objEmployeeQueryTable.DisciplineLetter, objEmployeeQueryTable.DisciplineDate, objEmployeeQueryTable.DisciplinedBy);
        }
        // sending query  (string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter)
        public int AddQuery(EmployeeQueryTableInfo objEmployeeQueryTable)
        {
            return (int)DataProvider.Instance().EmployeeQueryTableAddQuery(objEmployeeQueryTable.QueryTitle, objEmployeeQueryTable.Description, objEmployeeQueryTable.QueryReceivedBy, objEmployeeQueryTable.IssueDate, objEmployeeQueryTable.QueryIssuedBy, objEmployeeQueryTable.QueryLetter);
        }
        
        
        public void Update(EmployeeQueryTableInfo objEmployeeQueryTable)
        {
            DataProvider.Instance().EmployeeQueryTableUpdate(objEmployeeQueryTable.QueryID, objEmployeeQueryTable.QueryTitle, objEmployeeQueryTable.Description, objEmployeeQueryTable.QueryReceivedBy, objEmployeeQueryTable.IssueDate, objEmployeeQueryTable.QueryIssuedBy, objEmployeeQueryTable.QueryLetter, objEmployeeQueryTable.EmployeeResponse, objEmployeeQueryTable.ResponseDate, objEmployeeQueryTable.EmpResponseLetter, objEmployeeQueryTable.DiscipliineType_FK, objEmployeeQueryTable.DisciplineDetails, objEmployeeQueryTable.DisciplineLetter, objEmployeeQueryTable.DisciplineDate, objEmployeeQueryTable.DisciplinedBy);
        }

        // update Query  Response 

        public void UpdateQueryResponse(EmployeeQueryTableInfo objEmployeeQueryTable) 
        {
            DataProvider.Instance().EmployeeQueryTableUpdateQueryResponse(objEmployeeQueryTable.QueryID, objEmployeeQueryTable.EmployeeResponse, objEmployeeQueryTable.ResponseDate, objEmployeeQueryTable.EmpResponseLetter);
        }

        // update query discipline EmployeeQueryTableUpdateQueryDiscipline
        public void UpdateQueryDiscipline(EmployeeQueryTableInfo objEmployeeQueryTable)
        {
            DataProvider.Instance().EmployeeQueryTableUpdateQueryDiscipline(objEmployeeQueryTable.QueryID, objEmployeeQueryTable.DiscipliineType_FK, objEmployeeQueryTable.DisciplineDetails, objEmployeeQueryTable.DisciplineLetter, objEmployeeQueryTable.DisciplineDate, objEmployeeQueryTable.DisciplinedBy);
        }
        public void Delete(int queryID)
        {
            DataProvider.Instance().EmployeeQueryTableDelete(queryID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //EmployeeDisciplineTableController
    public class EmployeeDisciplineTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeDisciplineTableInfo Get(int disciplineID)
        {
            return (EmployeeDisciplineTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeDisciplineTableGet(disciplineID), typeof(EmployeeDisciplineTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDisciplineTableList(), typeof(EmployeeDisciplineTableInfo));
        }


        public int Add(EmployeeDisciplineTableInfo objEmployeeDisciplineTable)
        {
            return (int)DataProvider.Instance().EmployeeDisciplineTableAdd(objEmployeeDisciplineTable.DiscplineDescription);
        }

        public void Update(EmployeeDisciplineTableInfo objEmployeeDisciplineTable)
        {
            DataProvider.Instance().EmployeeDisciplineTableUpdate(objEmployeeDisciplineTable.DisciplineID, objEmployeeDisciplineTable.DiscplineDescription);
        }

        public void Delete(int disciplineID)
        {
            DataProvider.Instance().EmployeeDisciplineTableDelete(disciplineID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //EmployeeTypeOfLeaveTableController
    public class EmployeeTypeOfLeaveTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeTypeOfLeaveTableInfo Get(int leaveTypeID)
        {
            return (EmployeeTypeOfLeaveTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeTypeOfLeaveTableGet(leaveTypeID), typeof(EmployeeTypeOfLeaveTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTypeOfLeaveTableList(), typeof(EmployeeTypeOfLeaveTableInfo));
        }


        public int Add(EmployeeTypeOfLeaveTableInfo objEmployeeTypeOfLeaveTable)
        {
            return (int)DataProvider.Instance().EmployeeTypeOfLeaveTableAdd(objEmployeeTypeOfLeaveTable.LeaveTypeName);
        }

        public void Update(EmployeeTypeOfLeaveTableInfo objEmployeeTypeOfLeaveTable)
        {
            DataProvider.Instance().EmployeeTypeOfLeaveTableUpdate(objEmployeeTypeOfLeaveTable.LeaveTypeID, objEmployeeTypeOfLeaveTable.LeaveTypeName);
        }

        public void Delete(int leaveTypeID)
        {
            DataProvider.Instance().EmployeeTypeOfLeaveTableDelete(leaveTypeID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

   
    
    //EmployeeLeaveTableController


    public class EmployeeLeaveTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeLeaveTableInfo Get(int leaveID)
        {
            return (EmployeeLeaveTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeLeaveTableGet(leaveID), typeof(EmployeeLeaveTableInfo));
        }

        // get leave details for an employee EmployeeLeaveTableGetForAnEmployee
        public EmployeeLeaveTableInfo GetForAnEmployee(int employeeID)
        {
            return (EmployeeLeaveTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeLeaveTableGetForAnEmployee(employeeID), typeof(EmployeeLeaveTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableList(), typeof(EmployeeLeaveTableInfo));
        }

        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableGetByEmployeeDepartmentTable(deptID), typeof(EmployeeLeaveTableInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableGetByEmployeeDetails(employeeID), typeof(EmployeeLeaveTableInfo));
        }
        public ArrayList GetByEmployeeLevelTable(int levelID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableGetByEmployeeLevelTable(levelID), typeof(EmployeeLeaveTableInfo));
        }
        public ArrayList GetByEmployeeTypeOfLeaveTable(int leaveTypeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableGetByEmployeeTypeOfLeaveTable(leaveTypeID), typeof(EmployeeLeaveTableInfo));
        }
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableGetByUsers(userID), typeof(EmployeeLeaveTableInfo));
        }

        public int Add(EmployeeLeaveTableInfo objEmployeeLeaveTable)
        {
            return (int)DataProvider.Instance().EmployeeLeaveTableAdd(objEmployeeLeaveTable.LeaveType_FK, objEmployeeLeaveTable.LeaveDescription, objEmployeeLeaveTable.StartDate, objEmployeeLeaveTable.EndDate, objEmployeeLeaveTable.Duration, objEmployeeLeaveTable.Level_FK, objEmployeeLeaveTable.LeaveThreshold, objEmployeeLeaveTable.DateApplied, objEmployeeLeaveTable.LeaveStatus, objEmployeeLeaveTable.LeaveGrantedBy, objEmployeeLeaveTable.DateGranted, objEmployeeLeaveTable.ApproveOrDisapproveReason, objEmployeeLeaveTable.Dept_FK, objEmployeeLeaveTable.EmployeeID_FK);
        }

        // Saving employee leave application  
        public int AddLeaveApplication(EmployeeLeaveTableInfo objEmployeeLeaveTable)
        {
            return (int)DataProvider.Instance().EmployeeLeaveTableAddLeaveApplication(objEmployeeLeaveTable.LeaveType_FK, objEmployeeLeaveTable.LeaveDescription, objEmployeeLeaveTable.StartDate, objEmployeeLeaveTable.EndDate, objEmployeeLeaveTable.Duration, objEmployeeLeaveTable.Level_FK, objEmployeeLeaveTable.LeaveThreshold, objEmployeeLeaveTable.DateApplied, objEmployeeLeaveTable.Dept_FK, objEmployeeLeaveTable.EmployeeID_FK);
        }
        public void Update(EmployeeLeaveTableInfo objEmployeeLeaveTable)
        {
            DataProvider.Instance().EmployeeLeaveTableUpdate(objEmployeeLeaveTable.LeaveID, objEmployeeLeaveTable.LeaveType_FK, objEmployeeLeaveTable.LeaveDescription, objEmployeeLeaveTable.StartDate, objEmployeeLeaveTable.EndDate, objEmployeeLeaveTable.Duration, objEmployeeLeaveTable.Level_FK, objEmployeeLeaveTable.LeaveThreshold, objEmployeeLeaveTable.DateApplied, objEmployeeLeaveTable.LeaveStatus, objEmployeeLeaveTable.LeaveGrantedBy, objEmployeeLeaveTable.DateGranted, objEmployeeLeaveTable.ApproveOrDisapproveReason, objEmployeeLeaveTable.Dept_FK, objEmployeeLeaveTable.EmployeeID_FK);
        }
        //upade employee application EmployeeLeaveTableUpdateLeaveApplication
        public void UpdateLeaveApplication(EmployeeLeaveTableInfo objEmployeeLeaveTable)
        {
            DataProvider.Instance().EmployeeLeaveTableUpdateLeaveApplication( objEmployeeLeaveTable.LeaveType_FK, objEmployeeLeaveTable.LeaveDescription, objEmployeeLeaveTable.StartDate, objEmployeeLeaveTable.EndDate, objEmployeeLeaveTable.Duration, objEmployeeLeaveTable.Level_FK, objEmployeeLeaveTable.LeaveThreshold, objEmployeeLeaveTable.DateApplied, objEmployeeLeaveTable.Dept_FK, objEmployeeLeaveTable.EmployeeID_FK);
        }
        public void Delete(int leaveID)
        {
            DataProvider.Instance().EmployeeLeaveTableDelete(leaveID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }
   
    
   // EmployeeLeaveTableLog  Controller
    public class EmployeeLeaveTableLogController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeLeaveTableLogInfo Get(int leaveLogID)
        {
            return (EmployeeLeaveTableLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeLeaveTableLogGet(leaveLogID), typeof(EmployeeLeaveTableLogInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogList(), typeof(EmployeeLeaveTableLogInfo));
        }

        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogGetByEmployeeDepartmentTable(deptID), typeof(EmployeeLeaveTableLogInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogGetByEmployeeDetails(employeeID), typeof(EmployeeLeaveTableLogInfo));
        }
        public ArrayList GetByEmployeeLeaveTable(int leaveID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogGetByEmployeeLeaveTable(leaveID), typeof(EmployeeLeaveTableLogInfo));
        }
        public ArrayList GetByEmployeeLevelTable(int levelID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogGetByEmployeeLevelTable(levelID), typeof(EmployeeLeaveTableLogInfo));
        }
        public ArrayList GetByEmployeeTypeOfLeaveTable(int leaveTypeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogGetByEmployeeTypeOfLeaveTable(leaveTypeID), typeof(EmployeeLeaveTableLogInfo));
        }
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogGetByUsers(userID), typeof(EmployeeLeaveTableLogInfo));
        }

        public int Add(EmployeeLeaveTableLogInfo objEmployeeLeaveTableLog)
        {
            return (int)DataProvider.Instance().EmployeeLeaveTableLogAdd(objEmployeeLeaveTableLog.LeaveType_FK, objEmployeeLeaveTableLog.LeaveDescription, objEmployeeLeaveTableLog.StartDate, objEmployeeLeaveTableLog.EndDate, objEmployeeLeaveTableLog.Duration, objEmployeeLeaveTableLog.Level_FK, objEmployeeLeaveTableLog.LeaveThreshold, objEmployeeLeaveTableLog.DateApplied, objEmployeeLeaveTableLog.LeaveStatus, objEmployeeLeaveTableLog.LeaveGrantedBy, objEmployeeLeaveTableLog.DateGranted, objEmployeeLeaveTableLog.ApproveOrDisapproveReason, objEmployeeLeaveTableLog.Dept_FK, objEmployeeLeaveTableLog.EmployeeID_FK, objEmployeeLeaveTableLog.LeaveID_FK);
        }


        // Saving employee leave application  in log table
        public int AddLeaveApplication(EmployeeLeaveTableLogInfo objEmployeeLeaveTable)
        {
            return (int)DataProvider.Instance().EmployeeLeaveTableLogAddLeaveApplication(objEmployeeLeaveTable.LeaveType_FK, objEmployeeLeaveTable.LeaveDescription, objEmployeeLeaveTable.StartDate, objEmployeeLeaveTable.EndDate, objEmployeeLeaveTable.Duration, objEmployeeLeaveTable.Level_FK, objEmployeeLeaveTable.LeaveThreshold, objEmployeeLeaveTable.DateApplied, objEmployeeLeaveTable.Dept_FK, objEmployeeLeaveTable.EmployeeID_FK, objEmployeeLeaveTable.LeaveID_FK);
        }
        public void Update(EmployeeLeaveTableLogInfo objEmployeeLeaveTableLog)
        {
            DataProvider.Instance().EmployeeLeaveTableLogUpdate(objEmployeeLeaveTableLog.LeaveLogID, objEmployeeLeaveTableLog.LeaveType_FK, objEmployeeLeaveTableLog.LeaveDescription, objEmployeeLeaveTableLog.StartDate, objEmployeeLeaveTableLog.EndDate, objEmployeeLeaveTableLog.Duration, objEmployeeLeaveTableLog.Level_FK, objEmployeeLeaveTableLog.LeaveThreshold, objEmployeeLeaveTableLog.DateApplied, objEmployeeLeaveTableLog.LeaveStatus, objEmployeeLeaveTableLog.LeaveGrantedBy, objEmployeeLeaveTableLog.DateGranted, objEmployeeLeaveTableLog.ApproveOrDisapproveReason, objEmployeeLeaveTableLog.Dept_FK, objEmployeeLeaveTableLog.EmployeeID_FK, objEmployeeLeaveTableLog.LeaveID_FK);
        }

        public void Delete(int leaveLogID)
        {
            DataProvider.Instance().EmployeeLeaveTableLogDelete(leaveLogID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }






    //public class EmployeeLeaveTableLogController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    //{
    //    #region "Public Methods"
    //    public EmployeeLeaveTableLogInfo Get(int leaveID)
    //    {
    //        return (EmployeeLeaveTableLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeLeaveTableLogGet(leaveID), typeof(EmployeeLeaveTableLogInfo));
    //    }

    //    public ArrayList List()
    //    {
    //        return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogList(), typeof(EmployeeLeaveTableLogInfo));
    //    }

    //    public ArrayList GetByEmployeeDepartmentTable(int deptID)
    //    {
    //        return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogGetByEmployeeDepartmentTable(deptID), typeof(EmployeeLeaveTableLogInfo));
    //    }
    //    public ArrayList GetByEmployeeDetails(int employeeID)
    //    {
    //        return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogGetByEmployeeDetails(employeeID), typeof(EmployeeLeaveTableLogInfo));
    //    }
    //    public ArrayList GetByEmployeeLevelTable(int levelID)
    //    {
    //        return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogGetByEmployeeLevelTable(levelID), typeof(EmployeeLeaveTableLogInfo));
    //    }
    //    public ArrayList GetByEmployeeTypeOfLeaveTable(int leaveTypeID)
    //    {
    //        return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogGetByEmployeeTypeOfLeaveTable(leaveTypeID), typeof(EmployeeLeaveTableLogInfo));
    //    }
    //    public ArrayList GetByUsers(int userID)
    //    {
    //        return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogGetByUsers(userID), typeof(EmployeeLeaveTableLogInfo));
    //    }

    //    public int Add(EmployeeLeaveTableLogInfo objEmployeeLeaveTableLog)
    //    {
    //        return (int)DataProvider.Instance().EmployeeLeaveTableLogAdd(objEmployeeLeaveTableLog.LeaveType_FK, objEmployeeLeaveTableLog.LeaveDescription, objEmployeeLeaveTableLog.StartDate, objEmployeeLeaveTableLog.EndDate, objEmployeeLeaveTableLog.Duration, objEmployeeLeaveTableLog.Level_FK, objEmployeeLeaveTableLog.LeaveThreshold, objEmployeeLeaveTableLog.DateApplied, objEmployeeLeaveTableLog.LeaveStatus, objEmployeeLeaveTableLog.LeaveGrantedBy, objEmployeeLeaveTableLog.DateGranted, objEmployeeLeaveTableLog.ApproveOrDisapproveReason, objEmployeeLeaveTableLog.Dept_FK, objEmployeeLeaveTableLog.EmployeeID_FK);
    //    }

    //    // Saving employee leave application  in log table
    //    public int AddLeaveApplication(EmployeeLeaveTableLogInfo objEmployeeLeaveTable)
    //    {
    //        return (int)DataProvider.Instance().EmployeeLeaveTableLogAddLeaveApplication(objEmployeeLeaveTable.LeaveType_FK, objEmployeeLeaveTable.LeaveDescription, objEmployeeLeaveTable.StartDate, objEmployeeLeaveTable.EndDate, objEmployeeLeaveTable.Duration, objEmployeeLeaveTable.Level_FK, objEmployeeLeaveTable.LeaveThreshold, objEmployeeLeaveTable.DateApplied, objEmployeeLeaveTable.Dept_FK, objEmployeeLeaveTable.EmployeeID_FK);
    //    }
    //    public void Update(EmployeeLeaveTableLogInfo objEmployeeLeaveTableLog)
    //    {
    //        DataProvider.Instance().EmployeeLeaveTableLogUpdate(objEmployeeLeaveTableLog.LeaveID, objEmployeeLeaveTableLog.LeaveType_FK, objEmployeeLeaveTableLog.LeaveDescription, objEmployeeLeaveTableLog.StartDate, objEmployeeLeaveTableLog.EndDate, objEmployeeLeaveTableLog.Duration, objEmployeeLeaveTableLog.Level_FK, objEmployeeLeaveTableLog.LeaveThreshold, objEmployeeLeaveTableLog.DateApplied, objEmployeeLeaveTableLog.LeaveStatus, objEmployeeLeaveTableLog.LeaveGrantedBy, objEmployeeLeaveTableLog.DateGranted, objEmployeeLeaveTableLog.ApproveOrDisapproveReason, objEmployeeLeaveTableLog.Dept_FK, objEmployeeLeaveTableLog.EmployeeID_FK);
    //    }

    //    public void Delete(int leaveID)
    //    {
    //        DataProvider.Instance().EmployeeLeaveTableLogDelete(leaveID);
    //    }
    //    #endregion

    //    #region "Optional Interfaces"
    //    public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
    //    {
    //        return null;
    //    }

    //    public string ExportModule(int ModuleID)
    //    {
    //        return "";
    //    }

    //    public void ImportModule(int ModuleID, string Content, string Version, int UserId)
    //    {
    //    }
    //    #endregion
    //}
}



