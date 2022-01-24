using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateButton : MonoBehaviour
{
    [SerializeField] private Gate _gate;
    [SerializeField] private Sprite _openSprite;

    private BoxCollider2D _boxCollider;
    

    // Start is called before the first frame update
    void Start()
    {
        _boxCollider = transform.GetComponent<BoxCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Moved onto gate button.");
        _gate.gameObject.SetActive(false);
        transform.GetComponent<SpriteRenderer>().sprite = _openSprite;
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        Debug.Log("Moved off gate button.");
    }
}
