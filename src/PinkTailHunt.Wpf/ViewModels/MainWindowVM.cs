using System;
using System.Windows.Input;
using SysadminsLV.WPF.OfficeTheme.Toolkit.Commands;
using SysadminsLV.WPF.OfficeTheme.Toolkit.ViewModels;

namespace PinkTailHunt.Wpf.ViewModels {
    class MainWindowVM : ViewModelBase {
        Hunt hunt;
        int timeSpentSeconds,
            encounters,
            flanPrincessesKilled,
            gilEarned,
            expEarned,
            runTimes,
            sirensStart,
            sirensLeft,
            starDustsStart,
            starDustsLeft;

        TimeSpan totalTimeSpent;

        public MainWindowVM() {
            HuntCommand = new RelayCommand(goHunt);
        }

        public ICommand HuntCommand { get; set; }

        public TimeSpan TotalTimeSpent {
            get => totalTimeSpent;
            set {
                totalTimeSpent = value;
                OnPropertyChanged(nameof(TotalTimeSpent));
            }
        }

        public int SirensStart {
            get => sirensStart;
            set {
                sirensStart = value;
                OnPropertyChanged(nameof(SirensStart));
            }
        }

        public int StarDustsStart {
            get => starDustsStart;
            set {
                starDustsStart = value;
                OnPropertyChanged(nameof(StarDustsStart));
            }
        }
        public int Encounters {
            get => encounters;
            set {
                encounters = value;
                OnPropertyChanged(nameof(Encounters));
            }
        }
        public int FlanPrincessesKilled {
            get => flanPrincessesKilled;
            set {
                flanPrincessesKilled = value;
                OnPropertyChanged(nameof(FlanPrincessesKilled));
            }
        }

        public int GilEarned {
            get => gilEarned;
            set {
                gilEarned = value;
                OnPropertyChanged(nameof(GilEarned));
            }
        }

        public int ExpEarned {
            get => expEarned;
            set {
                expEarned = value;
                OnPropertyChanged(nameof(ExpEarned));
            }
        }

        public int RunTimes {
            get => runTimes;
            set {
                runTimes = value;
                OnPropertyChanged(nameof(RunTimes));
            }
        }

        public int SirensLeft {
            get => sirensLeft;
            set {
                sirensLeft = value;
                OnPropertyChanged(nameof(SirensLeft));
            }
        }

        public int StarDustsLeft {
            get => starDustsLeft;
            set {
                starDustsLeft = value;
                OnPropertyChanged(nameof(StarDustsStart));
            }
        }

        void goHunt(object o) {
            hunt = new Hunt(SirensStart, StarDustsStart);
            TotalTimeSpent = hunt.TotalTimeSpent;
            Encounters = hunt.Encounters;
            FlanPrincessesKilled = hunt.FlanPrincessesKilled;
            GilEarned = hunt.GilEarned;
            ExpEarned = hunt.ExpEarned;
            RunTimes = hunt.RunTimes;
            SirensLeft = hunt.SirensLeft;
            StarDustsLeft = hunt.StarDustsLeft;
        }
    }
}
