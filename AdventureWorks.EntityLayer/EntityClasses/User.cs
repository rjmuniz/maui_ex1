using Common.Library;
namespace AdventureWorks.EntityLayer.EntityClasses;
public class User : EntityBase 
{
  #region Private Variables
  private int _UserId;
  private string _LoginId = string.Empty;
  private string _FirstName = string.Empty;
  private string _LastName = string.Empty;
  private string _Email = string.Empty;
  private string _Password = string.Empty;
  private string _Phone = string.Empty;
  private string _PhoneType = string.Empty;
  private bool _IsFullTime;
  private bool _IsEnrolledIn401k;
  private bool _IsEnrolledInHealthCare;
  private bool _IsEnrolledInHSA;
  private bool _IsEnrolledInFlexTime;
  private bool _IsEmployed;
  private DateTime _BirthDate = DateTime.Now.AddYears(-18);
  private TimeSpan? _StartTime = new(8, 0, 0);
  #endregion
  
  #region Public Properties
  public int UserId 
  {
    get => _UserId;
    set 
    {
      _UserId = value;
      RaisePropertyChanged(nameof(UserId));
    }
  }
  
  public string LoginId 
  {
    get => _LoginId;
    set {
      _LoginId = value;
      RaisePropertyChanged(nameof(LoginId));
    }
  }
  
  public string FirstName 
  {
    get => _FirstName;
    set {
      _FirstName = value;
      RaisePropertyChanged(nameof(FirstName));
    }
  }
  
  public string LastName 
  {
    get => _LastName;
    set {
      _LastName = value;
      RaisePropertyChanged(nameof(LastName));
    }
  }
  
  public string Email 
  {
    get => _Email;
    set {
      _Email = value;
      RaisePropertyChanged(nameof(Email));
    }
  }
  
  public string Password 
  {
    get => _Password;
    set {
      _Password = value;
      RaisePropertyChanged(nameof(Password));
    }
  }
  
  public string Phone 
  {
    get => _Phone;
    set {
      _Phone = value;
      RaisePropertyChanged(nameof(Phone));
    }
  }
  
  public string PhoneType 
  {
    get => _PhoneType;
    set {
      _PhoneType = value;
      RaisePropertyChanged(nameof(PhoneType));
    }
  }
  
  public bool IsFullTime 
  {
    get => _IsFullTime;
    set {
      _IsFullTime = value;
      RaisePropertyChanged(nameof(IsFullTime));
    }
  }
  
  public bool IsEnrolledIn401k 
  {
    get => _IsEnrolledIn401k;
    set {
      _IsEnrolledIn401k = value;
      RaisePropertyChanged(nameof(IsEnrolledIn401k));
    }
  }
  
  public bool IsEnrolledInHealthCare 
  {
    get => _IsEnrolledInHealthCare;
    set {
      _IsEnrolledInHealthCare = value;
      RaisePropertyChanged(nameof(IsEnrolledInHealthCare));
    }
  }
  
  public bool IsEnrolledInHSA 
  {
    get => _IsEnrolledInHSA;
    set {
      _IsEnrolledInHSA = value;
      RaisePropertyChanged(nameof(IsEnrolledInHSA));
    }
  }
  
  public bool IsEnrolledInFlexTime 
  {
    get => _IsEnrolledInFlexTime;
    set {
      _IsEnrolledInFlexTime = value;
      RaisePropertyChanged(
        nameof(IsEnrolledInFlexTime));
    }
  }
  
  public bool IsEmployed 
  {
    get => _IsEmployed;
    set {
      _IsEmployed = value;
      RaisePropertyChanged(nameof(IsEmployed));
    }
  }
  
  public DateTime BirthDate
  {
    get => _BirthDate;
    set {
      _BirthDate = value;
      RaisePropertyChanged(nameof(BirthDate));
    }
  }

  public TimeSpan? StartTime 
  {
    get => _StartTime;
    set {
      _StartTime = value;
      RaisePropertyChanged(nameof(StartTime));
    }
  }
  
  public string FullName => FirstName + " " + LastName;

  public string LastNameFirstName => LastName + ", " + FirstName;

  #endregion
}