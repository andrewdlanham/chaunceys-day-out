using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScene : MonoBehaviour
{
    public void ReturnToMainMenu() {
        SceneManager.LoadScene("CompletedMainMenu");
    }
}
