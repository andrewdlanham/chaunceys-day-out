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

        transform.GetComponent<BoxCollider2D>().enabled = false;

        if (!isMovingIntoWall() && !isMovingIntoPlayer()) {
            movePlayer();
        }

        transform.GetComponent<BoxCollider2D>().enabled = true;

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

    private bool isMovingIntoWall() 
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, getMovementVector(), 1);
        if (hit.collider != null) {
            if (hit.transform.tag == "Wall") {
                printHitTransformTag(hit);
                return true;
            }
        }
        return false;
    }

    private bool isMovingIntoPlayer() 
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, getMovementVector(), 1);
        if (hit.collider != null) {
            if (hit.transform.tag == "Player") {
                printHitTransformTag(hit);
                return true;
            }
        }
        return false;
    }

    private void printHitTransformTag(RaycastHit2D hit)
    {
        Debug.Log("There is a " + getHitTransformTag(hit) + " in the way.");
    }

    private string getHitTransformTag(RaycastHit2D hit)
    {
        return hit.transform.tag;
    }

    
}
