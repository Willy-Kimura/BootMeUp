using System;
using System.ComponentModel;

namespace WK.Libraries.BootMeUpNS
{
    public partial class BootMeUp : Component
    {
        public BootMeUp()
        {
            InitializeComponent();
        }

        public BootMeUp(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
