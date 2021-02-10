using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCourotine : MonoBehaviour
{
    [SerializeField] private Transform MovingObject;
    [SerializeField] private Transform StartPoint;
    [SerializeField] private Transform EndPoint;
    [SerializeField] private float speed = 10;
    void Start()
    {
        StartCoroutine(MoveFromTo(MovingObject,StartPoint.position,EndPoint.position,speed));
    }

    IEnumerator MoveFromTo(Transform objectToMove, Vector3 a, Vector3 b, float speed)
    {
        float step = (speed / (a - b).magnitude) * Time.fixedDeltaTime;
        float t = 0;
        while (t <= 1.0f)
        {
            t += step; // Goes from 0 to 1, incrementing by step each time
            objectToMove.position = Vector3.Lerp(a, b, t); // Move objectToMove closer to b
            yield return null;
        }
        objectToMove.position = b;
    }
}
