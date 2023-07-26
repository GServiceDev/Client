using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{   
    public List<Card_SO> deck = new List<Card_SO>(); 
    public List<Card_SO> container = new List<Card_SO>(); 
    
    public int x;
    public int deckSize = 10;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        
        for(int i = 0; i < deckSize; i++)
        {
            x = Random.Range(1, 1);
            deck[i] = cards_DB.cardList[x];
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shuffle()
    {
        for(int i = 0; i < deckSize; i++)
        {
            container[0] = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container[0];
            
        }

    }
}
