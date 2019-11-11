using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    public List<GraphNode> Nodes = new List<GraphNode>();
    public GraphNode Source, Target;
    List<int> Path = new List<int>();
    public DFS dFS;
    public bool RouteCalculated, PathCalculated;
    //The list is here that has all the nodes
    // Start is called before the first frame update

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
        if (!RouteCalculated)
            RouteCalculated = dFS.CalculateRoute(Source, Target);

    
    }
}
