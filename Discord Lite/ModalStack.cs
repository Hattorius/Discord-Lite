using System.Collections.Generic;

namespace Discord_Lite;

public class ModalStack
{
    public MainWindow MainWindow;
    private List<ModalUserControl> _modalStack = new();
    private ModalUserControl? _currentModal;

    private void _updateCurrentModal()
    {
        if (_currentModal == null)
        {
            if (_modalStack.Count == 0)
            {
                MainWindow.RemoveModal();
                return;
            }
            _currentModal = _modalStack[0];
            _modalStack.Remove(_currentModal);
        }
        
        MainWindow.SetCurrentModal(_currentModal);
    }

    public void AddModal(ModalUserControl modal)
    {
        if (_currentModal != null)
        {
            _modalStack.Insert(0, _currentModal);
        }
        _currentModal = modal;

        _updateCurrentModal();
    }

    public void CloseCurrentModal()
    {
        _currentModal = null;
        _updateCurrentModal();
    }
}