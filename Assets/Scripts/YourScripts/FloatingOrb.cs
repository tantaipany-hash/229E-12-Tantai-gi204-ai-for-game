using UnityEngine;

public class FloatingOrb : MonoBehaviour
{
    public float height = 1f;
    public float speed = 2f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float newY = Mathf.Sin(Time.time * speed) * height;
        transform.position = startPos + new Vector3(0, newY, 0);
    }
}