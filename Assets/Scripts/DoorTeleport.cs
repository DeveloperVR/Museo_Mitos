using Unity.VisualScripting;
using UnityEngine;

public class DoorTeleport : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform TP_point;


    void OnTriggerEnter(Collider other)
    {
        player.transform.position = TP_point.position;
    }
}
