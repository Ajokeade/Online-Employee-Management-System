using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bilikis.HRManagementSystem;

/// <summary>
/// Summary description for HRMSInfo
/// </summary>
namespace Bilikis.HRManagementSystem
{
    public class HRMSInfo
    {
        public HRMSInfo()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }






    //ApplicantPersonalDetailsInfo

    public class ApplicantPersonalDetailsInfo
    {
        #region "Private Members"
        int _applicantID;
        string _applicantNum;
        string _positionAppliedFor;
        string _title;
        string _firstName;
        string _middleName;
        string _lastName;
        string _gender;
        string _dateOfBirth;
        string _age;
        string _maritalStatus;
        string _religion;
        int _nationality_FK;
        int _stateOfOrigin_FK;
        int _lGA_FK;
        string _homeTown;
        string _phoneNo;
        string _email;
        string _contactAddress;
        string _passport;
        string _applicationStatus;
        int _positionApproved_FK;
        int _departmentID_FK;
        int _workLocationID_FK;
        int _levelID_FK;
        string _resumptionDate;
        string _interviewerDecision;
        string _managementDecision;
        string _nationality;
        string _stateOfOrigin;
        string _lga;
        string _approvedPositionName;
        string _deptName;
        string _locationName;
        string _levelName;
        string _salary;
        
        #endregion

        #region "Constructors"
        public ApplicantPersonalDetailsInfo()
        {
        }

        public ApplicantPersonalDetailsInfo(int applicantID, string applicantNum, string positionAppliedFor, string title, string firstName, string middleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, string religion, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string passport, string applicationStatus, int positionApproved_FK, int departmentID_FK, int workLocationID_FK, int levelID_FK, string resumptionDate, string interviewerDecision, string managementDecision, string stateOfOrigin, string nationality, string lga, string approvedPositionName, string deptName, string locationName, string levelName, string salary)
        {
            this.ApplicantID = applicantID;
            this.ApplicantNum = applicantNum;
            this.PositionAppliedFor = positionAppliedFor;
            this.Title = title;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.Age = age;
            this.MaritalStatus = maritalStatus;
            this.Religion = religion;
            this.Nationality_FK = nationality_FK;
            this.StateOfOrigin_FK = stateOfOrigin_FK;
            this.LGA_FK = lGA_FK;
            this.HomeTown = homeTown;
            this.PhoneNo = phoneNo;
            this.Email = email;
            this.ContactAddress = contactAddress;
            this.Passport = passport;
            this.ApplicationStatus = applicationStatus;
            this.PositionApproved_FK = positionApproved_FK;
            this.DepartmentID_FK = departmentID_FK;
            this.WorkLocationID_FK = workLocationID_FK;
            this.LevelID_FK = levelID_FK;
            this.ResumptionDate = resumptionDate;
            this.InterviewerDecision = interviewerDecision;
            this.ManagementDecision = managementDecision;
            this.Nationality = nationality;
            this.StateOfOrigin = stateOfOrigin;
            this.LGA = lga;
            this.ApprovedPositionName = approvedPositionName;
            this.DeptName = deptName;
            this.LocationName = locationName;
            this.LevelName = levelName;
            this.Salary = salary;
        }
        #endregion

        #region "Public Properties"
        public int ApplicantID
        {
            get { return _applicantID; }
            set { _applicantID = value; }
        }

        public string ApplicantNum
        {
            get { return _applicantNum; }
            set { _applicantNum = value; }
        }

        public string PositionAppliedFor
        {
            get { return _positionAppliedFor; }
            set { _positionAppliedFor = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string MaritalStatus
        {
            get { return _maritalStatus; }
            set { _maritalStatus = value; }
        }

        public string Religion
        {
            get { return _religion; }
            set { _religion = value; }
        }

        public int Nationality_FK
        {
            get { return _nationality_FK; }
            set { _nationality_FK = value; }
        }

        public int StateOfOrigin_FK
        {
            get { return _stateOfOrigin_FK; }
            set { _stateOfOrigin_FK = value; }
        }

        public int LGA_FK
        {
            get { return _lGA_FK; }
            set { _lGA_FK = value; }
        }

        public string HomeTown
        {
            get { return _homeTown; }
            set { _homeTown = value; }
        }

        public string PhoneNo
        {
            get { return _phoneNo; }
            set { _phoneNo = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string ContactAddress
        {
            get { return _contactAddress; }
            set { _contactAddress = value; }
        }

        public string Passport
        {
            get { return _passport; }
            set { _passport = value; }
        }

        public string ApplicationStatus
        {
            get { return _applicationStatus; }
            set { _applicationStatus = value; }
        }

        public int PositionApproved_FK
        {
            get { return _positionApproved_FK; }
            set { _positionApproved_FK = value; }
        }

        public int DepartmentID_FK
        {
            get { return _departmentID_FK; }
            set { _departmentID_FK = value; }
        }

        public int WorkLocationID_FK
        {
            get { return _workLocationID_FK; }
            set { _workLocationID_FK = value; }
        }

        public int LevelID_FK
        {
            get { return _levelID_FK; }
            set { _levelID_FK = value; }
        }

        public string ResumptionDate
        {
            get { return _resumptionDate; }
            set { _resumptionDate = value; }
        }

        public string InterviewerDecision
        {
            get { return _interviewerDecision; }
            set { _interviewerDecision = value; }
        }

        public string ManagementDecision
        {
            get { return _managementDecision; }
            set { _managementDecision = value; }
        }

        public string Nationality
        {
            get { return _nationality; }
            set { _nationality = value; }
        }
        public string StateOfOrigin
        {
            get { return _stateOfOrigin; }
            set { _stateOfOrigin = value; }
        }

        public string LGA
        {
            get { return _lga; }
            set { _lga = value; }

        }

        public string ApprovedPositionName
        {
            get { return _approvedPositionName; }
            set { _approvedPositionName = value; }

        }
        public string DeptName
        {
            get { return _deptName; }
            set { _deptName = value; }

        }
        public string LocationName
        {
            get { return _locationName; }
            set { _locationName = value; }

        }

        public string LevelName
        {
            get { return _levelName; }
            set { _levelName = value; }

        }
      
        public string Salary
        {
            get { return _salary; }
            set { _salary = value; }

        }
        #endregion
    }






    //public class ApplicantPersonalDetailsInfo
    //{
    //    #region "Private Members"
    //    int _applicantID;
    //    string _applicantNum;
    //    string _positionAppliedFor;
    //    string _title;
    //    string _firstName;
    //    string _middleName;
    //    string _lastName;
    //    string _gender;
    //    string _dateOfBirth;
    //    string _age;
    //    string _maritalStatus;
    //    string _religion;
    //    int _nationality_FK;
    //    int _stateOfOrigin_FK;
    //    int _lGA_FK;
    //    string _homeTown;
    //    string _phoneNo;
    //    string _email;
    //    string _contactAddress;
    //    string _passport;
    //    string _applicationStatus;
    //    string _employmentStatus;

    //    string _nationality;
    //    string _stateOfOrigin;     
    //    string _lga;
    //    #endregion

    //    #region "Constructors"
    //    public ApplicantPersonalDetailsInfo()
    //    {
    //    }

    //    public ApplicantPersonalDetailsInfo(int applicantID, string applicantNum, string positionAppliedFor,  string title, string firstName, string middleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, string religion,int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string passport, string applicationStatus,string employmentStatus,string stateOfOrigin, string nationality, string lga)
    //    {
    //        this.ApplicantID = applicantID;
    //        this.ApplicantNum = applicantNum;
    //        this.PositionAppliedFor = positionAppliedFor;
    //        this.Title = title;
    //        this.FirstName = firstName;
    //        this.MiddleName = middleName;
    //        this.LastName = lastName;
    //        this.Gender = gender;
    //        this.DateOfBirth = dateOfBirth;
    //        this.Age = age;
    //        this.MaritalStatus = maritalStatus;
    //        this.Religion = religion;
    //        this.Nationality_FK = nationality_FK;
    //        this.StateOfOrigin_FK = stateOfOrigin_FK;
    //        this.LGA_FK = lGA_FK;
    //        this.HomeTown = homeTown;
    //        this.PhoneNo = phoneNo;
    //        this.Email = email;
    //        this.ContactAddress = contactAddress;
    //        this.Passport = passport;
    //        this.ApplicationStatus = applicationStatus;
    //        this.EmploymentStatus = employmentStatus;
    //        this.Nationality = nationality;
    //        this.StateOfOrigin = stateOfOrigin;
    //        this.LGA = lga;
    //    }
    //    #endregion

    //    #region "Public Properties"
    //    public int ApplicantID
    //    {
    //        get { return _applicantID; }
    //        set { _applicantID = value; }
    //    }

    //    public string ApplicantNum
    //    {
    //        get { return _applicantNum; }
    //        set { _applicantNum = value; }
    //    }

    //    public string PositionAppliedFor
    //    {
    //        get { return _positionAppliedFor; }
    //        set { _positionAppliedFor = value; }
    //    }

    //    public string Title
    //    {
    //        get { return _title; }
    //        set { _title = value; }
    //    }
    //    public string FirstName
    //    {
    //        get { return _firstName; }
    //        set { _firstName = value; }
    //    }

    //    public string MiddleName
    //    {
    //        get { return _middleName; }
    //        set { _middleName = value; }
    //    }

    //    public string LastName
    //    {
    //        get { return _lastName; }
    //        set { _lastName = value; }
    //    }

    //    public string Gender
    //    {
    //        get { return _gender; }
    //        set { _gender = value; }
    //    }

    //    public string DateOfBirth
    //    {
    //        get { return _dateOfBirth; }
    //        set { _dateOfBirth = value; }
    //    }

    //    public string Age
    //    {
    //        get { return _age; }
    //        set { _age = value; }
    //    }

    //    public string MaritalStatus
    //    {
    //        get { return _maritalStatus; }
    //        set { _maritalStatus = value; }
    //    }

    //    public string Religion
    //    {
    //        get { return _religion; }
    //        set { _religion = value; }
    //    }
    //    public int Nationality_FK
    //    {
    //        get { return _nationality_FK; }
    //        set { _nationality_FK = value; }
    //    }

    //    public int StateOfOrigin_FK
    //    {
    //        get { return _stateOfOrigin_FK; }
    //        set { _stateOfOrigin_FK = value; }
    //    }

    //    public int LGA_FK
    //    {
    //        get { return _lGA_FK; }
    //        set { _lGA_FK = value; }
    //    }

    //    public string HomeTown
    //    {
    //        get { return _homeTown; }
    //        set { _homeTown = value; }
    //    }

    //    public string PhoneNo
    //    {
    //        get { return _phoneNo; }
    //        set { _phoneNo = value; }
    //    }

    //    public string Email
    //    {
    //        get { return _email; }
    //        set { _email = value; }
    //    }

    //    public string ContactAddress
    //    {
    //        get { return _contactAddress; }
    //        set { _contactAddress = value; }
    //    }

    //    public string Passport
    //    {
    //        get { return _passport; }
    //        set { _passport = value; }
    //    }

    //    public string ApplicationStatus
    //     {
    //         get { return _applicationStatus; }
    //         set { _applicationStatus = value; }
    //    }
    //    public string EmploymentStatus
    //    {
    //        get { return _employmentStatus; }
    //        set { _employmentStatus = value; }
    //    }
    //    public string Nationality
    //    {
    //        get { return _nationality; }
    //        set {_nationality =value; }
    //    }
    //    public string StateOfOrigin
    //    {
    //        get { return _stateOfOrigin; }
    //        set { _stateOfOrigin = value; }
    //    }

    //    public string LGA
    //    {
    //        get { return _lga; }
    //        set { _lga = value; }

    //    }
    //    #endregion
    //}
    public class ApplicantQualificationInfo
    {
        #region "Private Members"
        int _qualificationID;
        string _institutionName;
        string _qualificationType;
        string _course;
        string _grade;
        string _startYear;
        string _endYear;
        int _applicantID_FK;
        #endregion

        #region "Constructors"
        public ApplicantQualificationInfo()
        {
        }

        public ApplicantQualificationInfo(int qualificationID, string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK)
        {
            this.QualificationID = qualificationID;
            this.InstitutionName = institutionName;
            this.QualificationType = qualificationType;
            this.Course = course;
            this.Grade = grade;
            this.StartYear = startYear;
            this.EndYear = endYear;
            this.ApplicantID_FK = applicantID_FK;
        }
        #endregion

        #region "Public Properties"
        public int QualificationID
        {
            get { return _qualificationID; }
            set { _qualificationID = value; }
        }

        public string InstitutionName
        {
            get { return _institutionName; }
            set { _institutionName = value; }
        }

        public string QualificationType
        {
            get { return _qualificationType; }
            set { _qualificationType = value; }
        }

        public string Course
        {
            get { return _course; }
            set { _course = value; }
        }

        public string Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        public string StartYear
        {
            get { return _startYear; }
            set { _startYear = value; }
        }

        public string EndYear
        {
            get { return _endYear; }
            set { _endYear = value; }
        }

        public int ApplicantID_FK
        {
            get { return _applicantID_FK; }
            set { _applicantID_FK = value; }
        }
        #endregion
    }

    //
    // ApplicantProfQualification Info 
    public class ApplicantProfQualificationInfo
    {
        #region "Private Members"
        int _profQualificationID;
        string _certificationName;
        string _certificateNo;
        string _stage;
        string _certYear;
        int _applicantID_FK;
        #endregion

        #region "Constructors"
        public ApplicantProfQualificationInfo()
        {
        }

        public ApplicantProfQualificationInfo(int profQualificationID, string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK)
        {
            this.ProfQualificationID = profQualificationID;
            this.CertificationName = certificationName;
            this.CertificateNo = certificateNo;
            this.Stage = stage;
            this.CertYear = certYear;
            this.ApplicantID_FK = applicantID_FK;
        }
        #endregion

        #region "Public Properties"
        public int ProfQualificationID
        {
            get { return _profQualificationID; }
            set { _profQualificationID = value; }
        }

        public string CertificationName
        {
            get { return _certificationName; }
            set { _certificationName = value; }
        }

        public string CertificateNo
        {
            get { return _certificateNo; }
            set { _certificateNo = value; }
        }

        public string Stage
        {
            get { return _stage; }
            set { _stage = value; }
        }

        public string CertYear
        {
            get { return _certYear; }
            set { _certYear = value; }
        }

        public int ApplicantID_FK
        {
            get { return _applicantID_FK; }
            set { _applicantID_FK = value; }
        }
        #endregion
    }


    // work Applicak WorkExperienceInfo
    public class ApplicantWorkExperienceInfo
    {
        #region "Private Members"
        int _workExperienceID;
        string _companyName;
        string _positionHeld;
        string _jobDescriprtion;
        string _salaryReceived;
        string _startYear;
        string _endYear;
        int _applicantID_FK;
        #endregion

        #region "Constructors"
        public ApplicantWorkExperienceInfo()
        {
        }

        public ApplicantWorkExperienceInfo(int workExperienceID, string companyName, string positionHeld, string jobDescriprtion, string salaryReceived, string startYear, string endYear, int applicantID_FK)
        {
            this.WorkExperienceID = workExperienceID;
            this.CompanyName = companyName;
            this.PositionHeld = positionHeld;
            this.JobDescriprtion = jobDescriprtion;
            this.SalaryReceived = salaryReceived;
            this.StartYear = startYear;
            this.EndYear = endYear;
            this.ApplicantID_FK = applicantID_FK;
        }
        #endregion

        #region "Public Properties"
        public int WorkExperienceID
        {
            get { return _workExperienceID; }
            set { _workExperienceID = value; }
        }

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        public string PositionHeld
        {
            get { return _positionHeld; }
            set { _positionHeld = value; }
        }

        public string JobDescriprtion
        {
            get { return _jobDescriprtion; }
            set { _jobDescriprtion = value; }
        }

        public string SalaryReceived
        {
            get { return _salaryReceived; }
            set { _salaryReceived = value; }
        }

        public string StartYear
        {
            get { return _startYear; }
            set { _startYear = value; }
        }

        public string EndYear
        {
            get { return _endYear; }
            set { _endYear = value; }
        }

        public int ApplicantID_FK
        {
            get { return _applicantID_FK; }
            set { _applicantID_FK = value; }
        }
        #endregion
    }


    // Applicant Document Info
    public class ApplicantDocumentInfo
    {
        #region "Private Members"
        int _documentID;
        string _documentType;
        string _documentPath;
        int _applicantID_FK;
        #endregion

        #region "Constructors"
        public ApplicantDocumentInfo()
        {
        }

        public ApplicantDocumentInfo(int documentID, string documentType, string documentPath, int applicantID_FK)
        {
            this.DocumentID = documentID;
            this.DocumentType = documentType;
            this.DocumentPath = documentPath;
            this.ApplicantID_FK = applicantID_FK;
        }
        #endregion

        #region "Public Properties"
        public int DocumentID
        {
            get { return _documentID; }
            set { _documentID = value; }
        }

        public string DocumentType
        {
            get { return _documentType; }
            set { _documentType = value; }
        }

        public string DocumentPath
        {
            get { return _documentPath; }
            set { _documentPath = value; }
        }

        public int ApplicantID_FK
        {
            get { return _applicantID_FK; }
            set { _applicantID_FK = value; }
        }
        #endregion
    }


    // country infoclass
    public class CountryTableInfo
    {
        #region "Private Members"
        int _countryID;
        string _countryName;
        #endregion

        #region "Constructors"
        public CountryTableInfo()
        {
        }

        public CountryTableInfo(int countryID, string countryName)
        {
            this.CountryID = countryID;
            this.CountryName = countryName;
        }
        #endregion

        #region "Public Properties"
        public int CountryID
        {
            get { return _countryID; }
            set { _countryID = value; }
        }

        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }
        #endregion
    }


    // state table info class
    public class StateTableInfo
    {
        #region "Private Members"
        int _stateID;
        string _stateName;
        string _stateCode;
        int _countryID;
        #endregion

        #region "Constructors"
        public StateTableInfo()
        {
        }

        public StateTableInfo(int stateID, string stateName, string stateCode, int countryID)
        {
            this.StateID = stateID;
            this.StateName = stateName;
            this.StateCode = stateCode;
            this.CountryID = countryID;
        }
        #endregion

        #region "Public Properties"
        public int StateID
        {
            get { return _stateID; }
            set { _stateID = value; }
        }

        public string StateName
        {
            get { return _stateName; }
            set { _stateName = value; }
        }

        public string StateCode
        {
            get { return _stateCode; }
            set { _stateCode = value; }
        }

        public int CountryID
        {
            get { return _countryID; }
            set { _countryID = value; }
        }
        #endregion
    }


    // lga info class
    public class LGATableInfo
    {
        #region "Private Members"
        int _lgaID;
        string _lgaName;
        int _stateID;
        #endregion

        #region "Constructors"
        public LGATableInfo()
        {
        }

        public LGATableInfo(int lgaID, string lgaName, int stateID)
        {
            this.LgaID = lgaID;
            this.LgaName = lgaName;
            this.StateID = stateID;
        }
        #endregion

        #region "Public Properties"
        public int LgaID
        {
            get { return _lgaID; }
            set { _lgaID = value; }
        }

        public string LgaName
        {
            get { return _lgaName; }
            set { _lgaName = value; }
        }

        public int StateID
        {
            get { return _stateID; }
            set { _stateID = value; }
        }
        #endregion
    }

 
   // qualifictaion table info class
    public class QualificationTableInfo
    {
        #region "Private Members"
        int _qualificationID;
        string _qualificationName;
        #endregion

        #region "Constructors"
        public QualificationTableInfo()
        {
        }

        public QualificationTableInfo(int qualificationID, string qualificationName)
        {
            this.QualificationID = qualificationID;
            this.QualificationName = qualificationName;
        }
        #endregion

        #region "Public Properties"
        public int QualificationID
        {
            get { return _qualificationID; }
            set { _qualificationID = value; }
        }

        public string QualificationName
        {
            get { return _qualificationName; }
            set { _qualificationName = value; }
        }
        #endregion
    }
    
    
    
    // Grade table info class
    public class GradeTableInfo
    {
        #region "Private Members"
        int _gradeID;
        string _gradeName;
        #endregion

        #region "Constructors"
        public GradeTableInfo()
        {
        }

        public GradeTableInfo(int gradeID, string gradeName)
        {
            this.GradeID = gradeID;
            this.GradeName = gradeName;
        }
        #endregion

        #region "Public Properties"
        public int GradeID
        {
            get { return _gradeID; }
            set { _gradeID = value; }
        }

        public string GradeName
        {
            get { return _gradeName; }
            set { _gradeName = value; }
        }
        #endregion
    }

    //AvailablePositionTable Info CLASS
    public class AvailablePositionTableInfo
    {
        #region "Private Members"
        int _positionID;
        string _positionName;
        #endregion

        #region "Constructors"
        public AvailablePositionTableInfo()
        {
        }

        public AvailablePositionTableInfo(int positionID, string positionName)
        {
            this.positionID = positionID;
            this.positionName = positionName;
        }
        #endregion

        #region "Public Properties"
        public int positionID
        {
            get { return _positionID; }
            set { _positionID = value; }
        }

        public string positionName
        {
            get { return _positionName; }
            set { _positionName = value; }
        }
        #endregion
    }


    //EmployeeDepartmentTable  Info
    public class EmployeeDepartmentTableInfo
    {
        #region "Private Members"
        int _deptID;
        string _deptName;
        #endregion

        #region "Constructors"
        public EmployeeDepartmentTableInfo()
        {
        }

        public EmployeeDepartmentTableInfo(int deptID, string deptName)
        {
            this.DeptID = deptID;
            this.DeptName = deptName;
        }
        #endregion

        #region "Public Properties"
        public int DeptID
        {
            get { return _deptID; }
            set { _deptID = value; }
        }

        public string DeptName
        {
            get { return _deptName; }
            set { _deptName = value; }
        }
        #endregion
    }

   
    //EmployeePositionTable Info
    public class EmployeePositionTableInfo
    {
        #region "Private Members"
        int _positionID;
        string _positionName;
        int _deptID_FK;
        #endregion

        #region "Constructors"
        public EmployeePositionTableInfo()
        {
        }

        public EmployeePositionTableInfo(int positionID, string positionName, int deptID_FK)
        {
            this.PositionID = positionID;
            this.PositionName = positionName;
            this.DeptID_FK = deptID_FK;
        }
        #endregion

        #region "Public Properties"
        public int PositionID
        {
            get { return _positionID; }
            set { _positionID = value; }
        }

        public string PositionName
        {
            get { return _positionName; }
            set { _positionName = value; }
        }

        public int DeptID_FK
        {
            get { return _deptID_FK; }
            set { _deptID_FK = value; }
        }
        #endregion
    }



    //EmployeeLevelTable  Info
    public class EmployeeLevelTableInfo
    {
        #region "Private Members"
        int _levelID;
        string _levelName;
        int _deptID_FK;
        string _salary;
        string _salaryDetails;
        string _leaveEntitle;
        #endregion

        #region "Constructors"
        public EmployeeLevelTableInfo()
        {
        }

        public EmployeeLevelTableInfo(int levelID, string levelName, int deptID_FK, string salary, string salaryDetails, string leaveEntitle)
        {
            this.LevelID = levelID;
            this.LevelName = levelName;
            this.DeptID_FK = deptID_FK;
            this.Salary = salary;
            this.SalaryDetails = salaryDetails;
            this.LeaveEntitle = leaveEntitle;
        }
        #endregion

        #region "Public Properties"
        public int LevelID
        {
            get { return _levelID; }
            set { _levelID = value; }
        }

        public string LevelName
        {
            get { return _levelName; }
            set { _levelName = value; }
        }

        public int DeptID_FK
        {
            get { return _deptID_FK; }
            set { _deptID_FK = value; }
        }

        public string Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public string SalaryDetails
        {
            get { return _salaryDetails; }
            set { _salaryDetails = value; }
        }

        public string LeaveEntitle
        {
            get { return _leaveEntitle; }
            set { _leaveEntitle = value; }
        }
        #endregion
    }

   // EmployeeWorkLocation Info
    public class EmployeeWorkLocationInfo
    {
        #region "Private Members"
        int _workLocationID;
        string _locationName;
        string _locationAddress;
        #endregion

        #region "Constructors"
        public EmployeeWorkLocationInfo()
        {
        }

        public EmployeeWorkLocationInfo(int workLocationID, string locationName, string locationAddress)
        {
            this.WorkLocationID = workLocationID;
            this.LocationName = locationName;
            this.LocationAddress = locationAddress;
        }
        #endregion

        #region "Public Properties"
        public int WorkLocationID
        {
            get { return _workLocationID; }
            set { _workLocationID = value; }
        }

        public string LocationName
        {
            get { return _locationName; }
            set { _locationName = value; }
        }

        public string LocationAddress
        {
            get { return _locationAddress; }
            set { _locationAddress = value; }
        }
        #endregion
    }



    //InterviewRatingKey1 InfoCLASS
    public class InterviewRatingKey1Info
    {
        #region "Private Members"
        int _ratingKeyID;
        string _ratingDescription;
        #endregion

        #region "Constructors"
        public InterviewRatingKey1Info()
        {
        }

        public InterviewRatingKey1Info(int ratingKeyID, string ratingDescription)
        {
            this.ratingKeyID = ratingKeyID;
            this.ratingDescription = ratingDescription;
        }
        #endregion

        #region "Public Properties"
        public int ratingKeyID
        {
            get { return _ratingKeyID; }
            set { _ratingKeyID = value; }
        }

        public string ratingDescription
        {
            get { return _ratingDescription; }
            set { _ratingDescription = value; }
        }
        #endregion
    }


    //InterviewRatingKey2 InfoCLASS
    public class InterviewRatingKey2Info
    {
        #region "Private Members"
        int _ratingKeyID;
        string _ratingKeyDescription;
        #endregion

        #region "Constructors"
        public InterviewRatingKey2Info()
        {
        }

        public InterviewRatingKey2Info(int ratingKeyID, string ratingKeyDescription)
        {
            this.ratingKeyID = ratingKeyID;
            this.ratingKeyDescription = ratingKeyDescription;
        }
        #endregion

        #region "Public Properties"
        public int ratingKeyID
        {
            get { return _ratingKeyID; }
            set { _ratingKeyID = value; }
        }

        public string ratingKeyDescription
        {
            get { return _ratingKeyDescription; }
            set { _ratingKeyDescription = value; }
        }
        #endregion
    }



    //EmployeeDetailsInfo


    public class EmployeeDetailsInfo
    {
        #region "Private Members"
        int _employeeID;
        string _employeeNum;
        string _title;
        string _firstName;
        string _miiddleName;
        string _lastName;
        string _gender;
        string _dateOfBirth;
        string _age;
        string _maritalStatus;
        int _nationality_FK;
        int _stateOfOrigin_FK;
        int _lGA_FK;
        string _homeTown;
        string _phoneNo;
        string _email;
        string _contactAddress;
        string _religion;
        string _passport;
        string _accountName;
        string _accountNo;
        string _bankName;
        int _department_FK;
        int _positionHeld_FK;
        int _employeeLevel_FK;
        int _workLocation_FK;
        string _confirmationDate;
        int _confirmedBy;
        string _employeeStatus;
        string _startDate;
        string _nxtOfKinFName;
        string _nxtOfKinMidName;
        string _nxtOfKinLName;
        string _nxtOfKinAddress;
        string _nxtOfKinPhoneNo;
        string _nxtOfKinEmail;
        string _nxtOfKinOccupation;
        string _nxtOfKinRelationship;
        string _spouseNames;
        string _spouseAddress;
        string _spousePhoneNo;
        string _spouseEmail;
        string _spouseOccupation;
        string _spouseEmployerNames;
        string _refree1Names;
        string _refree1Occupation;
        string _refree1PhoneNum;
        string _refree1Email;
        string _refree1ContactAddr;
        string _refree2Names;
        string _refree2Occupation;
        string _refree2PhoneNum;
        string _refree2Email;
        string _refree2ContactAddr;
        string _guarrantorNames;
        string _guarrantorFormPath;
        int _applicantID_FK;
        int _employeeUserID_FK;
        int _supervisorID;
        string _countryName;
        string _stateName;
        string _LgaName;
        string _DeptName;
        string _PositionName;
        string _LevelName;
        string _Salary;
        string _LocationName;
        string _LocationAddress;
        string _Username;
        string _confirmedByName;

        #endregion

        #region "Constructors"
        public EmployeeDetailsInfo()
        {
        }

        public EmployeeDetailsInfo(int employeeID, string employeeNum, string title, string firstName, string miiddleName,
            string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK,
            int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress,
            string religion, string passport, string accountName, string accountNo, string bankName, int department_FK,
            int positionHeld_FK, int employeeLevel_FK, int workLocation_FK, string confirmationDate, int confirmedBy,
            string employeeStatus, string startDate, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName,
            string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation,
            string nxtOfKinRelationship, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail,
            string spouseOccupation, string spouseEmployerNames, string refree1Names, string refree1Occupation,
            string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names,
            string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr,
            string guarrantorNames, string guarrantorFormPath, int applicantID_FK, int employeeUserID_FK, int supervisorID,
            string countryName, string stateName, string LgaName,
            string DeptName, string PositionName, string LevelName, string Salary, string LocationName, string LocationAddress, string username, string confirmedByName)
        {
            this.EmployeeID = employeeID;
            this.EmployeeNum = employeeNum;
            this.Title = title;
            this.FirstName = firstName;
            this.MiiddleName = miiddleName;
            this.LastName = lastName;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.Age = age;
            this.MaritalStatus = maritalStatus;
            this.Nationality_FK = nationality_FK;
            this.StateOfOrigin_FK = stateOfOrigin_FK;
            this.LGA_FK = lGA_FK;
            this.HomeTown = homeTown;
            this.PhoneNo = phoneNo;
            this.Email = email;
            this.ContactAddress = contactAddress;
            this.Religion = religion;
            this.Passport = passport;
            this.AccountName = accountName;
            this.AccountNo = accountNo;
            this.BankName = bankName;
            this.Department_FK = department_FK;
            this.PositionHeld_FK = positionHeld_FK;
            this.EmployeeLevel_FK = employeeLevel_FK;
            this.WorkLocation_FK = workLocation_FK;
            this.ConfirmationDate = confirmationDate;
            this.ConfirmedBy = confirmedBy;
            this.EmployeeStatus = employeeStatus;
            this.StartDate = startDate;
            this.NxtOfKinFName = nxtOfKinFName;
            this.NxtOfKinMidName = nxtOfKinMidName;
            this.NxtOfKinLName = nxtOfKinLName;
            this.NxtOfKinAddress = nxtOfKinAddress;
            this.NxtOfKinPhoneNo = nxtOfKinPhoneNo;
            this.NxtOfKinEmail = nxtOfKinEmail;
            this.NxtOfKinOccupation = nxtOfKinOccupation;
            this.NxtOfKinRelationship = nxtOfKinRelationship;
            this.SpouseNames = spouseNames;
            this.SpouseAddress = spouseAddress;
            this.SpousePhoneNo = spousePhoneNo;
            this.SpouseEmail = spouseEmail;
            this.SpouseOccupation = spouseOccupation;
            this.SpouseEmployerNames = spouseEmployerNames;
            this.Refree1Names = refree1Names;
            this.Refree1Occupation = refree1Occupation;
            this.Refree1PhoneNum = refree1PhoneNum;
            this.Refree1Email = refree1Email;
            this.Refree1ContactAddr = refree1ContactAddr;
            this.Refree2Names = refree2Names;
            this.Refree2Occupation = refree2Occupation;
            this.Refree2PhoneNum = refree2PhoneNum;
            this.Refree2Email = refree2Email;
            this.Refree2ContactAddr = refree2ContactAddr;
            this.GuarrantorNames = guarrantorNames;
            this.GuarrantorFormPath = guarrantorFormPath;
            this.ApplicantID_FK = applicantID_FK;
            this.EmployeeUserID_FK = employeeUserID_FK;
            this.SupervisorID=supervisorID;
            this.countryName = countryName;
            this.stateName = stateName;
            this.LgaName = LgaName;
            this.DeptName = DeptName;
            this.PositionName = PositionName;
            this.LevelName = LevelName;
            this.Salary = Salary;
            this.LocationName = LocationName;
            this.LocationAddress = _LocationAddress;
            this.Username = Username;
            this.ConfirmedByName = ConfirmedByName;

        }
        #endregion

        #region "Public Properties"
        public int EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }

        public string EmployeeNum
        {
            get { return _employeeNum; }
            set { _employeeNum = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string MiiddleName
        {
            get { return _miiddleName; }
            set { _miiddleName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string MaritalStatus
        {
            get { return _maritalStatus; }
            set { _maritalStatus = value; }
        }

        public int Nationality_FK
        {
            get { return _nationality_FK; }
            set { _nationality_FK = value; }
        }

        public int StateOfOrigin_FK
        {
            get { return _stateOfOrigin_FK; }
            set { _stateOfOrigin_FK = value; }
        }

        public int LGA_FK
        {
            get { return _lGA_FK; }
            set { _lGA_FK = value; }
        }

        public string HomeTown
        {
            get { return _homeTown; }
            set { _homeTown = value; }
        }

        public string PhoneNo
        {
            get { return _phoneNo; }
            set { _phoneNo = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string ContactAddress
        {
            get { return _contactAddress; }
            set { _contactAddress = value; }
        }

        public string Religion
        {
            get { return _religion; }
            set { _religion = value; }
        }

        public string Passport
        {
            get { return _passport; }
            set { _passport = value; }
        }

        public string AccountName
        {
            get { return _accountName; }
            set { _accountName = value; }
        }

        public string AccountNo
        {
            get { return _accountNo; }
            set { _accountNo = value; }
        }

        public string BankName
        {
            get { return _bankName; }
            set { _bankName = value; }
        }

        public int Department_FK
        {
            get { return _department_FK; }
            set { _department_FK = value; }
        }

        public int PositionHeld_FK
        {
            get { return _positionHeld_FK; }
            set { _positionHeld_FK = value; }
        }

        public int EmployeeLevel_FK
        {
            get { return _employeeLevel_FK; }
            set { _employeeLevel_FK = value; }
        }

        public int WorkLocation_FK
        {
            get { return _workLocation_FK; }
            set { _workLocation_FK = value; }
        }

        public string ConfirmationDate
        {
            get { return _confirmationDate; }
            set { _confirmationDate = value; }
        }

        public int ConfirmedBy
        {
            get { return _confirmedBy; }
            set { _confirmedBy = value; }
        }

        public string EmployeeStatus
        {
            get { return _employeeStatus; }
            set { _employeeStatus = value; }
        }

        public string StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public string NxtOfKinFName
        {
            get { return _nxtOfKinFName; }
            set { _nxtOfKinFName = value; }
        }

        public string NxtOfKinMidName
        {
            get { return _nxtOfKinMidName; }
            set { _nxtOfKinMidName = value; }
        }

        public string NxtOfKinLName
        {
            get { return _nxtOfKinLName; }
            set { _nxtOfKinLName = value; }
        }

        public string NxtOfKinAddress
        {
            get { return _nxtOfKinAddress; }
            set { _nxtOfKinAddress = value; }
        }

        public string NxtOfKinPhoneNo
        {
            get { return _nxtOfKinPhoneNo; }
            set { _nxtOfKinPhoneNo = value; }
        }

        public string NxtOfKinEmail
        {
            get { return _nxtOfKinEmail; }
            set { _nxtOfKinEmail = value; }
        }

        public string NxtOfKinOccupation
        {
            get { return _nxtOfKinOccupation; }
            set { _nxtOfKinOccupation = value; }
        }

        public string NxtOfKinRelationship
        {
            get { return _nxtOfKinRelationship; }
            set { _nxtOfKinRelationship = value; }
        }

        public string SpouseNames
        {
            get { return _spouseNames; }
            set { _spouseNames = value; }
        }

        public string SpouseAddress
        {
            get { return _spouseAddress; }
            set { _spouseAddress = value; }
        }

        public string SpousePhoneNo
        {
            get { return _spousePhoneNo; }
            set { _spousePhoneNo = value; }
        }

        public string SpouseEmail
        {
            get { return _spouseEmail; }
            set { _spouseEmail = value; }
        }

        public string SpouseOccupation
        {
            get { return _spouseOccupation; }
            set { _spouseOccupation = value; }
        }

        public string SpouseEmployerNames
        {
            get { return _spouseEmployerNames; }
            set { _spouseEmployerNames = value; }
        }

        public string Refree1Names
        {
            get { return _refree1Names; }
            set { _refree1Names = value; }
        }

        public string Refree1Occupation
        {
            get { return _refree1Occupation; }
            set { _refree1Occupation = value; }
        }

        public string Refree1PhoneNum
        {
            get { return _refree1PhoneNum; }
            set { _refree1PhoneNum = value; }
        }

        public string Refree1Email
        {
            get { return _refree1Email; }
            set { _refree1Email = value; }
        }

        public string Refree1ContactAddr
        {
            get { return _refree1ContactAddr; }
            set { _refree1ContactAddr = value; }
        }

        public string Refree2Names
        {
            get { return _refree2Names; }
            set { _refree2Names = value; }
        }

        public string Refree2Occupation
        {
            get { return _refree2Occupation; }
            set { _refree2Occupation = value; }
        }

        public string Refree2PhoneNum
        {
            get { return _refree2PhoneNum; }
            set { _refree2PhoneNum = value; }
        }

        public string Refree2Email
        {
            get { return _refree2Email; }
            set { _refree2Email = value; }
        }

        public string Refree2ContactAddr
        {
            get { return _refree2ContactAddr; }
            set { _refree2ContactAddr = value; }
        }

        public string GuarrantorNames
        {
            get { return _guarrantorNames; }
            set { _guarrantorNames = value; }
        }

        public string GuarrantorFormPath
        {
            get { return _guarrantorFormPath; }
            set { _guarrantorFormPath = value; }
        }

        public int ApplicantID_FK
        {
            get { return _applicantID_FK; }
            set { _applicantID_FK = value; }
        }

        public int EmployeeUserID_FK
        {
            get { return _employeeUserID_FK; }
            set { _employeeUserID_FK = value; }
        }

         public int SupervisorID
        {
            get { return _supervisorID; }
            set { _supervisorID = value; }
        }
        public string countryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }

        public string stateName
        {
            get { return _stateName; }
            set { _stateName = value; }
        }

        public string LgaName
        {
            get { return _LgaName; }
            set { _LgaName = value; }
        }

        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }

        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }

        public string LevelName
        {
            get { return _LevelName; }
            set { _LevelName = value; }
        }
        public string Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public string LocationName
        {
            get { return _LocationName; }
            set { _LocationName = value; }
        }
        public string LocationAddress
        {
            get { return _LocationAddress; }
            set { _LocationAddress = value; }
        }

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        public string ConfirmedByName
        {
            get { return _confirmedByName; }
            set { _confirmedByName = value; }
        }


        #endregion

               
    }

    //EmployeeQualificationTableInfo

    public class EmployeeQualificationTableInfo
    {
        #region "Private Members"
        int _qualificationID;
        string _institutionName;
        string _qualificationType;
        string _course;
        string _grade;
        string _startYear;
        string _endYear;
        int _applicantID_FK;
        int _employeeID_FK;
        string _hrApproval;
        string _employeeNum;
        #endregion

        #region "Constructors"
        public EmployeeQualificationTableInfo()
        {
        }

        public EmployeeQualificationTableInfo(int qualificationID, string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK, int employeeID_FK, string hrApproval, string employeeNum)
        {
            this.QualificationID = qualificationID;
            this.InstitutionName = institutionName;
            this.QualificationType = qualificationType;
            this.Course = course;
            this.Grade = grade;
            this.StartYear = startYear;
            this.EndYear = endYear;
            this.ApplicantID_FK = applicantID_FK;
            this.EmployeeID_FK = employeeID_FK;
            this.HrApproval = hrApproval;
            this.EmployeeNum = employeeNum;
        }
        #endregion



        #region "Public Properties"
        public int QualificationID
        {
            get { return _qualificationID; }
            set { _qualificationID = value; }
        }

        public string InstitutionName
        {
            get { return _institutionName; }
            set { _institutionName = value; }
        }

        public string QualificationType
        {
            get { return _qualificationType; }
            set { _qualificationType = value; }
        }

        public string Course
        {
            get { return _course; }
            set { _course = value; }
        }

        public string Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        public string StartYear
        {
            get { return _startYear; }
            set { _startYear = value; }
        }

        public string EndYear
        {
            get { return _endYear; }
            set { _endYear = value; }
        }

        public int ApplicantID_FK
        {
            get { return _applicantID_FK; }
            set { _applicantID_FK = value; }
        }

        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }

        public string HrApproval
        {
            get { return _hrApproval; }
            set { _hrApproval = value; }
        }
        public string EmployeeNum
        {
            get { return _employeeNum; }
            set { _employeeNum = value; }
        }
        #endregion
    }


    //EmployeeProfQualificationTableInfo

    public class EmployeeProfQualificationTableInfo
    {
        #region "Private Members"
        int _profQualificationID;
        string _certificationName;
        string _certificateNo;
        string _stage;
        string _certYear;
        int _applicantID_FK;
        int _employeeID_FK;
        string _hrApproval;
        #endregion

        #region "Constructors"
        public EmployeeProfQualificationTableInfo()
        {
        }

        public EmployeeProfQualificationTableInfo(int profQualificationID, string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK, int employeeID_FK, string hrApproval)
        {
            this.ProfQualificationID = profQualificationID;
            this.CertificationName = certificationName;
            this.CertificateNo = certificateNo;
            this.Stage = stage;
            this.CertYear = certYear;
            this.ApplicantID_FK = applicantID_FK;
            this.employeeID_FK = employeeID_FK;
            this._hrApproval = hrApproval;
        }
        #endregion

        #region "Public Properties"
        public int ProfQualificationID
        {
            get { return _profQualificationID; }
            set { _profQualificationID = value; }
        }

        public string CertificationName
        {
            get { return _certificationName; }
            set { _certificationName = value; }
        }

        public string CertificateNo
        {
            get { return _certificateNo; }
            set { _certificateNo = value; }
        }

        public string Stage
        {
            get { return _stage; }
            set { _stage = value; }
        }

        public string CertYear
        {
            get { return _certYear; }
            set { _certYear = value; }
        }

        public int ApplicantID_FK
        {
            get { return _applicantID_FK; }
            set { _applicantID_FK = value; }
        }

        public int employeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }
        public string HrApproval
        {
            get { return _hrApproval; }
            set { _hrApproval = value; }
        }

        #endregion
    }



    //EmployeeDocumentTableInfo
    public class EmployeeDocumentTableInfo
    {
        #region "Private Members"
        int _documentID;
        string _documentType;
        string _documentPath;
        int _applicantID_FK;
        int _employeeID_Fk;
        string _hrApproval;
        #endregion

        #region "Constructors"
        public EmployeeDocumentTableInfo()
        {
        }

        public EmployeeDocumentTableInfo(int documentID, string documentType, string documentPath, int applicantID_FK, int employeeID_Fk, string hrApproval)
        {
            this.DocumentID = documentID;
            this.DocumentType = documentType;
            this.DocumentPath = documentPath;
            this.ApplicantID_FK = applicantID_FK;
            this.EmployeeID_Fk = employeeID_Fk;
            this._hrApproval = hrApproval;
        }
        #endregion

        #region "Public Properties"
        public int DocumentID
        {
            get { return _documentID; }
            set { _documentID = value; }
        }

        public string DocumentType
        {
            get { return _documentType; }
            set { _documentType = value; }
        }

        public string DocumentPath
        {
            get { return _documentPath; }
            set { _documentPath = value; }
        }

        public int ApplicantID_FK
        {
            get { return _applicantID_FK; }
            set { _applicantID_FK = value; }
        }

        public int EmployeeID_Fk
        {
            get { return _employeeID_Fk; }
            set { _employeeID_Fk = value; }
        }
        public string HrApproval
        {
            get { return _hrApproval; }
            set { _hrApproval = value; }
        }
        #endregion
    }

    //EmployeeTransferTableInfo
    public class EmployeeTransferTableInfo
    {
        #region "Private Members"
        int _transferID;
        int _previousDept;
        int _newDept;
        int _prevWorkLocation;
        int _newWorkLcation;
        int _employeeID_FK;
        string _transferDate;
        int _transferedBy;

        string _DeptName;
        string _PositionName;
        string _LevelName;
        string _Salary;
        string _LocationName;
        #endregion

        #region "Constructors"
        public EmployeeTransferTableInfo()
        {
        }


        public EmployeeTransferTableInfo(int transferID, int previousDept, int newDept, int prevWorkLocation, int newWorkLcation, int employeeID_FK,
        string transferDate, int transferedBy, string DeptName, string PositionName, string LevelName, string Salary, string LocationName)
        {

            this.TransferID = transferID;
            this.PreviousDept = previousDept;
            this.NewDept = newDept;
            this.PrevWorkLocation = prevWorkLocation;
            this.NewWorkLcation = newWorkLcation;
            this.EmployeeID_FK = employeeID_FK;
            this.TransferDate = transferDate;
            this.TransferedBy = transferedBy;

            this.DeptName = DeptName;
            this.PositionName = PositionName;
            this.LevelName = LevelName;
            this.Salary = Salary;
            this.LocationName = LocationName;
        }
        #endregion

        #region "Public Properties"
        public int TransferID
        {
            get { return _transferID; }
            set { _transferID = value; }
        }

        public int PreviousDept
        {
            get { return _previousDept; }
            set { _previousDept = value; }
        }

        public int NewDept
        {
            get { return _newDept; }
            set { _newDept = value; }
        }

        public int PrevWorkLocation
        {
            get { return _prevWorkLocation; }
            set { _prevWorkLocation = value; }
        }

        public int NewWorkLcation
        {
            get { return _newWorkLcation; }
            set { _newWorkLcation = value; }
        }

        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }

        public string TransferDate
        {
            get { return _transferDate; }
            set { _transferDate = value; }
        }

        public int TransferedBy
        {
            get { return _transferedBy; }
            set { _transferedBy = value; }
        }

        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }

        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }

        public string LevelName
        {
            get { return _LevelName; }
            set { _LevelName = value; }
        }
        public string Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public string LocationName
        {
            get { return _LocationName; }
            set { _LocationName = value; }
        }
        #endregion
    }


    //EmployeeQueryTableInfo
    public class EmployeeQueryTableInfo
    {
        #region "Private Members"
        int _queryID;
        string _queryTitle;
        string _description;
        int _queryReceivedBy;
        string _issueDate;
        int _queryIssuedBy;
        string _queryLetter;
        string _employeeResponse;
        string _responseDate;
        string _empResponseLetter;
        int _discipliineType_FK;
        string _disciplineDetails;
        string _disciplineLetter;
        string _disciplineDate;
        int _disciplinedBy;

        string _queryIssueByName;
        string _employeeNum;
        string _queryReceivedByName;
        #endregion

        #region "Constructors"
        public EmployeeQueryTableInfo()
        {
        }

        public EmployeeQueryTableInfo(int queryID, string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter, string employeeResponse, string responseDate, string empResponseLetter, int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy, string queryIssueByName, string employeeNum, string queryReceivedByName)
        {
            this.QueryID = queryID;
            this.QueryTitle = queryTitle;
            this.Description = description;
            this.QueryReceivedBy = queryReceivedBy;
            this.IssueDate = issueDate;
            this.QueryIssuedBy = queryIssuedBy;
            this.QueryLetter = queryLetter;
            this.EmployeeResponse = employeeResponse;
            this.ResponseDate = responseDate;
            this.EmpResponseLetter = empResponseLetter;
            this.DiscipliineType_FK = discipliineType_FK;
            this.DisciplineDetails = disciplineDetails;
            this.DisciplineLetter = disciplineLetter;
            this.DisciplineDate = disciplineDate;
            this.DisciplinedBy = disciplinedBy;
            this.QueryIssueByName = queryIssueByName;
            this.EmployeeNum = employeeNum;
            this.QueryReceivedByName = queryReceivedByName;
        }
        #endregion

        #region "Public Properties"
        public int QueryID
        {
            get { return _queryID; }
            set { _queryID = value; }
        }

        public string QueryTitle
        {
            get { return _queryTitle; }
            set { _queryTitle = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int QueryReceivedBy
        {
            get { return _queryReceivedBy; }
            set { _queryReceivedBy = value; }
        }

        public string IssueDate
        {
            get { return _issueDate; }
            set { _issueDate = value; }
        }

        public int QueryIssuedBy
        {
            get { return _queryIssuedBy; }
            set { _queryIssuedBy = value; }
        }

        public string QueryLetter
        {
            get { return _queryLetter; }
            set { _queryLetter = value; }
        }

        public string EmployeeResponse
        {
            get { return _employeeResponse; }
            set { _employeeResponse = value; }
        }

        public string ResponseDate
        {
            get { return _responseDate; }
            set { _responseDate = value; }
        }

        public string EmpResponseLetter
        {
            get { return _empResponseLetter; }
            set { _empResponseLetter = value; }
        }

        public int DiscipliineType_FK
        {
            get { return _discipliineType_FK; }
            set { _discipliineType_FK = value; }
        }

        public string DisciplineDetails
        {
            get { return _disciplineDetails; }
            set { _disciplineDetails = value; }
        }

        public string DisciplineLetter
        {
            get { return _disciplineLetter; }
            set { _disciplineLetter = value; }
        }

        public string DisciplineDate
        {
            get { return _disciplineDate; }
            set { _disciplineDate = value; }
        }

        public int DisciplinedBy
        {
            get { return _disciplinedBy; }
            set { _disciplinedBy = value; }
        }

        
        public string QueryIssueByName
        {
            get { return _queryIssueByName; }
            set { _queryIssueByName = value; }
        }
        public string EmployeeNum
        {
            get { return _employeeNum; }
            set { _employeeNum = value; }
        }

        //QueryReceivedByName
        public string QueryReceivedByName
        {
            get { return _queryReceivedByName; }
            set { _queryReceivedByName = value; }
        }
        #endregion
    }


    //EmployeeDisciplineTableInfo
    public class EmployeeDisciplineTableInfo
    {
        #region "Private Members"
        int _disciplineID;
        string _discplineDescription;
        #endregion

        #region "Constructors"
        public EmployeeDisciplineTableInfo()
        {
        }

        public EmployeeDisciplineTableInfo(int disciplineID, string discplineDescription)
        {
            this.DisciplineID = disciplineID;
            this.DiscplineDescription = discplineDescription;
        }
        #endregion

        #region "Public Properties"
        public int DisciplineID
        {
            get { return _disciplineID; }
            set { _disciplineID = value; }
        }

        public string DiscplineDescription
        {
            get { return _discplineDescription; }
            set { _discplineDescription = value; }
        }
        #endregion
    }

    //EmployeeTypeOfLeaveTableInfo
    public class EmployeeTypeOfLeaveTableInfo
    {
        #region "Private Members"
        int _leaveTypeID;
        string _leaveTypeName;
        #endregion

        #region "Constructors"
        public EmployeeTypeOfLeaveTableInfo()
        {
        }

        public EmployeeTypeOfLeaveTableInfo(int leaveTypeID, string leaveTypeName)
        {
            this.LeaveTypeID = leaveTypeID;
            this.LeaveTypeName = leaveTypeName;
        }
        #endregion

        #region "Public Properties"
        public int LeaveTypeID
        {
            get { return _leaveTypeID; }
            set { _leaveTypeID = value; }
        }

        public string LeaveTypeName
        {
            get { return _leaveTypeName; }
            set { _leaveTypeName = value; }
        }
        #endregion
    }


    //EmployeeLeaveTableInfo
    public class EmployeeLeaveTableInfo
    {
        #region "Private Members"
        int _leaveID;
        int _leaveType_FK;
        string _leaveDescription;
        string _startDate;
        string _endDate;
        string _duration;
        int _level_FK;
        string _leaveThreshold;
        string _dateApplied;
        string _leaveStatus;
        int _leaveGrantedBy;
        string _dateGranted;
        string _approveOrDisapproveReason;
        int _dept_FK;
        int _employeeID_FK;
        #endregion

        #region "Constructors"
        public EmployeeLeaveTableInfo()
        {
        }

        public EmployeeLeaveTableInfo(int leaveID, int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK)
        {
            this.LeaveID = leaveID;
            this.LeaveType_FK = leaveType_FK;
            this.LeaveDescription = leaveDescription;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Duration = duration;
            this.Level_FK = level_FK;
            this.LeaveThreshold = leaveThreshold;
            this.DateApplied = dateApplied;
            this.LeaveStatus = leaveStatus;
            this.LeaveGrantedBy = leaveGrantedBy;
            this.DateGranted = dateGranted;
            this.ApproveOrDisapproveReason = approveOrDisapproveReason;
            this.Dept_FK = dept_FK;
            this.EmployeeID_FK = employeeID_FK;
        }
        #endregion

        #region "Public Properties"
        public int LeaveID
        {
            get { return _leaveID; }
            set { _leaveID = value; }
        }

        public int LeaveType_FK
        {
            get { return _leaveType_FK; }
            set { _leaveType_FK = value; }
        }

        public string LeaveDescription
        {
            get { return _leaveDescription; }
            set { _leaveDescription = value; }
        }

        public string StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public string EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public string Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public int Level_FK
        {
            get { return _level_FK; }
            set { _level_FK = value; }
        }

        public string LeaveThreshold
        {
            get { return _leaveThreshold; }
            set { _leaveThreshold = value; }
        }

        public string DateApplied
        {
            get { return _dateApplied; }
            set { _dateApplied = value; }
        }

        public string LeaveStatus
        {
            get { return _leaveStatus; }
            set { _leaveStatus = value; }
        }

        public int LeaveGrantedBy
        {
            get { return _leaveGrantedBy; }
            set { _leaveGrantedBy = value; }
        }

        public string DateGranted
        {
            get { return _dateGranted; }
            set { _dateGranted = value; }
        }

        public string ApproveOrDisapproveReason
        {
            get { return _approveOrDisapproveReason; }
            set { _approveOrDisapproveReason = value; }
        }

        public int Dept_FK
        {
            get { return _dept_FK; }
            set { _dept_FK = value; }
        }

        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }
        #endregion
    }

    //EmployeeLeaveTableLog Info 
    public class EmployeeLeaveTableLogInfo
    {
        #region "Private Members"
        int _leaveLogID;
        int _leaveType_FK;
        string _leaveDescription;
        string _startDate;
        string _endDate;
        string _duration;
        int _level_FK;
        string _leaveThreshold;
        string _dateApplied;
        string _leaveStatus;
        int _leaveGrantedBy;
        string _dateGranted;
        string _approveOrDisapproveReason;
        int _dept_FK;
        int _employeeID_FK;
        int _leaveID_FK;
        #endregion

        #region "Constructors"
        public EmployeeLeaveTableLogInfo()
        {
        }

        public EmployeeLeaveTableLogInfo(int leaveLogID, int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK, int leaveID_FK)
        {
            this.LeaveLogID = leaveLogID;
            this.LeaveType_FK = leaveType_FK;
            this.LeaveDescription = leaveDescription;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Duration = duration;
            this.Level_FK = level_FK;
            this.LeaveThreshold = leaveThreshold;
            this.DateApplied = dateApplied;
            this.LeaveStatus = leaveStatus;
            this.LeaveGrantedBy = leaveGrantedBy;
            this.DateGranted = dateGranted;
            this.ApproveOrDisapproveReason = approveOrDisapproveReason;
            this.Dept_FK = dept_FK;
            this.EmployeeID_FK = employeeID_FK;
            this.LeaveID_FK = leaveID_FK;
        }
        #endregion

        #region "Public Properties"
        public int LeaveLogID
        {
            get { return _leaveLogID; }
            set { _leaveLogID = value; }
        }

        public int LeaveType_FK
        {
            get { return _leaveType_FK; }
            set { _leaveType_FK = value; }
        }

        public string LeaveDescription
        {
            get { return _leaveDescription; }
            set { _leaveDescription = value; }
        }

        public string StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public string EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public string Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public int Level_FK
        {
            get { return _level_FK; }
            set { _level_FK = value; }
        }

        public string LeaveThreshold
        {
            get { return _leaveThreshold; }
            set { _leaveThreshold = value; }
        }

        public string DateApplied
        {
            get { return _dateApplied; }
            set { _dateApplied = value; }
        }

        public string LeaveStatus
        {
            get { return _leaveStatus; }
            set { _leaveStatus = value; }
        }

        public int LeaveGrantedBy
        {
            get { return _leaveGrantedBy; }
            set { _leaveGrantedBy = value; }
        }

        public string DateGranted
        {
            get { return _dateGranted; }
            set { _dateGranted = value; }
        }

        public string ApproveOrDisapproveReason
        {
            get { return _approveOrDisapproveReason; }
            set { _approveOrDisapproveReason = value; }
        }

        public int Dept_FK
        {
            get { return _dept_FK; }
            set { _dept_FK = value; }
        }

        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }

        public int LeaveID_FK
        {
            get { return _leaveID_FK; }
            set { _leaveID_FK = value; }
        }
        #endregion
    }
}
