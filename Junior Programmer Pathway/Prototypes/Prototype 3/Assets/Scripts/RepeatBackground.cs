using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Sets the start position of the background to original starting position
        startPos = transform.position;
        // Finds needed width of backgrounds box collider X value and divides by two
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        // If the background position is less than starting position minus midway offset
        if (transform.position.x < startPos.x - repeatWidth)
        {
            // Sets the background position to the original starting position
            transform.position = startPos;
        }
    }
}
