using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    
    // Start is called before the first frame update
    public float speed = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector2(x, 0);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
