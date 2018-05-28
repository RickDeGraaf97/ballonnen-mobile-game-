using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class spwning : MonoBehaviour {


    public static int speed = 100;



    /*   // Update is called once per frame
       void Update()
       {


           //werkt hier gebruik je een raycast die er voor zorgt dat de raycast naar de mouseposition kijkt en als er iets tegen de raycast aan komt dan kan je iets doen bij if (hit.collider != null) en of bij if(input.getmoo=usebuttondown(0)) kan je ook iets doen. 

           RaycastHit2D hit = Physics2D.CircleCast(Input.mousePosition,10 ,0.1f * Vector2.up);
           if (hit.collider != null)
           {
               Debug.Log("gfsazdfad");
               if (Input.GetMouseButtonDown(0))
               {
                   print("mouse pressed");
                   Destroy(hit.transform.gameObject);
                   speed++;
                   //highscore +1
                  // textsc 

               }
           }

       }*/

    private void Update()
    {
        Debug.Log("speed" + speed);
    }
}
