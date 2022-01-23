using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToxicCanController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "SharkPlayer") {
            print("Trigger happens!");
            print(gameObject.name);
            float ori_speed;
            ori_speed = other.gameObject.GetComponent<SharkController>().speed;
            if (ori_speed <= 5) {
                other.gameObject.GetComponent<SharkController>().speed = ori_speed;
            } else {
                other.gameObject.GetComponent<SharkController>().speed = ori_speed - 10.0f;
            }
            Destroy(gameObject);
        }
    }
}
