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
}
```