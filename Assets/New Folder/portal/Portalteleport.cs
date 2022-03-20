using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portalteleport : MonoBehaviour
{
    [SerializeField] Transform receiver;
    [SerializeField] Transform player;
    bool playerIsPassing;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsPassing = true;
        }
    }

    private void FixedUpdate()
    {
        teleport();
        DrawVectors();
    }
    void DrawVectors()
    {
        Debug.DrawLine(transform.position, player.position);
    }
    private void teleport()
    {
        if (playerIsPassing)
        {
            Vector3 portalDirection = transform.up;
             Vector3 portalToPlayer= player.position - transform.position;
            float dotProduct = Vector3.Dot(portalDirection, portalToPlayer);

            if (dotProduct < 0)
            {
                float rotationDiff = -Quaternion.Angle(transform.rotation, receiver.rotation);
                rotationDiff += 180;
                Vector3 positionOffset = Quaternion.Euler(0, rotationDiff, 0) * portalToPlayer;
                
                player.Rotate(Vector3.up, rotationDiff);
                player.position = receiver.position + positionOffset;
                playerIsPassing = false;

            }
            
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        playerIsPassing = false;
    }
}
