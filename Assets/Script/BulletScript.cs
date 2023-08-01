using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float speed;
    public void SetTarget(Transform target)
    {
        this.target = target;
    }

    void Update()
    {
        if (target)
        {
            Vector3 dir =target.position - transform.position;
            transform.forward = dir;
            transform.Translate(transform.forward * Time.deltaTime * speed, Space.World);
            StartCoroutine(DestrotBullet());
        }
        
     
    }
    IEnumerator DestrotBullet()
    {
        yield return new WaitForSeconds(0.8f);
        Destroy(gameObject);
    }
}
