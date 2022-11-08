using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //print(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        //print("Hello");
        print(transform.position);


        if(Input.GetKey(KeyCode.W) == true)
        {
            //print("W");

            //transform.position = new Vector3(0, 2, 0);

            transform.position = new Vector3(transform.position.x, transform.position.y + 0.001f, 0);

        }

        if (Input.GetKey(KeyCode.S) == true)
        {

            //transform.position = new Vector3(0, -2, 0);

            transform.position = new Vector3(transform.position.x, transform.position.y + -0.001f, 0);
        }


        if (Input.GetKey(KeyCode.A) == true)
        {

            //transform.position = new Vector3(-2, 0, 0);

            transform.position = new Vector3(transform.position.x + -0.001f, transform.position.y, 0);
        }


        if (Input.GetKey(KeyCode.D) == true)
        {

            //transform.position = new Vector3(2, 0, 0);

            transform.position = new Vector3(transform.position.x + 0.001f, transform.position.y, 0);
        }



    }
}
