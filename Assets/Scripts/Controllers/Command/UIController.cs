using System.Collections.Generic;
using UnityEngine;


namespace Asteroids
{
    public class UIController
    {
        private readonly InfoWindow _infoWindow;
        private readonly Stack<UIState> _stateUI = new Stack<UIState>();
        private IUI _currentWindow;

        public UIController( InfoWindow infoWindow)
        {
            _infoWindow = infoWindow;
            _infoWindow.Cancel();
        }

        public void Execute(UIState uiState, bool isSave = true)
        {
            if (_currentWindow != null)
            {
                _currentWindow.Cancel();
            }

            switch (uiState)
            {
                case UIState.InfoPanel:
                    _currentWindow = _infoWindow;
                    break;
                default:
                    _currentWindow = null;
                    break;
            }

            _currentWindow?.Execute();
            if (isSave)
            {
                _stateUI.Push(uiState);
            }
        }

        public void RestoreStep()
        {
            if (_stateUI.Count > 0)
            {
                Execute(_stateUI.Pop(), false);
            }
            else
            {
                Execute(UIState.None, false);
            }
        }
    }
}

