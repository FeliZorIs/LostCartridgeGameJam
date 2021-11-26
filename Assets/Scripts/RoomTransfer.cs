using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTransfer : MonoBehaviour
{
    Camera Maincam;
    GameObject player;

    public Vector3 cameraShift;
    public Vector3 playerShift;

    // Start is called before the first frame update
    void Start()
    {
        Maincam = Camera.main;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Maincam.transform.position += cameraShift;
            collision.transform.position += playerShift;
        }
    }
}
