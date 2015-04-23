using System;
using System.Collections.Generic;
using System.ComponentModel;
 
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using CsQuery;
using CsQuery.HtmlParser;
using CsQuery.Utility;

using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using Description = NUnit.Framework.DescriptionAttribute;
namespace ManualTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CQ cq = CQ.Create("<button>Boo!</button>");
            IHTMLButtonElement buttonElement = cq["button"].FirstElement() as IHTMLButtonElement;
            Assert.IsNotNull(buttonElement);
        }
    }
}
