using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    public float moveSpeed = 10f;
    public float jumpPower = 10f;
    public TMPro.TextMeshProUGUI text; 
    float jumpsLeft = 5f; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        text = GetComponentInChildren<TMPro.TextMeshProUGUI>();
        string initialText = text.text;
        text.text = "JumpsLeft: 5"; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0, 0); 
        }
        if(Input.GetButtonDown("Jump"))
        {
            if(jumpsLeft > 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpPower);
                jumpsLeft -= 1f;
                text.text = "JumpsLeft: " + jumpsLeft.ToString();
            }
        }
    }
}
