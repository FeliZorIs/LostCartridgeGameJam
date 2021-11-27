using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTransfer : MonoBehaviour
{
    Camera Maincam;
    GameObject player;

    public Vector3 cameraShift;
    public Vector3 playerShift;
    public float smoothing;

    // Start is called before the first frame update
    void Start()
    {
        Maincam = Camera.main;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Maincam.transform.position = Vector3.Lerp(transform.position, Maincam.transform.position += cameraShift, smoothing);

            Maincam.transform.position += cameraShift;
            collision.transform.position += playerShift;
        }
    }
}
