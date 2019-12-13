using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    public static Graph Map;
    public List<GraphNode> Nodes = new List<GraphNode>();
    List<int> Path = new List<int>();
    public BFS bfs;
    public DFS Dfs;
    public bool RouteCalculated, PathCalculated;
    //The list is here that has all the nodes
    // Start is called before the first frame update
    private void Awake()
    {
        Map = this;
    }
    void Start()
    {
        int i = 0;
        foreach (var item in Nodes)
        {
            item.name = "Node" + i;
            item.index = i;
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Map = this;
    }
}
