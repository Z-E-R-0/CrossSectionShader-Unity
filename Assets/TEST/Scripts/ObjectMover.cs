using UnityEngine;
using UnityEngine.UI;

public class ObjectMover : MonoBehaviour
{
    public Transform pointA; // Empty GameObject for Point A
    public Transform pointB; // Empty GameObject for Point B
    public Slider slider;    // UI Slider

    void Update()
    {
        // Ensure pointA, pointB, and slider are set
        if (pointA != null && pointB != null && slider != null)
        {
            // Lerp between Point A and Point B based on the slider value
            transform.position = Vector3.Lerp(pointA.position, pointB.position, slider.value);
        }
    }
}
