using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour {

	Skill sk1(){
		Skill retVal = new Skill ();
		retVal.dmgToEnemy = 2;
		return retVal;
	}

	Skill sk2(){
		Skill retVal = new Skill ();
		retVal.selfAttackBuff.Add(new AttackBuff(2, 2));
		return retVal;
	}

	public List<Skill> ChooseCharacter(string name){
		List<Skill> retVal = new List<Skill> ();
		switch (name) {
		case "Jaan":
			retVal.Add (sk1 ());
			retVal.Add (sk2 ());
			break;
		case "Nikita":

			break;
		case "Syn sobaki":
			
			break;
		}
		return retVal;
	}


}
