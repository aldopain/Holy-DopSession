using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	public static void LevelLoad(string level){
		GameObject player = GameObject.FindWithTag ("Player");
		DontDestroyOnLoad (player);
		switch (level) {
		case "Fight":
			player.transform.position = new Vector3(-795, -126, -30);
			break;
		case "First":
			player.transform.position = new Vector3(-722, -146, 0);
			break;
		}
		SceneManager.LoadScene (level);
	}

	public void Load(string level){
		LevelLoad (level);
	}
}
