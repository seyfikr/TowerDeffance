using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level23trigger : MonoBehaviour
{
    TurretControl turretcontol;
    public GameObject Tower31;
    public GameObject hitObject1;
    TurretSlideLevel2 turretSlideLevel2;
    private void Start()
    {
        turretcontol = GameObject.Find("GameMeneger").GetComponent<TurretControl>();
        turretSlideLevel2 = GameObject.Find("Level2TurretSlide").GetComponent<TurretSlideLevel2>();
    }
    private void OnCollisionEnter(Collision collision)
    {



        if (collision.gameObject.CompareTag("Box2.2"))
        {
            Destroy(collision.gameObject);
            Destroy(hitObject1);

            if (turretSlideLevel2.upkey13 == true)
            {

                turretcontol.BuyKey3 = false;
                Instantiate(Tower31, collision.transform.position, Quaternion.identity);
            }
            if (turretSlideLevel2.DownKey12 == true)
            {
                turretcontol.BuyKey2 = false;
                Instantiate(Tower31, collision.transform.position, Quaternion.identity);
            }


        }
        if (collision.gameObject.CompareTag("Box2.4"))
        {
            Destroy(collision.gameObject);
            Destroy(hitObject1);

            if (turretSlideLevel2.rightkey13 == true)
            {
                turretcontol.BuyKey3 = false;
                Instantiate(Tower31, collision.transform.position, Quaternion.identity);
            }
            if (turretSlideLevel2.leftkey14 == true)
            {
                turretcontol.BuyKey4 = false;
                Instantiate(Tower31, collision.transform.position, Quaternion.identity);
            }
        }

    }
}
