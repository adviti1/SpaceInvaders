using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invaderSpeed : MonoBehaviour
{
    public float moveSpeed;
  
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "boundary")
        {
            transform.position = new Vector3 (transform.position.x, transform.position.y -1 , transform.position.z);
            moveSpeed *= -1;
        }
        if (collision.gameObject.tag == "neeche")
        {
            Destroy(gameObject);
        }
    }
}
