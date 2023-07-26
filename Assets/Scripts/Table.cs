using UnityEngine;

public class Table : MonoBehaviour
{
    public int rows = 7;
    public int columns = 6;
    public Vector3 size = new Vector3(300f, 30f, 280f);
    public float offset = 20f;

    public GameObject cardTemplate;

    private void Start()
    {
        GenerateChessboard();
    }

    void GenerateChessboard()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Vector3 cellPosition = new Vector3(col * (size.x + offset), 0f, row * (size.z + offset));
                GenerateCell(cellPosition, row, col);
            }
        }
    }

    void GenerateCell(Vector3 position, int row, int col)
    {
        GameObject cellObj = new GameObject("Cell [" + row + ", " + col + "]");
        cellObj.transform.parent = transform;
        cellObj.transform.localPosition = position;

        Cell cell = cellObj.AddComponent<Cell>();
        cell.row = row;
        cell.col = col;

        // Assegna il colore della cella in base alla posizione della scacchiera.
        if ((row + col) % 2 == 0)
        {
            cell.terrain = "White";
        }
        else
        {
            cell.terrain = "Black";
        }

        if (true)
        {
            cell.GenerateCell(cards_DB.cardList[0], cardTemplate);
        }
        else
        {
            cell.GenerateCell(null, null);
        }
    }
}
