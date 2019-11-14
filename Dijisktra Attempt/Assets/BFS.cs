using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BFS : MonoBehaviour
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

    public bool CalculateRoute(GraphNode Source, GraphNode Target) //These are the arguements
    {
        Queue<GraphEdge> graphEdges = new Queue<GraphEdge>(); //Thats the stack
        Route = new List<int>(Map.Nodes.Count);
        Visited = new List<bool>(Map.Nodes.Count);
        for (int i = 0; i < Map.Nodes.Count; i++)// Looping through the map node
        {
            Route.Add(-10);
            Visited.Add(false); //This initalises both the lists, 
        }
        for (int i = 0; i < Source.AdjacencyList.Length; i++) //FIFO
            graphEdges.Enqueue(Source.AdjacencyList[i]); //Adding all the adjactency edges to the start node
        Visited[Source.index] = true;
        while (graphEdges.Count > 0)
        {
            GraphEdge edge = graphEdges.Dequeue();
            Route[edge.to.index] = edge.from.index;
            Visited[edge.to.index] = true;
            for (int i = 0; i < Source.AdjacencyList.Length; i++) //Attempting FIFO, Arrays have .length rather than .count
                Visited[edge.to.index] = true;

            if (edge.to.index == Target.index)
            {
                CalculatedPath = CalculatePath(Source, Target);
                for (int i = 0; i < CalculatedPath.Count - 1; i++)
                {
                    Debug.DrawLine(Map.Nodes[CalculatedPath[i]].transform.position, Map.Nodes[CalculatedPath[i + 1]].transform.position, Color.red, 2.0f);
                    // This draws the line (Somewhat poorly if you add a number more than one but heyho)
                    //From what Ive been testing out, it does a path via how many lines I put in next to the Array and it gets really scruffy.
                }
                return true;   //This is where I aim to generate the path and for it to come out true
            }
            for (int i = 0; i < edge.to.AdjacencyList.Length; i++)
                if (!Visited[edge.to.AdjacencyList[i].to.index])
                    graphEdges.Enqueue(edge.to.AdjacencyList[i]);
        }
        return false;
    }
}

// I literally needed to change all the LIFO stuff to FIFO stuff.... FUCK SAKE I TOOK 4 hours on this shit man all the Stack stuff had to be changed to Queue.... FUCK CODING MAN

