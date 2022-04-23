using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace TossBinding.UI.Units
{
    public class HeartSwitch : ToggleButton
    {
        #region DefaultStyleKey

        static HeartSwitch()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HeartSwitch), new FrameworkPropertyMetadata(typeof(HeartSwitch)));
        }
        #endregion
    }
}
