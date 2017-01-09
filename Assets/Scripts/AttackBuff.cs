using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBuff : MonoBehaviour {

	public int time;
	public int attack;

	public AttackBuff(int a, int t){
		time = t;
		attack = a;
	}
}
