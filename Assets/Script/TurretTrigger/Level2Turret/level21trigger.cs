using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level21trigger : MonoBehaviour
{
    public GameObject Tower31 ;
    public GameObject hitObject1;
    TurretControl turretcontol;
    TurretSlideLevel2 turretSlideLevel2;
    private Vector3 objectPos;

    private void Start()
    {

        turretcontol = GameObject.Find("GameMeneger").GetComponent<TurretControl>();
        turretSlideLevel2 = GameObject.Find("Level2TurretSlide").GetComponent<TurretSlideLevel2>();
        objectPos=hitObject1.transform.position;

    }
   
    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.CompareTag("Box2.2"))
        {

            Destroy(collision.gameObject);
            Destroy(hitObject1);


            if (turretSlideLevel2.UpKey12 == true)
            {
                turretcontol.BuyKey2 = false;
                Instantiate(Tower31, collision.transform.position, Quaternion.identity);
            }
            if (turretSlideLevel2.DownKey11 == true)
            {
                turretcontol.BuyKey1 = false;
                Instantiate(Tower31, collision.transform.position, Quaternion.identity);
            }




        }
        if (collision.gameObject.CompareTag("Box2.8"))
        {
            Destroy(collision.gameObject);
            Destroy(hitObject1);

            if (turretSlideLevel2.RightKey1 == true)
            {
                Instantiate(Tower31, collision.transform.position, Quaternion.identity);
                turretcontol.BuyKey1 = false;
            }
            if (turretSlideLevel2.leftkey18 == true)
            {
                turretcontol.BuyKey8 = false;
                Instantiate(Tower31, collision.transform.position, Quaternion.identity);
            }

        }
       


    }
}
