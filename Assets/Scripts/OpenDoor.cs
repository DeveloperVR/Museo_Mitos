using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] 
    GameObject Opened_door;
    [SerializeField]
    GameObject closed_door;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "key")
        {
            Debug.Log("Door Opened!");
            Opened_door.SetActive(true);
            closed_door.SetActive(false);
            other.gameObject.SetActive(false);
        }
    }
}
