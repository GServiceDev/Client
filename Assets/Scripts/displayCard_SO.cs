using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using TMPro;

public class DisplayCard_SO : MonoBehaviour
{
    public Card_SO card;


    public TextMeshProUGUI titleText;
    public Image artImage;

    // Start is called before the first frame update
    void Start()
    {
        
        titleText.text = card.Title;
        artImage.sprite = card.ImageSprite;

    }


}
