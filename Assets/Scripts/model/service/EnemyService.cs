using System.Collections.Generic;
using System;
using UnityEngine;
public class EnemyService {

    private static List<Enemy> one  = Enemies.initLevelOneEnemyList() ;
    private static List<Enemy> two = Enemies.initLevelTwoEnemyList();
    private static List<Enemy> three = Enemies.initLevelThreeEnemyList();

    public static List<Enemy> pickEnemies(EncounterRow encounterRow){
        List<Enemy> result = new List<Enemy>();
        result.AddRange(pickSpecificEnemy(1, encounterRow.levelOneNumber));
        result.AddRange(pickSpecificEnemy(2, encounterRow.levelTwoNumber));
        result.AddRange(pickSpecificEnemy(3, encounterRow.levelThreeNumber));
        return result;

    }

    public static List<Enemy> pickSpecificEnemy(int level, int qty){
        System.Random rand = new System.Random();
        List<Enemy> enemyOneCopy = new List<Enemy>(one);
        List<Enemy> enemyTwoCopy = new List<Enemy>(two);
        List<Enemy> enemyThreeCopy = new List<Enemy>(three);

        List<Enemy> result = new List<Enemy>();
        for(int i = 0; i<= qty-1; i++){
            switch (level){
                case 1:
                    Enemy a =  one[rand.Next(one.Count)];
                    one.Remove(a);
                    result.Add(a);
                    break;
                case 2:
                    Enemy b = two[rand.Next(two.Count)];
                    two.Remove(b);
                    result.Add(b);
                    break;
                case 3:
                    Enemy c = three[rand.Next(three.Count)];
                    three.Remove(c);
                    result.Add(c);
                    break;
            }
        }
        return result;
    }

    public List<Player> enemyAttack(Enemy enemy, AlliesBoard alliesBoard){
        List<Player> targetedByAttack = new List<Player>(); 
        Player p = (Player) alliesBoard.getAtPosition(enemy.attackTarget[0]);
        if (!enemy.isAreaAttack && p != null){
                targetedByAttack.Add(p);
        }
        return targetedByAttack;
    }

 
    public EnemyAttack attack(int attackerIndex, EnemiesBoard enemiesBoard, AlliesBoard alliesBoard){
			List<Enemy> enemies = (List<Enemy>) enemiesBoard.getAllPlaced();
            Enemy nextAttacker = enemies.Find(e => e.isAreaAttack == false);
            List<Player> attackedPlayer = enemyAttack(nextAttacker, alliesBoard);
            nextAttacker.hasAtatcked = true;
            return new EnemyAttack(nextAttacker, attackedPlayer);
    }
}
