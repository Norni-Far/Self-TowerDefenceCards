using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsForLinePosition : MonoBehaviour
{
    public enum MovementType
    {
        Moveing,
        Lerping
    }

    public MovementType Type = MovementType.Moveing;
    public CreateLineForMovement myPath; // vjq 
    public float speed = 1;
    public float maxDistance = 0.1f;

    private IEnumerator<Transform> pointInPath;


    private void Start()
    {
        if (myPath == null)
            return;

        pointInPath = myPath.GetNextPathPoint();

        pointInPath.MoveNext();

        if (pointInPath.Current == null)
            return;

        transform.position = pointInPath.Current.position;
    }

    private void FixedUpdate()
    {
        if (pointInPath == null || pointInPath.Current == null)
            return;

        if (Type == MovementType.Moveing)
            transform.position = Vector3.MoveTowards(transform.position, pointInPath.Current.position, Time.deltaTime * speed);
        else if (Type == MovementType.Lerping)
            transform.position = Vector3.Lerp(transform.position, pointInPath.Current.position, Time.deltaTime * speed);

        var distanceSqure = (transform.position - pointInPath.Current.position).sqrMagnitude;

        // направление переда
        var direction = (pointInPath.Current.position - transform.position).normalized;
        var euler = transform.eulerAngles;

        euler.y = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        transform.eulerAngles = euler;

        /*// направление колёс 
        foreach (var item in whilessTop)
        {
            item.transform.eulerAngles = euler;
        }*/

        if (distanceSqure < maxDistance * maxDistance)
            pointInPath.MoveNext();
    }
}
