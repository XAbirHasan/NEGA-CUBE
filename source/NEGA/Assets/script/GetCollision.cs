using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCollision : MonoBehaviour
{   
    public PlayerMovement player;
    public GameObject replacement;
    

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "object" || collision.collider.tag == "object_1" || collision.collider.tag == "object_2" || collision.collider.tag == "object_3" || collision.collider.tag == "object_4")
        {
            player.enabled = false;
            GameObject.Instantiate(replacement, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        
    }
}