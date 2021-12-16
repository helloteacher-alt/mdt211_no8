using System;
using System.Collections.Generic;
using System.Text;

namespace mdt211_no8
{
    class Stack
    {
        private Node root;
        public void Push(Node node)
        {
            if(root is null)
            {
                root = node;
            }
            else
            {
                node.next = root;
                root = node;
            }
        }

        public Node Pop()
        {
            Node node = root;
            root = root.next;
            root.next = null;
            return node;
        }
    }

    
}
