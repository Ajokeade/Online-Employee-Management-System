using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DotNetNuke;
using DotNetNuke.Framework;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Framework.Providers;
using Bilikis.HRManagementSystem;
/// <summary>
/// Summary description for SqlDataProvider
/// </summary>
namespace Bilikis.HRManagementSystem
{
    public class SqlDataProvider : DataProvider
    {
        //public SqlDataProvider()
        //{
        //    //
        //    // TODO: Add constructor logic here
        //    //


        //    // country table



        //}

        #region Private Members
        private const string ProviderType = "data";
        private const string ModuleQualifier = "YourCompany_";
        private ProviderConfiguration _providerConfiguration = ProviderConfiguration.GetProviderConfiguration(ProviderType);
        private string _connectionString;
        private string _providerPath;
        private string _objectQualifier;
        private string _databaseOwner;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructs new SqlDataProvider instance
        /// </summary>
        public SqlDataProvider()
        {
            //Read the configuration specific information for this provider
            Provider objProvider = (Provider)_providerConfiguration.Providers[_providerConfiguration.DefaultProvider];

            //Read the attributes for this provider
            if ((objProvider.Attributes["connectionStringName"] != "") && (System.Configuration.ConfigurationManager.AppSettings[objProvider.Attributes["connectionStringName"]] != ""))
            {
                _connectionString = System.Configuration.ConfigurationManager.AppSettings[objProvider.Attributes["connectionStringName"]];
            }
            else
            {
                _connectionString = objProvider.Attributes["connectionString"];
            }

            _providerPath = objProvider.Attributes["providerPath"];

            _objectQualifier = objProvider.Attributes["objectQualifier"];

            if ((_objectQualifier != "") && (_objectQualifier.EndsWith("_") == false))
            {
                _objectQualifier += "_";
            }

            _databaseOwner = objProvider.Attributes["databaseOwner"];
            if ((_databaseOwner != "") && (_databaseOwner.EndsWith(".") == false))
            {
                _databaseOwner += ".";
            }
        }

        #endregion


        #region Properties
        /// <summary>
        /// Gets and sets the connection string
        /// </summary>
        public string ConnectionString
        {
            get { return _connectionString; }
        }

        /// <summary>
        /// Gets and sets the Provider path
        /// </summary>
        public string ProviderPath
        {
            get { return _providerPath; }
        }

        /// <summary>
        /// Gets and sets the Object qualifier
        /// </summary>
        public string ObjectQualifier
        {
            get { return _objectQualifier; }
        }

        /// <summary>
        /// Gets and sets the database ownere
        /// </summary>
        public string DatabaseOwner
        {
            get { return _databaseOwner; }
        }

        #endregion

        #region Private Methods

        private string GetFullyQualifiedName(string name)
        {
            return DatabaseOwner + ObjectQualifier + ModuleQualifier + name;
        }

        private Object GetNull(Object Field)
        {
            return Null.GetNull(Field, DBNull.Value);
        }

        #endregion


        // ApplicantPersonalDetails sqldataprovider


        #region "ApplicantPersonalDetails Methods"
        public override IDataReader ApplicantPersonalDetailsGet(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGet", applicantID);
        }

        // get offer details ApplicantPersonalDetailsGetOfferDetails

        public override IDataReader ApplicantPersonalDetailsGetOfferDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetOfferDetails", applicantID);
        }


        // by applicantNum
        public override IDataReader ApplicantPersonalDetailsGetByApplicantNum(string applicantNum)
        {
           return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByApplicantNum", applicantNum);

        }

        public override IDataReader ApplicantPersonalDetailsList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsList");
        }

        // list by position applied for and application Status is null 
        public override IDataReader ApplicantPersonalDetailsListByPositionNotShortlisted(string positionAppliedFor)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsListByPositionNotShortlisted", positionAppliedFor);
        }

        // list by position applied for and application Status is shortlisted but interviewer decision is null
        public override IDataReader ApplicantPersonalDetailsListByPositionShortlisted(string positionAppliedFor)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsListByPositionShortlisted", positionAppliedFor);
        }

        // list by position applied for both shortlisted and not shortlisted 
        public override IDataReader ApplicantPersonalDetailsListByPositionAppliedForAll(string positionAppliedFor)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsListByPositionAppliedForAll", positionAppliedFor);
        }

        
        // list by position applied for and interviewer decision is hire
        public override IDataReader ApplicantPersonalDetailsListByPositionHire(string positionAppliedFor)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsListByPositionHire", positionAppliedFor);
        }

        // /list by position applied for, shortlisted and interviewer decision is hire and not hire(is null)
        public override IDataReader ApplicantPersonalDetailsListByPositionHireAndNot(string positionAppliedFor)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsListByPositionHireAndNot", positionAppliedFor);
        }

    
        // list by position applied for and management approved
        public override IDataReader ApplicantPersonalDetailsListByPositionApprove(string positionAppliedFor)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsListByPositionApprove", positionAppliedFor);
        }

        // list all approved applicants
        public override IDataReader ApplicantPersonalDetailsListAllApprovedApplicants()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsListAllApprovedApplicants");
        }

        public override IDataReader ApplicantPersonalDetailsGetByCountryTable(int countryID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByCountryTable", countryID);
        }

        public override IDataReader ApplicantPersonalDetailsGetByEmployeeDepartmentTable(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByEmployeeDepartmentTable", deptID);
        }

        public override IDataReader ApplicantPersonalDetailsGetByEmployeeLevel(int levelID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByEmployeeLevel", levelID);
        }

        public override IDataReader ApplicantPersonalDetailsGetByEmployeePositionTable(int positionID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByEmployeePositionTable", positionID);
        }

        public override IDataReader ApplicantPersonalDetailsGetByEmployeeWorkLocation(int workLocationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByEmployeeWorkLocation", workLocationID);
        }

        public override IDataReader ApplicantPersonalDetailsGetByLGATable(int lgaID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByLGATable", lgaID);
        }

        public override IDataReader ApplicantPersonalDetailsGetByStateTable(int stateID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByStateTable", stateID);
        }

        //public override int ApplicantPersonalDetailsAdd(string applicantNum, string positionAppliedFor, string title, string firstName, string middleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, string religion, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string passport, string applicationStatus, int positionApproved_FK, int departmentID_FK, int workLocationID_FK, int levelID_FK, string interviewerDecision, string managementDecision)
        //{
        //    return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsAdd", GetNull(applicantNum), positionAppliedFor, GetNull(title), firstName, GetNull(middleName), lastName, gender, dateOfBirth, GetNull(age), maritalStatus, GetNull(religion), GetNull(nationality_FK), GetNull(stateOfOrigin_FK), lGA_FK, homeTown, phoneNo, email, contactAddress, passport, GetNull(applicationStatus), GetNull(positionApproved_FK), GetNull(departmentID_FK), GetNull(workLocationID_FK), GetNull(levelID_FK), GetNull(interviewerDecision), GetNull(managementDecision)).ToString());
        //}
        public override int ApplicantPersonalDetailsAdd(string applicantNum, string positionAppliedFor, string title, string firstName, string middleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, string religion, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string passport, string applicationStatus,  string interviewerDecision, string managementDecision)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsAdd", GetNull(applicantNum), positionAppliedFor, GetNull(title), firstName, GetNull(middleName), lastName, gender, dateOfBirth, GetNull(age), maritalStatus, GetNull(religion), GetNull(nationality_FK), GetNull(stateOfOrigin_FK), lGA_FK, homeTown, phoneNo, email, contactAddress, passport, GetNull(applicationStatus),  GetNull(interviewerDecision), GetNull(managementDecision)).ToString());
        }

        public override void ApplicantPersonalDetailsUpdate(int applicantID, string applicantNum, string positionAppliedFor, string title, string firstName, string middleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, string religion, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string passport, string applicationStatus, int positionApproved_FK, int departmentID_FK, int workLocationID_FK, int levelID_FK, string interviewerDecision, string managementDecision)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsUpdate", applicantID, GetNull(applicantNum), positionAppliedFor, GetNull(title), firstName, GetNull(middleName), lastName, gender, dateOfBirth, GetNull(age), maritalStatus, GetNull(religion), GetNull(nationality_FK), GetNull(stateOfOrigin_FK), lGA_FK, homeTown, phoneNo, email, contactAddress, passport, GetNull(applicationStatus), GetNull(positionApproved_FK), GetNull(departmentID_FK), GetNull(workLocationID_FK), GetNull(levelID_FK), GetNull(interviewerDecision), GetNull(managementDecision));
        }

        //// this method update only the applicantNum
        public override void ApplicantPersonalDetailsUpdateApplicantNum(int applicantID, string applicantNum)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsUpdateApplicantNum", applicantID, GetNull(applicantNum));
        }

        //// this method update applicant personal details using applicantNum

        public override void ApplicantPersonalDetailsUpdateUsingApplicantNum(int applicantID, string applicantNum, string positionAppliedFor, string title, string firstName, string middleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, string religion, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string passport)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsUpdateUsingApplicantNum", applicantID, GetNull(applicantNum), positionAppliedFor, GetNull(title), firstName, GetNull(middleName), lastName, gender, dateOfBirth, GetNull(age), maritalStatus, GetNull(religion), GetNull(nationality_FK), GetNull(stateOfOrigin_FK), lGA_FK, homeTown, phoneNo, email, contactAddress, passport);
        }

        // this method update applicationStatus
        public override void ApplicantPersonalDetailsUpdateApplicationStatus(int applicantID, string applicationStatus)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsUpdateApplicationStatus", applicantID, GetNull(applicationStatus));
        }

        //this method update interviewer decision
                
        public override void ApplicantPersonalDetailsUpdateInterviewerDecision(int applicantID, int positionApproved_FK, int departmentID_FK, int workLocationID_FK, int levelID_FK, string resumptionDate, string interviewerDecision )
	    {
		    SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsUpdateInterviewerDecision", applicantID,  GetNull(positionApproved_FK), GetNull(departmentID_FK), GetNull(workLocationID_FK), GetNull(levelID_FK), GetNull(resumptionDate), GetNull(interviewerDecision));
	    }
            //this method update Management decision
        public override void ApplicantPersonalDetailsUpdateManagementDecision(int applicantID, string managementDecision)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsUpdateManagementDecision", applicantID, GetNull(managementDecision));
        }
        public override void ApplicantPersonalDetailsDelete(int applicantID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsDelete", applicantID);
        }



        // copied from ola
        public override IDataReader ApplicantManagementApprovedList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantManagementApprovedList");
        }
        public override IDataReader ApplicantPersonalDetailsAcceptanceAppList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsAcceptanceAppList");
        }
        public override void ApplicantPersonalDetailsSendingOfferUpdate(int applicantID, int positionApproved_FK, int departmentID_FK, int levelID_FK, int workLocationID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsSendingOfferUpdate", applicantID, GetNull(positionApproved_FK), GetNull(departmentID_FK), GetNull(levelID_FK), GetNull(workLocationID_FK));
        }

        #endregion






        //#region "ApplicantPersonalDetails Methods"
        //public override IDataReader ApplicantPersonalDetailsGet(int applicantID)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGet", applicantID);
        //}
        //public override IDataReader ApplicantPersonalDetailsGetByApplicantNum(string applicantNum)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByApplicantNum", applicantNum);

        //}
        //public override IDataReader ApplicantPersonalDetailsList()
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsList");
        //}
        //// list by position applied for and application Status is null 
        //public override IDataReader ApplicantPersonalDetailsListByPositionAppliedFor(string positionAppliedFor)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsListByPositionAppliedFor", positionAppliedFor);
        //}

        //// list by position applied for and application Status is shortlisted
        //public override IDataReader ApplicantPersonalDetailsListByPositionAndApplicationStatus(string positionAppliedFor)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsListByPositionAndApplicationStatus", positionAppliedFor);
        //}

        //// list by position applied for both shortlisted and not shortlisted 
        //public override IDataReader ApplicantPersonalDetailsListByPositionAppliedForAll(string positionAppliedFor)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsListByPositionAppliedForAll", positionAppliedFor);
        //}
        //public override IDataReader ApplicantPersonalDetailsGetByCountryTable(int countryID)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByCountryTable", countryID);
        //}

        //public override IDataReader ApplicantPersonalDetailsGetByLGATable(int lgaID)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByLGATable", lgaID);
        //}

        //public override IDataReader ApplicantPersonalDetailsGetByStateTable(int stateID)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByStateTable", stateID);
        //}

        //public override int ApplicantPersonalDetailsAdd(string applicantNum, string positionAppliedFor, string title, string firstName, string middleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, string religion, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string passport, string applicationStatus, string employmentStatus)
        //{
        //    return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsAdd", GetNull(applicantNum), positionAppliedFor, GetNull(title), firstName, GetNull(middleName), lastName, gender, dateOfBirth, GetNull(age), maritalStatus, GetNull(religion), GetNull(nationality_FK), GetNull(stateOfOrigin_FK), lGA_FK, homeTown, phoneNo, email, contactAddress, passport, GetNull(applicationStatus), GetNull(employmentStatus)).ToString());
        //}

        //public override void ApplicantPersonalDetailsUpdate(int applicantID, string applicantNum, string positionAppliedFor, string title, string firstName, string middleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, string religion, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string passport, string applicationStatus, string employmentStatus)
        //{
        //    SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsUpdate", applicantID, GetNull(applicantNum), positionAppliedFor, GetNull(title), firstName, GetNull(middleName), lastName, gender, dateOfBirth, GetNull(age), maritalStatus, GetNull(religion), GetNull(nationality_FK), GetNull(stateOfOrigin_FK), lGA_FK, homeTown, phoneNo, email, contactAddress, passport, GetNull(applicationStatus), GetNull(employmentStatus));
        //}

      

        ////// this method update only the applicantNum
        //public override void ApplicantPersonalDetailsUpdateApplicantNum(int applicantID, string applicantNum)
        //{
        //    SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsUpdateApplicantNum", applicantID, GetNull(applicantNum));
        //}

        ////// this method update applicant personal details using applicantNum
        
        //public override void ApplicantPersonalDetailsUpdateUsingApplicantNum(int applicantID, string applicantNum, string positionAppliedFor, string title, string firstName, string middleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, string religion, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string passport)
        //{
        //    SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsUpdate", applicantID, GetNull(applicantNum), positionAppliedFor, GetNull(title), firstName, GetNull(middleName), lastName, gender, dateOfBirth, GetNull(age), maritalStatus, GetNull(religion), GetNull(nationality_FK), GetNull(stateOfOrigin_FK), lGA_FK, homeTown, phoneNo, email, contactAddress, passport);
        //}

        //// this method update applicationStatus
        //public override void ApplicantPersonalDetailsUpdateApplicationStatus(int applicantID, string applicationStatus)
        //{
        //    SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsUpdateApplicationStatus", applicantID, GetNull(applicationStatus));
        //}
        ////this method update EmploymentStatus
        //public override void ApplicantPersonalDetailsUpdateEmploymentStatus(int applicantID, string employmentStatus)
        //{
        //    SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsUpdateEmploymentStatus", applicantID, GetNull(employmentStatus));
        //}
        //public override void ApplicantPersonalDetailsDelete(int applicantID)
        //{
        //    SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsDelete", applicantID);
        //}
        //#endregion




      






        #region "ApplicantQualification Methods"
        public override IDataReader ApplicantQualificationGet(int qualificationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantQualificationGet", qualificationID);
        }

        public override IDataReader ApplicantQualificationList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantQualificationList");
        }

        public override IDataReader ApplicantQualificationGetByApplicantPersonalDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantQualificationGetByApplicantPersonalDetails", applicantID);
        }

        public override int ApplicantQualificationAdd(string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantQualificationAdd", institutionName, qualificationType, course, grade, startYear, endYear, applicantID_FK).ToString());
        }

        public override void ApplicantQualificationUpdate(int qualificationID, string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantQualificationUpdate", qualificationID, institutionName, qualificationType, course, grade, startYear, endYear, applicantID_FK);
        }

        public override void ApplicantQualificationDelete(int qualificationID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantQualificationDelete", qualificationID);
        }
        #endregion




       



        // ApplicantProfQualification sqldataprovider
        #region "ApplicantProfQualification Methods"
        public override IDataReader ApplicantProfQualificationGet(int profQualificationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantProfQualificationGet", profQualificationID);
        }

        public override IDataReader ApplicantProfQualificationList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantProfQualificationList");
        }

        public override IDataReader ApplicantProfQualificationGetByApplicantPersonalDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantProfQualificationGetByApplicantPersonalDetails", applicantID);
        }

        public override int ApplicantProfQualificationAdd(string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantProfQualificationAdd", certificationName, certificateNo, stage, certYear, applicantID_FK).ToString());
        }

        public override void ApplicantProfQualificationUpdate(int profQualificationID, string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantProfQualificationUpdate", profQualificationID, certificationName, certificateNo, stage, certYear, applicantID_FK);
        }

        public override void ApplicantProfQualificationDelete(int profQualificationID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantProfQualificationDelete", profQualificationID);
        }
        #endregion



        // ApplicantWorkExperience sqldataprovider
        #region "ApplicantWorkExperience Methods"
        public override IDataReader ApplicantWorkExperienceGet(int workExperienceID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantWorkExperienceGet", workExperienceID);
        }

        public override IDataReader ApplicantWorkExperienceList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantWorkExperienceList");
        }

        public override IDataReader ApplicantWorkExperienceGetByApplicantPersonalDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantWorkExperienceGetByApplicantPersonalDetails", applicantID);
        }

        public override int ApplicantWorkExperienceAdd(string companyName, string positionHeld, string jobDescriprtion, string salaryReceived, string startYear, string endYear, int applicantID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantWorkExperienceAdd", companyName, positionHeld, jobDescriprtion, salaryReceived, startYear, endYear, applicantID_FK).ToString());
        }

        public override void ApplicantWorkExperienceUpdate(int workExperienceID, string companyName, string positionHeld, string jobDescriprtion, string salaryReceived, string startYear, string endYear, int applicantID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantWorkExperienceUpdate", workExperienceID, companyName, positionHeld, jobDescriprtion, salaryReceived, startYear, endYear, applicantID_FK);
        }

        public override void ApplicantWorkExperienceDelete(int workExperienceID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantWorkExperienceDelete", workExperienceID);
        }
        #endregion


        // ApplicantDocument sqldataprovider
        #region "ApplicantDocument Methods"
        public override IDataReader ApplicantDocumentGet(int documentID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantDocumentGet", documentID);
        }

        public override IDataReader ApplicantDocumentList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantDocumentList");
        }

        public override IDataReader ApplicantDocumentGetByApplicantPersonalDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantDocumentGetByApplicantPersonalDetails", applicantID);
        }

        public override int ApplicantDocumentAdd(string documentType, string documentPath, int applicantID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantDocumentAdd", documentType, documentPath, applicantID_FK).ToString());
        }

        public override void ApplicantDocumentUpdate(int documentID, string documentType, string documentPath, int applicantID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantDocumentUpdate", documentID, documentType, documentPath, applicantID_FK);
        }

        public override void ApplicantDocumentDelete(int documentID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantDocumentDelete", documentID);
        }
        #endregion






        // Country table LGA SQLDATAPROVIDER
        #region "CountryTable Methods"
        public override IDataReader CountryTableGet(int countryID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "CountryTableGet", countryID);
        }

        public override IDataReader CountryTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "CountryTableList");
        }

        public override int CountryTableAdd(string countryName)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "CountryTableAdd", GetNull(countryName)).ToString());
        }

        public override void CountryTableUpdate(int countryID, string countryName)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "CountryTableUpdate", countryID, GetNull(countryName));
        }

        public override void CountryTableDelete(int countryID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "CountryTableDelete", countryID);
        }
        #endregion


        // state table  SQLDATAPROVIDER
        #region "StateTable Methods"
        public override IDataReader StateTableGet(int stateID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "StateTableGet", stateID);
        }

        public override IDataReader StateTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "StateTableList");
        }

        public override IDataReader StateTableGetByCountryTable(int countryID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "StateTableGetByCountryTable", countryID);
        }

        public override int StateTableAdd(string stateName, string stateCode, int countryID)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "StateTableAdd", GetNull(stateName), GetNull(stateCode), GetNull(countryID)).ToString());
        }

        public override void StateTableUpdate(int stateID, string stateName, string stateCode, int countryID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "StateTableUpdate", stateID, GetNull(stateName), GetNull(stateCode), GetNull(countryID));
        }

        public override void StateTableDelete(int stateID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "StateTableDelete", stateID);
        }
        #endregion

        // LGA SQLDATAPROVIDER
        #region "LGATable Methods"
        public override IDataReader LGATableGet(int lgaID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "LGATableGet", lgaID);
        }

        public override IDataReader LGATableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "LGATableList");
        }

        public override IDataReader LGATableGetByStateTable(int stateID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "LGATableGetByStateTable", stateID);
        }

        public override int LGATableAdd(string lgaName, int stateID)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "LGATableAdd", GetNull(lgaName), GetNull(stateID)).ToString());
        }

        public override void LGATableUpdate(int lgaID, string lgaName, int stateID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "LGATableUpdate", lgaID, GetNull(lgaName), GetNull(stateID));
        }

        public override void LGATableDelete(int lgaID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "LGATableDelete", lgaID);
        }
        #endregion

        // QualificationTable SQLDATAPROVIDER
        #region "QualificationTable Methods"
        public override IDataReader QualificationTableGet(int qualificationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "QualificationTableGet", qualificationID);
        }

        public override IDataReader QualificationTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "QualificationTableList");
        }

        public override int QualificationTableAdd(string qualificationName)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "QualificationTableAdd", GetNull(qualificationName)).ToString());
        }

        public override void QualificationTableUpdate(int qualificationID, string qualificationName)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "QualificationTableUpdate", qualificationID, GetNull(qualificationName));
        }

        public override void QualificationTableDelete(int qualificationID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "QualificationTableDelete", qualificationID);
        }
        #endregion


        // GradeTable SQLDATAPROVIDER
        #region "GradeTable Methods"
        public override IDataReader GradeTableGet(int gradeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "GradeTableGet", gradeID);
        }

        public override IDataReader GradeTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "GradeTableList");
        }

        public override int GradeTableAdd(string gradeName)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "GradeTableAdd", GetNull(gradeName)).ToString());
        }

        public override void GradeTableUpdate(int gradeID, string gradeName)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "GradeTableUpdate", gradeID, GetNull(gradeName));
        }

        public override void GradeTableDelete(int gradeID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "GradeTableDelete", gradeID);
        }
        #endregion


        //AvailablePositionTable SQLDATAPROVIDER
        #region "AvailablePositionTable Methods"
        public override IDataReader AvailablePositionTableGet(int positionID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "AvailablePositionTableGet", positionID);
        }

        public override IDataReader AvailablePositionTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "AvailablePositionTableList");
        }

        public override int AvailablePositionTableAdd(string positionName)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "AvailablePositionTableAdd", GetNull(positionName)).ToString());
        }

        public override void AvailablePositionTableUpdate(int positionID, string positionName)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "AvailablePositionTableUpdate", positionID, GetNull(positionName));
        }

        public override void AvailablePositionTableDelete(int positionID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "AvailablePositionTableDelete", positionID);
        }
        #endregion



        //EmployeeDepartmentTable SQLDATAPROVIDER
        #region "EmployeeDepartmentTable Methods"
        public override IDataReader EmployeeDepartmentTableGet(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDepartmentTableGet", deptID);
        }

        public override IDataReader EmployeeDepartmentTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDepartmentTableList");
        }

        public override int EmployeeDepartmentTableAdd(string deptName)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDepartmentTableAdd", GetNull(deptName)).ToString());
        }

        public override void EmployeeDepartmentTableUpdate(int deptID, string deptName)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDepartmentTableUpdate", deptID, GetNull(deptName));
        }

        public override void EmployeeDepartmentTableDelete(int deptID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDepartmentTableDelete", deptID);
        }
        #endregion

        //  "EmployeePositionTable Methods SQLDATAPROVIDER

        #region "EmployeePositionTable Methods"
        public override IDataReader EmployeePositionTableGet(int positionID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePositionTableGet", positionID);
        }

        public override IDataReader EmployeePositionTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePositionTableList");
        }

        public override IDataReader EmployeePositionTableGetByEmployeeDepartmentTable(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePositionTableGetByEmployeeDepartmentTable", deptID);
        }

        public override int EmployeePositionTableAdd(string positionName, int deptID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePositionTableAdd", positionName, deptID_FK).ToString());
        }

        public override void EmployeePositionTableUpdate(int positionID, string positionName, int deptID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePositionTableUpdate", positionID, positionName, deptID_FK);
        }

        public override void EmployeePositionTableDelete(int positionID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePositionTableDelete", positionID);
        }
        #endregion


        //EmployeeLevelTable SQLDATAPROVIDER

        #region "EmployeeLevelTable Methods"
        public override IDataReader EmployeeLevelTableGet(int levelID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLevelTableGet", levelID);
        }

        public override IDataReader EmployeeLevelTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLevelTableList");
        }

        public override IDataReader EmployeeLevelTableGetByEmployeeDepartmentTable(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLevelTableGetByEmployeeDepartmentTable", deptID);
        }

        public override int EmployeeLevelTableAdd(string levelName, int deptID_FK, string salary, string salaryDetails, string leaveEntitle)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLevelTableAdd", levelName, GetNull(deptID_FK), GetNull(salary), GetNull(salaryDetails), GetNull(leaveEntitle)).ToString());
        }

        public override void EmployeeLevelTableUpdate(int levelID, string levelName, int deptID_FK, string salary, string salaryDetails, string leaveEntitle)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLevelTableUpdate", levelID, levelName, GetNull(deptID_FK), GetNull(salary), GetNull(salaryDetails), GetNull(leaveEntitle));
        }

        public override void EmployeeLevelTableDelete(int levelID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLevelTableDelete", levelID);
        }
        #endregion



        // EmployeeWorkLocation SQLDATAPROVIDER
        #region "EmployeeWorkLocation Methods"
        public override IDataReader EmployeeWorkLocationGet(int workLocationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeWorkLocationGet", workLocationID);
        }

        public override IDataReader EmployeeWorkLocationList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeWorkLocationList");
        }

        public override int EmployeeWorkLocationAdd(string locationName, string locationAddress)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeWorkLocationAdd", GetNull(locationName), GetNull(locationAddress)).ToString());
        }

        public override void EmployeeWorkLocationUpdate(int workLocationID, string locationName, string locationAddress)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeWorkLocationUpdate", workLocationID, GetNull(locationName), GetNull(locationAddress));
        }

        public override void EmployeeWorkLocationDelete(int workLocationID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeWorkLocationDelete", workLocationID);
        }
        #endregion

        //InterviewRatingKey1 SQL DATA PROVIDER

        #region "InterviewRatingKey1 Methods"
        public override IDataReader InterviewRatingKey1Get(int ratingKeyID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "InterviewRatingKey1Get", ratingKeyID);
        }

        public override IDataReader InterviewRatingKey1List()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "InterviewRatingKey1List");
        }

        public override int InterviewRatingKey1Add(string ratingDescription)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "InterviewRatingKey1Add", GetNull(ratingDescription)).ToString());
        }

        public override void InterviewRatingKey1Update(int ratingKeyID, string ratingDescription)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "InterviewRatingKey1Update", ratingKeyID, GetNull(ratingDescription));
        }

        public override void InterviewRatingKey1Delete(int ratingKeyID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "InterviewRatingKey1Delete", ratingKeyID);
        }
        #endregion



        //InterviewRatingKey2 SQL DATA PROVIDER
        #region "InterviewRatingKey2 Methods"
        public override IDataReader InterviewRatingKey2Get(int ratingKeyID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "InterviewRatingKey2Get", ratingKeyID);
        }

        public override IDataReader InterviewRatingKey2List()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "InterviewRatingKey2List");
        }

        public override int InterviewRatingKey2Add(string ratingKeyDescription)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "InterviewRatingKey2Add", GetNull(ratingKeyDescription)).ToString());
        }

        public override void InterviewRatingKey2Update(int ratingKeyID, string ratingKeyDescription)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "InterviewRatingKey2Update", ratingKeyID, GetNull(ratingKeyDescription));
        }

        public override void InterviewRatingKey2Delete(int ratingKeyID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "InterviewRatingKey2Delete", ratingKeyID);
        }
        #endregion


        //EmployeeDetails

        #region "EmployeeDetails Methods"
        public override IDataReader EmployeeDetailsGet(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGet", employeeID);
        }
        //trying something
        //public override IDataReader EmployeeProfQualificationTableGetByApplicantPersonalDetails(int applicantID)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableGetByApplicantPersonalDetails", applicantID);
        //}
        public override IDataReader EmployeeDetailsList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsList");
        }

        public override IDataReader EmployeeDetailsHiredList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsHiredList");
        }
        public override IDataReader EmployeeDetailsUnconfirmedList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsUnconfirmedList");
        }
        public override IDataReader EmployeeDetailsConfirmedEmployeeList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsConfirmedEmployeeList");
        }


        public override IDataReader EmployeeDetailsQualifUnApprovedList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsQualifUnApprovedList");
        }
        public override IDataReader EmployeeDetailsProfQualifUnApprovedList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsProfQualifUnApprovedList");
        }
        public override IDataReader EmployeeDetailsDocUnApprovedList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsDocUnApprovedList");
        }

        public override IDataReader EmployeeDetailsGetByApplicantPersonalDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByApplicantPersonalDetails", applicantID);
        }

        public override IDataReader EmployeeDetailsGetByCountryTable(int countryID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByCountryTable", countryID);
        }

        public override IDataReader EmployeeDetailsGetByEmployeeDepartmentTable(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByEmployeeDepartmentTable", deptID);
        }

        public override IDataReader EmployeeDetailsGetByEmployeeLevel(int levelID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByEmployeeLevel", levelID);
        }

        public override IDataReader EmployeeDetailsGetByEmployeePositionTable(int positionID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByEmployeePositionTable", positionID);
        }

        public override IDataReader EmployeeDetailsGetByEmployeeWorkLocations(int workLocationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByEmployeeWorkLocations", workLocationID);
        }

        public override IDataReader EmployeeDetailsGetByLGATable(int lgaID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByLGATable", lgaID);
        }

        public override IDataReader EmployeeDetailsGetByStateTable(int stateID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByStateTable", stateID);
        }

        public override IDataReader EmployeeDetailsGetBySupervisor(int supervisorID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetBySupervisor", supervisorID);
        }

        public override IDataReader EmployeeDetailsGetByUserID(int userID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByUserID", userID);
        }

        //EmployeeDetailsGetBySupervisor
        //public override IDataReader EmployeeDetailsGetBySupervisor(int supervisorID)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetBySupervisor", supervisorID);
        //}
        public override int EmployeeDetailsAdd(string employeeNum, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string accountName, string accountNo, string bankName, int department_FK, int positionHeld_FK, int employeeLevel_FK, int workLocation_FK, string confirmationDate, int confirmedBy, string employeeStatus, string startDate, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, string guarrantorNames, string guarrantorFormPath, int applicantID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsAdd", GetNull(employeeNum), GetNull(title), firstName, GetNull(miiddleName), lastName, gender, dateOfBirth, age, GetNull(maritalStatus), nationality_FK, stateOfOrigin_FK, lGA_FK, homeTown, phoneNo, email, contactAddress, GetNull(religion), passport, GetNull(accountName), GetNull(accountNo), GetNull(bankName), GetNull(department_FK), GetNull(positionHeld_FK), GetNull(employeeLevel_FK), GetNull(workLocation_FK), GetNull(confirmationDate), GetNull(confirmedBy), GetNull(employeeStatus), GetNull(startDate), GetNull(nxtOfKinFName), GetNull(nxtOfKinMidName), GetNull(nxtOfKinLName), GetNull(nxtOfKinAddress), GetNull(nxtOfKinPhoneNo), GetNull(nxtOfKinEmail), GetNull(nxtOfKinOccupation), GetNull(nxtOfKinRelationship), GetNull(spouseNames), GetNull(spouseAddress), GetNull(spousePhoneNo), GetNull(spouseEmail), GetNull(spouseOccupation), GetNull(spouseEmployerNames), GetNull(refree1Names), GetNull(refree1Occupation), GetNull(refree1PhoneNum), GetNull(refree1Email), GetNull(refree1ContactAddr), GetNull(refree2Names), GetNull(refree2Occupation), GetNull(refree2PhoneNum), GetNull(refree2Email), GetNull(refree2ContactAddr), GetNull(guarrantorNames), GetNull(guarrantorFormPath), GetNull(applicantID_FK)).ToString());
        }

        public override void EmployeeDetailsUpdate(int employeeID, string employeeNum, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string accountName, string accountNo, string bankName, int department_FK, int positionHeld_FK, int employeeLevel_FK, int workLocation_FK, string confirmationDate, int confirmedBy, string employeeStatus, string startDate, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, string guarrantorNames, string guarrantorFormPath, int applicantID_FK, int employeeUserID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsUpdate", employeeID, GetNull(employeeNum), GetNull(title), firstName, GetNull(miiddleName), lastName, gender, dateOfBirth, age, GetNull(maritalStatus), nationality_FK, stateOfOrigin_FK, lGA_FK, homeTown, phoneNo, email, contactAddress, GetNull(religion), passport, GetNull(accountName), GetNull(accountNo), GetNull(bankName), GetNull(department_FK), GetNull(positionHeld_FK), GetNull(employeeLevel_FK), GetNull(workLocation_FK), GetNull(confirmationDate), GetNull(confirmedBy), GetNull(employeeStatus), GetNull(startDate), GetNull(nxtOfKinFName), GetNull(nxtOfKinMidName), GetNull(nxtOfKinLName), GetNull(nxtOfKinAddress), GetNull(nxtOfKinPhoneNo), GetNull(nxtOfKinEmail), GetNull(nxtOfKinOccupation), GetNull(nxtOfKinRelationship), GetNull(spouseNames), GetNull(spouseAddress), GetNull(spousePhoneNo), GetNull(spouseEmail), GetNull(spouseOccupation), GetNull(spouseEmployerNames), GetNull(refree1Names), GetNull(refree1Occupation), GetNull(refree1PhoneNum), GetNull(refree1Email), GetNull(refree1ContactAddr), GetNull(refree2Names), GetNull(refree2Occupation), GetNull(refree2PhoneNum), GetNull(refree2Email), GetNull(refree2ContactAddr), GetNull(guarrantorNames), GetNull(guarrantorFormPath), GetNull(applicantID_FK), GetNull(employeeUserID_FK));
        }

        public override void EmployeeDetailsUpdateEmployeeNum(int employeeID, string employeeNum)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsUpdateEmployeeNum", employeeID, GetNull(employeeNum));
        }
        public override void EmployeeDetailsUpdateEmployeeUserID(int employeeID, int employeeUserID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsUpdateEmployeeUserID", employeeID, GetNull(employeeUserID_FK));
        }
        public override void EmployeeDetailsNextOfKinUpdate(int employeeID, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, int employeeUserID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsNextOfKinUpdate", employeeID, GetNull(nxtOfKinFName), GetNull(nxtOfKinMidName), GetNull(nxtOfKinLName), GetNull(nxtOfKinAddress), GetNull(nxtOfKinPhoneNo), GetNull(nxtOfKinEmail), GetNull(nxtOfKinOccupation), GetNull(nxtOfKinRelationship), GetNull(employeeUserID_FK));
        }

        public override void EmployeeDetailsSpouseUpdate(int employeeID, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, int employeeUserID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsSpouseUpdate", employeeID, GetNull(spouseNames), GetNull(spouseAddress), GetNull(spousePhoneNo), GetNull(spouseEmail), GetNull(spouseOccupation), GetNull(spouseEmployerNames), GetNull(employeeUserID_FK));
        }

        public override void EmployeeDetailsRefereeUpdate(int employeeID, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, int employeeUserID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsRefereeUpdate", employeeID, GetNull(refree1Names), GetNull(refree1Occupation), GetNull(refree1PhoneNum), GetNull(refree1Email), GetNull(refree1ContactAddr), GetNull(refree2Names), GetNull(refree2Occupation), GetNull(refree2PhoneNum), GetNull(refree2Email), GetNull(refree2ContactAddr), GetNull(employeeUserID_FK));
        }

        public override void EmployeeDetailsBankInfoUpdate(int employeeID, string bankName, string accountName, string accountNo, int employeeUserID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsBankInfoUpdate", employeeID, GetNull(bankName), GetNull(accountName), GetNull(accountNo), GetNull(employeeUserID_FK));
        }

        public override void EmployeeDetailsGuarantorUpdate(int employeeID, string guarrantorNames, string guarrantorFormPath, int employeeUserID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGuarantorUpdate", employeeID, GetNull(guarrantorNames), GetNull(guarrantorFormPath), GetNull(employeeUserID_FK));
        }

        public override void EmployeeDetailsUpdateConfirmation(int employeeID, string confirmationDate, int confirmedBy)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsUpdateConfirmation", employeeID, GetNull(confirmationDate), GetNull(confirmedBy));
        }
        public override void EmployeeDetailsTransferUpdate(int employeeID, int department_FK, int workLocation_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsTransferUpdate", employeeID, GetNull(department_FK), GetNull(workLocation_FK));

        }



        public override void EmployeeDetailsDelete(int employeeID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsDelete", employeeID);
        }
        #endregion


        //EmployeeQualificationTable 

        #region "EmployeeQualificationTable Methods"
        public override IDataReader EmployeeQualificationTableGet(int qualificationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableGet", qualificationID);
        }

        public override IDataReader EmployeeQualificationTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableList");
        }
        public override IDataReader EmployeeQualificationTableUnApprovedList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableUnApprovedList");
        }

        public override IDataReader EmployeeQualificationTableGetByApplicantPersonalDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableGetByApplicantPersonalDetails", applicantID);
        }

        public override IDataReader EmployeeQualificationTableGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableGetByEmployeeDetails", employeeID);
        }
        public override IDataReader EmployeeQualificationUnApprovedGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationUnApprovedGetByEmployeeDetails", employeeID);
        }
        public override IDataReader EmployeeQualificationTableApprovedQualifGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableApprovedQualifGetByEmployeeDetails", employeeID);
        }


        public override int EmployeeQualificationTableAdd(string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableAdd", GetNull(institutionName), GetNull(qualificationType), GetNull(course), GetNull(grade), GetNull(startYear), GetNull(endYear), GetNull(applicantID_FK)).ToString());
        }
        public override int EmployeeQualificationTableNewAdd(string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK, int employeeID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableNewAdd", GetNull(institutionName), GetNull(qualificationType), GetNull(course), GetNull(grade), GetNull(startYear), GetNull(endYear), GetNull(applicantID_FK), GetNull(employeeID_FK)).ToString());
        }

        public override void EmployeeQualificationTableUpdate(int qualificationID, string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableUpdate", qualificationID, GetNull(institutionName), GetNull(qualificationType), GetNull(course), GetNull(grade), GetNull(startYear), GetNull(endYear), GetNull(applicantID_FK), GetNull(employeeID_FK));
        }
        public override void EmployeeQualificationTableEmpIDUpdate(int applicantID_FK, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableEmpIDUpdate", GetNull(applicantID_FK), GetNull(employeeID_FK));
        }
        public override void EmployeeQualificationTableHrApprovalUpdate(int employeeID_FK, string hrApproval)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableHrApprovalUpdate", GetNull(employeeID_FK), GetNull(hrApproval));
        }


        public override void EmployeeQualificationTableDelete(int qualificationID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableDelete", qualificationID);
        }
        #endregion


        //EmployeeProfQualificationTable

        #region "EmployeeProfQualificationTable Methods"
        public override IDataReader EmployeeProfQualificationTableGet(int profQualificationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableGet", profQualificationID);
        }

        public override IDataReader EmployeeProfQualificationTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableList");
        }

        public override IDataReader EmployeeProfQualificationTableGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableGetByEmployeeDetails", employeeID);
        }
        public override IDataReader EmployeeProfQualificationTableApprovedProfQualifGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableApprovedProfQualifGetByEmployeeDetails", employeeID);
        }

        public override IDataReader EmployeeProfQualificationUnApprovedGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationUnApprovedGetByEmployeeDetails", employeeID);
        }

        public override IDataReader EmployeeProfQualificationTableGetByApplicantPersonalDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableGetByApplicantPersonalDetails", applicantID);
        }

        public override int EmployeeProfQualificationTableAdd(string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableAdd", GetNull(certificationName), GetNull(certificateNo), GetNull(stage), GetNull(certYear), GetNull(applicantID_FK)).ToString());
        }
        public override int EmployeeProfQualificationTableNewAdd(string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK, int employeeID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableNewAdd", GetNull(certificationName), GetNull(certificateNo), GetNull(stage), GetNull(certYear), GetNull(applicantID_FK), GetNull(employeeID_FK)).ToString());
        }

        public override void EmployeeProfQualificationTableUpdate(int profQualificationID, string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableUpdate", profQualificationID, GetNull(certificationName), GetNull(certificateNo), GetNull(stage), GetNull(certYear), GetNull(applicantID_FK), GetNull(employeeID_FK));
        }

        public override void EmployeeProfQualificationTableEmpIDUpdate(int applicantID_FK, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableEmpIDUpdate", GetNull(applicantID_FK), GetNull(employeeID_FK));
        }
        public override void EmployeeProfQualificationTableHrApprovalUpdate(int employeeID_FK, string hrApproval)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableHrApprovalUpdate", GetNull(employeeID_FK), GetNull(hrApproval));
        }

        public override void EmployeeProfQualificationTableDelete(int profQualificationID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableDelete", profQualificationID);
        }
        #endregion


        //EmployeeDocument Table

        #region "EmployeeDocumentTable Methods"
        public override IDataReader EmployeeDocumentTableGet(int documentID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableGet", documentID);
        }

        public override IDataReader EmployeeDocumentTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableList");
        }
        //public override IDataReader EmployeeDetailsDocUnApprovedList()
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsDocUnApprovedList");
        //}

        public override IDataReader EmployeeDocumentTableGetByApplicantPersonalDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableGetByApplicantPersonalDetails", applicantID);
        }

        public override IDataReader EmployeeDocumentTableGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableGetByEmployeeDetails", employeeID);
        }
        public override IDataReader EmployeeDocumentTableApprovedDocGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableApprovedDocGetByEmployeeDetails", employeeID);
        }

        public override IDataReader EmployeeDocumentUnApprovedGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentUnApprovedGetByEmployeeDetails", employeeID);
        }


        public override int EmployeeDocumentTableAdd(string documentType, string documentPath, int applicantID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableAdd", GetNull(documentType), GetNull(documentPath), GetNull(applicantID_FK)).ToString());
        }
        public override int EmployeeDocumentTableNewAdd(string documentType, string documentPath, int applicantID_FK, int employeeID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableNewAdd", GetNull(documentType), GetNull(documentPath), GetNull(applicantID_FK), GetNull(employeeID_FK)).ToString());
        }

        public override void EmployeeDocumentTableUpdate(int documentID, string documentType, string documentPath, int applicantID_FK, int employeeID_Fk)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableUpdate", documentID, GetNull(documentType), GetNull(documentPath), GetNull(applicantID_FK), GetNull(employeeID_Fk));
        }
        public override void EmployeeDocumentTableEmpIDUpdate(int applicantID_FK, int employeeID_Fk)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableEmpIDUpdate", GetNull(applicantID_FK), GetNull(employeeID_Fk));
        }
        public override void EmployeeDocumentTableHrApprovalUpdate(int employeeID_Fk, string hrApproval)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableHrApprovalUpdate", GetNull(employeeID_Fk), GetNull(hrApproval));
        }

        public override void EmployeeDocumentTableDelete(int documentID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableDelete", documentID);
        }
        #endregion


        //EmployeeTransferTable


        #region "EmployeeTransferTable Methods"
        public override IDataReader EmployeeTransferTableGet(int transferID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableGet", transferID);
        }

        public override IDataReader EmployeeTransferTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableList");
        }

        public override IDataReader EmployeeTransferTableGetByEmployeeDepartmentTable(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableGetByEmployeeDepartmentTable", deptID);
        }

        public override IDataReader EmployeeTransferTableGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableGetByEmployeeDetails", employeeID);
        }

        public override IDataReader EmployeeTransferTableGetByEmployeeWorkLocations(int workLocationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableGetByEmployeeWorkLocations", workLocationID);
        }
        public override IDataReader EmployeeTransferTableGetByUsers(int userID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableGetByUsers", userID);
        }
        public override int EmployeeTransferTableAdd(int previousDept, int newDept, int prevWorkLocation, int newWorkLcation, int employeeID_FK, string transferDate, int transferedBy)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableAdd", GetNull(previousDept), GetNull(newDept), GetNull(prevWorkLocation), GetNull(newWorkLcation), GetNull(employeeID_FK), GetNull(transferDate), GetNull(transferedBy)).ToString());
        }

        public override void EmployeeTransferTableUpdate(int transferID, int previousDept, int newDept, int prevWorkLocation, int newWorkLcation, int employeeID_FK, string transferDate, int transferedBy)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableUpdate", transferID, GetNull(previousDept), GetNull(newDept), GetNull(prevWorkLocation), GetNull(newWorkLcation), GetNull(employeeID_FK), GetNull(transferDate), GetNull(transferedBy));
        }

        public override void EmployeeTransferTableDelete(int transferID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableDelete", transferID);
        }
        #endregion




        //EmployeeQueryTable
        #region "EmployeeQueryTable Methods"
        public override IDataReader EmployeeQueryTableGet(int queryID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableGet", queryID);
        }

        public override IDataReader EmployeeQueryTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableList");
        }

        public override IDataReader EmployeeQueryTableGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableGetByEmployeeDetails", employeeID);
        }

        public override IDataReader EmployeeQueryTableGetByUsers(int userID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableGetByUsers", userID);
        }

        public override int EmployeeQueryTableAdd(string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter, string employeeResponse, string responseDate, string empResponseLetter, int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableAdd", GetNull(queryTitle), GetNull(description), GetNull(queryReceivedBy), GetNull(issueDate), GetNull(queryIssuedBy), GetNull(queryLetter), GetNull(employeeResponse), GetNull(responseDate), GetNull(empResponseLetter), GetNull(discipliineType_FK), GetNull(disciplineDetails), GetNull(disciplineLetter), GetNull(disciplineDate), GetNull(disciplinedBy)).ToString());
        }

        // sending query         public abstract int EmployeeQueryTableAddQuery(string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter);
        public override int EmployeeQueryTableAddQuery(string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableAddQuery", GetNull(queryTitle), GetNull(description), GetNull(queryReceivedBy), GetNull(issueDate), GetNull(queryIssuedBy), GetNull(queryLetter)).ToString());
        }
        public override void EmployeeQueryTableUpdate(int queryID, string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter, string employeeResponse, string responseDate, string empResponseLetter, int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableUpdate", queryID, GetNull(queryTitle), GetNull(description), GetNull(queryReceivedBy), GetNull(issueDate), GetNull(queryIssuedBy), GetNull(queryLetter), GetNull(employeeResponse), GetNull(responseDate), GetNull(empResponseLetter), GetNull(discipliineType_FK), GetNull(disciplineDetails), GetNull(disciplineLetter), GetNull(disciplineDate), GetNull(disciplinedBy));
        }
       
        // update response to query EmployeeQueryTableUpdateQueryResponse(int queryID,  string employeeResponse, string responseDate, string empResponseLetter);
        public override void EmployeeQueryTableUpdateQueryResponse(int queryID, string employeeResponse, string responseDate, string empResponseLetter)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableUpdateQueryResponse", queryID, GetNull(employeeResponse), GetNull(responseDate), GetNull(empResponseLetter));
        }

        // update query Discipline (int queryID,  int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy);
        public override void EmployeeQueryTableUpdateQueryDiscipline(int queryID,  int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableUpdateQueryDiscipline", queryID,  GetNull(discipliineType_FK), GetNull(disciplineDetails), GetNull(disciplineLetter), GetNull(disciplineDate), GetNull(disciplinedBy));
        }
        
        public override void EmployeeQueryTableDelete(int queryID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableDelete", queryID);
        }
        #endregion



        //EmployeeDisciplineTable
        #region "EmployeeDisciplineTable Methods"
        public override IDataReader EmployeeDisciplineTableGet(int disciplineID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDisciplineTableGet", disciplineID);
        }

        public override IDataReader EmployeeDisciplineTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDisciplineTableList");
        }

        public override int EmployeeDisciplineTableAdd(string discplineDescription)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDisciplineTableAdd", GetNull(discplineDescription)).ToString());
        }

        public override void EmployeeDisciplineTableUpdate(int disciplineID, string discplineDescription)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDisciplineTableUpdate", disciplineID, GetNull(discplineDescription));
        }

        public override void EmployeeDisciplineTableDelete(int disciplineID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDisciplineTableDelete", disciplineID);
        }
        #endregion


        //EmployeeTypeOfLeaveTable
        #region "EmployeeTypeOfLeaveTable Methods"
        public override IDataReader EmployeeTypeOfLeaveTableGet(int leaveTypeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTypeOfLeaveTableGet", leaveTypeID);
        }

        public override IDataReader EmployeeTypeOfLeaveTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTypeOfLeaveTableList");
        }

        public override int EmployeeTypeOfLeaveTableAdd(string leaveTypeName)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTypeOfLeaveTableAdd", GetNull(leaveTypeName)).ToString());
        }

        public override void EmployeeTypeOfLeaveTableUpdate(int leaveTypeID, string leaveTypeName)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTypeOfLeaveTableUpdate", leaveTypeID, GetNull(leaveTypeName));
        }

        public override void EmployeeTypeOfLeaveTableDelete(int leaveTypeID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTypeOfLeaveTableDelete", leaveTypeID);
        }
        #endregion


        //EmployeeLeaveTable  

        #region "EmployeeLeaveTable Methods"
        public override IDataReader EmployeeLeaveTableGet(int leaveID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableGet", leaveID);
        }
        // get leave details for an employee EmployeeLeaveTableGetForAnEmployee
        public override IDataReader EmployeeLeaveTableGetForAnEmployee(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableGetForAnEmployee", employeeID);
        }
        public override IDataReader EmployeeLeaveTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableList");
        }

        public override IDataReader EmployeeLeaveTableGetByEmployeeDepartmentTable(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableGetByEmployeeDepartmentTable", deptID);
        }

        public override IDataReader EmployeeLeaveTableGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableGetByEmployeeDetails", employeeID);
        }

        public override IDataReader EmployeeLeaveTableGetByEmployeeLevelTable(int levelID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableGetByEmployeeLevelTable", levelID);
        }

        public override IDataReader EmployeeLeaveTableGetByEmployeeTypeOfLeaveTable(int leaveTypeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableGetByEmployeeTypeOfLeaveTable", leaveTypeID);
        }

        public override IDataReader EmployeeLeaveTableGetByUsers(int userID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableGetByUsers", userID);
        }

        public override int EmployeeLeaveTableAdd(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableAdd", GetNull(leaveType_FK), GetNull(leaveDescription), GetNull(startDate), GetNull(endDate), GetNull(duration), GetNull(level_FK), GetNull(leaveThreshold), GetNull(dateApplied), GetNull(leaveStatus), GetNull(leaveGrantedBy), GetNull(dateGranted), GetNull(approveOrDisapproveReason), GetNull(dept_FK), employeeID_FK).ToString());
        }


        // saving employee leave application   EmployeeLeaveTableAddLeaveApplication(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied,  int dept_FK, int employeeID_FK);
        public override int EmployeeLeaveTableAddLeaveApplication(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, int dept_FK, int employeeID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableAddLeaveApplication", GetNull(leaveType_FK), GetNull(leaveDescription), GetNull(startDate), GetNull(endDate), GetNull(duration), GetNull(level_FK), GetNull(leaveThreshold), GetNull(dateApplied), GetNull(dept_FK), GetNull(employeeID_FK)).ToString());
        }
        public override void EmployeeLeaveTableUpdate(int leaveID, int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableUpdate", leaveID, GetNull(leaveType_FK), GetNull(leaveDescription), GetNull(startDate), GetNull(endDate), GetNull(duration), GetNull(level_FK), GetNull(leaveThreshold), GetNull(dateApplied), GetNull(leaveStatus), GetNull(leaveGrantedBy), GetNull(dateGranted), GetNull(approveOrDisapproveReason), GetNull(dept_FK), employeeID_FK);
        }

        //update employee leave application
        public override void EmployeeLeaveTableUpdateLeaveApplication(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied,  int dept_FK, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableUpdateLeaveApplication", GetNull(leaveType_FK), GetNull(leaveDescription), GetNull(startDate), GetNull(endDate), GetNull(duration), GetNull(level_FK), GetNull(leaveThreshold), GetNull(dateApplied),  GetNull(dept_FK), employeeID_FK);
        }
        public override void EmployeeLeaveTableDelete(int leaveID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableDelete", leaveID);
        }
        #endregion



        // EmployeeLeaveTableLog
        #region "EmployeeLeaveTableLog Methods"
        public override IDataReader EmployeeLeaveTableLogGet(int leaveLogID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGet", leaveLogID);
        }

        public override IDataReader EmployeeLeaveTableLogList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogList");
        }

        public override IDataReader EmployeeLeaveTableLogGetByEmployeeDepartmentTable(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGetByEmployeeDepartmentTable", deptID);
        }

        public override IDataReader EmployeeLeaveTableLogGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGetByEmployeeDetails", employeeID);
        }

        public override IDataReader EmployeeLeaveTableLogGetByEmployeeLeaveTable(int leaveID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGetByEmployeeLeaveTable", leaveID);
        }

        public override IDataReader EmployeeLeaveTableLogGetByEmployeeLevelTable(int levelID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGetByEmployeeLevelTable", levelID);
        }

        public override IDataReader EmployeeLeaveTableLogGetByEmployeeTypeOfLeaveTable(int leaveTypeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGetByEmployeeTypeOfLeaveTable", leaveTypeID);
        }

        public override IDataReader EmployeeLeaveTableLogGetByUsers(int userID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGetByUsers", userID);
        }

        public override int EmployeeLeaveTableLogAdd(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK, int leaveID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogAdd", GetNull(leaveType_FK), GetNull(leaveDescription), GetNull(startDate), GetNull(endDate), GetNull(duration), GetNull(level_FK), GetNull(leaveThreshold), GetNull(dateApplied), GetNull(leaveStatus), GetNull(leaveGrantedBy), GetNull(dateGranted), GetNull(approveOrDisapproveReason), GetNull(dept_FK), GetNull(employeeID_FK), GetNull(leaveID_FK)).ToString());
        }

        // saving employee leave application   in log table
        public override int EmployeeLeaveTableLogAddLeaveApplication(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, int dept_FK, int employeeID_FK, int leaveID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogAddLeaveApplication", GetNull(leaveType_FK), GetNull(leaveDescription), GetNull(startDate), GetNull(endDate), GetNull(duration), GetNull(level_FK), GetNull(leaveThreshold), GetNull(dateApplied), GetNull(dept_FK), GetNull(employeeID_FK), GetNull(leaveID_FK)).ToString());
        }
        public override void EmployeeLeaveTableLogUpdate(int leaveLogID, int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK, int leaveID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogUpdate", leaveLogID, GetNull(leaveType_FK), GetNull(leaveDescription), GetNull(startDate), GetNull(endDate), GetNull(duration), GetNull(level_FK), GetNull(leaveThreshold), GetNull(dateApplied), GetNull(leaveStatus), GetNull(leaveGrantedBy), GetNull(dateGranted), GetNull(approveOrDisapproveReason), GetNull(dept_FK), GetNull(employeeID_FK), GetNull(leaveID_FK));
        }

        public override void EmployeeLeaveTableLogDelete(int leaveLogID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogDelete", leaveLogID);
        }
        #endregion


        //#region "EmployeeLeaveTableLog Methods"
        //public override IDataReader EmployeeLeaveTableLogGet(int leaveID)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGet", leaveID);
        //}

        //public override IDataReader EmployeeLeaveTableLogList()
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogList");
        //}

        //public override IDataReader EmployeeLeaveTableLogGetByEmployeeDepartmentTable(int deptID)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGetByEmployeeDepartmentTable", deptID);
        //}

        //public override IDataReader EmployeeLeaveTableLogGetByEmployeeDetails(int employeeID)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGetByEmployeeDetails", employeeID);
        //}

        //public override IDataReader EmployeeLeaveTableLogGetByEmployeeLevelTable(int levelID)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGetByEmployeeLevelTable", levelID);
        //}

        //public override IDataReader EmployeeLeaveTableLogGetByEmployeeTypeOfLeaveTable(int leaveTypeID)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGetByEmployeeTypeOfLeaveTable", leaveTypeID);
        //}

        //public override IDataReader EmployeeLeaveTableLogGetByUsers(int userID)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGetByUsers", userID);
        //}

        //public override int EmployeeLeaveTableLogAdd(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK)
        //{
        //    return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogAdd", GetNull(leaveType_FK), GetNull(leaveDescription), GetNull(startDate), GetNull(endDate), GetNull(duration), GetNull(level_FK), GetNull(leaveThreshold), GetNull(dateApplied), GetNull(leaveStatus), GetNull(leaveGrantedBy), GetNull(dateGranted), GetNull(approveOrDisapproveReason), GetNull(dept_FK), GetNull(employeeID_FK)).ToString());
        //}


        //// saving employee leave application   in log table
        //public override int EmployeeLeaveTableLogAddLeaveApplication(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, int dept_FK, int employeeID_FK)
        //{
        //    return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogAddLeaveApplication", GetNull(leaveType_FK), GetNull(leaveDescription), GetNull(startDate), GetNull(endDate), GetNull(duration), GetNull(level_FK), GetNull(leaveThreshold), GetNull(dateApplied), GetNull(dept_FK), GetNull(employeeID_FK)).ToString());
        //}
        //public override void EmployeeLeaveTableLogUpdate(int leaveID, int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK)
        //{
        //    SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogUpdate", leaveID, GetNull(leaveType_FK), GetNull(leaveDescription), GetNull(startDate), GetNull(endDate), GetNull(duration), GetNull(level_FK), GetNull(leaveThreshold), GetNull(dateApplied), GetNull(leaveStatus), GetNull(leaveGrantedBy), GetNull(dateGranted), GetNull(approveOrDisapproveReason), GetNull(dept_FK), GetNull(employeeID_FK));
        //}

        //public override void EmployeeLeaveTableLogDelete(int leaveID)
        //{
        //    SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogDelete", leaveID);
        //}
        //#endregion


    }
}
