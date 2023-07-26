using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card_SO : ScriptableObject

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

}
