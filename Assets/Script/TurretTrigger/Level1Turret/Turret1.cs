using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret1 : MonoBehaviour
{
    public GameObject Tower22,Tower28,Tower21;
    public GameObject hitObject1;
    TurretControl turretcontol;
    TurretSllide turretSllide;
  

    private void Start()
    {
       
        turretcontol = GameObject.Find("GameMeneger").GetComponent<TurretControl>();
        turretSllide = GameObject.Find("Level1TurretSlide").GetComponent<TurretSllide>();


    }
    private void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
       

        if (collision.gameObject.CompareTag("Box1.2"))
        {
            
            Destroy(collision.gameObject);
            Destroy(hitObject1);
           
            
            if (turretSllide.UpKey12 == true)
            {
                turretcontol.BuyKey2 = false;
                Instantiate(Tower21, collision.transform.position, Quaternion.identity);
            }
            if (turretSllide.DownKey11 == true)
            {
                turretcontol.BuyKey1 = false;
                Instantiate(Tower22, collision.transform.position, Quaternion.identity);
            }
           
          


        }

        if (collision.gameObject.CompareTag("Box1.8"))
        {
            Destroy(collision.gameObject);
            Destroy(hitObject1);
            
            if (turretSllide.RightKey1 == true)
            {
                Instantiate(Tower28, collision.transform.position, Quaternion.identity);
                turretcontol.BuyKey1 = false;
            }
            if (turretSllide.leftkey18 == true)
            {
                turretcontol.BuyKey8 = false;
                Instantiate(Tower21, collision.transform.position, Quaternion.identity);
            }

        }
        if (collision.gameObject.CompareTag("Box2.2"))
        {

        }

    }
   
}
