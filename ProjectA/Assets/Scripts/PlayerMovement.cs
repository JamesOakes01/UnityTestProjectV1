using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetButtonDown("Fire1")) 
        {
            Debug.Log("fire 1!");
        }

        if (Input.GetButtonDown("Submit"))
        {
            Debug.Log("submit");
        }
        */

        if (Input.GetButton("Forward"))
        {
            //Debug.Log("Forward");
            this.gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetButton("Backward"))
        {
            //Debug.Log("Forward");
            this.gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetButton("Left"))
        {
            //Debug.Log("Forward");
            this.gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetButton("Right"))
        {
            //Debug.Log("Forward");
            this.gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
