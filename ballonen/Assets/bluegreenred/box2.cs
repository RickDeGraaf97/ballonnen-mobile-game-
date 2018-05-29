using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class box2 : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Destroy(gameObject);
        spwning.speed = 0;
        highscorescore.Reset();
        hoioi();
        
    }

    private void Update()
    {
        if (spwning.speed == 0)
        {
            Destroy(this.gameObject);
        }
    }



    void hoioi() { SceneManager.LoadScene(0); }

    IEnumerator hoi()
    {
        //highscore

        


        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);

    }
}