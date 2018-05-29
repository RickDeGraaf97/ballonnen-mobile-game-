using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class box3 : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Destroy(gameObject);
        spwning.speed+=2;
        highscorescore.AddPoints(4);
    }

    private void Update()
    {
        if (spwning.speed == 0)
        {
            Destroy(this.gameObject);
        }
    }

}
