using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    private NavMeshAgent agent;
   
    //private void Awake()
    //{
    //    agent = GetComponent<NavMeshAgent>();
    //}

    //private void Start()
    //{
    //    enemySpawner = GameObject.Find("Spamwn").GetComponent<EnemySpawner>();
    //    for(int i= 0; i < 10; i++)
    //    {
    //        agent.SetDestination(MapManager.instance.Finish.position);
    //        Debug.Log("road1");
    //    }
    //    for (int i = 0; i < 10; i++)
    //    {
    //        agent.SetDestination(MapManager.instance.Finish2.position);
    //        Debug.Log("road2");
    //    }
    //}
    private void Update()
    {
       
        //if (roadCont < 10 && enemySpawner.roadKey == true)
        //{
        //    agent.SetDestination(MapManager.instance.Finish.position);
        //    roadCont++;
        //    enemySpawner.roadKey = false;
        //    Debug.Log(roadCont);
        //    Debug.Log(enemySpawner.roadKey);
        //}
        //if (roadCont > 9 && enemySpawner.roadKey == true)
        //{
        //    agent.SetDestination(MapManager.instance.Finish2.position);
        //    enemySpawner.roadKey = false;
        //    roadCont++;
        //    Debug.Log(roadCont);

        //}
       

    }
    //IEnumerator RoadControlller()
    //{
        
    //    yield return new WaitForSeconds(0.9f);
    //    roadCont = Random.Range(0, 2);
       
    //}
}
