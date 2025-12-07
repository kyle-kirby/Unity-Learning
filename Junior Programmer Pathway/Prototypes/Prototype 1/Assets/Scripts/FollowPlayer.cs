using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // LateUpdate is called once per frame after all Update functions have been called
    void LateUpdate()
    {
        // Camera follows the player with an offset
        transform.position = player.transform.position + offset;
    }
}
