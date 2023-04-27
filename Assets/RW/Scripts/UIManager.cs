using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
	public void StartGame()
    	{
		SceneManager.LoadScene("RocketMouse");
	}
}