using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Practice_code
{
    public static class Leet_269_Alien_Dictionary
    {
        private static Dictionary<char, HashSet<char>> adj;
        private static Dictionary<char, bool> visited;
        private static List<char> result;

        public static string AlienDictionary(string[] words)
        {
            adj = new Dictionary<char, HashSet<char>>();
            foreach (string word in words)
            {
                foreach (char ch in word)
                {
                    if (!adj.ContainsKey(ch))
                        adj.Add(ch, new HashSet<char>());
                }
            }


            for (int i = 0; i < words.Length - 1; i++)
            {
                string w1 = words[i];
                string w2 = words[i + 1];
                int minLength = Math.Min(w1.Length, w2.Length);

                if (w1.Length > w2.Length && w1.Substring(0, minLength) == w2.Substring(0, minLength))
                {
                    return "";
                }

                for (int j = 0; j < minLength; j++)
                {
                    if (w1[j] != w2[j])
                    {
                        adj[w1[j]].Add(w2[j]);
                        break;
                    }
                }

            }

            visited = new Dictionary<char, bool>();
            result = new List<char>();
            foreach (char ch in adj.Keys)
            {
                if (dfs(ch))
                {
                    return "";
                }
            }

            result.Reverse();
            var sb = new StringBuilder();
            foreach (char ch in result)
            {
                sb.Append(ch);
            }

            return sb.ToString();
        }

        private static bool dfs(char ch)
        {
            if (visited.ContainsKey(ch))
            {
                return visited[ch];
            }

            visited[ch] = true;
            foreach (char next in adj[ch])
            {
                if (dfs(next))
                {
                    return true;
                }
            }
            visited[ch] = false;
            result.Add(ch);
            return false;
        }
    }
}
