using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetNuke;
using DotNetNuke.Framework;
using System.Data;
/// <summary>
/// Summary description for DataProvider
/// </summary>

namespace Bilikis.HRManagementSystem
{
    public abstract class DataProvider
    {
        //public DataProvider()
        //{
            
        //     TODO: Add constructor logic here

        



        //}

        #region Shared/Static Methods

        // singleton reference to the instantiated object 
        static DataProvider objProvider = null;

        // constructor
        static DataProvider()
        {
            CreateProvider();
        }

        // dynamically create provider
        private static void CreateProvider()
        {
            objProvider = (DataProvider)Reflection.CreateObject("data", "Bilikis.HRManagementSystem", "");
        }

        // return the provider
        public static DataProvider Instance()
        {
            return objProvider;
        }

        #endregion

        // ApplicantPersonalDetails   data provider

        #region "ApplicantPersonalDetails Abstract Methods"
        public abstract IDataReader ApplicantPersonalDetailsGet(int applicantID);
        // get offer details
        public abstract IDataReader ApplicantPersonalDetailsGetOfferDetails(int applicantID);

        public abstract IDataReader ApplicantPersonalDetailsGetByApplicantNum(string applicantNum);

        public abstract IDataReader ApplicantPersonalDetailsList();
        
        // list by postion applied for and application status is null(not shortlisted)
        public abstract IDataReader ApplicantPersonalDetailsListByPositionNotShortlisted(string positionAppliedFor);

        //// list by position applied for and Application Status is shortlisted but interviewer decision is null
        public abstract IDataReader ApplicantPersonalDetailsListByPositionShortlisted(string positionAppliedFor);

        // list by postion applied for and both shortlisted and not shortlisted
        public abstract IDataReader ApplicantPersonalDetailsListByPositionAppliedForAll(string positionAppliedFor);
      
        //list by postion applied for and  interviewer decision is hire 
        public abstract IDataReader ApplicantPersonalDetailsListByPositionHire(string positionAppliedFor);

        // /list by position applied for, shortlisted and interviewer decision is hire and not hire(is null)
        public abstract IDataReader ApplicantPersonalDetailsListByPositionHireAndNot(string positionAppliedFor);


        //list by position applied for and management approved
        public abstract IDataReader ApplicantPersonalDetailsListByPositionApprove(string positionAppliedFor);
       
        // list all approved applicants
        public abstract IDataReader ApplicantPersonalDetailsListAllApprovedApplicants();

        public abstract IDataReader ApplicantPersonalDetailsGetByCountryTable(int countryID);
        public abstract IDataReader ApplicantPersonalDetailsGetByEmployeeDepartmentTable(int deptID);
        public abstract IDataReader ApplicantPersonalDetailsGetByEmployeeLevel(int levelID);
        public abstract IDataReader ApplicantPersonalDetailsGetByEmployeePositionTable(int positionID);
        public abstract IDataReader ApplicantPersonalDetailsGetByEmployeeWorkLocation(int workLocationID);
        public abstract IDataReader ApplicantPersonalDetailsGetByLGATable(int lgaID);
        public abstract IDataReader ApplicantPersonalDetailsGetByStateTable(int stateID);
      //  public abstract int ApplicantPersonalDetailsAdd(string applicantNum, string positionAppliedFor, string title, string firstName, string middleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, string religion, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string passport, string applicationStatus, int positionApproved_FK, int departmentID_FK, int workLocationID_FK, int levelID_FK, string interviewerDecision, string managementDecision);
        public abstract int ApplicantPersonalDetailsAdd(string applicantNum, string positionAppliedFor, string title, string firstName, string middleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, string religion, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string passport, string applicationStatus, string interviewerDecision, string managementDecision);

        public abstract void ApplicantPersonalDetailsUpdate(int applicantID, string applicantNum, string positionAppliedFor, string title, string firstName, string middleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, string religion, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string passport, string applicationStatus, int positionApproved_FK, int departmentID_FK, int workLocationID_FK, int levelID_FK, string interviewerDecision, string managementDecision);
        public abstract void ApplicantPersonalDetailsDelete(int applicantID);



        // this method update only the applicant applicantnum
        public abstract void ApplicantPersonalDetailsUpdateApplicantNum(int applicantID, string applicantNum);

        ////this method update applicant details using applicantNum
        public abstract void ApplicantPersonalDetailsUpdateUsingApplicantNum(int applicantID, string applicantNum, string positionAppliedFor, string title, string firstName, string middleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, string religion, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string passport);

        // update application status
        public abstract void ApplicantPersonalDetailsUpdateApplicationStatus(int applicantID, string applicantionStatus);

        // update interviewer decision 
        public abstract void ApplicantPersonalDetailsUpdateInterviewerDecision(int applicantID,int positionApproved_FK, int departmentID_FK, int workLocationID_FK, int levelID_FK, string resumptionDate, string interviewerDecision);

        // update management decision
        public abstract void ApplicantPersonalDetailsUpdateManagementDecision(int applicantID, string managementDecision);


        // Copied from ola
        public abstract IDataReader ApplicantManagementApprovedList();
        public abstract IDataReader ApplicantPersonalDetailsAcceptanceAppList();
        public abstract void ApplicantPersonalDetailsSendingOfferUpdate(int applicantID, int positionApproved_FK, int departmentID_FK, int levelID_FK, int workLocationID_FK);

        #endregion


      
     

        



        // ApplicantQualification data provider
        #region "ApplicantQualification Abstract Methods"
        public abstract IDataReader ApplicantQualificationGet(int qualificationID);
        public abstract IDataReader ApplicantQualificationList();
        public abstract IDataReader ApplicantQualificationGetByApplicantPersonalDetails(int applicantID);
        public abstract int ApplicantQualificationAdd(string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK);
        public abstract void ApplicantQualificationUpdate(int qualificationID, string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK);
        public abstract void ApplicantQualificationDelete(int qualificationID);
        #endregion


        //ApplicantProfQualification data provider

        #region "ApplicantProfQualification Abstract Methods"
        public abstract IDataReader ApplicantProfQualificationGet(int profQualificationID);
        public abstract IDataReader ApplicantProfQualificationList();
        public abstract IDataReader ApplicantProfQualificationGetByApplicantPersonalDetails(int applicantID);
        public abstract int ApplicantProfQualificationAdd(string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK);
        public abstract void ApplicantProfQualificationUpdate(int profQualificationID, string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK);
        public abstract void ApplicantProfQualificationDelete(int profQualificationID);
        #endregion





        // ApplicantWorkExperience data provider

        #region "ApplicantWorkExperience Abstract Methods"
        public abstract IDataReader ApplicantWorkExperienceGet(int workExperienceID);
        public abstract IDataReader ApplicantWorkExperienceList();
        public abstract IDataReader ApplicantWorkExperienceGetByApplicantPersonalDetails(int applicantID);
        public abstract int ApplicantWorkExperienceAdd(string companyName, string positionHeld, string jobDescriprtion, string salaryReceived, string startYear, string endYear, int applicantID_FK);
        public abstract void ApplicantWorkExperienceUpdate(int workExperienceID, string companyName, string positionHeld, string jobDescriprtion, string salaryReceived, string startYear, string endYear, int applicantID_FK);
        public abstract void ApplicantWorkExperienceDelete(int workExperienceID);
        #endregion


        // Applicant Document data provider
        #region "ApplicantDocument Abstract Methods"
        public abstract IDataReader ApplicantDocumentGet(int documentID);
        public abstract IDataReader ApplicantDocumentList();
        public abstract IDataReader ApplicantDocumentGetByApplicantPersonalDetails(int applicantID);
        public abstract int ApplicantDocumentAdd(string documentType, string documentPath, int applicantID_FK);
        public abstract void ApplicantDocumentUpdate(int documentID, string documentType, string documentPath, int applicantID_FK);
        public abstract void ApplicantDocumentDelete(int documentID);
        #endregion



        // Country table dataprovider
        #region "CountryTable Abstract Methods"
        public abstract IDataReader CountryTableGet(int countryID);
        public abstract IDataReader CountryTableList();
        public abstract int CountryTableAdd(string countryName);
        public abstract void CountryTableUpdate(int countryID, string countryName);
        public abstract void CountryTableDelete(int countryID);
        #endregion


        // State Table Data Provider

        #region "StateTable Abstract Methods"
        public abstract IDataReader StateTableGet(int stateID);
        public abstract IDataReader StateTableList();
        public abstract IDataReader StateTableGetByCountryTable(int countryID);
        public abstract int StateTableAdd(string stateName, string stateCode, int countryID);
        public abstract void StateTableUpdate(int stateID, string stateName, string stateCode, int countryID);
        public abstract void StateTableDelete(int stateID);
        #endregion

        // lga data provider

        #region "LGATable Abstract Methods"
        public abstract IDataReader LGATableGet(int lgaID);
        public abstract IDataReader LGATableList();
        public abstract IDataReader LGATableGetByStateTable(int stateID);
        public abstract int LGATableAdd(string lgaName, int stateID);
        public abstract void LGATableUpdate(int lgaID, string lgaName, int stateID);
        public abstract void LGATableDelete(int lgaID);
        #endregion


        // Qualification Table data provider

        #region "QualificationTable Abstract Methods"
        public abstract IDataReader QualificationTableGet(int qualificationID);
        public abstract IDataReader QualificationTableList();
        public abstract int QualificationTableAdd(string qualificationName);
        public abstract void QualificationTableUpdate(int qualificationID, string qualificationName);
        public abstract void QualificationTableDelete(int qualificationID);
        #endregion

        // Grade Table data provider

        #region "GradeTable Abstract Methods"
        public abstract IDataReader GradeTableGet(int gradeID);
        public abstract IDataReader GradeTableList();
        public abstract int GradeTableAdd(string gradeName);
        public abstract void GradeTableUpdate(int gradeID, string gradeName);
        public abstract void GradeTableDelete(int gradeID);
        #endregion


        // Available position table data provider

        #region "AvailablePositionTable Abstract Methods"
        public abstract IDataReader AvailablePositionTableGet(int positionID);
        public abstract IDataReader AvailablePositionTableList();
        public abstract int AvailablePositionTableAdd(string positionName);
        public abstract void AvailablePositionTableUpdate(int positionID, string positionName);
        public abstract void AvailablePositionTableDelete(int positionID);
        #endregion


        // EmployeeDepartmentTable Controller

        #region "EmployeeDepartmentTable Abstract Methods"
        public abstract IDataReader EmployeeDepartmentTableGet(int deptID);
        public abstract IDataReader EmployeeDepartmentTableList();
        public abstract int EmployeeDepartmentTableAdd(string deptName);
        public abstract void EmployeeDepartmentTableUpdate(int deptID, string deptName);
        public abstract void EmployeeDepartmentTableDelete(int deptID);
        #endregion

        //EmployeePositionTable data provider
        #region "EmployeePositionTable Abstract Methods"
        public abstract IDataReader EmployeePositionTableGet(int positionID);
        public abstract IDataReader EmployeePositionTableList();
        public abstract IDataReader EmployeePositionTableGetByEmployeeDepartmentTable(int deptID);
        public abstract int EmployeePositionTableAdd(string positionName, int deptID_FK);
        public abstract void EmployeePositionTableUpdate(int positionID, string positionName, int deptID_FK);
        public abstract void EmployeePositionTableDelete(int positionID);
        #endregion



        //EmployeeLevelTable data provider

        #region "EmployeeLevelTable Abstract Methods"
        public abstract IDataReader EmployeeLevelTableGet(int levelID);
        public abstract IDataReader EmployeeLevelTableList();
        public abstract IDataReader EmployeeLevelTableGetByEmployeeDepartmentTable(int deptID);
        public abstract int EmployeeLevelTableAdd(string levelName, int deptID_FK, string salary, string salaryDetails, string leaveEntitle);
        public abstract void EmployeeLevelTableUpdate(int levelID, string levelName, int deptID_FK, string salary, string salaryDetails, string leaveEntitle);
        public abstract void EmployeeLevelTableDelete(int levelID);
        #endregion

        //EmployeeWorkLocation data provider
        #region "EmployeeWorkLocation Abstract Methods"
        public abstract IDataReader EmployeeWorkLocationGet(int workLocationID);
        public abstract IDataReader EmployeeWorkLocationList();
        public abstract int EmployeeWorkLocationAdd(string locationName, string locationAddress);
        public abstract void EmployeeWorkLocationUpdate(int workLocationID, string locationName, string locationAddress);
        public abstract void EmployeeWorkLocationDelete(int workLocationID);
        #endregion










        //InterviewRatingKey1 DATA PROVIDER
        #region "InterviewRatingKey1 Abstract Methods"
        public abstract IDataReader InterviewRatingKey1Get(int ratingKeyID);
        public abstract IDataReader InterviewRatingKey1List();
        public abstract int InterviewRatingKey1Add(string ratingDescription);
        public abstract void InterviewRatingKey1Update(int ratingKeyID, string ratingDescription);
        public abstract void InterviewRatingKey1Delete(int ratingKeyID);
        #endregion


        //InterviewRatingKey2 DATAPROVIDER

        #region "InterviewRatingKey2 Abstract Methods"
        public abstract IDataReader InterviewRatingKey2Get(int ratingKeyID);
        public abstract IDataReader InterviewRatingKey2List();
        public abstract int InterviewRatingKey2Add(string ratingKeyDescription);
        public abstract void InterviewRatingKey2Update(int ratingKeyID, string ratingKeyDescription);
        public abstract void InterviewRatingKey2Delete(int ratingKeyID);
        #endregion




        //EmployeeDetails


        #region "EmployeeDetails Abstract Methods"
        public abstract IDataReader EmployeeDetailsGet(int employeeID);
        //trying something
        //public abstract IDataReader EmployeeQualificationTableGetByApplicantPersonalDetails(int applicantID);
        public abstract IDataReader EmployeeDetailsList();
        public abstract IDataReader EmployeeDetailsHiredList();
        public abstract IDataReader EmployeeDetailsUnconfirmedList();
        public abstract IDataReader EmployeeDetailsConfirmedEmployeeList();
        public abstract IDataReader EmployeeDetailsQualifUnApprovedList();
        public abstract IDataReader EmployeeDetailsProfQualifUnApprovedList();
        public abstract IDataReader EmployeeDetailsDocUnApprovedList();

        public abstract IDataReader EmployeeDetailsGetByApplicantPersonalDetails(int applicantID);
        public abstract IDataReader EmployeeDetailsGetByCountryTable(int countryID);
        public abstract IDataReader EmployeeDetailsGetByEmployeeDepartmentTable(int deptID);
        public abstract IDataReader EmployeeDetailsGetByEmployeeLevel(int levelID);
        public abstract IDataReader EmployeeDetailsGetByEmployeePositionTable(int positionID);
        public abstract IDataReader EmployeeDetailsGetByEmployeeWorkLocations(int workLocationID);
        public abstract IDataReader EmployeeDetailsGetByLGATable(int lgaID);
        public abstract IDataReader EmployeeDetailsGetByStateTable(int stateID);
        public abstract IDataReader EmployeeDetailsGetBySupervisor(int supervisorID);
        public abstract IDataReader EmployeeDetailsGetByUserID(int userID);

        // get by supervisor
      //  public abstract IDataReader EmployeeDetailsGetBySupervisor(int supervisorID);
        public abstract int EmployeeDetailsAdd(string employeeNum, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string accountName, string accountNo, string bankName, int department_FK, int positionHeld_FK, int employeeLevel_FK, int workLocation_FK, string confirmationDate, int confirmedBy, string employeeStatus, string startDate, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, string guarrantorNames, string guarrantorFormPath, int applicantID_FK);
        //public abstract int EmployeeDetailsAdd(string employeeNum, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string accountName, string accountNo, string bankName, int department_FK, int positionHeld_FK, int employeeLevel_FK, int workLocation_FK, string confirmationDate, string confirmedBy, string employeeStatus, string startDate, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseOccupation, string spouseEmployerNames, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, string guarrantorNames, string guarrantorFormPath, int applicantID_FK, int employeeUserID_FK, int supervisorID);
        public abstract void EmployeeDetailsUpdate(int employeeID, string employeeNum, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string accountName, string accountNo, string bankName, int department_FK, int positionHeld_FK, int employeeLevel_FK, int workLocation_FK, string confirmationDate, int confirmedBy, string employeeStatus, string startDate, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, string guarrantorNames, string guarrantorFormPath, int applicantID_FK, int employeeUserID_FK);
        public abstract void EmployeeDetailsUpdateEmployeeNum(int employeeID, string employeeNum);
        public abstract void EmployeeDetailsUpdateEmployeeUserID(int employeeID, int employeeUserID_FK);
        public abstract void EmployeeDetailsNextOfKinUpdate(int employeeID, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, int employeeUserID_FK);
        public abstract void EmployeeDetailsSpouseUpdate(int employeeID, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, int employeeUserID_FK);
        public abstract void EmployeeDetailsRefereeUpdate(int employeeID, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, int employeeUserID_FK);
        public abstract void EmployeeDetailsBankInfoUpdate(int employeeID, string bankName, string accountName, string accountNo, int employeeUserID_FK);
        public abstract void EmployeeDetailsGuarantorUpdate(int employeeID, string guarrantorNames, string guarrantorFormPath, int employeeUserID_FK);
        public abstract void EmployeeDetailsUpdateConfirmation(int employeeID, string confirmationDate, int confirmedBy);
        public abstract void EmployeeDetailsTransferUpdate(int employeeID, int departmentID_FK, int workLocationID_FK);
        // public abstract void EmployeeDetailsUpdateConfirmation(int employeeID, string confirmationDate, string confirmedBy);
        public abstract void EmployeeDetailsDelete(int employeeID);

        #endregion

        //EmployeeQualificationTable

        #region "EmployeeQualificationTable Abstract Methods"
        public abstract IDataReader EmployeeQualificationTableGet(int qualificationID);
        public abstract IDataReader EmployeeQualificationTableList();
        public abstract IDataReader EmployeeQualificationTableUnApprovedList();
        public abstract IDataReader EmployeeQualificationTableGetByApplicantPersonalDetails(int applicantID);
        public abstract IDataReader EmployeeQualificationTableGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeQualificationUnApprovedGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeQualificationTableApprovedQualifGetByEmployeeDetails(int employeeID);
        public abstract int EmployeeQualificationTableAdd(string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK);
        public abstract int EmployeeQualificationTableNewAdd(string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK, int employeeID_FK);
        public abstract void EmployeeQualificationTableUpdate(int qualificationID, string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK, int employeeID_FK);
        public abstract void EmployeeQualificationTableEmpIDUpdate(int applicantID_FK, int employeeID_FK);
        public abstract void EmployeeQualificationTableHrApprovalUpdate(int employeeID_FK, string hrApproval);

        public abstract void EmployeeQualificationTableDelete(int qualificationID);
        #endregion


        //EmployeeProfQualificationTable

        #region "EmployeeProfQualificationTable Abstract Methods"
        public abstract IDataReader EmployeeProfQualificationTableGet(int profQualificationID);
        public abstract IDataReader EmployeeProfQualificationTableList();

        // public abstract IDataReader EmployeeDetailsProfQualifUnApprovedList();          
        public abstract IDataReader EmployeeProfQualificationTableGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeProfQualificationTableApprovedProfQualifGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeProfQualificationUnApprovedGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeProfQualificationTableGetByApplicantPersonalDetails(int applicantID);
        public abstract int EmployeeProfQualificationTableAdd(string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK);
        public abstract int EmployeeProfQualificationTableNewAdd(string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK, int employeeID_FK);
        public abstract void EmployeeProfQualificationTableUpdate(int profQualificationID, string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK, int employeeID_FK);
        public abstract void EmployeeProfQualificationTableEmpIDUpdate(int applicantID_FK, int employeeID_FK);

        public abstract void EmployeeProfQualificationTableHrApprovalUpdate(int employeeID_FK, string hrApproval);

        public abstract void EmployeeProfQualificationTableDelete(int profQualificationID);
        #endregion

        //EmployeeDocumentTable

        #region "EmployeeDocumentTable Abstract Methods"
        public abstract IDataReader EmployeeDocumentTableGet(int documentID);
        public abstract IDataReader EmployeeDocumentTableList();
        // public abstract IDataReader EmployeeDetailsDocUnApprovedList();        
        public abstract IDataReader EmployeeDocumentTableGetByApplicantPersonalDetails(int applicantID);
        public abstract IDataReader EmployeeDocumentTableGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeDocumentTableApprovedDocGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeDocumentUnApprovedGetByEmployeeDetails(int employeeID);
        public abstract int EmployeeDocumentTableAdd(string documentType, string documentPath, int applicantID_FK);
        public abstract int EmployeeDocumentTableNewAdd(string documentType, string documentPath, int applicantID_FK, int employeeID_FK);
        public abstract void EmployeeDocumentTableUpdate(int documentID, string documentType, string documentPath, int applicantID_FK, int employeeID_Fk);
        public abstract void EmployeeDocumentTableEmpIDUpdate(int applicantID_FK, int employeeID_Fk);
        public abstract void EmployeeDocumentTableHrApprovalUpdate(int employeeID_Fk, string hrApproval);

        public abstract void EmployeeDocumentTableDelete(int documentID);
        #endregion

        //EmployeeTransferTable


        #region "EmployeeTransferTable Abstract Methods"
        public abstract IDataReader EmployeeTransferTableGet(int transferID);
        public abstract IDataReader EmployeeTransferTableList();
        public abstract IDataReader EmployeeTransferTableGetByEmployeeDepartmentTable(int deptID);
        public abstract IDataReader EmployeeTransferTableGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeTransferTableGetByEmployeeWorkLocations(int workLocationID);
        public abstract IDataReader EmployeeTransferTableGetByUsers(int userID);
        public abstract int EmployeeTransferTableAdd(int previousDept, int newDept, int prevWorkLocation, int newWorkLcation, int employeeID_FK, string transferDate, int transferedBy);
        public abstract void EmployeeTransferTableUpdate(int transferID, int previousDept, int newDept, int prevWorkLocation, int newWorkLcation, int employeeID_FK, string transferDate, int transferedBy);
        public abstract void EmployeeTransferTableDelete(int transferID);
        #endregion

        
        // EmployeeQueryTable
        #region "EmployeeQueryTable Abstract Methods"
        public abstract IDataReader EmployeeQueryTableGet(int queryID);
        public abstract IDataReader EmployeeQueryTableList();
        public abstract IDataReader EmployeeQueryTableGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeQueryTableGetByUsers(int userID);
        public abstract int EmployeeQueryTableAdd(string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter, string employeeResponse, string responseDate, string empResponseLetter, int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy);
       
        // sending query
        public abstract int EmployeeQueryTableAddQuery(string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter);

        public abstract void EmployeeQueryTableUpdate(int queryID, string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter, string employeeResponse, string responseDate, string empResponseLetter, int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy);
        
        // update query response
        public abstract void EmployeeQueryTableUpdateQueryResponse(int queryID,  string employeeResponse, string responseDate, string empResponseLetter);

        //update query discipline
        public abstract void EmployeeQueryTableUpdateQueryDiscipline(int queryID,  int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy);

        public abstract void EmployeeQueryTableDelete(int queryID);
        #endregion



        //EmployeeDisciplineTable
        #region "EmployeeDisciplineTable Abstract Methods"
        public abstract IDataReader EmployeeDisciplineTableGet(int disciplineID);
        public abstract IDataReader EmployeeDisciplineTableList();
        public abstract int EmployeeDisciplineTableAdd(string discplineDescription);
        public abstract void EmployeeDisciplineTableUpdate(int disciplineID, string discplineDescription);
        public abstract void EmployeeDisciplineTableDelete(int disciplineID);
        #endregion


        //EmployeeTypeOfLeaveTable
        #region "EmployeeTypeOfLeaveTable Abstract Methods"
        public abstract IDataReader EmployeeTypeOfLeaveTableGet(int leaveTypeID);
        public abstract IDataReader EmployeeTypeOfLeaveTableList();
        public abstract int EmployeeTypeOfLeaveTableAdd(string leaveTypeName);
        public abstract void EmployeeTypeOfLeaveTableUpdate(int leaveTypeID, string leaveTypeName);
        public abstract void EmployeeTypeOfLeaveTableDelete(int leaveTypeID);
        #endregion



        //EmployeeLeaveTable


        #region "EmployeeLeaveTable Abstract Methods"
        public abstract IDataReader EmployeeLeaveTableGet(int leaveID);

        // Get leave details of an employee
        public abstract IDataReader EmployeeLeaveTableGetForAnEmployee(int employeeID);
        public abstract IDataReader EmployeeLeaveTableList();
        public abstract IDataReader EmployeeLeaveTableGetByEmployeeDepartmentTable(int deptID);
        public abstract IDataReader EmployeeLeaveTableGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeLeaveTableGetByEmployeeLevelTable(int levelID);
        public abstract IDataReader EmployeeLeaveTableGetByEmployeeTypeOfLeaveTable(int leaveTypeID);
        public abstract IDataReader EmployeeLeaveTableGetByUsers(int userID);
        public abstract int EmployeeLeaveTableAdd(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK);


         // Saving employee leave application 
        public abstract int EmployeeLeaveTableAddLeaveApplication(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied,  int dept_FK, int employeeID_FK);
       
        public abstract void EmployeeLeaveTableUpdate(int leaveID, int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK);

        // update employee application
        public abstract void EmployeeLeaveTableUpdateLeaveApplication( int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, int dept_FK, int employeeID_FK);

        public abstract void EmployeeLeaveTableDelete(int leaveID);
        #endregion



        //EmployeeLeaveTableLog
        #region "EmployeeLeaveTableLog Abstract Methods"
        public abstract IDataReader EmployeeLeaveTableLogGet(int leaveLogID);
        public abstract IDataReader EmployeeLeaveTableLogList();
        public abstract IDataReader EmployeeLeaveTableLogGetByEmployeeDepartmentTable(int deptID);
        public abstract IDataReader EmployeeLeaveTableLogGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeLeaveTableLogGetByEmployeeLeaveTable(int leaveID);
        public abstract IDataReader EmployeeLeaveTableLogGetByEmployeeLevelTable(int levelID);
        public abstract IDataReader EmployeeLeaveTableLogGetByEmployeeTypeOfLeaveTable(int leaveTypeID);
        public abstract IDataReader EmployeeLeaveTableLogGetByUsers(int userID);
        public abstract int EmployeeLeaveTableLogAdd(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK, int leaveID_FK);

        // Saving employee leave application  in log table
        public abstract int EmployeeLeaveTableLogAddLeaveApplication(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, int dept_FK, int employeeID_FK, int leaveID_FK);

        public abstract void EmployeeLeaveTableLogUpdate(int leaveLogID, int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK, int leaveID_FK);
        public abstract void EmployeeLeaveTableLogDelete(int leaveLogID);
        #endregion



        //#region "EmployeeLeaveTableLog Abstract Methods"
        //public abstract IDataReader EmployeeLeaveTableLogGet(int leaveID);
        //public abstract IDataReader EmployeeLeaveTableLogList();
        //public abstract IDataReader EmployeeLeaveTableLogGetByEmployeeDepartmentTable(int deptID);
        //public abstract IDataReader EmployeeLeaveTableLogGetByEmployeeDetails(int employeeID);
        //public abstract IDataReader EmployeeLeaveTableLogGetByEmployeeLevelTable(int levelID);
        //public abstract IDataReader EmployeeLeaveTableLogGetByEmployeeTypeOfLeaveTable(int leaveTypeID);
        //public abstract IDataReader EmployeeLeaveTableLogGetByUsers(int userID);
        //public abstract int EmployeeLeaveTableLogAdd(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK);


        //// Saving employee leave application  in log table
        //public abstract int EmployeeLeaveTableLogAddLeaveApplication(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, int dept_FK, int employeeID_FK);

        //public abstract void EmployeeLeaveTableLogUpdate(int leaveID, int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK);
        //public abstract void EmployeeLeaveTableLogDelete(int leaveID);
        //#endregion



    }
}
