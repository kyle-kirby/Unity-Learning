using UnityEngine;

//[ExecuteAlways] // Optional: allows it to run in edit mode too
public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day in seconds.")]
    [SerializeField] private float dayDurationInSeconds = 120f;

    private void Update()
    {
        if (dayDurationInSeconds <= 0f) return;

        // Calculate rotation speed: 360 degrees per full day
        float rotationSpeed = 360f / dayDurationInSeconds;

        // Rotate around the X-axis to simulate sun movement
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}