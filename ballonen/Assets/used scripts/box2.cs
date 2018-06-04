using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class box2 : MonoBehaviour, IPointerClickHandler
{
    destroy destroyscript;
    private void Start()
    {
        destroyscript = FindObjectOfType<destroy>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Destroy(gameObject);
        spwning.speed = 0;
        highscorescore.Reset();
        destroyscript.hoistart();

    }

    private void Update()
    {
        if (spwning.speed == 0)
        {
            Destroy(this.gameObject);
        }
    }



}