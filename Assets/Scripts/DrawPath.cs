using NaughtyAttributes;
using UnityEngine;
using UnityEngine.AI;

[DefaultExecutionOrder(10)]
public class DrawPath : MonoBehaviour
{
    [SerializeField] private LineRenderer line;

    [SerializeField] private Transform startPos, endPos;

    private NavMeshPath _path;

    private void Start()
    {
        DrawPathLine();
    }

    [Button("Draw Path")]
    private void DrawPathLine()
    {
        _path = new NavMeshPath();
        var result = NavMesh.CalculatePath(startPos.position, endPos.position, NavMesh.AllAreas, _path);
        Debug.Log("Result: " + result + ", Length: " + _path.corners.Length);

        if (!result) return;
        var corners = _path.corners;
        line.positionCount = corners.Length;
        line.SetPositions(corners);
    }
}