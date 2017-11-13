using System;
using System.Diagnostics;

namespace Tree
{
    internal class Node
    {
        int key;
        int count;
        Node left, right;

        public Node(int key, int count)
        {
            this.key = key;
            this.count = count;
            left = right = null;
        }
        public int Key
        {
            get
            {
                return key;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
             set
             {
                count = value;
             }
        }

        public Node Left
        {
            get { return left; }
            set { left = value; }
        }


        public Node Right
        {
            get { return right; }
            set { right = value; }
        }
    }
    internal class BST
    {
        Node root;
        public BST()
        {
            Console.WriteLine("Am creat un BST");
            root = null;

        }
        public void Add(int key)
        {
            bool inserted = false;

            Node p = root;
            if (root == null)
            {
                root = new Node(key, 1);
                inserted = true;
                Debug.WriteLine("Am creat nodul radacina");
            }
                
            while (!inserted)
            {
                if (p.Key == key)
                {
                    p.Count = p.Count + 1;
                    inserted = true;
                }
                    
                else if(p.Key > key)
                 {
                    if (p.Left == null)
                    {
                        // creare nou nod
                        Node q;
                        q = new Node(key, 1);
                        p.Left = q;
                        inserted = true;
                    }
                    else
                        p = p.Left;
                        
                 }
                else
                {
                    if (p.Right == null)
                    {
                        Node q;
                        q = new Node(key, 1);
                        p.Right = q;
                        inserted = true;
                    }
                    else
                        p = p.Right;
                }
            }
        }

        internal void Print()
        {
            Print(root);
        }

        internal bool Search(int val)
        {
            Node p = root;

            while (p != null)
            {
                if (p.Key == val)
                    return true;
                else
                    if (p.Key < val)
                        p = p.Right;
                    else
                        p = p.Left;

            }
            return false;
        }

        private void Print(Node p)
        {
            if(p != null)
            {
                Print(p.Left);
                Console.WriteLine("{0}, {1}", p.Key, p.Count);
                Print(p.Right);
            }
        }
    }
}