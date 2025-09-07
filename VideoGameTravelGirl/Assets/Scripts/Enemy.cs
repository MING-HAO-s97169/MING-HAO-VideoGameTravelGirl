using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{
    private float TurnSpeed;
    private float Speed;
    private float TraceRadius;
    private NavMeshAgent enemyagent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyagent = GetComponent<NavMeshAgent>();
        enemyagent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        //·j´Mª±®a
    }
}
