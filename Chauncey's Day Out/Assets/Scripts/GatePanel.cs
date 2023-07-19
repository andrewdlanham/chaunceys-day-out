using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatePanel : MonoBehaviour
{

    [SerializeField] private Gate _gate;
    [SerializeField] private Sprite _activatedSprite;
    [SerializeField] private Sprite _unactivatedSprite;

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Moved onto gate panel.");
        _gate.gameObject.SetActive(false);
        transform.GetComponent<SpriteRenderer>().sprite = _activatedSprite;
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        Debug.Log("Moved off of gate panel.");
        _gate.gameObject.SetActive(true);
        transform.GetComponent<SpriteRenderer>().sprite = _unactivatedSprite;
    }
}
