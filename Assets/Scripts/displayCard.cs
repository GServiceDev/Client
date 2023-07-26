using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using TMPro;

public class DisplayCard : MonoBehaviour
{
    public List<Card_SO> displayCard_SO = new List<Card_SO>();
    public int displayId = 0;

    public int Id;
    public string Title;
    public (int, int, int) Cost; //S-M-B
    public (int, int) Body; //{ get; private set; }
    public int Energy;
    public string Nature;
    public (string,string) Tags; //dove (s, e) sono tags 'A-B-Z' ed e 'A:...;B:...' con indice anche non necessario, sufficente ordine alfabetico
    public (string, string) Effect; //formato (t, 'effect') dove t è il tipo(passivo, attivo, etc..) //Bastano i tags?
    public string Description;
    public Sprite ImageSprite; //{ get; private set; }

    public TextMeshProUGUI titleText;
    public Image artImage;

    // Start is called before the first frame update
    void Start()
    {
        displayCard_SO.Add(cards_DB.cardList[displayId]);
        Id = displayCard_SO[0].Id;
        Title = displayCard_SO[0].Title;
        ImageSprite = displayCard_SO[0].ImageSprite;
        
        titleText.text = " " + Title;
        artImage.sprite = ImageSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
