using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

  

    public Transform prefab;

    public Canvas can;

    public GameObject[] spwingpoint = new GameObject[4];

    public GameObject[] bluegreenred = new GameObject[7];

    // Use this for initialization
    void Start () {
        spwnin();
	}
	
	// Update is called once per frame
	void Update () {

    }

   public void spwnin()
    {
        var clone = Instantiate(bluegreenred[Random.Range(0,14)], spwingpoint[Random.Range(0, 4)].transform.position, Quaternion.identity);

        clone.transform.SetParent(can.transform); 
        clone.GetComponent<Rigidbody2D>().velocity = new Vector2(0, spwning.speed);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ja");
        if (collision.gameObject.tag == "blue" || collision.gameObject.tag == "green"  || collision.gameObject.tag == "red")
        {
            //Invoke("spwnin",0);

            spwnin();

            spwning.speed++;
        }

    }

}
