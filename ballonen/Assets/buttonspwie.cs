using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonspwie : MonoBehaviour {

    GameObject gams;

	// Use this for initialization
	void Start () {
        gams = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    public void onclickbutoon()
    {
        Destroy(gams);
        spwning.speed++;
    }
}
