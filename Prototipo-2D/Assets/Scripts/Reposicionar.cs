using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Reposicionar : MonoBehaviour{

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            int currentIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentIndex);
        }
    }
}
