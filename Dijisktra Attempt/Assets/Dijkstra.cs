using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Dijkstra : MonoBehaviour
{
    public List<int> Route = new List<int>(); //List of Integers from one node to the other
    public List<bool> Visited = new List<bool>(); //Stores if they have been stored or not
    public List<int> CalculatedPath = new List<int>();  //Makes Path work
    public Graph Map;
    public List<float> Cost = new List<float>();
    public List<dynamic> TraversedEdges = new List<dynamic>();


    public bool CalculateRoute(GraphNode Source, GraphNode Target)
    {

        Cost[Source.index] = 0.0f;
        PriorityQueue<float> MinPriorityQuee = new PriorityQueue<float>();
        for (int i = 0; i < Source.AdjacencyList.Length; i++) ;
        MinPriorityQuee.Enqueue(Source.AdjacencyList[i].GetCost());
        while (graphEdges.Count > 0)


            while

                if (Cost[Edge.To] > Cost[Edge.From] + Edge.GetCost)
    }
}
} 