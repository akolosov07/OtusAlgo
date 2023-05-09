using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusAlgoTrie
{
    public class Trie
    {
        const int A = 128;
        Node root;

        public Trie()
        {
            root = new Node();
        }

        public void Insert(string word)
        {
            Node node = root;
            foreach (char c in word)
            {
                node = node.Next(c);
            }
            node.isEnd = true;
        }

        public bool Search(string word)
        {
            Node node = Go(word);
            if (node == null)
                return false;
            return node.isEnd;
        }

        public bool StartsWith(string prefix)
        {
            return Go(prefix) != null;
        }

        Node Go(string word)
        {
            Node node = root;
            foreach (char c in word)
                if (node.Exists(c))
                    node = node.Next(c);
                else return null;
            return node;
        }

        class Node
        {
            public Node[] child;
            public bool isEnd;

            public Node()
            {
                child = new Node[A];
                isEnd = false;
            }

            public Node Next(char c)
            {
                if (!Exists(c))
                    child[c] = new Node();
                return child[c];
            }

            public bool Exists(char c)
            {
                return child[c] != null;
            }
        }
    }
}
