
using OtusAlgoTrie;

Trie trie = new Trie();
trie.Insert("apple");
bool a1 = trie.Search("apple"); // return true
bool a2 = trie.Search("app");   // return false
bool a3 = trie.StartsWith("app"); // return true
trie.Insert("app");
bool a4 = trie.Search("app"); // return true

var test = 0;