using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float moveHorizontal = horizontalInput * speed * Time.deltaTime;
        transform.position = new Vector2(transform.position.x + moveHorizontal, transform.position.y);
    }
}
