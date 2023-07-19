using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkForRestart();
        checkForESC();
    }

    private void checkForRestart() {
        if (Input.GetKeyDown("r")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("Level restarted.");
        }
    }

    private void checkForESC() {
        if (Input.GetKeyDown("escape")) {
            SceneManager.LoadScene("CompletedMainMenu");
        }
    }
}
