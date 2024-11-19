Here is a Python console application that detects if a directed graph has a cycle. This application uses Depth-First Search (DFS) to detect cycles.

```python
from collections import defaultdict

class Graph:
    def __init__(self, num_vertices):
        self.num_vertices = num_vertices
        self.graph = defaultdict(list)

    def add_edge(self, u, v):
        self.graph[u].append(v)

    def is_cyclic_util(self, v, visited, rec_stack):
        visited[v] = True
        rec_stack[v] = True

        for neighbor in self.graph[v]:
            if visited[neighbor] == False:
                if self.is_cyclic_util(neighbor, visited, rec_stack) == True:
                    return True
            elif rec_stack[neighbor] == True:
                return True

        rec_stack[v] = False
        return False

    def is_cyclic(self):
        visited = [False] * (self.num_vertices + 1)
        rec_stack = [False] * (self.num_vertices + 1)
        for node in range(self.num_vertices):
            if visited[node] == False:
                if self.is_cyclic_util(node, visited, rec_stack) == True:
                    return True
        return False

if __name__ == "__main__":
    g = Graph(4)
    g.add_edge(0, 1)
    g.add_edge(1, 2)
    g.add_edge(2, 3)
    g.add_edge(3, 0)

    if g.is_cyclic() == 1:
        print("Graph contains cycle")
    else:
        print("Graph doesn't contain cycle")
```

In this application, you first create a graph with a specified number of vertices using the `Graph` class. You can then add edges to the graph using the `add_edge` method. The `is_cyclic` method checks if the graph contains a cycle and returns `True` if it does and `False` otherwise. The `is_cyclic_util` method is a helper method used by `is_cyclic` to perform the depth-first search.