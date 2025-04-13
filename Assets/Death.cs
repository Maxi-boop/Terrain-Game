using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public string Level_1;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(Level_1);
        }   
    }
}
