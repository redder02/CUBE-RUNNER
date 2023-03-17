using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float force = 1000f;
    public float speed = 10f;
    public float maxX = 4.45f;
    public float minX = -4.45f;
    // Start is called before the first frame update
    public playerScript() { }
    void Start()
    {
        //Debug.Log("hello world");
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + new Vector3(0, 0, 10f*Time.deltaTime); //this is not a good way to give speed 
        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(transform.position.x, minX, maxX);
        /*if(playerPos.x<minX)//manual code for clamping the cube
        {
            playerPos.x = minX;
        }
        if (playerPos.x > maxX)
        {
            playerPos.x = maxX;
        }*/
        transform.position = playerPos;
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            //rigidbody.AddForce(1000f * Time.deltaTime, 0, 0);
            //if(transform.position<=)
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0,0 );
        }
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            //rigidbody.AddForce(-1000f * Time.deltaTime, 0, 0);
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0,0 );
        }       

    }
    public void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, force * Time.deltaTime);
    }
}
