using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectionButtons : MonoBehaviour
{
    public void StartLevel(int index)
    {
        SceneManager.LoadScene(index);
    }
}
