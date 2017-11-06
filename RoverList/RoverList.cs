using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class RoverList : RoverListBase
    {
        // Add any variables you need here
        Node tail;
        
        public RoverList ()
        {
            count = 0;
            head = null;
            tail = null;
        }

        private int count = 0;
        public override int Count => count;

        public override void Add(object data)
        {
           
            if (head == null)
            {
                head = new Node(data);
                tail = head;
            }
            else
            {
                tail.Next = new Node(data);
                tail = tail.Next; 
            }
        }

        public override void Add(int Position, object data)
        {
            throw new NotImplementedException();
        }

        public override void Clear()
        {
            throw new NotImplementedException();
        }

        public override Node ElementAt(int Position)
        {
            throw new NotImplementedException();
        }

        public override void ListNodes()
        {
            Node node = head;
            while (node != null)
            {
                Console.Write(node.Data + " ");
                node = node.Next;
            }
        }

        public override bool RemoveAt(int Position)
        {
            throw new NotImplementedException();
        }
    }
}
