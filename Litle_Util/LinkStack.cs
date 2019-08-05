using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Litle_Util
{
    public class LinkStack<T>
    {
        
        private LinkStack<T> head;
        private LinkStack<T> next;
        private T node;
        private String msg;
        List<AttrFilter.Node> nodes;

        public LinkStack<T> Head { get => head; set => head = value; }
        public LinkStack<T> Next { get => next; set => next = value; }
        public T Node { get => node; set => node = value; }
        public string Msg { get => msg; set => msg = value; }
        public List<AttrFilter.Node> Nodes { get => nodes; set => nodes = value; }
    }
}
