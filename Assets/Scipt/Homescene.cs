using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Homescene : MonoBehaviour
{
    public void GoToPlayground()
    {
        SceneManager.LoadScene("myscene");
    }
}
