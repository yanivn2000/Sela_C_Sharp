using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace GraphD
{
    class Graph
    {
        int[,] a = {
            {-1, 10, -1, -1, -1, -1, 2, -1, 6 },//0
            {10, -1, 5, -1, -1, 7, -1, -1, -1 },//1
            {-1, 5, -1, 12, -1, -1, -1, -1, -1 },//2
            {-1, -1, 12, -1, -1, -1, -1, 8, -1 },//3
            {-1, -1, -1, -1, -1, 11, 17, 4, 23 },//4
            {-1, 7, -1, -1, 11, -1, -1, -1, -1 },//5
            {2, -1, -1, -1, 17, -1, -1, -1, -1 },//6
            {-1, -1, -1, 8, 4, -1, -1, -1, 14 },//7
            {6, -1, -1, -1, 23, -1, -1, 14, -1 },//8
        };

        //a.Length = 9*9 -> 91
        //a.GetLength(0) - number of rows
        //a.GetLength(1) - number of columns

        public bool IsPathExists(int source, int dest, int maxSteps)
        {
            bool[] visited = new bool[a.GetLength(1)];
            visited[source] = true;
            return IsPathExists(source, dest, maxSteps, visited);

        }

        private bool IsPathExists(int source, int dest, int maxSteps, bool[] visited)
        {
            if (source == dest) return true;
            if (maxSteps == 0) return false;

            for (int i = 0; i < a.GetLength(1)/*cols*/; i++)
            {
                if (a[source, i] != -1 && visited[i] == false) //there is an edge between sourse and i (for each possible i) 
                {
                    visited[i] = true;
                    bool isFound = IsPathExists(i, dest, maxSteps - 1);
                    if (isFound) return true;
                    visited[i] = false;
                }
            }
            return false;
        }

        public List<Path> FindAllPaths(int source, int dest)
        {
            List<Path> all = new List<Path>();
            bool[] visited = new bool[a.GetLength(1)];
            //this is the default - we start at this node so we never want to go through this node again
            visited[source] = true;

            FindAllPaths(source, dest, all, visited);
            return all;
        }

        void FindAllPaths(int source, int dest, List<Path> all, bool[] visited)
        {
            if(source == dest)
            {
                all.Add(new Path());
                return;
            }

            for (int i = 0; i < a.GetLength(1)/*cols*/; i++)
            {
                if (a[source, i] > 0 && visited[i] == false)
                {
                    visited[i] = true;
                    int lenBefore = all.Count; 
                    FindAllPaths(i, dest, all, visited);
                    int lenAfter = all.Count; 
                    for (int j = lenBefore; j < lenAfter; j++)
                    {
                        all[j].vertices.AddFirst(i);
                        all[j].totalWeight += a[source, i];
                    }

                    visited[i] = false;
                }
            }
        }

        public class Path
        {
           public int totalWeight;
           public LinkedList<int> vertices;

            public Path()
            {
                vertices = new LinkedList<int>();
                totalWeight = 0;
            }
        }
       
    }
}
