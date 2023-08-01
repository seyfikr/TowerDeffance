using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurretControl : MonoBehaviour
{
    [SerializeField] private TMP_Text goldText;
    public int  gold;
    public float b = 0;
    Turret1 turret1;
    public GameObject Turret1, Turret2, Turret3, Turret4, Turret5, Turret6, Turret7, Turret8, Buy1, Buy2, Buy3, Buy4, Buy5, Buy6, Buy7, Buy8;
    public GameObject Tower11, Tower12, Tower13, Tower14, Tower15, Tower16, Tower17, Tower18;
    public bool BuyKey1 = false, BuyKey2 = false, BuyKey3 = false, BuyKey4 = false, BuyKey5 = false, BuyKey6 = false, BuyKey7 = false, BuyKey8 = false;
    private void Start()
    {
        gold = 60;
        turret1 = GetComponent<Turret1>();
        
    }
    public void Update()
    {
        GameObject gameManager = GameObject.FindWithTag("enemy");
        
        goldText.text = "Gold: " + " " + gold.ToString();
    }

    public void TaretButton1()
    {
        if (BuyKey1 == false)
        {
            Buy1.SetActive(true); Buy2.SetActive(false); Buy3.SetActive(false); Buy4.SetActive(false); Buy5.SetActive(false); Buy6.SetActive(false); Buy7.SetActive(false); Buy8.SetActive(false);
            Turret1.GetComponent<MeshRenderer>().material.color = Color.black;
            Turret2.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret3.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret4.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret5.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret6.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret7.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret8.GetComponent<MeshRenderer>().material.color = Color.green;
           
            
        }

    }
    public void TaretButton2()
    {
        if (BuyKey2 == false)
        {
            Buy1.SetActive(false); Buy2.SetActive(true); Buy3.SetActive(false); Buy4.SetActive(false); Buy5.SetActive(false); Buy6.SetActive(false); Buy7.SetActive(false); Buy8.SetActive(false);
            Turret2.GetComponent<MeshRenderer>().material.color = Color.black;
            Turret1.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret3.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret4.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret5.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret6.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret7.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret8.GetComponent<MeshRenderer>().material.color = Color.green;
            
        }
    }
    public void TaretButton3()
    {
        if (BuyKey3 == false)
        {
            Buy1.SetActive(false); Buy2.SetActive(false); Buy3.SetActive(true); Buy4.SetActive(false); Buy5.SetActive(false); Buy6.SetActive(false); Buy7.SetActive(false); Buy8.SetActive(false);
            Turret3.GetComponent<MeshRenderer>().material.color = Color.black;
            Turret1.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret2.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret4.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret5.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret6.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret7.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret8.GetComponent<MeshRenderer>().material.color = Color.green;
      
        }
    }
    public void TaretButton4()
    {
        if (BuyKey4 == false)
        {
            Buy1.SetActive(false); Buy2.SetActive(false); Buy3.SetActive(false); Buy4.SetActive(true); Buy5.SetActive(false); Buy6.SetActive(false); Buy7.SetActive(false); Buy8.SetActive(false);
            Turret4.GetComponent<MeshRenderer>().material.color = Color.black;
            Turret1.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret2.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret3.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret5.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret6.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret7.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret8.GetComponent<MeshRenderer>().material.color = Color.green;
            
        }
    }
    public void TaretButton5()
    {
        if (BuyKey5 == false)
        {
            Buy1.SetActive(false); Buy2.SetActive(false); Buy3.SetActive(false); Buy4.SetActive(false); Buy5.SetActive(true); Buy6.SetActive(false); Buy7.SetActive(false); Buy8.SetActive(false);
            Turret5.GetComponent<MeshRenderer>().material.color = Color.black;
            Turret1.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret2.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret3.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret4.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret6.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret7.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret8.GetComponent<MeshRenderer>().material.color = Color.green;
          
        }
    }
    public void TaretButton6()
    {
        if (BuyKey6 == false)
        {
            Buy1.SetActive(false); Buy2.SetActive(false); Buy3.SetActive(false); Buy4.SetActive(false); Buy5.SetActive(false); Buy6.SetActive(true); Buy7.SetActive(false); Buy8.SetActive(false);
            Turret6.GetComponent<MeshRenderer>().material.color = Color.black;
            Turret1.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret2.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret3.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret4.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret5.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret7.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret8.GetComponent<MeshRenderer>().material.color = Color.green;
           
        }
    }
    public void TaretButton7()
    {
        if (BuyKey7 == false)
        {
            Buy1.SetActive(false); Buy2.SetActive(false); Buy3.SetActive(false); Buy4.SetActive(false); Buy5.SetActive(false); Buy6.SetActive(false); Buy7.SetActive(true); Buy8.SetActive(false);
            Turret7.GetComponent<MeshRenderer>().material.color = Color.black;
            Turret1.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret2.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret3.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret4.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret5.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret6.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret8.GetComponent<MeshRenderer>().material.color = Color.green;
           
        }
    }
    public void TaretButton8()
    {
        if (BuyKey8 == false)
        {
            Buy1.SetActive(false); Buy2.SetActive(false); Buy3.SetActive(false); Buy4.SetActive(false); Buy5.SetActive(false); Buy6.SetActive(false); Buy7.SetActive(false); Buy8.SetActive(true);
            Turret8.GetComponent<MeshRenderer>().material.color = Color.black;
            Turret1.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret2.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret3.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret4.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret5.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret6.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret7.GetComponent<MeshRenderer>().material.color = Color.green;
          
        }
    }
    public void Buyy1(GameObject Object)
    {
        if (gold >= 20)
        {
            GameObject Tower11Prefab = Instantiate(Object);
            Tower11Prefab.transform.position = new Vector3(-9.6f, 0.2f, -50.9f);
            Buy1.SetActive(false);
            Turret8.GetComponent<MeshRenderer>().material.color = Color.green; Turret1.GetComponent<MeshRenderer>().material.color = Color.green; Turret2.GetComponent<MeshRenderer>().material.color = Color.green; Turret3.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret4.GetComponent<MeshRenderer>().material.color = Color.green; Turret5.GetComponent<MeshRenderer>().material.color = Color.green; Turret6.GetComponent<MeshRenderer>().material.color = Color.green; Turret7.GetComponent<MeshRenderer>().material.color = Color.green;
            BuyKey1 = true;
            gold -= 20;
        }
    }
    public void Buyy2(GameObject Object)
    {
        if (gold >= 20)
        {

            GameObject Tower12Prefab = Instantiate(Object);
            Tower12Prefab.transform.position = new Vector3(-0.024f, 0f, -50.54725f);
            Buy2.SetActive(false);
            Turret8.GetComponent<MeshRenderer>().material.color = Color.green; Turret1.GetComponent<MeshRenderer>().material.color = Color.green; Turret2.GetComponent<MeshRenderer>().material.color = Color.green; Turret3.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret4.GetComponent<MeshRenderer>().material.color = Color.green; Turret5.GetComponent<MeshRenderer>().material.color = Color.green; Turret6.GetComponent<MeshRenderer>().material.color = Color.green; Turret7.GetComponent<MeshRenderer>().material.color = Color.green;
            BuyKey2 = true; gold -= 20;
        }
    }
    public void Buyy3(GameObject Object)
    {
        if (gold >= 20)
        {
            GameObject Tower13Prefab = Instantiate(Object);
            Tower13Prefab.transform.position = new Vector3(10f, 0f, -49.6f);
            Buy3.SetActive(false);
            Turret8.GetComponent<MeshRenderer>().material.color = Color.green; Turret1.GetComponent<MeshRenderer>().material.color = Color.green; Turret2.GetComponent<MeshRenderer>().material.color = Color.green; Turret3.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret4.GetComponent<MeshRenderer>().material.color = Color.green; Turret5.GetComponent<MeshRenderer>().material.color = Color.green; Turret6.GetComponent<MeshRenderer>().material.color = Color.green; Turret7.GetComponent<MeshRenderer>().material.color = Color.green;
            BuyKey3 = true; gold -= 20;
        }
    }
    public void Buyy4(GameObject Object)
    {
        if (gold >= 20)
        {
            GameObject Tower14Prefab = Instantiate(Object);
            Tower14Prefab.transform.position = new Vector3(10f, 0f, -39.6f);
            Buy4.SetActive(false);
            Turret8.GetComponent<MeshRenderer>().material.color = Color.green; Turret1.GetComponent<MeshRenderer>().material.color = Color.green; Turret2.GetComponent<MeshRenderer>().material.color = Color.green; Turret3.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret4.GetComponent<MeshRenderer>().material.color = Color.green; Turret5.GetComponent<MeshRenderer>().material.color = Color.green; Turret6.GetComponent<MeshRenderer>().material.color = Color.green; Turret7.GetComponent<MeshRenderer>().material.color = Color.green;
            BuyKey4 = true; gold -= 20;
        }
    }
    public void Buyy5(GameObject Object)
    {
        if (gold >= 20)
        {
            GameObject Tower15Prefab = Instantiate(Object);
            Tower15Prefab.transform.position = new Vector3(10f, 0f, -29.5f);
            Buy5.SetActive(false);
            Turret8.GetComponent<MeshRenderer>().material.color = Color.green; Turret1.GetComponent<MeshRenderer>().material.color = Color.green; Turret2.GetComponent<MeshRenderer>().material.color = Color.green; Turret3.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret4.GetComponent<MeshRenderer>().material.color = Color.green; Turret5.GetComponent<MeshRenderer>().material.color = Color.green; Turret6.GetComponent<MeshRenderer>().material.color = Color.green; Turret7.GetComponent<MeshRenderer>().material.color = Color.green;
            BuyKey5 = true; gold -= 20;
        }
    }
    public void Buyy6(GameObject Object)
    {
        if (gold >= 20)
        {
            GameObject Tower16Prefab = Instantiate(Object);
            Tower16Prefab.transform.position = new Vector3(0.9f, 0f, -29.9f);
            Buy6.SetActive(false);
            Turret8.GetComponent<MeshRenderer>().material.color = Color.green; Turret1.GetComponent<MeshRenderer>().material.color = Color.green; Turret2.GetComponent<MeshRenderer>().material.color = Color.green; Turret3.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret4.GetComponent<MeshRenderer>().material.color = Color.green; Turret5.GetComponent<MeshRenderer>().material.color = Color.green; Turret6.GetComponent<MeshRenderer>().material.color = Color.green; Turret7.GetComponent<MeshRenderer>().material.color = Color.green;
            BuyKey6 = true; gold -= 20;
        }
    }
    public void Buyy7(GameObject Object)
    {
        if (gold >= 20)
        {
            GameObject Tower17Prefab = Instantiate(Object);
            Tower17Prefab.transform.position = new Vector3(-9.4f, 0f, -29.9f);
            Buy7.SetActive(false);
            Turret8.GetComponent<MeshRenderer>().material.color = Color.green; Turret1.GetComponent<MeshRenderer>().material.color = Color.green; Turret2.GetComponent<MeshRenderer>().material.color = Color.green; Turret3.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret4.GetComponent<MeshRenderer>().material.color = Color.green; Turret5.GetComponent<MeshRenderer>().material.color = Color.green; Turret6.GetComponent<MeshRenderer>().material.color = Color.green; Turret7.GetComponent<MeshRenderer>().material.color = Color.green;
            BuyKey7 = true; gold -= 20;
        }
    }
    public void Buyy8(GameObject Object)
    {
        if (gold >= 20)
        {
            GameObject Tower18Prefab = Instantiate(Object);
            Tower18Prefab.transform.position = new Vector3(-9.1f, 0f, -40.2f);
            Buy8.SetActive(false);
            Turret8.GetComponent<MeshRenderer>().material.color = Color.green; Turret1.GetComponent<MeshRenderer>().material.color = Color.green; Turret2.GetComponent<MeshRenderer>().material.color = Color.green; Turret3.GetComponent<MeshRenderer>().material.color = Color.green;
            Turret4.GetComponent<MeshRenderer>().material.color = Color.green; Turret5.GetComponent<MeshRenderer>().material.color = Color.green; Turret6.GetComponent<MeshRenderer>().material.color = Color.green; Turret7.GetComponent<MeshRenderer>().material.color = Color.green;
            BuyKey8 = true; gold -= 20;
        }
    }
}
