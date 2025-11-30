using Common.Library;

namespace AdventureWorks.EntityLayer.EntityClasses;

public class PhoneType :EntityBase
{
    #region Private Variables
    private int _phoneTypeId;
    private string _typeDescription = string.Empty;
    #endregion

    #region Public Properties
    public int PhoneTypeId
    {
        get => _phoneTypeId;
        set
        {
            _phoneTypeId = value;
            RaisePropertyChanged(nameof(PhoneTypeId));
        }
    }

    public string TypeDescription
    {
        get => _typeDescription;
        set
        {
            _typeDescription = value;
            RaisePropertyChanged(nameof(TypeDescription));
        }
    }
    #endregion
}