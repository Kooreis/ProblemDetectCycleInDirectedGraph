```C#
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
```