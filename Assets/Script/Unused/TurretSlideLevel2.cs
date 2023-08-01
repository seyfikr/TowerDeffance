using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSlideLevel2 : MonoBehaviour
{
   
    public float minSwipeDistance = 55f;
    private Vector3 swipeStartPosition;
    private Vector3 swipeEndPosition;
    private bool isSwipe = false;
    public GameObject hitObject1, hitObject2, hitObject3, hitObject4, hitObject5, hitObject6, hitObject7, hitObject8;

    public Vector3 ObjeInitPos;
    public bool hitkey = false, hitkey2 = false, hitkey3 = false, hitkey4 = false, hitkey5 = false, hitkey6 = false, hitkey7 = false, hitkey8 = false;
    public bool DownKey11 = false, RightKey1 = false, UpKey12 = false, DownKey12 = false, upkey13 = false, rightkey13 = false, leftkey14 = false,
    rightkey14 = false, upkey15 = false, leftkey15 = false, upkey16 = false, downkey16 = false, downkey17 = false, leftkey17 = false, rightkey18 = false, leftkey18 = false;

   
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                isSwipe = true;
                swipeStartPosition = touch.position;

                // Check if the touch hits a "Box" object
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Box2.1"))
                {
                    // Save the hit object for later use
                    hitObject1 = hit.collider.gameObject;
                    hitkey = true;



                }
                if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Box2.2"))
                {
                    // Save the hit object for later use
                    hitObject2 = hit.collider.gameObject;

                    hitkey2 = true;

                }
                if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Box2.3"))
                {
                    // Save the hit object for later use
                    hitObject3 = hit.collider.gameObject;

                    hitkey3 = true;
                }
                if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Box2.4"))
                {
                    // Save the hit object for later use
                    hitObject4 = hit.collider.gameObject;

                    hitkey4 = true;
                }
                if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Box2.5"))
                {
                    // Save the hit object for later use
                    hitObject5 = hit.collider.gameObject;
                    hitkey5 = true;
                }
                if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Box2.6"))
                {
                    // Save the hit object for later use
                    hitObject6 = hit.collider.gameObject;
                    hitkey6 = true;
                }
                if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Box2.7"))
                {
                    // Save the hit object for later use
                    hitObject7 = hit.collider.gameObject;
                    hitkey7 = true;
                }
                if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Box2.8"))
                {
                    // Save the hit object for later use
                    hitObject8 = hit.collider.gameObject;
                    hitkey8 = true;
                }
            }
            else if (touch.phase == TouchPhase.Moved && isSwipe)
            {
                // Set swipe end position
                swipeEndPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended && isSwipe)
            {
                // Calculate swipe distance and direction
                float swipeDistance = Vector2.Distance(swipeStartPosition, swipeEndPosition);
                if (swipeDistance > minSwipeDistance)
                {
                    Vector2 swipeDirection = swipeEndPosition - swipeStartPosition;
                    if (Mathf.Abs(swipeDirection.x) > Mathf.Abs(swipeDirection.y))
                    {
                        // Horizontal swipe
                        if (swipeDirection.x > 0)
                        {

                            // Right swipe
                            //Debug.Log("Right Swipe");

                            // Move the hit object to the right
                            if (hitObject1 != null && hitkey == true)
                            {
                                hitkey = false;
                                StartCoroutine(RightPos1());

                            }

                            if (hitObject3 != null && hitkey3 == true)
                            {
                                StartCoroutine(RightPos3());
                                hitkey3 = false;
                            }
                            if (hitObject4 != null && hitkey4 == true)
                            {
                                StartCoroutine(RightPos4());
                                hitkey4 = false;
                            }
                           
                            if (hitObject8 != null && hitkey8 == true)
                            {
                                hitkey8 = false;
                                StartCoroutine(RightPos8());
                            }
                        }
                        else
                        {
                            // Left swipe
                            //Debug.Log("Left Swipe");

                           
                            if (hitObject4 != null && hitkey4 == true)
                            {
                                hitkey4 = false;
                                StartCoroutine(LeftPos4());

                            }
                            if (hitObject5 != null && hitkey5 == true)
                            {
                                hitkey5 = false;
                                StartCoroutine(LeftPos5());

                            }
                            if (hitObject6 != null && hitkey6 == true)
                            {
                                hitkey6 = false;
                                StartCoroutine(LeftPos6());

                            }
                            if (hitObject7 != null && hitkey7 == true)
                            {
                                hitkey7 = false;
                                StartCoroutine(LeftPos7());
                            }
                            if (hitObject8 != null && hitkey8 == true)
                            {
                                hitkey8 = false;
                                StartCoroutine(LeftPos8());

                            }
                        }
                    }
                    else
                    {
                        // Vertical swipe
                        if (swipeDirection.y > 0)
                        {
                            // Up swipe
                            //Debug.Log("Up Swipe");                          
                            if (hitObject2 != null && hitkey2 == true)
                            {
                                hitkey2 = false;
                                StartCoroutine(ForwardPos2());

                            }
                            if (hitObject3 != null && hitkey3 == true)
                            {
                                hitkey3 = false;
                                StartCoroutine(ForwardPos3());

                            }
                        
                            if (hitObject5 != null && hitkey5 == true)
                            {
                              
                                hitkey5 = false;
                                StartCoroutine(ForwardPos5());
                            }
                            if (hitObject6 != null && hitkey6 == true)
                            {
                               
                                hitkey6 = false;
                                StartCoroutine(ForwardPos6());

                            }
                       
                        }
                        else
                        {
                            // Down swipe
                            
                            if (hitObject1 != null && hitkey == true)
                            {
                                
                                StartCoroutine(BackPos1());
                            }
                            if (hitObject2 != null && hitkey2 == true)
                            {
                               
                                hitkey2 = false;
                                StartCoroutine(BackPos2());

                            }
                         
                            if (hitObject6 != null && hitkey6 == true)
                            {
                             
                                hitkey6 = false;
                                StartCoroutine(BackPos6());

                            }
                            if (hitObject7 != null && hitkey7 == true)
                            {
                             
                                hitkey7 = false;
                                StartCoroutine(BackPos7());

                            }
                           
                        }
                    }
                    isSwipe = false;
                }
            }
        }
    }

    IEnumerator RightPos1()
    {
        RightKey1 = true;
        ObjeInitPos = hitObject1.transform.position;
        hitObject1.transform.position += new Vector3(0f, 0f, 10f);
        yield return new WaitForSeconds(0.5f);
        hitObject1.transform.position = ObjeInitPos;
    }
   
    IEnumerator RightPos3()
    {
        rightkey13 = true;
        ObjeInitPos = hitObject3.transform.position;
        hitObject3.transform.position += new Vector3(0f, 0f, 9f);
        yield return new WaitForSeconds(0.5f);
        hitObject3.transform.position = ObjeInitPos;
    }
    IEnumerator RightPos4()
    {
        rightkey14 = true;
        ObjeInitPos = hitObject4.transform.position;
        hitObject4.transform.position += new Vector3(0f, 0f, 9.4f);
        yield return new WaitForSeconds(0.5f);
        hitObject4.transform.position = ObjeInitPos;
    }
    IEnumerator RightPos8()
    {
        rightkey18 = true;
        ObjeInitPos = hitObject8.transform.position;
        hitObject8.transform.position += new Vector3(0f, 0f, 10f);
        yield return new WaitForSeconds(0.5f);
        hitObject8.transform.position = ObjeInitPos;
    }

    IEnumerator LeftPos4()
    {
        leftkey14 = true;
        ObjeInitPos = hitObject4.transform.position;
        hitObject4.transform.position += new Vector3(0f, 0f, -9.5f);
        yield return new WaitForSeconds(0.5f);
        hitObject4.transform.position = ObjeInitPos;
    }
    IEnumerator LeftPos5()
    {
        leftkey15 = true;
        ObjeInitPos = hitObject5.transform.position;
        hitObject5.transform.position += new Vector3(0f, 0f, -9.8f);
        yield return new WaitForSeconds(0.5f);
        hitObject5.transform.position = ObjeInitPos;
    }
    IEnumerator LeftPos6()
    {
        ObjeInitPos = hitObject6.transform.position;
        hitObject6.transform.position += new Vector3(0f, 0f, -9f);
        yield return new WaitForSeconds(0.5f);
        hitObject6.transform.position = ObjeInitPos;
    }
    IEnumerator LeftPos7()
    {
        leftkey17 = true;
        ObjeInitPos = hitObject7.transform.position;
        hitObject7.transform.position += new Vector3(0f, 0f, -9f);
        yield return new WaitForSeconds(0.5f);
        hitObject7.transform.position = ObjeInitPos;
    }
    IEnumerator LeftPos8()
    {
        leftkey18 = true;
        ObjeInitPos = hitObject8.transform.position;
        hitObject8.transform.position += new Vector3(0f, 0f, -9f);
        yield return new WaitForSeconds(0.5f);
        hitObject8.transform.position = ObjeInitPos;
    }
    IEnumerator ForwardPos2()
    {
        UpKey12 = true;
        ObjeInitPos = hitObject2.transform.position;
        hitObject2.transform.position += new Vector3(-10f, 0f, 0f);
        yield return new WaitForSeconds(0.5f);
        hitObject2.transform.position = ObjeInitPos;
    }
    IEnumerator ForwardPos3()
    {
        upkey13 = true;
        ObjeInitPos = hitObject3.transform.position;
        hitObject3.transform.position += new Vector3(-10f, 0f, 0f);
        yield return new WaitForSeconds(0.5f);
        hitObject3.transform.position = ObjeInitPos;
    }
    IEnumerator ForwardPos5()
    {
        upkey15 = true;
        ObjeInitPos = hitObject5.transform.position;
        hitObject5.transform.position += new Vector3(-9f, 0f, 0f);
        yield return new WaitForSeconds(0.5f);
        hitObject5.transform.position = ObjeInitPos;
    }
    IEnumerator ForwardPos6()
    {
        upkey16 = true;
        ObjeInitPos = hitObject6.transform.position;
        hitObject6.transform.position += new Vector3(-9.8f, 0f, 0f);
        yield return new WaitForSeconds(0.5f);
        hitObject6.transform.position = ObjeInitPos;
    }
    IEnumerator BackPos1()
    {

        DownKey11 = true;
        ObjeInitPos = hitObject1.transform.position;
        hitObject1.transform.position += new Vector3(9f, 0f, 0f);
        yield return new WaitForSeconds(0.5f);
        hitObject1.transform.position = ObjeInitPos;
    }
    IEnumerator BackPos2()
    {
        DownKey12 = true;
        ObjeInitPos = hitObject2.transform.position;
        hitObject2.transform.position += new Vector3(10.2f, 0f, 0f);
        yield return new WaitForSeconds(0.5f);
        hitObject2.transform.position = ObjeInitPos;
    }
    IEnumerator BackPos6()
    {
        downkey16 = true;
        ObjeInitPos = hitObject6.transform.position;
        hitObject6.transform.position += new Vector3(9f, 0f, 0f);
        yield return new WaitForSeconds(0.5f);
        hitObject6.transform.position = ObjeInitPos;
    }
    IEnumerator BackPos7()
    {
        downkey17 = true;
        ObjeInitPos = hitObject7.transform.position;
        hitObject7.transform.position += new Vector3(9f, 0f, 0f);
        yield return new WaitForSeconds(0.5f);
        hitObject7.transform.position = ObjeInitPos;
    }

}
