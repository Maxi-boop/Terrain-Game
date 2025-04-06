using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipyScript : MonoBehaviour
{
    public TMPro.TextMeshPro text;
    public float scaleMultiplier = 2f; 
    Transform tf; 

    private bool hasTouchedCoin = false;
    private bool hasTouchedPlayer = false; 
    
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            hasTouchedPlayer = true;
        }
        if (collision.gameObject.tag == "Coin")
        {
            hasTouchedCoin = true;
        }
        if (hasTouchedCoin && hasTouchedPlayer == true)
        {
            if(collision.gameObject.tag == "Coin")
            {
                int notherNum = int.Parse(s: collision.gameObject.GetComponentInChildren<MultipyScript>().text.text);
                int myInt = int.Parse(text.text);
                int product = myInt * notherNum;
                tf.localScale *= scaleMultiplier; 
                hasTouchedCoin = false;
                hasTouchedPlayer = false;
                text.text = product.ToString();

                Destroy(collision.gameObject, 0.1f);
            }
        }    
    }
}
