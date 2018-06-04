using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroy : MonoBehaviour {

    public GameObject cans;


   GameObject blue;
   GameObject green;
   GameObject red;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
      /*  var box = collision.GetComponent<box>();  // better way but not for me
       *  

        if (box)
        {
            Destroy(box.gameObject);
            spwning.speed = 0;
        }*/

        Debug.Log("ja");
        if (collision.gameObject.tag == "blue")
        {
            blue = collision.gameObject;
            Destroy(blue);
            Debug.Log("destryoy");
            spwning.speed = 0;
            StartCoroutine(hoi());
            highscorescore.Reset();
        }
       else if(collision.gameObject.tag == "green")
        {
            green = collision.gameObject;
            Destroy(green);
            Debug.Log("greendestroy");
            spwning.speed = 0;
            StartCoroutine(hoi());
            highscorescore.Reset();

        }
       else if (collision.gameObject.tag == "red")
        {
            red = collision.gameObject;
            Destroy(red);
            Debug.Log("reddestoy");
        }
    }

    public void hoistart()
    {
        StartCoroutine(hoi());
    }
    IEnumerator hoi()
    {
        //highscore

        cans.SetActive(true);


        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);

    }
}
