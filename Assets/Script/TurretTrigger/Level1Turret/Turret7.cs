using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret7 : MonoBehaviour
{
    TurretSllide turretSllide;
    TurretControl turretcontol;
    public GameObject Tower26, Tower28,Tower27;
    public GameObject hitObject1;
    private void Start()
    {
        turretcontol = GameObject.Find("GameMeneger").GetComponent<TurretControl>();
        turretSllide = GameObject.Find("Level1TurretSlide").GetComponent<TurretSllide>();
    }
    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.CompareTag("Box1.6"))
        {
            Destroy(collision.gameObject);
            Destroy(hitObject1);
           
            if (turretSllide.upkey16 == true)
            {
                turretcontol.BuyKey6 = false;
                Instantiate(Tower27, collision.transform.position, Quaternion.identity);
            }
            if (turretSllide.downkey17 == true)
            {
                turretcontol.BuyKey7 = false;
                Instantiate(Tower26, collision.transform.position, Quaternion.identity);
            }

        }
        if (collision.gameObject.CompareTag("Box1.8"))
        {
            Destroy(collision.gameObject);
            Destroy(hitObject1);
           
           
            if (turretSllide.leftkey17 == true)
            {
                turretcontol.BuyKey7 = false;
                Instantiate(Tower28, collision.transform.position, Quaternion.identity);
            }
            if (turretSllide.rightkey18 == true)
            {
                turretcontol.BuyKey8 = false;
                Instantiate(Tower27, collision.transform.position, Quaternion.identity);
            }
        }

    }
}
