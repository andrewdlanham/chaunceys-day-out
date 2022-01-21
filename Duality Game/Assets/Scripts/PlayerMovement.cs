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

    private void movePlayer() 
    {
        switch (getDirection()) {
            case "Up":       transform.position += new Vector3(0f, 1f, 0f); break;
            case "Down":     transform.position += new Vector3(0f, -1f, 0f); break;
            case "Left":     transform.position += new Vector3(-1f, 0f, 0f); break;
            case "Right":    transform.position += new Vector3(1f, 0f, 0f); break;
            default: break;
        }
    }

    private string getDirection() 
    {
        if (_isHorizontalPlayer) {
            if (Input.GetKeyDown("d") || Input.GetKeyDown("right")) {
                return "Right";
            } else if (Input.GetKeyDown("a") || Input.GetKeyDown("left")) {
                return "Left";
            }
        } else {
            if (Input.GetKeyDown("w") || Input.GetKeyDown("up")) {
                return "Up";
            } else if (Input.GetKeyDown("s") || Input.GetKeyDown("down")) {
                return "Down";
            }
        }

        return "";
    
    }


    
}
