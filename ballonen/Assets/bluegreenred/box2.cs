using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class box2 : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Destroy(gameObject);
        spwning.speed = 0;
        highscorescore.Reset();
    }

    private void Update()
    {
        if (spwning.speed == 0)
        {
            Destroy(this.gameObject);
        }
    }

}