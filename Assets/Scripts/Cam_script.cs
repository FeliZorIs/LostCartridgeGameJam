using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_script : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    string player_location;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player_location == "room1")
        {
            transform.position = new Vector3(0, 0, 0);
        }

        if (player_location == "room2")
        {
            transform.position = new Vector3(-16, 0, 0);
        }
    }
}
