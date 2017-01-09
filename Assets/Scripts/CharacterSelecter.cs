using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelecter : MonoBehaviour {

	public void selectCharacter(string name){
		GameObject selected = GameObject.Find(name);
		selected.tag = "Player";
		LevelLoader.LevelLoad ("First");
	}
}
