using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SharkController : MonoBehaviour
{ 
    public GameObject maincam, minimap, topcam2;
    public float speed;
    Rigidbody rb;

    void Awake()
    {
        minimap.SetActive(true);
        topcam2.SetActive(false);
        maincam.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
 
        if (Input.GetKey(KeyCode.C)) {
            maincam.SetActive(false);
            topcam2.SetActive(true);
            minimap.SetActive(false);
        } else if (Input.GetKey(KeyCode.X)) {
            maincam.SetActive(true);
            topcam2.SetActive(false);
            minimap.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        rb.velocity = gameObject.transform.forward * speed * moveVertical;

        if(Input.GetKey(KeyCode.A)){
            gameObject.transform.Rotate(new Vector3(0, -2.0f, 0));
        }

        if(Input.GetKey(KeyCode.D)){
            gameObject.transform.Rotate(new Vector3(0, 2.0f, 0));
        }

        rb.angularVelocity = Vector3.zero;
    }
}
