using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatScript : MonoBehaviour
{


    public float speed;
    public float x_move;
    public float y_move;
    private Vector3 StartPosition;
    private Vector3 EndPosition;
    private bool OnTheMove;


    // Start is called before the first frame update
    void Start()
    {
        StartPosition = new Vector3((float)transform.position.x-x_move, (float)transform.position.y-y_move, (float)transform.position.z);
        EndPosition = new Vector3((float)transform.position.x+x_move, (float)transform.position.y+y_move, (float)transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;

        if (OnTheMove == false) {
            this.transform.position = Vector3.MoveTowards(this.transform.position, EndPosition, step);
        } else {
            this.transform.position = Vector3.MoveTowards(this.transform.position, StartPosition, step);
        }

        if (this.transform.position.x == EndPosition.x && this.transform.position.y == EndPosition.y && OnTheMove == false) {
            OnTheMove = true;
        } else if(this.transform.position.x == StartPosition.x && this.transform.position.y == StartPosition.y && OnTheMove == true) {
            OnTheMove = false;
        }
    }
}
