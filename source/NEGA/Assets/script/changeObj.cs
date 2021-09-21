using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeObj : MonoBehaviour {

    // Use this for initialization
    public GameObject replacement;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "player")
        {
            GameObject.Instantiate(replacement, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }
}
