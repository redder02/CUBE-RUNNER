using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerScript ps ;
    //public Rigidbody rigidbody;
    public Rigidbody rb;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("hello");
        
        if (other.gameObject.tag == "Collectables")
        {
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log("hello");

        if (other.gameObject.tag == "Obstacles")
        {
            //Destroy(other.gameObject);
            ps.enabled = false;
            rb.drag = 34;
        }
    }
}
