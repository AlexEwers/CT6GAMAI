using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DFSLERP : MonoBehaviour
{


    public bool PathRecieved;
    List<Vector3> Targets = new List<Vector3>();
    // Start is called before the first frame update
    public GraphNode SourceNode;
    // Update is called once per frame
    void Update()
    {
        if (Targets.Count > 0)
        {
            for (var i = 0; i < Graph.Map.Dfs.CalculatedPath.Count - 1; i++)

                this.transform.position = Vector3.Lerp(transform.position, Targets[0], Time.smoothDeltaTime);
            if (Vector3.Distance(transform.position, Targets[0]) < 0.5f)
                Targets.Remove(Targets[0]);
        }
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;


        //Abstaction and Inheriance 

        if (Physics.Raycast(transform.position - forward * 2, forward, out RaycastHit Hit))
            SourceNode = Hit.transform.GetComponent<GraphNode>();
        if (!PathRecieved)
        {
            bool a = false;
            if (SourceNode)
                a = Graph.Map.Dfs.CalculateRoute(SourceNode, Graph.Map.Nodes[24]);
            if (a)
            {
                PathRecieved = true;
                foreach (var item in Graph.Map.Dfs.CalculatedPath)
                    Targets.Add(Graph.Map.Nodes[item].transform.position);
            }
        }

    }
}

