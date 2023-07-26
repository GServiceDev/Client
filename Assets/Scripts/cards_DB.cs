using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cards_DB : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>(); //fully accessable


    void Awake()
    {
        cardList.Add(new Card(0, "Goliath, turned antelope", (7,2,2), (12,4), 1,
         "Necrotic",
         ("Adaptation-Gap-Target'" , "Steal 2 health from a random enemy creature-4-null"),   
        ("n","null"),
        "One of the first appearance in the upper land, a demon risen from the unknown work of The Lich, the dead wizard of the council.",
        Resources.Load<Sprite>("png_goliath")
            
         ));

    }


}
