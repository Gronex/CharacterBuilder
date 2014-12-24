using GalaSoft.MvvmLight;
using CharacterBuilder.Model;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using CharacterBuilder.Commands;
using CharacterModel;

namespace CharacterBuilder.View
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
        public RelayCommand LoadCharacterCommand { get; private set; }
        public RelayCommand StatRollCommand { get; private set; }

        public Character character = null;


        private CharacterCommand characterCommand = new CharacterCommand();
        private DiceCommand diceCommand = new DiceCommand();
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
        {
            this.NewCharacterCommand = new RelayCommand(CreateNewCharacter);
            this.LoadCharacterCommand = new RelayCommand(characterCommand.LoadCharacter);
            this.StatRollCommand = new RelayCommand(diceCommand.StatRoll);
        }

        private void CreateNewCharacter()
        {
            NewCharacterWindow newCharacterWindow = new NewCharacterWindow();
            newCharacterWindow.Show();
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}