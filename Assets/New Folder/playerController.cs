using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField] float speed = 12f;
    [SerializeField] LayerMask groundMask;
    Vector3 velocity;
    CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        GroundCheck();
        
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Pickup"))
        {
            hit.gameObject.GetComponent<pickup>().Picked();
        }
    }

    private void GroundCheck()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,Vector3.down, out hit, 1.2f, groundMask))
        {

            
            string groundType = hit.collider.tag;
            
            switch (groundType)
            {
                case "GroundFast":
                    speed = 20f;
                    break;
                case "GroundSlow":
                    speed = 5f;
                    break;
                default:
                    speed = 12f;
                    break;
                    
            }
        }
        
                
    }

    private void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = (z* transform.forward) + (x*transform.right);
        controller.Move(move * speed * Time.deltaTime);
    }
}
