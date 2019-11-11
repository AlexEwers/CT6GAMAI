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

    }
}