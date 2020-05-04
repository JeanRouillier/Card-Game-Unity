using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack 
{
    public Enemy attacker;
    public List<Player> targets;

    public EnemyAttack(Enemy enemy, List<Player> l){
        attacker = enemy;
        targets = l;
    }
}
