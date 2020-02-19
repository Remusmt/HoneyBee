using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Services.TreeStructure
{
    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }
    }
}
