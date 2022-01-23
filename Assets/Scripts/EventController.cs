using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour
{
    public GameObject ToxicCan; //prefab
    private GameObject curToxicCan;

    public GameObject ToxicCan2; //prefab
    private GameObject curToxicCan2;

    public GameObject ToxicCan3; //prefab
    private GameObject curToxicCan3;

    public GameObject ToxicCan4; //prefab
    private GameObject curToxicCan4;

    public GameObject Fish; //prefab
    private GameObject curFood;

    public GameObject Fish2; //prefab
    private GameObject curFood2;

    public GameObject Ham; //prefab
    private GameObject curFood3;

    public GameObject Steak; //prefab
    private GameObject curFood4;

    public GameObject Ham2; //prefab
    private GameObject curFood5;

    public GameObject Ham3; //prefab
    private GameObject curFood6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(curToxicCan == null){
            float x = Random.Range(0.0f, 180.0f);
            float y = Random.Range(1.5f, 2.0f);
            float z = Random.Range(0.0f, 180.0f);
            curToxicCan = Instantiate(ToxicCan, new Vector3(x, y, z), Quaternion.identity);
        }

        if(curToxicCan2 == null){
            float x = Random.Range(0.0f, 180.0f);
            float y = Random.Range(1.5f, 2.0f);
            float z = Random.Range(0.0f, 180.0f);
            curToxicCan2 = Instantiate(ToxicCan2, new Vector3(x, y, z), Quaternion.identity);
        }

        if(curToxicCan3 == null){
            float x = Random.Range(0.0f, 180.0f);
            float y = Random.Range(1.5f, 2.0f);
            float z = Random.Range(0.0f, 180.0f);
            curToxicCan3 = Instantiate(ToxicCan3, new Vector3(x, y, z), Quaternion.identity);
        }
        
        if(curToxicCan4 == null){
            float x = Random.Range(0.0f, 180.0f);
            float y = Random.Range(1.5f, 2.0f);
            float z = Random.Range(0.0f, 180.0f);
            curToxicCan4 = Instantiate(ToxicCan4, new Vector3(x, y, z), Quaternion.identity);
        }

        if(curFood == null){
            float x = Random.Range(0.0f, 180.0f);
            float y = Random.Range(2.5f, 3.5f);
            float z = Random.Range(0.0f, 180.0f);
            curFood = Instantiate(Fish, new Vector3(x, y, z), Quaternion.identity);
        }

        if(curFood2 == null){
            float x = Random.Range(0.0f, 180.0f);
            float y = Random.Range(2.5f, 3.5f);
            float z = Random.Range(0.0f, 180.0f);
            curFood2 = Instantiate(Fish2, new Vector3(x, y, z), Quaternion.identity);
        }

        if(curFood3 == null){
            float x = Random.Range(0.0f, 180.0f);
            float y = Random.Range(1.5f, 3.0f);
            float z = Random.Range(0.0f, 180.0f);
            curFood3 = Instantiate(Ham, new Vector3(x, y, z), Quaternion.identity);
        }

        if(curFood4 == null){
            float x = Random.Range(0.0f, 180.0f);
            float y = Random.Range(2.5f, 3.5f);
            float z = Random.Range(0.0f, 180.0f);
            curFood4 = Instantiate(Steak, new Vector3(x, y, z), Quaternion.identity);
        }

        if(curFood5 == null){
            float x = Random.Range(0.0f, 180.0f);
            float y = Random.Range(1.5f, 3.0f);
            float z = Random.Range(0.0f, 180.0f);
            curFood5 = Instantiate(Ham2, new Vector3(x, y, z), Quaternion.identity);
        }

        
        if(curFood6 == null){
            float x = Random.Range(0.0f, 180.0f);
            float y = Random.Range(1.5f, 3.0f);
            float z = Random.Range(0.0f, 180.0f);
            curFood6 = Instantiate(Ham3, new Vector3(x, y, z), Quaternion.identity);
        }
    }
}
