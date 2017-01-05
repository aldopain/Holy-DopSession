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

	public int pMissTurn = 0;
	public int eMissTurn = 0;

	public int[] pAttackBuff = {0, 0};
	public int[] AttackBuff = {0, 0};

	public int pInvurable = 0;
	public int eInvurable = 0;

	private Enemy eManager;
	private PlayerManager pManager;

	void Start(){
		eManager = enemy.GetComponent<Enemy> ();
		pManager = player.GetComponent<PlayerManager> ();
	}

	void enemyAttack(){
		if (pInvurable <= 0 && eMissTurn <= 0)
			pManager.HealthPoints--;
		if (pInvurable > 0)
			pInvurable--;
		if (eMissTurn > 0)
			eMissTurn--;
	}

	public void useSkill1(){
		eManager.HealthPoints--;
		enemyAttack ();
	}

	public void useSkill2(){
		eMissTurn += 2;
		enemyAttack ();
	}

	public void useUltimate(){
		pInvurable += 2;
		enemyAttack ();
	}

	void Update(){
		if (eManager.HealthPoints <= 0) {
			result.text = "YOU WON";
			SceneManager.LoadScene ("First");
			System.Threading.Thread.Sleep(2000);
		}
		if (pManager.HealthPoints <= 0) {
			result.text = "YOU LOST";
			SceneManager.LoadScene ("First");
			System.Threading.Thread.Sleep(2000);
		}
		enemyHealthBar.text = "Enemy HP: " + eManager.HealthPoints;
		playerHealthBar.text = "Your HP: " + pManager.HealthPoints;
	}
}
