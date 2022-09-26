using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    private GameObject currentTeleporter;
    public bool TeleportCollision;
    void Update()
    {
        if (TeleportCollision)
        {
            if(currentTeleporter != null)
            {
                transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter") ||collision.CompareTag("Spike"))
        {
            currentTeleporter = collision.gameObject;
            TeleportCollision = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter") || collision.CompareTag("Spike"))
        {
            if(collision.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
                TeleportCollision = false;
            }
        }
    }
}
