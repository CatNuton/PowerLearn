using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerLearnCreator.Controls
{
    public class SplitButton : ToolStripSplitButton
    {
        protected override void OnDropDownItemClicked(ToolStripItemClickedEventArgs e)
        {
            DefaultItem = e.ClickedItem;
            Text = $"Add {DefaultItem.Text}";
            base.OnDropDownItemClicked(e);
        }
    }
}
