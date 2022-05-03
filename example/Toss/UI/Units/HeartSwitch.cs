using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
