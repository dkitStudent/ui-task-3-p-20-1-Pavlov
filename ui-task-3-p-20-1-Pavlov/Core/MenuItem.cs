using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ui_task_p_20_1_Pavlov.Core
{
    public class MenuItem
    {
        public string Name { get; private set; }

        public PackIconKind Icon { get; private set; }

        public ItemCount Count { get; private set; }

        public MenuItem(string name, PackIconKind icon, ItemCount count)
        {
            Name = name;
            Icon = icon;
            Count = count;
        }
    }
}
