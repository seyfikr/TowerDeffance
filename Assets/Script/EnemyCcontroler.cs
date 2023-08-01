using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyCcontroler : MonoBehaviour
{
    public GameObject wrongPanel, stopButton;
    private int timeCounter = 0;
    private float timer = 0f;
    private float interval = 1f;
    public GameObject gameOverPanel;
    public GameObject[] spawmButton;
    public GameObject enemy1,enemy2,enemy3,enemy4,enemy5;
    public int enemyCount;
    public int enemyCount2;
    public Vector3 spawnPosition;
    public Transform waypoint1,waypoint2;
    private int objectsSpawned = 0;  
    public float spawnDelay = 1.0f;
    public int notDeadEnemy = 5;
    private int deadEnemy = 0;
    [SerializeField] public TMP_Text enemyText,timeText,losePanelTimeText,highScoreText,defeatText;
    
    void Start()
    {
        deadEnemy=notDeadEnemy;
        spawmButton[0].SetActive(true);
        Time.timeScale = 1;      
    }
    private void Update()
    {
        if (notDeadEnemy > 0)
        {
            if (deadEnemy != notDeadEnemy)
            {
                deadEnemy = notDeadEnemy;
                StartCoroutine(WrondPanel());

            }
        }
        if (notDeadEnemy > 5)
        {
            stopButton.SetActive(false);
            gameOverPanel.SetActive(true);
            interval = 10000;
            defeatText.text = "Succes ";
        }

        PlayerPrefs.GetInt("HighScore", timeCounter);
        //timeCounter = PlayerPrefs.GetInt(nameof(highScore));

        timer += Time.deltaTime;
        if (timer >= interval)
        {
            timeCounter++;
            timer = 0f;
        }
        enemyText.text = ": " + " " + notDeadEnemy.ToString();
        timeText.text = "Time: " + " " + timeCounter.ToString();
        losePanelTimeText.text = "Time: " + " " + timeCounter.ToString();
        highScoreText.text = "HighScore: " + " " + PlayerPrefs.GetInt("HighScore", timeCounter).ToString();
        if (notDeadEnemy <1)
        {
            gameOverPanel.SetActive(true);
            stopButton.SetActive(false);
            
            interval = 10000;
            defeatText.text = "Defeat ";
            //Time.timeScale=0;

            if (timeCounter > PlayerPrefs.GetInt("HighScore", timeCounter))
            {
                PlayerPrefs.SetInt("HighScore", timeCounter);
                
            }
        }
        
    }
    
    public void RestartButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void SpawmButton1()
    {
        StartCoroutine(SpawnCoroutine1());
        spawmButton[0].SetActive(false);
    }
    public void SpawmButton2()
    {
        objectsSpawned = 0;
        StartCoroutine(SpawnCoroutine2());
        spawmButton[1].SetActive(false);
        
    }
    public void SpawmButton3()
    {
        objectsSpawned = 0;
        StartCoroutine(SpawnCoroutine3());
        spawmButton[2].SetActive(false);
    }
    public void SpawmButton4()
    {
        objectsSpawned = 0;
        StartCoroutine(SpawnCoroutine4());
        spawmButton[3].SetActive(false);
    }
    public void SpawmButton5()
    {
        objectsSpawned = 0;
        StartCoroutine(SpawnCoroutine5());
        spawmButton[4].SetActive(false);
    }
    public void SpawmButton6()
    {
        objectsSpawned = 0;
        StartCoroutine(SpawnCoroutine6());
        spawmButton[5].SetActive(false);
    }
    public void SpawmButton7()
    {
        objectsSpawned = 0;
        StartCoroutine(SpawnCoroutine7());
        spawmButton[6].SetActive(false);
    }
    IEnumerator WrondPanel()
    {
        wrongPanel.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        wrongPanel.SetActive(false);
    }
   
    IEnumerator SpawnCoroutine1()
    {
        while (objectsSpawned < enemyCount)
        {
            if (objectsSpawned < 3)
            {
                WayPoint1();
                
            }
            else if (objectsSpawned >= 3 && objectsSpawned < 5)
            {
                WayPoint2();
            }
            else if (objectsSpawned >= 5 && objectsSpawned < 7)
            {
                WayPoint1();
            }
            else
            {
                WayPoint2();
            }
            if (objectsSpawned == enemyCount)
            {
                
                spawmButton[1].SetActive(true);
            }
            {
                yield return new WaitForSeconds(spawnDelay);
            }
            
        }
    }
    IEnumerator SpawnCoroutine2()
    {
        while (objectsSpawned < enemyCount)
        {
            if (objectsSpawned < 3)
            {
                WayPoint1();

            }
            else if (objectsSpawned >= 3 && objectsSpawned < 5)
            {
                WayPoint2Enemy2();
            }
            else if (objectsSpawned >= 5 && objectsSpawned < 6)
            {
                WayPoint2();
            }
            else if (objectsSpawned >= 7 && objectsSpawned < 7)
            {
                WayPoint1();
            }
            else
            {
                WayPoint2();
            }
            if (objectsSpawned == enemyCount)
            {

                spawmButton[2].SetActive(true);
            }
            {
                yield return new WaitForSeconds(spawnDelay);
            }
        }
    }
    IEnumerator SpawnCoroutine3()
    {
        while (objectsSpawned < enemyCount)
        {
            if (objectsSpawned < 3)
            {
                WayPoint1Enemy2();

            }
            else if (objectsSpawned >= 3 && objectsSpawned < 5)
            {
                WayPoint2Enemy2();
            }
            else if (objectsSpawned >= 5 && objectsSpawned < 6)
            {
                WayPoint2Enemy2();
            }
            else if (objectsSpawned >= 7 && objectsSpawned < 7)
            {
                WayPoint1Enemy2();
            }
            else
            {
                WayPoint2Enemy2();
            }
            if (objectsSpawned == enemyCount)
            {

                spawmButton[3].SetActive(true);
            }
            {
                yield return new WaitForSeconds(spawnDelay);
            }
        }
    }
    IEnumerator SpawnCoroutine4()
    {
        while (objectsSpawned < enemyCount2)
        {
            if (objectsSpawned < 5)
            {
                WayPoint1Enemy2();

            }
            else if (objectsSpawned >= 5 && objectsSpawned < 10)
            {
                WayPoint2Enemy2();
            }
            else if (objectsSpawned==10 )
            {
                WayPoint1Enemy2();
            }
            else if (objectsSpawned==11)
            {
                WayPoint2Enemy2();
            }
            else if (objectsSpawned == 12)
            {
                WayPoint1Enemy2();
            }
            else if (objectsSpawned == 13)
            {
                WayPoint2Enemy2();
            }
            //else
            //{
            //    WayPoint2Enemy2();
            //}
            if (objectsSpawned == enemyCount2)
            {

                spawmButton[4].SetActive(true);
            }
            {
                yield return new WaitForSeconds(spawnDelay);
            }
        }
    }
    IEnumerator SpawnCoroutine5()
    {
        while (objectsSpawned < enemyCount2)
        {
            if (objectsSpawned < 3)
            {
                WayPoint1Enemy3();

            }
            else if (objectsSpawned >= 3 && objectsSpawned < 5)
            {
                WayPoint1Enemy3();
            }
            else if (objectsSpawned >= 5 && objectsSpawned < 7)
            {
                WayPoint2Enemy3();
            }
            else
            {
                WayPoint1Enemy3();
            }
            if (objectsSpawned == enemyCount2)
            {

                spawmButton[5].SetActive(true);
            }
            {
                yield return new WaitForSeconds(spawnDelay);
            }

        }
    }
    IEnumerator SpawnCoroutine6()
    {
        while (objectsSpawned < enemyCount)
        {
            if (objectsSpawned < 6)
            {
                WayPoint2Enemy4();


            }
           
            else
            {
                WayPoint1Enemy4();
            }
            if (objectsSpawned == enemyCount)
            {

                spawmButton[6].SetActive(true);
            }
            {
                yield return new WaitForSeconds(spawnDelay);
            }

        }
    }
    IEnumerator SpawnCoroutine7()
    {
        while (objectsSpawned < enemyCount)
        {
            if (objectsSpawned <1)
            {
                WayPoint2Enemy5();


            }
    
            //if (objectsSpawned == enemyCount)
            //{

            //    spawmButton[6].SetActive(true);
            //}
            {
                yield return new WaitForSeconds(spawnDelay);
            }

        }
    }

    public void WayPoint1()
    {
        GameObject obj = Instantiate(enemy1, spawnPosition, Quaternion.identity);
        objectsSpawned++;
        obj.GetComponent<NavMeshAgent>().SetDestination(waypoint1.position);
    }
    public void WayPoint2()
    {
        GameObject obj = Instantiate(enemy1, spawnPosition, Quaternion.identity);
        objectsSpawned++;
        obj.GetComponent<NavMeshAgent>().SetDestination(waypoint2.position);
    }
    public void WayPoint1Enemy2()
    {
        GameObject obj = Instantiate(enemy2, spawnPosition, Quaternion.identity);
        objectsSpawned++;
        obj.GetComponent<NavMeshAgent>().SetDestination(waypoint1.position);
    }
    public void WayPoint2Enemy2()
    {
        GameObject obj = Instantiate(enemy2, spawnPosition, Quaternion.identity);
        objectsSpawned++;
        obj.GetComponent<NavMeshAgent>().SetDestination(waypoint2.position);
    }
    public void WayPoint1Enemy3()
    {
        GameObject obj = Instantiate(enemy3, spawnPosition, Quaternion.identity);
        objectsSpawned++;
        obj.GetComponent<NavMeshAgent>().SetDestination(waypoint1.position);
    }
    public void WayPoint2Enemy3()
    {
        GameObject obj = Instantiate(enemy3, spawnPosition, Quaternion.identity);
        objectsSpawned++;
        obj.GetComponent<NavMeshAgent>().SetDestination(waypoint2.position);
    }
    public void WayPoint1Enemy4()
    {
        GameObject obj = Instantiate(enemy4, spawnPosition, Quaternion.identity);
        objectsSpawned++;
        obj.GetComponent<NavMeshAgent>().SetDestination(waypoint1.position);
    }
    public void WayPoint2Enemy4()
    {
        GameObject obj = Instantiate(enemy4, spawnPosition, Quaternion.identity);
        objectsSpawned++;
        obj.GetComponent<NavMeshAgent>().SetDestination(waypoint2.position);
    }
    public void WayPoint2Enemy5()
    {
        GameObject obj = Instantiate(enemy5, spawnPosition, Quaternion.identity);
        objectsSpawned++;
        obj.GetComponent<NavMeshAgent>().SetDestination(waypoint2.position);
    }


}
