using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    [SerializeField] Teleporter _otherTeleporter;

    private bool _readyToTeleport;

    // Start is called before the first frame update
    void Start()
    {
        _readyToTeleport = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        if (_readyToTeleport) {
            Debug.Log("Player collided with a teleporter.");
            GameObject collisionGameObject = collider.gameObject;
            collisionGameObject.transform.position = _otherTeleporter.transform.position;
        }
        
        _readyToTeleport = false;
        _otherTeleporter._readyToTeleport = false;
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        _readyToTeleport = true;
        _otherTeleporter._readyToTeleport = false;
        Debug.Log("Player left a teleporter.");
    }
}
