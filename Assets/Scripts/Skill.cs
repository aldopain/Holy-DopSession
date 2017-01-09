using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour {
	public int dmgToEnemy = 0;

	public int selfHeal = 0;
	public int enemyHeal = 0;

	public int selfMissTurn = 0;
	public int enemyMissTurn = 0;

	public List<AttackBuff> selfAttackBuff;
	public List<AttackBuff> enemyAttackBuff;

	public int selfInvurable = 0;
	public int EnemyInvurable = 0;
}
