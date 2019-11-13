using System;
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

    GraphEdge FindShortestPathBFS(GraphEdge startPosition, GraphEdge goalPosition)
    {
        Queue<GraphEdge> queue = new Queue<GraphEdge>();
        HashSet<GraphEdge> exploredNodes = new HashSet<GraphEdge>(); //Start state, and stops it doing it m
        queue.Enqueue(startPosition);

        while (queue.Count != 0)
        {
            GraphEdge currentNode = queue.Dequeue();
            if (currentNode == goalPosition)
            {
                return currentNode;
            }
            IList<GraphEdge> nodes = GetWalkableNodes(currentNode);

            foreach(GraphEdge node in nodes)
            {
                if(!exploredNodes.Contains(node))
                {
                    exploredNodes.Add(node);

                  nodeParents.Add(node, currentNode);

                    queue.Enqueue(node);
                }
            }
        }
        return startPosition;
    }

    private IList<GraphEdge> GetWalkableNodes(GraphEdge currentNode)
    {
        throw new NotImplementedException();
    }
}


//Note, even though I understand this now, most of it was cause of the help of Kirean, Work on it when you get home, it does lines now but not very well
//What Im trying to say is it does lines but does it poorly