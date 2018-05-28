using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n : MonoBehaviour {

    GameObject note;
	// Use this for initialization
	void Start () {
        note = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void nu()
    {
        Destroy(note);
    }
}
