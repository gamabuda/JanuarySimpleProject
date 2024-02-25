using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RTS.Lib
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Unit _unit;

        public Unit Unit
        {
            get { return _unit; }
            set
            {
                _unit = value;
                OnPropertyChanged(nameof(Unit));
            }
        }

        public ICommand IncreaseStrengthCommand { get; private set; }
        public ICommand DecreaseStrengthCommand { get; private set; }
        // ... другие команды для других характеристик ...

        public MainWindowViewModel()
        {
            _unit = new Unit();
            IncreaseStrengthCommand = new RelayCommand(IncreaseStrength);
            DecreaseStrengthCommand = new RelayCommand(DecreaseStrength);
            // ... инициализация других команд ...
        }

        private void IncreaseStrength()
        {
            _unit.IncreaseStrength();
            OnPropertyChanged(nameof(Unit));
        }

        private void DecreaseStrength()
        {
            _unit.DecreaseStrength();
            OnPropertyChanged(nameof(Unit));
        }

        // ... методы для других характеристик ...

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
