using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Keys : MonoBehaviour
{
    public Text keyCount;
    public int keys;

    private void Start()
    {
        keys = 0;
    }

    private void Update()
    {
        keyCount.text = keys.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.CompareTag("Key"))
        {
            keys++;
            Destroy(collider.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("LockedDoor") && keys > 0)
        {
            keys--;
            Destroy(collision.gameObject);
        }
    }
}
