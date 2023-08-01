using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyTriger : MonoBehaviour
{
    EnemyCcontroler enmyControler;
    TurretControl trtContrl;
    public float enemyHP = 100;
    

    
     void Start()
    {
        GameObject gameManager = GameObject.Find("GameMeneger");
        trtContrl = gameManager.GetComponent<TurretControl>();

        GameObject gameManager2 = GameObject.Find("EnemyControler");
        enmyControler = gameManager2.GetComponent<EnemyCcontroler>();

    }
    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            enemyHP -=9f;
            Destroy(other.gameObject);
            //Destroy(this.gameObject);
            
            if(enemyHP < 0)
            {
                Destroy(gameObject);
                trtContrl.gold += 4;
                

            }
        }
        if (other.gameObject.CompareTag("Bullet2"))
        {
            enemyHP -= 22;
            Destroy(other.gameObject);
            //Destroy(this.gameObject);

            if (enemyHP < 0)
            {
                trtContrl.gold += 4;
                Destroy(gameObject);

            }
        }
        if (other.gameObject.CompareTag("Bullet3"))
        {
            enemyHP -= 33;
            Destroy(other.gameObject);
            //Destroy(this.gameObject);

            if (enemyHP < 0)
            {
                Destroy(gameObject);
                trtContrl.gold += 4;

            }
        }
        if (other.gameObject.CompareTag("Finish"))
        {
            
            Destroy(gameObject);
            enmyControler.notDeadEnemy-=1;


        }
    }
}
