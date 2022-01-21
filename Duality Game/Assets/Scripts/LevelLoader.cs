using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        Debug.Log("Player collided with a level loader.");
        GameObject collisionGameObject = collider.gameObject;
        SceneManager.LoadScene("Scene2"); // TODO: Switch from hard-coded string to scene numbers
    }
}
