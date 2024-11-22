# Question: How do you detect if a directed graph has a cycle? C# Summary

The provided C# code is a console application that determines whether a directed graph contains a cycle. The application first creates a directed graph with a specified number of vertices and edges. It then uses a Depth-First Search (DFS) algorithm to detect cycles in the graph. The DFS algorithm is implemented in the `IsCyclicUtil` method, which recursively visits each vertex in the graph. It uses two boolean arrays, `visited` and `recStack`, to keep track of the vertices that have been visited and the vertices currently in the recursion stack, respectively. If a vertex is encountered that is already in the recursion stack, a cycle is detected. If all vertices are visited and no cycle is detected, the graph is deemed acyclic. The result is then printed to the console.

---

# Python Differences

Both the C# and Python versions solve the problem using the same algorithmic approach, which is Depth-First Search (DFS). They both use a recursive helper function (`IsCyclicUtil` in C# and `is_cyclic_util` in Python) to perform the DFS and detect cycles.

However, there are some differences in the language features and methods used:

1. Data Structures: In C#, the graph is represented using an array of lists (`List<int>[] adj`). Each index of the array represents a vertex, and the list at each index represents the adjacent vertices. In Python, the graph is represented using a dictionary (`defaultdict(list) graph`), where each key-value pair represents a vertex and its adjacent vertices.

2. Initialization: In C#, the `Graph` class requires explicit initialization of the adjacency list for each vertex in the constructor. In Python, the `defaultdict` automatically initializes an empty list for each vertex when it's first accessed, so no explicit initialization is needed.

3. Boolean Arrays: In C#, boolean arrays (`bool[] visited` and `bool[] recStack`) are used to keep track of visited vertices and vertices in the recursion stack. In Python, the same concept is used, but the arrays are initialized using list comprehension (`[False] * (self.num_vertices + 1)`).

4. Looping: In C#, a `foreach` loop is used to iterate over the children of a vertex. In Python, a `for` loop is used for the same purpose.

5. Function Calls: In C#, the `IsCyclicUtil` function is called with the `if` statement to check if a cycle exists. In Python, the `is_cyclic_util` function is called within the `if` statement as well, but the comparison to `True` is explicit.

6. Main Function: In C#, the main function is a static method within the `Graph` class. In Python, the main function is not within the `Graph` class and is only executed if the script is run directly (not imported as a module), as indicated by `if __name__ == "__main__":`.

7. Printing: In C#, `Console.WriteLine` is used to print to the console. In Python, the `print` function is used.

---

# Java Differences

Both the C# and Java versions of the solution use the same approach to solve the problem. They both use Depth-First Search (DFS) to detect cycles in a directed graph. The main difference between the two versions is the language syntax and the data structures used.

In the C# version, the graph is represented using an array of lists (`List<int>[] adj`). In the Java version, the graph is represented using an array of LinkedLists (`LinkedList<Integer>[] adj`). The use of LinkedList in Java is similar to the use of List in C#. Both are used to store the adjacency lists for each vertex in the graph.

The methods `AddEdge` in C# and `addEdge` in Java are used to add an edge to the graph. They both take two integers as parameters representing the vertices of the edge.

The methods `IsCyclicUtil` in C# and `isCyclicUtil` in Java are recursive helper methods used in the DFS traversal of the graph. They both take an integer and two boolean arrays as parameters. The integer represents the current vertex, the first boolean array keeps track of the visited vertices, and the second boolean array keeps track of the vertices in the recursion stack.

The methods `IsCyclic` in C# and `isCyclic` in Java are used to check if the graph contains a cycle. They both initialize two boolean arrays for visited vertices and recursion stack, and then call the `IsCyclicUtil` or `isCyclicUtil` method for each vertex in the graph.

The `Main` method in C# and the `main` method in Java are the entry points of the programs. They both create a graph, add edges to it, and then check if it contains a cycle.

In terms of language features, C# uses `foreach` for iteration while Java uses the enhanced for loop. Also, C# uses `bool` for boolean values while Java uses `boolean`. The print statements are also different due to language differences (`Console.WriteLine` in C# vs `System.out.println` in Java).

---
