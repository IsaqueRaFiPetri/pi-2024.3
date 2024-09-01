using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.AI;

public enum Npc
{
    Break, Walking, DoingSomething
}
public class NpcFunctions : MonoBehaviour
{
    NavMeshAgent agent;
    public Npc npc;
    bool canWalk;

    public UnityEvent OnBreak, OnWalking, OnDoing; 

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SetDestiny();
    }

    void Update()
    {
        switch (npc)
        {
            case Npc.Break: //modod de aguardo
                break;
            case Npc.Walking:
                if (agent.stoppingDistance >= agent.remainingDistance)
                { //se estiver chegando ao destino, espere
                    SetNpcState(Npc.Break);
                }
                break;
            case Npc.DoingSomething:
                break;

        }
    }
    void SetDestiny() //anda para um ponto aleatório
    {
        agent.SetDestination(SetRandomNavTarget());
        SetNpcState(Npc.Walking);
    }
    Vector3 SetRandomNavTarget()
    {
        Vector3 randomPosition = Random.insideUnitSphere * 30;
        randomPosition.y = 0;
        randomPosition += transform.position;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomPosition, out hit, 5, 1);
        Vector3 finalPosition = hit.position;
        SetNpcState(Npc.Walking);

        return finalPosition;
    }
    IEnumerator GiveaBreak()
    {
        yield return new WaitForSeconds(2); //tempo de espera

        if (canWalk)
        {
            SetRandomNavTarget();
        }
        else
        {
            SetRandomNavTarget(); //setar um novo destino e começar a patrulha
        }
    }

    public void SetNpcState(Npc state)
    {
        state = npc;

        switch(state)
        {
            case Npc.Break:
                StartCoroutine(GiveaBreak()); //coroutine para esperar
                OnBreak.Invoke();
                break;
            case Npc.Walking:
                OnWalking.Invoke();
                break;
            case Npc.DoingSomething:
                OnDoing.Invoke();
                break;

        }
    }
}
