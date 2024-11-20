import java.util.*;

public class Main {
    private static int V;
    private static LinkedList<Integer> adj[];

    Main(int v) {
        V = v;
        adj = new LinkedList[v];
        for (int i=0; i<v; ++i)
            adj[i] = new LinkedList();
    }