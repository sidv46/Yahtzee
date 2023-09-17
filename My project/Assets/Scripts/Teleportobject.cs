using UnityEngine;

public class TeleportObject : MonoBehaviour
{
    // Reference to the object you want to teleport
    public GameObject linkedObject;

    // Destination where the object will be teleported
    public Transform teleportDestination;

    // Function to teleport the linked object
    public void Teleport()
    {
        if (linkedObject != null && teleportDestination != null)
        {
            linkedObject.transform.position = teleportDestination.position;
        }
    }
}
