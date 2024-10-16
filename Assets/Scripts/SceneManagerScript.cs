using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public void ChangeToMain()
    {
        SceneManager.LoadScene("Menu Scene");
    }

    public void ChangeToGameplay()
    {
        SceneManager.LoadScene("Gameplay Scene");
    }

}
