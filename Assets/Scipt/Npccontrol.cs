using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Npccontrol : MonoBehaviour
{
    //สำหรับ AI เดินบน Navmesh (by Aj.San)
    NavMeshAgent agent;

    //เป้าหมายให้ AI เดินไป (by Aj.San)
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(target.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
    }
}
