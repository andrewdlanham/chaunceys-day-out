using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private bool _isHorizontalPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();   
    }


    // Reads keyboard inputs and updates the player's position accordingly
    private void movePlayer()
    {
        if (_isHorizontalPlayer) {
            if (Input.GetKeyDown("d")) {
                transform.position += new Vector3(1f, 0f, 0f);
            } else if (Input.GetKeyDown("a")) {
                transform.position += new Vector3(-1f, 0f, 0f);
            }
        } else {
            if (Input.GetKeyDown("w")) {
                transform.position += new Vector3(0f, 1f, 0f);
            } else if (Input.GetKeyDown("s")) {
                transform.position += new Vector3(0f, -1f, 0f);
            }
        }
    }


    
}
