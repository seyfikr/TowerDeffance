using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret5 : MonoBehaviour
{
    TurretSllide turretSllide;
    TurretControl turretcontol;
    public GameObject Tower24,Tower25, Tower26;
    public GameObject hitObject1;
    private void Start()
    {
        turretcontol = GameObject.Find("GameMeneger").GetComponent<TurretControl>();
        turretSllide = GameObject.Find("Level1TurretSlide").GetComponent<TurretSllide>();
    }
    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.CompareTag("Box1.4"))
        {
            Destroy(collision.gameObject);
            Destroy(hitObject1);
            
            if (turretSllide.rightkey14 == true)
            {
                turretcontol.BuyKey4 = false;
                Instantiate(Tower25, collision.transform.position, Quaternion.identity);
            }
            if (turretSllide.leftkey15 == true)
            {
                turretcontol.BuyKey5 = false;
                Instantiate(Tower24, collision.transform.position, Quaternion.identity);
            }
        }
        if (collision.gameObject.CompareTag("Box1.6"))
        {
            Destroy(collision.gameObject);
            Destroy(hitObject1);
            
            if (turretSllide.upkey15 == true)
            {
                turretcontol.BuyKey5 = false;
                Instantiate(Tower26, collision.transform.position, Quaternion.identity);

            }
            if (turretSllide.downkey16 == true)
            {
                turretcontol.BuyKey6 = false;
                Instantiate(Tower25, collision.transform.position, Quaternion.identity);
            }
        }

    }
}
