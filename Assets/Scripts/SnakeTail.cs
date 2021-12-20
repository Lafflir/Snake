using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{
    public Transform SnakeHead;
    public float BodyDiameter;

    private List<Transform> snakeCircles = new List<Transform>();
    private List<Vector3> positions = new List<Vector3>();

    private void Awake()
    {
        positions.Add(SnakeHead.position);
    }

    private void Update()
    {
        float distance = ((Vector3)SnakeHead.position - positions[0]).magnitude;

        if (distance > BodyDiameter)
        {
            // Ќаправление от старого положени€ головы, к новому
            Vector3 direction = ((Vector3)SnakeHead.position - positions[0]).normalized;

            positions.Insert(0, positions[0] + direction * BodyDiameter);
            positions.RemoveAt(positions.Count - 1);

            distance -= BodyDiameter;
        }

        for (int i = 0; i < snakeCircles.Count; i++)
        {
            snakeCircles[i].position = Vector3.Lerp(positions[i + 1], positions[i], distance / BodyDiameter);
        }
    }

    public void AddBody()
    {
        Transform circle = Instantiate(SnakeHead, positions[positions.Count - 1], Quaternion.identity, transform);
        snakeCircles.Add(circle);
        positions.Add(circle.position);
    }

    public void RemoveBody()
    {
        Destroy(snakeCircles[0].gameObject);
        snakeCircles.RemoveAt(0);
        positions.RemoveAt(1);
    }
}
