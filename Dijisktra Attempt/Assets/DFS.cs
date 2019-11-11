using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DFS : MonoBehaviour
{

    public List<int> Route = new List<int>(); //List of Integers from one node to the other
    public List<bool> Visited = new List<bool>(); //Stores if they have been stored or not
    public List<int> CalculatedPath = new List<int>();  //Makes Path work
    public Graph Map;
    public List<int> CalculatePath(GraphNode Source, GraphNode Target) //Coding the route
    {
        List<int> Path = new List<int>();
        int currentNode = Target.index;
        Path.Add(currentNode);
        while (currentNode != Source.index) 
        {
            currentNode = Route[currentNode];
            Path.Add(currentNode);
        }
        return Path;
    }
    public bool CalculateRoute(GraphNode Source, GraphNode Target)
    {
        Stack<GraphEdge> graphEdges = new Stack<GraphEdge>(); //Thats the stack
        Route = new List<int>(Map.Nodes.Count);
        Visited = new List<bool>(Map.Nodes.Count);
        for (int i = 0; i < Map.Nodes.Count; i++)// Looping through the map node
        {
            Route.Add(-10);
            Visited.Add(false); //This initalises both the lists, 
        }
        for (int i = 0; i < Source.AdjacencyList.Length; i++) //LIFO
            graphEdges.Push(Source.AdjacencyList[i]); //Adding all the adjactency edges to the start node
        Visited[Source.index] = true;
        while (graphEdges.Count > 0)
        {
            GraphEdge edge = graphEdges.Pop();
            Route[edge.to.index] = edge.from.index;
            Visited[edge.to.index] = true;
            for (int i = 0; i < Source.AdjacencyList.Length; i++) //Attempting LIFO, Arrays have .length rather than .count
                Visited[edge.to.index] = true;

            if (edge.to.index == Target.index)
            {
                CalculatedPath = CalculatePath(Source, Target);
                return true;   //This is where I aim to generate the path and for it to come out true
            }
            for (int i = 0; i < edge.to.AdjacencyList.Length; i++)
                if (!Visited[edge.to.AdjacencyList[i].to.index])
                graphEdges.Push(edge.to.AdjacencyList[i]);
        }
        return false;
    }
}