using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayCard_SO : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public Image artImage;

    public void FillCardData(Card_SO cardData)
    {
        titleText.text = cardData.Title;
        artImage.sprite = cardData.ImageSprite;
    }
}
