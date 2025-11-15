using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    // Public fields to set in the Unity Inspector
    public MeshRenderer Renderer;
    public float positionX = 0.0f;
    public float positionY = 3.0f;
    public float positionZ = 0.0f;

    // Properties to be randomized
    public float scale;
    public float rotationSpeed;
    public Color color;
    [Range(0f, 1f)] public float opacity;

    void Start()
    {
        // Randomize properties
        scale = Random.Range(1.0f, 7.0f);
        rotationSpeed = Random.Range(5.0f, 50.0f);
        color = new Color(Random.value, Random.value, Random.value);
        opacity = Random.Range(0.2f, 1.0f);

        // Set position and scale
        transform.position = new Vector3(positionX, positionY, positionZ);
        transform.localScale = Vector3.one * scale;

        // Set material color and opacity
        Material material = Renderer.material;
        Color matColor = color;
        matColor.a = opacity;
        material.color = matColor;

    }

    void Update()
    {
        // Rotate the cube around the X-axis
        transform.Rotate(rotationSpeed * Time.deltaTime, 0.0f, 0.0f);

    }

}
