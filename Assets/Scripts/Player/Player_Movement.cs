using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    public void movement()
    {
        if (Input.GetKey(KeyCode.W)) //up
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A)) //left
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S)) //down
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D)) //right
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}
