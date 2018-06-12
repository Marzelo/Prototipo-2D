using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptNivelSig : MonoBehaviour {

    public static int nivel;

    // Use this for initialization
    void Start()
    {
        nivel++;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            nivel--;
        }

        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        if (CheckCount())
        {
            if (currentIndex < SceneManager.sceneCountInBuildSettings - 1)
            {
                SceneManager.LoadScene(currentIndex + 1);
            }
            else
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
        Destroy(gameObject);
    }

    bool CheckCount()
    {
        return nivel == 0;
    }

    public static void ResetCount()
    {
        nivel = 0;
    }
}
