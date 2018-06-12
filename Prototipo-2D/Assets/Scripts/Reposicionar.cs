using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposicionar : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entre en Trigger con " + other);
        if (other.CompareTag("Player"))
        {
            other.GetComponent<ScriptPlayer>().ResetPosition();
        }
    }
}
