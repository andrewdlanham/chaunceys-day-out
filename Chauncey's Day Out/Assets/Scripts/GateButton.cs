using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateButton : MonoBehaviour
{
    [SerializeField] private Gate _gate;
    [SerializeField] private Sprite _openSprite;

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Moved onto gate button.");
        _gate.gameObject.SetActive(false);
        transform.GetComponent<SpriteRenderer>().sprite = _openSprite;
        
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        Debug.Log("Moved off of gate button.");
    }
}
