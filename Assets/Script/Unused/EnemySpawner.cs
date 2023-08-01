using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform spawmTransform;
    public bool roadKey = false;
    private void Start()
    {
        InvokeRepeating(nameof(spawn), 0, Random.Range(0, 7f));
    }
    private void spawn()
    {
        Instantiate(enemyPrefab,spawmTransform.position,Quaternion.identity);
        
    }
    //IEnumerator RoadControlller()
    //{

    //    yield return new WaitForSeconds(0.9f);
        
    //    roadKey = true;
    //    Debug.Log("a");
    //    yield return new WaitForSeconds(0.9f);

    //}
}
