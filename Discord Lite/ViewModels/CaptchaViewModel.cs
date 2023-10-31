namespace Discord_Lite.ViewModels;

public class CaptchaViewModel
{
    public MainWindow? MainWindow;
    public void CloseModal()
    {
        MainWindow?.Modals.CloseCurrentModal();
    }
}