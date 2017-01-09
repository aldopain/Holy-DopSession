using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
	public int HealthPoints;
	public int MaxAttempts;
	public int[] PlayerNumberOfAttempts = new int[4];
	public int[] PlayerLevelOfSubject = new int[4];
	public List<Skill> skills;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}
