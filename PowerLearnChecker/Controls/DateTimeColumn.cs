﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerLearnChecker.Controls
{
    public class DateTimeColumn : DataGridViewTextBoxColumn
    {
        public DateTimeColumn()
        {
            CellTemplate = new DateTimeCell();
        }
    }
}
