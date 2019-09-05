using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MuteVolume : MonoBehaviour, IPointerClickHandler
{

    public Sprite defaultImage;
    public Sprite muteImage;

    public bool isPressed;

    public AudioSource theMusic;

    private Image theSR;
    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!isPressed)
        {
            theSR.sprite = muteImage;
            theMusic.volume = 0f;
            Debug.Log("gay");
            isPressed = true;

        }
        else
        {
            theSR.sprite = defaultImage;
            theMusic.volume = 1f;
            Debug.Log("gay!");
            isPressed = false;
        }
    }
}

