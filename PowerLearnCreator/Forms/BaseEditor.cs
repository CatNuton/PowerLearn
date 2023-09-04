using PowerLearn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerLearnCreator.Forms
{
    public partial class BaseEditor : Form
    {
        public event EventHandler ChangesApplied;

        public BaseEditor()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            ApplyChanges();
        }
        private void btn_Apply_Click(object sender, EventArgs e)
        {
            ApplyChanges();
            OnChangesApplied();
        }
        protected virtual void OnChangesApplied()
        {
            ChangesApplied?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void ApplyChanges()
        {
            btn_Apply.Enabled = false;
            btn_OK.Enabled = false;
        }

        private void pgAnswerProperties_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            btn_Apply.Enabled = true;
            btn_OK.Enabled = true;
        }
    }
}