using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
	public void LeaveTheMansion()
    {
        SceneManager.LoadScene(1);
    }
}
