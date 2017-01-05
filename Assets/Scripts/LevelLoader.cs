using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
	public GameObject player;

	public void LevelLoad(string myLevel){
		DontDestroyOnLoad (player);
		SceneManager.LoadScene (myLevel);
	}
}
