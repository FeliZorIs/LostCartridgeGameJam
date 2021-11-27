using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Pusher : MonoBehaviour
{
    public bool up;
    public float speed;
    public float pushDistance;
    [SerializeField]
    bool charge;

    Vector2 direction;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        charge = false;
        player = GameObject.FindGameObjectWithTag("Player");
        if (up)
        {
            direction = Vector2.up;
        }
        else
        {
            direction = Vector2.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.queriesStartInColliders = false;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, pushDistance);
        Debug.DrawRay(transform.position, direction * pushDistance, Color.red);

        if (hit.transform != null)
        {
            if (hit.transform.tag == "Player")
            {
                Debug.Log("I can smell you");
                charge = true;
            }
        }

        if (charge)
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
