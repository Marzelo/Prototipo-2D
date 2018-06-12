using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlayer : MonoBehaviour {

    public float speed = 1;
    public Rigidbody2D rigidbody2D;
    Vector3 initialPos;

    // Use this for initialization
    void Start () {
        initialPos = transform.position;
    }

    // Update is called once per frame
    void Update(){
        Vector3 movement = transform.position;
        if (Input.GetKey(KeyCode.A)){
            movement += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W)){
            movement += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)){
            movement += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)){
            movement += Vector3.right * speed * Time.deltaTime;
        }
        rigidbody2D.MovePosition(movement);
    }

    public void ResetPosition()
    {
        transform.position = initialPos;
    }
}
