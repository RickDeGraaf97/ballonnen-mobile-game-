using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class box : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Destroy(gameObject);
        spwning.speed++;
        highscorescore.AddPoints(2);
    }

    private void Update()
    {
        if (spwning.speed == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
