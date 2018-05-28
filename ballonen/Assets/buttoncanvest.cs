using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttoncanvest : MonoBehaviour {

   public Canvas canvestmi;
   public Canvas canvestri;
   public Canvas canvestli;

    public void onbuttoncanmi()
    {
        canvestmi.gameObject.active = true;
        canvestli.gameObject.active = false;
        canvestri.gameObject.active = false;


    }
    public void onbuttoncanri()
    {
        canvestri.gameObject.active = true;
        canvestmi.gameObject.active = false;
        canvestli.gameObject.active = false;


    }
    public void onbuttoncanli()
    {
        canvestli.gameObject.active = true;
        canvestmi.gameObject.active = false;
        canvestri.gameObject.active = false;


    }
}
