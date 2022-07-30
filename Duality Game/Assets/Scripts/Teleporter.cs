using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    [SerializeField] Teleporter _otherTeleporter;
    [SerializeField] private bool _isReadyToTeleport;

    // Start is called before the first frame update
    void Start()
    {
        _isReadyToTeleport = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        Debug.Log("Player triggered a teleporter.");

        if (_isReadyToTeleport && _otherTeleporter._isReadyToTeleport) {
            transform.GetComponent<BoxCollider2D>().enabled = false;
            GameObject collisionGameObject = collider.gameObject;
            teleportObject(collisionGameObject);
        }
        
        _isReadyToTeleport = false;
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        Debug.Log("Player exited a teleporter.");

        _isReadyToTeleport = true;
        _otherTeleporter._isReadyToTeleport = true;
        _otherTeleporter.transform.GetComponent<BoxCollider2D>().enabled = true;
    }

    private void teleportObject(GameObject obj)
    {
        obj.transform.position = _otherTeleporter.transform.position;
    }
}
