using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable] // Need this to show the adjectency list in the editor
public class GraphEdge
{
    public GraphNode from;
    public GraphNode to;
    public GraphEdge(GraphNode from, GraphNode to)
    {
        this.from = from; //  Sets Graph Egde From to From
        this.to = to; // Sets Graph Edge to to to


    }
    public float GetCost()
    {
        return from.cost + to.cost;
    }
}