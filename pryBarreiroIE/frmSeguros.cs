using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryBarreiroIE
{
    public partial class frmSeguros : Form
    {
        public frmSeguros()
        {
            InitializeComponent();
        }

        private void PopulateTreeView() 
        {
            TreeNode nodoMadre;

            DirectoryInfo info = new DirectoryInfo(@"../..");
            if (info.Exists )
            {
                nodoMadre = new TreeNode(info.Name);
                nodoMadre.Tag = info;
                treeView1.Nodes.Add(nodoMadre);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
