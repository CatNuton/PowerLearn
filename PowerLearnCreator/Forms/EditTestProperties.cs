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
    public partial class TestPropertiesEditor : BaseEditor
    {
        private readonly Test origTest;
        private readonly Test editTest;

        public TestPropertiesEditor()
        {
            InitializeComponent();
        }

        public TestPropertiesEditor(Test test) : this()
        {
            origTest = test;
            editTest = new Test
            {
                Name = test.Name,
                Description = test.Description,
                Type = test.Type,
                CanLernersSeeAllQuestions = test.CanLernersSeeAllQuestions
            };
            pgAnswerProperties.SelectedObject = this.editTest;
        }

        protected override void ApplyChanges()
        {
            origTest.Name = editTest.Name;
            origTest.Description = editTest.Description;
            origTest.Type = editTest.Type;
            origTest.CanLernersSeeAllQuestions = editTest.CanLernersSeeAllQuestions;
            base.ApplyChanges();
        }
    }
}
