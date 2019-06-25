using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bevegelse : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public Rigidbody2D rb;
    public float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, 0 , 0);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce);
        }

        if (timer > 0f)
        {
            timer += Time.deltaTime;
            if (timer > 1f)
            {
                timer = 0f;
                transform.position = Vector2.zero;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Hazard")
        {
            Debug.Log("OnCollisionEnter2D");
            rb.AddTorque(100);
            rb.AddForce(Vector2.up * 300);
            timer += Time.deltaTime;
        }
    }
}
