using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FightManager : MonoBehaviour {
	public GameObject player;
	public GameObject enemy;
	public Text enemyHealthBar;
	public Text playerHealthBar;
	public Text result;
	public Button Ult;

	public int pMissTurn = 0;
	public int eMissTurn = 0;

	private List<AttackBuff> playerAttackBuff;
	private List<AttackBuff> enemyAttackBuff;

	public int pInvurable = 0;
	public int eInvurable = 0;

	private Enemy eManager;
	private PlayerManager pManager;

	private List<Skill> pSkills;
	private List<Skill> eSkills;

	void Start(){
		eManager = enemy.GetComponent<Enemy> ();
		pManager = (GameObject.FindGameObjectWithTag("Player")).GetComponent<PlayerManager> ();
		playerAttackBuff = new List<AttackBuff>();
		enemyAttackBuff = new List<AttackBuff>();
	}

	void useSkill(Skill sk){
	}

	private int calculateBuffs(List<AttackBuff> bl){
		int retVal = 0;
		foreach(AttackBuff x in bl){
			if (x.time > 0)
				retVal += x.attack;
			x.time--;
		}
		return retVal;
	}

	void enemyAttack(){
		if (pInvurable <= 0 && eMissTurn <= 0)
			pManager.HealthPoints--;
		if (pInvurable > 0)
			pInvurable--;
		if (eMissTurn > 0)
			eMissTurn--;
		if (pMissTurn > 0)
			pMissTurn--;
	}

	public void useSkill1(){
		
		enemyAttack ();
	}

	public void useSkill2(){
		
		enemyAttack ();
	}

	public void useUltimate(){
		pInvurable += 2;
		enemyAttack ();
	}

	void Update(){
		/*if(Input.mousePosition.x > Ult.transform.position.x){
			Ult.interactable = true;
		}else{
			Ult.interactable = false;
		}*/
		if (eManager.HealthPoints <= 0) {
			result.text = "YOU WON";
			SceneManager.LoadScene ("First");
		}
		if (pManager.HealthPoints <= 0) {
			pManager.HealthPoints = 1;
			result.text = "YOU LOST";
			SceneManager.LoadScene ("First");
		}
		enemyHealthBar.text = "Enemy HP: " + eManager.HealthPoints;
		playerHealthBar.text = "Your HP: " + pManager.HealthPoints;
	}
}
