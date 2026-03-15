using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("How many real seconds one full day lasts")]
    public float dayDuration = 120f; // seconds for a full day

    private float rotationSpeed;

    void Start()
    {
        // Degrees per second (360 degrees in dayDuration seconds)
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}