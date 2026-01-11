namespace TarkovBuddie.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _mapOverlayHotKeyDisplay = "[Not Bound]";

    public MapViewModel MapViewModel { get; }
    public ItemsTrackerViewModel ItemsTrackerViewModel { get; }
    
    public string MapOverlayHotKeyDisplay
    {
        get => _mapOverlayHotKeyDisplay;
        set => SetProperty(ref _mapOverlayHotKeyDisplay, value);
    }

    public MainWindowViewModel()
    {
        MapViewModel = new MapViewModel();
        ItemsTrackerViewModel = new ItemsTrackerViewModel();
    }

    public void SetMapOverlayHotKey(string displayText)
    {
        MapOverlayHotKeyDisplay = displayText;
    }
}
