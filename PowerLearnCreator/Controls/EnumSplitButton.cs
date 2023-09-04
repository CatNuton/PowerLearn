using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerLearnCreator.Controls
{
    public class EnumSplitButton<T> : SplitButton where T : struct, Enum
    {
        public T SelectedValue { get; set; }

        public EnumSplitButton()
        {
            var t = typeof(T);
            var names = Enum.GetNames(typeof(T));
            foreach (var name in names)
            {
                var mi = t.GetMember(name)[0];
                var da = mi.GetCustomAttribute<DescriptionAttribute>();
                var tsmi = new ToolStripMenuItem
                {
                    Name = name,
                    Text = name,
                };
                if (da != null)
                {
                    tsmi.Text = da.Description;
                }
                DropDownItems.Add(tsmi);
            }
        }
    }
}
