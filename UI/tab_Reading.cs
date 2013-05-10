using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TPO.UI
{
    public partial class tab_Reading : Component
    {
        public tab_Reading()
        {
            InitializeComponent();
        }

        public tab_Reading(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
