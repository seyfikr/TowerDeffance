using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerFire : MonoBehaviour
{
    public GameObject bulletPos;
    [SerializeField] private float fireRate;
    [SerializeField] private float attackRadius;
    [SerializeField] private BulletScript bulletPrefab;
    private Collider[] enemies;
    private EnemyCcontroler currentEnemy=null;
    
  
    void Start()
    {
        InvokeRepeating(nameof(ScanArea), 0, fireRate);
       
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color= Color.green;
        Gizmos.DrawWireSphere(transform.position,attackRadius);
    }
    private void ScanArea()
    {
        float distance = 1000;
        enemies = Physics.OverlapSphere(transform.position, attackRadius);

        foreach(Collider enemy in enemies)
        {
            
            if (enemy.gameObject.TryGetComponent(out EnemyCcontroler enemyScript))
            {
                
                float dist = Vector3.Distance(transform.position, enemy.transform.position);
                if (dist <= distance)
                {
                    currentEnemy = enemyScript;
                    distance = dist;
                }
            }
        }
        if (currentEnemy)
        {
            BulletScript bulletScript = Instantiate(bulletPrefab, bulletPos.transform.position, Quaternion.identity);
            bulletScript.SetTarget(currentEnemy.transform);
            

        }
            
    }
     void Update()
    {
        if (currentEnemy)
        {
            Vector3 dir =currentEnemy.transform.position-transform.position;
            dir.y = 0;
            transform.rotation = Quaternion.LookRotation(dir);
        }
    }
}
