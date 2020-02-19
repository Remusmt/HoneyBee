using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Services.TreeStructure
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> ParentNode { get; set; }
        public List<TreeNode<T>> Children { get; set; }
        public int Level
        {
            get
            {
                int height = 1;
                TreeNode<T> current = this;
                while (current.ParentNode != null)
                {
                    height++;
                    current = current.ParentNode;
                }

                return height;
            }
        }
    }
}
