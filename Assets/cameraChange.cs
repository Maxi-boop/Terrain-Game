using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraChange : MonoBehaviour
{
    public Camera maincamera;

    private float num = 0f; 
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
        if(collision.tag == "Player")
        {
            num += 1f;    
        }
        if(num == 1f)
        {
            maincamera.transform.position = new Vector3(-10f, maincamera.transform.position.y, maincamera.transform.position.z);
            Debug.Log("Touched once");
        }
        if (num == 3f)
        {
            maincamera.transform.position = new Vector3(0f, maincamera.transform.position.y, maincamera.transform.position.z);
        }
    }
}
