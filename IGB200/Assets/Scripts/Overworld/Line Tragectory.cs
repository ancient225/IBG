using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LineTragectory : MonoBehaviour
{
    [SerializeField] private LineRenderer lineRen;

    [SerializeField] [Range(3, 30)] private int lineSegCount = 10;

    private List<Vector3> linePoints = new List<Vector3>();

    private void Update()
    {
        
    }

    void updateTragectory(Vector3 Force, Rigidbody RB, Vector3 StartPoint)
    {
        Vector3 Velocity = (Force / RB.mass) * Time.fixedDeltaTime;

        float duration = (2 * Velocity.y) / Physics.gravity.y;

        float stepTime = duration / lineSegCount;

        linePoints.Clear();

        for (int i = 0; i < lineSegCount; i++)
        {
            float stepTimePassed = stepTime * i;

            Vector3 MoveVector = new Vector3(Velocity.x * stepTimePassed, Velocity.y * stepTimePassed - 0.5f * Physics.gravity.y * stepTimePassed * stepTimePassed, Velocity.z * stepTimePassed);

            linePoints.Add(-MoveVector + StartPoint);
        }

        lineRen.positionCount = linePoints.Count;
        lineRen.SetPositions(linePoints.ToArray());
    }

}
