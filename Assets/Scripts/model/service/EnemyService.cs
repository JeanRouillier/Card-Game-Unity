using System.Collections.Generic;
using System;
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
        Random rand = new Random();
        List<Enemy> enemyOneCopy = new List<Enemy>(one);
        List<Enemy> enemyTwoCopy = new List<Enemy>(two);
        List<Enemy> enemyThreeCopy = new List<Enemy>(three);

        List<Enemy> result = new List<Enemy>();
        for(int i = 0; i<= qty-1; i++){
            switch (level){
                case 1:
                    Enemy a =  enemyOneCopy[rand.Next(enemyOneCopy.Count)];
                    result.Add(a);
                    break;
                case 2:
                    Enemy b = enemyTwoCopy[rand.Next(enemyOneCopy.Count)];
                    result.Add(b);
                    break;
                case 3:
                    Enemy c = enemyOneCopy[rand.Next(enemyOneCopy.Count)];
                    result.Add(c);
                    break;
            }
        }
        return result;
    }

    public static void enemyAttack(List<Enemy> enemyList, AlliesBoard alliesBoard){
        alliesBoard.print();
        foreach (Enemy e in enemyList) {
            Console.WriteLine("ATTACKER : " + e.name + " attacks => "+e.attackTarget);
            Player p = (Player) alliesBoard.getAtPosition(e.attackTarget[0]);
            if (!e.isAreaAttack && p != null){
                    Console.WriteLine("DEFENDER is "+p.name);
            }else{
            Console.WriteLine("Attack failed no target");
            }
        }

    }
}
