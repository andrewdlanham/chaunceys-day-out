using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateButton : MonoBehaviour
{
    [SerializeField] private Gate _gate;
    [SerializeField] private Sprite _openSprite;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Gate button clicked.");
        _gate.gameObject.SetActive(false);
        transform.GetComponent<SpriteRenderer>().sprite = _openSprite;
    }
}
