using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    public GameObject Coin; 
    public string Level_2; 
    public float moveSpeed = 10f;
    public float jumpPower = 10f;
    public float StartingJumps = 3f;
    public float coinsNeeded = 2f;
    float coins = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
            if(StartingJumps > 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpPower);
                StartingJumps -= 1f;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "CoinTwo")
        {
            coins += 1f;
            Destroy(collision);
            Coin.SetActive(false);
        }
        if (collision.tag == "Finish")
        {
            if (coins >= coinsNeeded)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(Level_2);
            }

        }
    }
}
