using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipe : MonoBehaviour {

    private bool tap, swipeleft, swiperight, swipeup, swipedown;
    private Vector2 starttouch, swipedelta;


    private bool isdragging = false;

    public Vector2 Swipedelta { get { return swipedelta; } }
    public bool Swipeleft { get { return swipeleft; } }
    public bool Swiperight { get { return swiperight; } }
    public bool Swipeup { get { return swipeup; } }
    public bool Swipedown { get { return swipedown; } }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        tap = swipeleft = swiperight = swipeup = swipedown = false;

#region standalone inputs
if (Input.GetMouseButtonDown(0))
        {
            tap = true;
            isdragging = true;

            starttouch = Input.mousePosition;


        }else if (Input.GetMouseButtonUp(0))
        {
            isdragging = false;

            Reset();
        }
        #endregion

        #region mobile inputs
if(Input.touches.Length != 0)
        {
            if(Input.touches[0].phase == TouchPhase.Began)
            {
                tap = true;
                isdragging = true;

                starttouch = Input.touches[0].position;



            }else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                isdragging = false;
                Reset();

            }
        }

        #endregion

        // calculate th distance 
        swipedelta = Vector2.zero;
        if(isdragging)
        {
            if(Input.touches.Length != 0)
            {
                swipedelta = Input.touches[0].position - starttouch;


            }else if (Input.GetMouseButton(0))
            {
                swipedelta = (Vector2)Input.mousePosition - starttouch;
            }
        }


        //did we cross the deadzone
        if(swipedelta.magnitude > 150)
        {
            // with derection
            float x = swipedelta.x;
            float y = swipedelta.y;              

            if(Mathf.Abs(x) > Mathf.Abs(y))
            {
                // left or right
                if (x < 0)
                {
                    swipeleft = true;

                }
                else
                {
                    swiperight = true;

                }
            }
            else
            {
                // up and down
                if (y < 0)
                {
                    swipedown = true;

                }
                else
                {
                    swipeup = true;

                }
            }






            Reset();
        }
    }

    private void Reset()
    {
        starttouch = swipedelta =  Vector2.zero;
        isdragging = false;
    }
}
