using UnityEngine;

public  class HexCell : MonoBehaviour
{
    public int elevation;
    public const float elevationStep = 5f;
    public HexCoordinates coordinates;
    public Color color;
    
    [SerializeField]
    HexCell[] neighbors;

    public HexCell GetNeighbor (HexDirection direction) {
        return neighbors[(int)direction];
    }

    public void SetNeighbor (HexDirection direction, HexCell cell) {
        neighbors[(int)direction] = cell;
        cell.neighbors[(int)direction.Opposite()] = this;
    }
}

