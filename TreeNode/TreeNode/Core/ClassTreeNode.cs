using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeNode
{
    public struct ClassTreeNode
    {
        public int Value;
        public List<ClassTreeNode> Children;

        public ClassTreeNode(int value)
        {
            Value = value;
            Children = new List<ClassTreeNode>();
        }
    }
}
