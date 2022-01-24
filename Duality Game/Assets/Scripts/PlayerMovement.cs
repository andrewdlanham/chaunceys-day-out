using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private bool _isHorizontalPlayer;
    private BoxCollider2D _boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        _boxCollider = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTryingToMove()) {
            attemptMove();
        }    
    }

    private bool isTryingToMove() 
    {
        return (getDirection() != "");
    }

    private void attemptMove() 
    {
        
        RaycastHit2D hit = Physics2D.Raycast(transform.position + getMovementVector(), getMovementVector(), 0.1f);
        if (hit.collider != null) {
            string tag = hit.transform.tag;
            Debug.Log("Moving into " + tag);
            if (tag != "Wall" && tag != "Player") {
                movePlayer();
            }
        } else {
            movePlayer();
        }

    }


    private void movePlayer() 
    {
        transform.position += getMovementVector();
    }

    private Vector3 getMovementVector() 
    {
        switch (getDirection()) {
            case "Up":       return new Vector3(0f, 1f, 0f);
            case "Down":     return new Vector3(0f, -1f, 0f);
            case "Left":     return new Vector3(-1f, 0f, 0f);
            case "Right":    return new Vector3(1f, 0f, 0f);
            default:         return new Vector3(0f, 0f, 0f);
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
