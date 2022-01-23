using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    Light sharkLight;
    int addLight;

    // Start is called before the first frame update
    void Start()
    {
        sharkLight = GetComponent<Light>();
        sharkLight.intensity = 1;
        addLight = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.U)){
            sharkLight.intensity = sharkLight.intensity + addLight;   
        }

        if(Input.GetKey(KeyCode.J)){
            sharkLight.intensity = sharkLight.intensity - addLight;   
        }
         
    }
}
