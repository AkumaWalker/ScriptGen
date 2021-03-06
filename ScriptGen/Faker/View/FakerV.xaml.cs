﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScriptGen.Faker.View
{
    public partial class FakerV : UserControl
    {
        public FakerV()
        {
            InitializeComponent();
        }

        private void ClearFocus(FrameworkElement focusElement)
        {
            if (focusElement == null)
                return;

            FrameworkElement parent = (FrameworkElement)focusElement.Parent;
            while (parent != null && parent is IInputElement && !((IInputElement)parent).Focusable)
                parent = (FrameworkElement)parent.Parent;

            DependencyObject scope = FocusManager.GetFocusScope(focusElement);
            FocusManager.SetFocusedElement(scope, parent as IInputElement);

            Keyboard.ClearFocus();
        }

        private void ClearFocus(object sender, RoutedEventArgs e)
            => ClearFocus((FrameworkElement)FocusManager.GetFocusedElement(this));

        private void LostFocusOnEnter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ClearFocus((FrameworkElement)sender);

                e.Handled = true;
            }
        }
    }
}
