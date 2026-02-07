    // MoveToClickPoint.cs
    using UnityEngine;
    using UnityEngine.AI;

public class FollowWhenSeen : MonoBehaviour
{
    public Transform player;
    public float viewDistance = 10f;
    public float viewAngle = 90f;
    public LayerMask obstacleMask;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (PlayerInSight())
        {
            agent.SetDestination(player.position);
        }
    }

    bool PlayerInSight()
    {
        Vector3 directionToPlayer = (player.position - transform.position).normalized;
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Too far
        if (distanceToPlayer > viewDistance)
            return false;

        // Outside view angle
        if (Vector3.Angle(transform.forward, directionToPlayer) > viewAngle / 2f)
            return false;

        // Blocked by obstacle?
        if (Physics.Raycast(
            transform.position + Vector3.up,
            directionToPlayer,
            distanceToPlayer,
            obstacleMask))
        {
            return false;
        }

        return true;
    }
}