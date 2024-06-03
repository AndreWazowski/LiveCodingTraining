using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingTraining.Trees {
    public static class InvertBinaryTree {
        public static TreeNode InvertTree(TreeNode root) {
            if (root is null) return root;

            (root.right, root.left) = (root.left, root.right);

            InvertTree(root.left);
            InvertTree(root.right);

            /*
                var node = new TreeNode(root.val);

                node.right = InvertTree(root.left);
                node.left = InvertTree(root.right);
             */

            return root;
        }
    }

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
