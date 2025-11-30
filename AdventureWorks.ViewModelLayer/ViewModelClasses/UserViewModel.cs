using System.Collections.ObjectModel;
using AdventureWorks.EntityLayer.EntityClasses;
using Common.Library;
using Common.Library.Interfaces;

namespace AdventureWorks.ViewModelLayer.ViewModelClasses;

public sealed class UserViewModel(
    IRepository<User> repository,
    IRepository<PhoneType> phoneTypeRepository) : ViewModelBase
{
    #region Private Variables

    private User? _currentEntity = new();
    private ObservableCollection<string> _phoneTypesList = [];

    #endregion

    #region Public Properties

    public User? CurrentEntity
    {
        get => _currentEntity;
        set
        {
            _currentEntity = value;
            RaisePropertyChanged(nameof(CurrentEntity));
        }
    }

    public ObservableCollection<string> PhoneTypesList
    {
        get => _phoneTypesList;
        set
        {
            _phoneTypesList = value;
            RaisePropertyChanged(nameof(PhoneTypesList));
        }
    }

    #endregion

    #region GetPhoneTypes Method

    public async Task<ObservableCollection<string>> GetPhoneTypes()
    {
        var list = await phoneTypeRepository.GetAsync();
        PhoneTypesList = new ObservableCollection<string>(list.Select(row =>
            row.TypeDescription));

        return PhoneTypesList;
    }

    #endregion

    #region GetAsync Method

    public async Task<ObservableCollection<User>> GetAsync()
    {
        RowsAffected = 0;
        return await Task.FromResult(new ObservableCollection<User>());
    }

    #endregion

    #region GetAsync(id) Method

    public async Task<User?> GetAsync(int id)
    {
        try
        {
            if (repository != null)
            {
                CurrentEntity = await repository.GetAsync(id);
                if (CurrentEntity == null)
                {
                    InfoMessage = $"User id={id} was not found.";
                }
                else
                {
                    InfoMessage = "Found the User";
                }
            }
            else
            {
                LastErrorMessage = REPO_NOT_SET;
                InfoMessage = "Found a MOCK User";
                // MOCK Data
                CurrentEntity = await Task.FromResult(new User
                {
                    UserId = id,
                    LoginId = "SallyJones615",
                    FirstName = "Sally",
                    LastName = "Jones",
                    Email = "Sallyj@jones.com",
                    Phone = "615.987.3456",
                    PhoneType = "Mobile",
                    IsFullTime = true,
                    IsEnrolledIn401k = true,
                    IsEnrolledInFlexTime = false,
                    IsEnrolledInHealthCare = true,
                    IsEnrolledInHSA = false,
                    IsEmployed = true,
                    BirthDate = Convert.ToDateTime("08-13-1989"),
                    StartTime = new TimeSpan(7, 30, 0)
                });
            }

            RowsAffected = 1;
        }
        catch (Exception ex)
        {
            RowsAffected = 0;
            PublishException(ex);
        }

        return CurrentEntity;
    }

    #endregion

    #region SaveAsync Method

    public async Task<User?> SaveAsync()
    {
        // TODO: Write code to save data
        System.Diagnostics.Debugger.Break();
        return await Task.FromResult(new User());
    }

    #endregion
}