using TMPro;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float ForwardSpeed = 5;
    public float Sensitivity = 10;

    public int Leght = 1;

    public TextMeshPro PointsText;

    private Camera mainCamera;
    private Rigidbody2D componentRigidbody;

    private Vector2 touchLastPos;
    private float sidewaysSpeed;

    void Start()
    {
        mainCamera = Camera.main;
        componentRigidbody = GetComponent<Rigidbody2D>();

        PointsText.SetText(Leght.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
