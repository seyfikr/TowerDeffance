using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret3 : MonoBehaviour
{
    TurretControl turretcontol;
    public GameObject Tower22, Tower24,Tower23;
    public GameObject hitObject1;
    TurretSllide turretSllide;
    private void Start()
    {
        turretcontol = GameObject.Find("GameMeneger").GetComponent<TurretControl>();
        turretSllide = GameObject.Find("Level1TurretSlide").GetComponent<TurretSllide>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        


        if (collision.gameObject.CompareTag("Box1.2"))
        {
            Destroy(collision.gameObject);
            Destroy(hitObject1);
            
            if (turretSllide.upkey13 == true)
            {
                Instantiate(Tower22, collision.transform.position, Quaternion.identity);
                turretcontol.BuyKey3 = false;
            }
            if (turretSllide.DownKey12 == true)
            {
                turretcontol.BuyKey2 = false;
                Instantiate(Tower23, collision.transform.position, Quaternion.identity);
            }


        }
        if (collision.gameObject.CompareTag("Box1.4"))
        {
            Destroy(collision.gameObject);
            Destroy(hitObject1);
            
            if (turretSllide.rightkey13 == true)
            {
                turretcontol.BuyKey3 = false;
                Instantiate(Tower24, collision.transform.position, Quaternion.identity);
            }
            if (turretSllide.leftkey14 == true)
            {
                turretcontol.BuyKey4 = false;
                Instantiate(Tower23, collision.transform.position, Quaternion.identity);
            }
        }

    }
}
