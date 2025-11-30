using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Common.Library
{
    public abstract class CommonBase : INotifyPropertyChanged
    {
        #region Constructor
        protected CommonBase()
        {
            Init();
        }
        #endregion

        #region Init Method
        /// <summary>
        /// Initialize properties
        /// </summary>
        protected virtual void Init()
        {
        }
        #endregion

        #region Private/Protected Variables
        private string _InfoMessage = string.Empty;
        private string _LastErrorMessage = string.Empty;
        private Exception? _LastException = null;

        protected const string REPO_NOT_SET = "The Repository Object is not Set.";
        #endregion

        #region Public Properties
        [NotMapped]
        [JsonIgnore]
        public string InfoMessage
        {
            get => _InfoMessage;
            set
            {
                _InfoMessage = value;
                RaisePropertyChanged(nameof(InfoMessage));
            }
        }

        [NotMapped]
        [JsonIgnore]
        public string LastErrorMessage
        {
            get => _LastErrorMessage; 
            set
            {
                _LastErrorMessage = value;
                RaisePropertyChanged(nameof(LastErrorMessage));
            }
        }

        [NotMapped]
        [JsonIgnore]
        public Exception? LastException
        {
            get  =>_LastException; 
            set
            {
                _LastException = value;
                LastErrorMessage = _LastException == null ? 
                    string.Empty : _LastException.Message;
                RaisePropertyChanged(nameof(LastException));
            }
        }
        #endregion
        
        #region RaisePropertyChanged Method
        /// <summary>
        /// Event used to raise changes
        /// to any bound UI objects
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, 
                new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}