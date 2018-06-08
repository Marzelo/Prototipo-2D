using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectable : MonoBehaviour{

    public static int count;

    // Use this for initialization
    void Start(){
        count++;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player")){
            count--;
        }
        if (CheckCount()){
            Camera.main.GetComponent<GameControl>().primeraPuerta.SayDebug();
        }
        Destroy(gameObject);
    }

    bool CheckCount(){
        return count == 0;
    }

    public static void ResetCount(){
        count = 0;
    }

    /*void OnTriggerEnter (Collider other) {
        Debug.Log ("Entre en Trigger con " + other);
        if (other.CompareTag("Player")) {
            other.GetComponent<Movimiento> ().ResetPosition ();
        }
    }*/
}
