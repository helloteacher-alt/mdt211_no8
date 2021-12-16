using System;
using System.Collections.Generic;
using System.Text;

namespace mdt211_no8
{
    class Node
    {
        public Node next;
        public char piece;
        public Node(char pieceValue)
        {
            piece = pieceValue;
        }
    }
}
