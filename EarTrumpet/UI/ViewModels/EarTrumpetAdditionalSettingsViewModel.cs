using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using EarTrumpet.DataModel.Storage;
using EarTrumpet.Properties;
using EarTrumpet.UI.Helpers;

namespace EarTrumpet.UI.ViewModels
{
    public class EarTrumpetAdditionalSettingsViewModel : SettingsPageViewModel
    {
        public ICommand RestoreHiddenApps { get; }
        public EarTrumpetAdditionalSettingsViewModel() : base(null)
        {
            Title = Resources.AdditionalSettingsTitle;
            Glyph = "\xE10C";
            RestoreHiddenApps =
                new RelayCommand(() =>
                {
                    StorageFactory.GetSettings().Set("HIDDEN_APPS", new List<string>());
                    MessageBox.Show(Resources.RestoreHiddenAppsDone, Resources.RestoreHiddenAppsButton);
                });
        }

        public bool ChangeCommDevice
        {
            get => StorageFactory.GetSettings().Get("ChangeCommDevice", false);
            set => StorageFactory.GetSettings().Set("ChangeCommDevice", value);
        }
    }
}