using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{

    public Camera camera;
    private NavMeshAgent agent;
    private RaycastHit hit;
    private float moveSpeed = 25f;
    public NavMeshSurface navMesh;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        navMesh.BuildNavMesh();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.CompareTag("Ground"))
                {
                    agent.speed = moveSpeed;
                    agent.SetDestination(hit.point);
                }
            }
        }
    }
}
