using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreateLineForMovement : MonoBehaviour
{
    public enum PathTypes
    {
        linear,
        loop
    }

    public PathTypes pathTypes;
    public int movementDirection = 1;
    public int moveinTo = 0;
    public Transform[] pathElements;

    public void OnDrawGizmos()
    {
        if (pathElements == null || pathElements.Length < 2)
            return;

        for (int i = 1; i < pathElements.Length; i++)
        {
            Gizmos.DrawLine(pathElements[i - 1].position, pathElements[i].position);

            if (pathTypes == PathTypes.loop)
                Gizmos.DrawLine(pathElements[0].position, pathElements[i].position);
        }
    }

    public IEnumerator<Transform> GetNextPathPoint()
    {
        if (pathElements == null || pathElements.Length < 1)
            yield break;

        while (true)
        {
            yield return pathElements[moveinTo];

            if (pathElements.Length == 1)
                continue;

            if (pathTypes == PathTypes.linear)
            {
                if (moveinTo <= 0)
                    movementDirection = 1;
                else if (moveinTo >= pathElements.Length - 1)
                    movementDirection = -1;
            }

            moveinTo = moveinTo + movementDirection;

            if (pathTypes == PathTypes.loop)
            {
                if (moveinTo >= pathElements.Length)
                    moveinTo = 0;

                if (moveinTo < 0)
                    moveinTo = pathElements.Length - 1;
            }
        }
    }
}
