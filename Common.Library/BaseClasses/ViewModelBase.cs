
namespace Common.Library;

public class ViewModelBase : CommonBase
{
    #region Private Variables
    private int _rowsAffected;
    #endregion

    #region Public Properties
    public int RowsAffected
    {
        get => _rowsAffected; 
        set
        {
            _rowsAffected = value;
            RaisePropertyChanged(nameof(RowsAffected));
        }
    }
    #endregion

    #region PublishException Method
    protected virtual void PublishException(Exception ex)
    {
        LastException = ex;
        System.Diagnostics.Debug.WriteLine(ex.ToString());
    }
    #endregion
}
