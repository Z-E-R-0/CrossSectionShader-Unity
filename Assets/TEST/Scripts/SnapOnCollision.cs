using UnityEngine;

public class SnapOnCollision : MonoBehaviour
{
    public bool isSnapped;
    public GameObject targetObject; // Define the target object in the Inspector

    private void OnTriggerEnter(Collider otherCollider)
    {
        Debug.Log("Entered");
        SnapIfMatchingTarget(otherCollider.transform);
    }

    private void OnTriggerStay(Collider otherCollider)
    {
        Debug.Log("Stayed");
        if (!isSnapped)
        {
            SnapIfMatchingTarget(otherCollider.transform);
            isSnapped = true;
        }
    }

    private void OnTriggerExit(Collider otherCollider)
    {
        isSnapped = false;
        targetObject.gameObject.SetActive(true);
        Debug.Log("Exited");
    }

    private void SnapIfMatchingTarget(Transform targetTransform)
    {
        if (targetTransform.gameObject == targetObject)
        {
            this.transform.position=targetTransform.position;
            targetObject.gameObject.SetActive(false);
        }
    }
}
