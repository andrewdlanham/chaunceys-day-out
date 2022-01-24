using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    [SerializeField] private string _sceneToLoadName;

    void OnTriggerEnter2D(Collider2D collider) 
    {
        Debug.Log("Player collided with a level loader.");
        GameObject collisionGameObject = collider.gameObject;
        SceneManager.LoadScene(_sceneToLoadName);
    }
}
