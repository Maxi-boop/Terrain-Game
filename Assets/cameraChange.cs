using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraChange : MonoBehaviour
{
    public Camera maincamera;

    private bool  num = false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        while (collision.tag == "Player")
        {
            num = true; // touched player
        }
        if (num == true)
        {
            maincamera.transform.position = new Vector3(-10f, maincamera.transform.position.y, maincamera.transform.position.z);
            Debug.Log("Touched once");
        }
        if (num == false)
        {
            maincamera.transform.position = new Vector3(0f, maincamera.transform.position.y, maincamera.transform.position.z);
            Debug.Log("Two times");
        }
    }
}
