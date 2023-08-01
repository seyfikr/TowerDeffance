using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level25trigger : MonoBehaviour
{
    TurretSlideLevel2 turretSlideLevel2;
    TurretControl turretcontol;
    public GameObject Tower31;
    public GameObject hitObject1;
    private void Start()
    {
        turretcontol = GameObject.Find("GameMeneger").GetComponent<TurretControl>();
        turretSlideLevel2 = GameObject.Find("Level2TurretSlide").GetComponent<TurretSlideLevel2>();
    }
    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.CompareTag("Box2.4"))
        {
            Destroy(collision.gameObject);
            Destroy(hitObject1);

            if (turretSlideLevel2.rightkey14 == true)
            {
                turretcontol.BuyKey4 = false;
                Instantiate(Tower31, collision.transform.position, Quaternion.identity);
            }
            if (turretSlideLevel2.leftkey15 == true)
            {
                turretcontol.BuyKey5 = false;
                Instantiate(Tower31, collision.transform.position, Quaternion.identity);
            }
        }
        if (collision.gameObject.CompareTag("Box2.6"))
        {
            Destroy(collision.gameObject);
            Destroy(hitObject1);

            if (turretSlideLevel2.upkey15 == true)
            {
                turretcontol.BuyKey5 = false;
                Instantiate(Tower31, collision.transform.position, Quaternion.identity);

            }
            if (turretSlideLevel2.downkey16 == true)
            {
                turretcontol.BuyKey6 = false;
                Instantiate(Tower31, collision.transform.position, Quaternion.identity);
            }
        }

    }
}
