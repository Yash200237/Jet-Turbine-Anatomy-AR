using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void Startsimulation ()
    {
        SceneManager.LoadScene("JetTurbine");
    }

    public void Back()
    {
        SceneManager.LoadScene("Home");
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
}
