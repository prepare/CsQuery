using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using CsQuery.HtmlParser;
using System.IO;
namespace ManualTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CQ cq = CQ.Create("<button>Boo!</button>");
            //IHTMLButtonElement buttonElement = cq["button"].FirstElement() as IHTMLButtonElement;
            //Assert.IsNotNull(buttonElement); 
            ParseHtmlFragment("<button>Boo!<div>ABD</div></button>");
        }
        void ParseHtmlFragment(string htmlFragment)
        {
            using (Stream s = new MemoryStream(Encoding.UTF8.GetBytes(htmlFragment.ToCharArray())))
            {
                var domdoc = ElementFactory.Create(s,
                      Encoding.UTF8,
                      CsQuery.HtmlParsingMode.Fragment,
                      CsQuery.HtmlParsingOptions.Default,
                      CsQuery.DocType.HTML5);


                this.treeView1.Nodes.Clear();

                var treeNode = new TreeNode("root");
                treeView1.Nodes.Add(treeNode);
                if (domdoc.HasChildren)
                {
                    foreach (var child in domdoc.ChildNodes)
                    {
                        DescribeDomNode(child, treeNode);
                    }
                }

                this.treeView1.ExpandAll();
            }
        }
        void DescribeDomNode(CsQuery.IDomNode domnode, TreeNode parentTreeNode)
        {
            var treeNode = new TreeNode(domnode.ToString());
            parentTreeNode.Nodes.Add(treeNode);
            if (domnode.HasChildren)
            {
                foreach (var child in domnode.ChildNodes)
                {
                    DescribeDomNode(child, treeNode);
                }
            }
            

        }

    }
}
