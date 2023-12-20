using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningApp.Model;

namespace LearningApp.ViewModel
{
    class LearmigAppViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Theme> _themes = new ObservableCollection<Theme>();

        public void AddNewTheme(string themeName)
        {
            _themes.Add(new Theme(themeName));
        }

        public void RemoveTheme(string themeName)
        {
            var theme = _themes.FirstOrDefault(t => t.ThemeName == themeName);
            if(theme != null)
            {
                _themes.Remove(theme);
            }
        }

        public void ChangeThemeName(string newThemeName, string currentName)
        {
            _themes.FirstOrDefault(t => t.ThemeName == currentName).ChangeThemeName(newThemeName);            
        }
    }
}
