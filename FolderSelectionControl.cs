using System;
using System.Windows;

namespace UI
{
    internal class FolderSelectionControl : UIElement
    {
        private Action<object> value;

        public FolderSelectionControl(Action<object> value)
        {
            this.value = value;
        }
    }
}