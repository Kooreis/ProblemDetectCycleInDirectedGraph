Here is a simple console application in C# that detects if a directed graph has a cycle. This application uses Depth-First Search (DFS) to detect cycles.

```C#
using System;
using System.Collections.Generic;

public class Graph
{
    private int Vertices;
    private List<int>[] adj;

    public Graph(int v)
    {
        Vertices = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; ++i)
            adj[i] = new List<int>();
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    private bool IsCyclicUtil(int i, bool[] visited, bool[] recStack)
    {
        if (recStack[i])
            return true;

        if (visited[i])
            return false;

        visited[i] = true;

        recStack[i] = true;
        List<int> children = adj[i];

        foreach (int c in children)
            if (IsCyclicUtil(c, visited, recStack))
                return true;

        recStack[i] = false;

        return false;
    }

    private bool IsCyclic()
    {
        bool[] visited = new bool[Vertices];
        bool[] recStack = new bool[Vertices];

        for (int i = 0; i < Vertices; i++)
            if (IsCyclicUtil(i, visited, recStack))
                return true;

        return false;
    }

    public static void Main(string[] args)
    {
        Graph g1 = new Graph(4);
        g1.AddEdge(0, 1);
        g1.AddEdge(0, 2);
        g1.AddEdge(1, 2);
        g1.AddEdge(2, 0);
        g1.AddEdge(2, 3);
        g1.AddEdge(3, 3);
        if (g1.IsCyclic())
            Console.WriteLine("Graph contains cycle");
        else
            Console.WriteLine("Graph doesn't contain cycle");
    }
}
```

This program creates a directed graph with 4 vertices. It then adds 6 edges to the graph. After that, it checks if the graph contains a cycle or not. If the graph contains a cycle, it prints "Graph contains cycle". Otherwise, it prints "Graph doesn't contain cycle".