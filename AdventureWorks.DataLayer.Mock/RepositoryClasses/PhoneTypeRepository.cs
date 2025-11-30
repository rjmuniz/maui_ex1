using System.Collections.ObjectModel;
using AdventureWorks.EntityLayer.EntityClasses;
using Common.Library.Interfaces;

namespace AdventureWorks.DataLayer;

public class PhoneTypeRepository: IRepository<PhoneType>
{
    #region GetAsync Method
    public async Task<ObservableCollection<PhoneType>> GetAsync()
    {
        return await Task.FromResult(
            new ObservableCollection<PhoneType>
            {
                new()
                {
                    PhoneTypeId = 1,
                    TypeDescription = "Home",
                },
                new()
                {
                    PhoneTypeId = 2,
                    TypeDescription = "Mobile",
                },
                new()
                {
                    PhoneTypeId = 3,
                    TypeDescription = "Work",
                },
                new()
                {
                    PhoneTypeId = 4,
                    TypeDescription = "Other",
                }
            }
        );
    }
    #endregion

    #region GetAsync(id) Method
    public async Task<PhoneType?> GetAsync(int id)
    {
        ObservableCollection<PhoneType> list = await GetAsync();
        PhoneType? entity = list.Where(row => 
            row.PhoneTypeId == id).FirstOrDefault();
        return entity;
    }
    #endregion
}