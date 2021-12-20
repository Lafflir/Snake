using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Target;

    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - Target.transform.position;
    }
    private void Update()
    {
        Vector3 p = Target.transform.position + offset;
        p.x = transform.position.x;
        transform.position = p;
    }
}
