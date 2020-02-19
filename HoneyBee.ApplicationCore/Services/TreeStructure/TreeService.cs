using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Services.TreeStructure
{
    public class TreeService<T>
    {
        public List<TreeNode<T>> GetTree(IReadOnlyList<T> treeNodes)
        {
            List<TreeNode<T>> nodes = new List<TreeNode<T>>();

            foreach (var node in treeNodes)
            {
                nodes.Add(
                    new TreeNode<T>
                    {
                         Data = node
                    }
                );
            }

            return nodes;
    }

        public List<TreeNode<T>> GetFlat(List<TreeNode<T>> treeNodes)
        {
            List<TreeNode<T>> nodes = new List<TreeNode<T>>();
            foreach (var node in treeNodes)
            {
                node.Children = null;
                node.ParentNode = null;
                nodes.Add(node);
            }
            return nodes;
        }
        public List<TreeNode<T>> Children { get; set; }
    }
}
