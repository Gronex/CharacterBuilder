using GalaSoft.MvvmLight;
using CharacterBuilder.Model;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using CharacterBuilder.Commands;

namespace CharacterBuilder.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand NewCharacterCommand { get; private set; }


        private NewCharacterCommand newCharacterCommand = new NewCharacterCommand();
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
        {
            this.NewCharacterCommand = new RelayCommand(newCharacterCommand.CreateNew);
        }

        private void NewCharacter()
        {
            MessageBox.Show("New!!");
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}