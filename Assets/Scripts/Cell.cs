using UnityEngine;

public class Cell : MonoBehaviour
{
    public int row;
    public int row_t;
    public int col;
    public int col_t;

    public int offset = 20;
    public string terrain;

    public Vector3 size = new Vector3(300f, 30f, 280f);

    public void GenerateCell(Card_SO cardData, GameObject cardTemplate)
    {
        GenerateSquare();
        GenerateCard(cardData, cardTemplate);
    }

    public void GenerateSquare()
    {
        GameObject square = GameObject.CreatePrimitive(PrimitiveType.Cube);
        square.name = "Square [" + row + ", " + col + "]";
        square.transform.parent = transform;
        square.transform.localPosition = new Vector3(size.x / 2f, size.y / 2f, size.z / 2f);
        square.transform.localScale = size;

        // Cambia il colore del quadrato in base all'attributo "terrain".
        Renderer renderer = square.GetComponent<Renderer>();
        if (terrain == "White")
        {
            renderer.material.color = Color.white;
        }
        else if (terrain == "Black")
        {
            renderer.material.color = Color.black;
        }
    }

    public void GenerateCard(Card_SO cardData, GameObject cardTemplate)
    {
        if (cardTemplate != null && cardData != null)
        {   
            // if (row == 0){
            //     row_t = row;
            // }else{
            //     row_t = row - 1;
            // }
            // if (col == 0){
            //     col_t = col;
            // }else{
            //     col_t = col - 1;
            // }

            float xOffset = (size.x) * col_t + size.x / 2f ;
            float zOffset = (size.z) * row_t + size.z / 2f ;
            
            GameObject cardObj = Instantiate(cardTemplate, transform);
            cardObj.transform.localPosition = new Vector3(xOffset, size.y + 20f, zOffset); // Posiziona la carta al centro della cella.
            cardObj.transform.localRotation = Quaternion.Euler(0f, 0f, -90f); // Ruota la carta di 90° attorno all'asse X.
           
            DisplayCard_SO cardDisplay = cardObj.GetComponentInChildren<DisplayCard_SO>();
            Debug.Log("ok0");
            if (cardDisplay != null)
            {   
                Debug.Log(cardData.ImageSprite);
                cardDisplay.FillCardData(cardData);
            }
            
        }
    }
}
