using UnityEngine;

public class ChessboardGenerator : MonoBehaviour
{
    public int rows = 8;
    public int columns = 8;
    public Vector3 size = new Vector3(300f, 30f, 280f);
    public float offset = 20f;

    void Start()
    {
        GenerateChessboard();
    }

    void GenerateChessboard()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Vector3 position = new Vector3(col * (size.x + offset), 0f, row * (size.z + offset));
                CreateSquare(position);
            }
        }
    }

    void CreateSquare(Vector3 position)
    {
        GameObject square = GameObject.CreatePrimitive(PrimitiveType.Cube);
        square.transform.position = position;
        square.transform.localScale = size;
        square.GetComponent<Renderer>().material.color = GetSquareColor(position);
    }

    Color GetSquareColor(Vector3 position)
    {
        int row = (int)(position.z / (size.z + offset));
        int col = (int)(position.x / (size.x + offset));

        // White color for even rows and columns, black for odd rows and columns.
        if ((row + col) % 2 == 0)
        {
            return Color.white;
        }
        else
        {
            return Color.black;
        }
    }
}
