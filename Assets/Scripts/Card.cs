using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card 
{   

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

    public Card(int id, string title, (int, int, int) cost, (int, int) body, int energy, string nature,
                 (string,string) tags, (string,string) effect, string description, Sprite imageSprite)
    {
        Id = id;
        Title = title;
        Cost = cost;
        Body = body;
        Energy = energy;
        Nature = nature;
        Tags = tags;
        Effect = effect;
        Description = description;
        ImageSprite = imageSprite;
    }
}
