using System;
using System.Windows;

namespace Sample
{
    /// <summary>Interaction logic for MainWindow.xaml</summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            virtualJoystick.Moved += VirtualJoystick_Moved;
        }

        private void VirtualJoystick_Moved(object sender, WpfCustomControls.VirtualJoystickEventArgs args)
        {
            joystickInfoLabel.Text = $"Joystick Distance:{args.Distance}, Joystick Angle:{(int)args.Angle}";
        }

    }
}