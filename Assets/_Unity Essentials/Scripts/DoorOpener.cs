using UnityEngine;

public class DoorOpener : MonoBehaviour
{
private Animator doorAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {if (doorAnimator != null)
            {
                // Trigger the door opening animation
                doorAnimator.SetTrigger("Door_Open");
            }
        }
    }
}
