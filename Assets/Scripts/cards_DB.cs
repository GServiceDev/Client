using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cards_DB : MonoBehaviour
{
    public static List<Card_SO> cardList = new List<Card_SO>(); //fully accessable


    void Awake()
    {
        
        cardList.Add(CreateCard(0, "Goliath, turned antelope", (7,2,2), (12,4), 1,
         "Necrotic",
         ("Adaptation-Gap-Target'" , "Steal 2 health from a random enemy creature-4-null"),   
        ("n","null"),
        "One of the first appearance in the upper land, a demon risen from the unknown work of The Lich, the dead wizard of the council.",
        Resources.Load<Sprite>("png_goliath")
            
         ));

    }

    private Card_SO CreateCard(int id, string title, (int, int, int) cost, (int, int) body, int energy,
        string nature, (string, string) tags, (string, string) effect, string description, Sprite imageSprite)
    {
        Card_SO card = ScriptableObject.CreateInstance<Card_SO>();
        card.Id = id;
        card.Title = title;
        card.Cost = cost;
        card.Body = body;
        card.Energy = energy;
        card.Nature = nature;
        card.Tags = tags;
        card.Effect = effect;
        card.Description = description;
        card.ImageSprite = imageSprite;
        return card;
    }


}
