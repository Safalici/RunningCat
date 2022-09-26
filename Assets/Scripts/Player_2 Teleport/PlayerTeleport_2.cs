using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport_2 : MonoBehaviour
{
    
    private GameObject currentTeleporter;
    public bool TeleportCollision;
    public bool fell = false;
    
    // Update is called once per frame
    void Update()
    {
        if (TeleportCollision)
        {
            if(currentTeleporter != null)
            {
                transform.position = currentTeleporter.GetComponent<Teleporter_2>().GetDestination().position;
                
                
            }
        }   
    }
   /* public bool Player2Respawn()
    {
        return TeleportCollision;
    }
   */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter") || collision.CompareTag("Spike"))
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
