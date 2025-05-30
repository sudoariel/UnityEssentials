using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("How many real seconds a full day lasts")]
    public float dayLengthInSeconds = 60f;

    private float rotationSpeed;

    void Start()
    {
        // 360 degrees per day
        rotationSpeed = 360f / dayLengthInSeconds;
    }

    void Update()
    {
        // Rotate around the X axis
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
