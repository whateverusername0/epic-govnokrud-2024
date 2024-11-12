using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GigaPetProject.Framework.MVVM
{
    /// <summary> Acts as a base for all ViewModels and provides wrappers to simplify work. </summary>
    /// <remarks> Always call the base methods! </remarks>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        protected virtual void Initialize()
        {

        }
    }
}
