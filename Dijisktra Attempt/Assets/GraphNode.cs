using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphNode : MonoBehaviour
{
    public float cost = 4;
    public GraphEdge[] AdjacencyList;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnDrawGizmosSelected()
    {
        foreach (var item in AdjacencyList)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(item.from.transform.position, item.to.transform.position);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
