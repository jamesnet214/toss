using System.Windows;
using System.Windows.Controls.Primitives;

namespace Toss.UI.Units
{
    internal class HeartSwitch : ToggleButton
    {
        static HeartSwitch()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HeartSwitch), new FrameworkPropertyMetadata(typeof(HeartSwitch)));
        }
    }
}
