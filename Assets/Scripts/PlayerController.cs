using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    Vector3 playerPosition;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        //playerPosition = rb.position;

    }



    // Update is called once per frame
    void Update()
    {
        //touchCount gibt an wieviele Sachen gerade getoucht wurden 
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            //touch.postion gives x,y coordinates on the screen
            //camera distance is manual set to it's view 
            

            //ScreenToWorldPoint rechne die position im touch im verhältnis zur kamera um 
            //camera position sollte hier rausgelesen werden sowas wie m_LocalPosition.z
            
            float cameraDistance = -10;
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x,touch.position.y,cameraDistance));

            rb.position = new Vector3(touchPosition.x*-1, -3, 0);
            
            if (Mathf.Abs(touchPosition.x) >= 2.5)
            {
                if (touchPosition.x >= 2.5f)
            {
                 rb.position = new Vector3(-2.5f, -3, 0);
            }

            if (touchPosition.x <= -2.5f)
            {
                 rb.position = new Vector3(2.5f, -3, 0);
            }

            }
            

            Debug.Log("rb: " + rb.position+"&"+"touch: "+ touchPosition);





        }

    }
        
}
