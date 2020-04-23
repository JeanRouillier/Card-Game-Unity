using System;
using System.Collections.Generic;

public class Enemies {


    public static List<Enemy> initLevelOneEnemyList(){
        Enemy irithyllianBeastHound = new Enemy(
                "irithyllianBeastHound",
                1,
                1,
                1,
                1,
                AttackTypeEnum.MAGICAL,
                2,
                ConditionEnum.FROST,
                new List<BoardPosition> { new BoardPosition(1, 0) },
                false,
                new BoardPosition(0, 2),
                null,
                "enemies_00018");
        Enemy hollowManservant = new Enemy(
                "hollowManservant",
                1,
                2,
                0,
                2,
                null,
                4,
                null,
                new List<BoardPosition> { new BoardPosition(0, 2) },
                false,
                new BoardPosition(0, 0),
                null,
                "enemies_00008");
        Enemy hollowSoldier = new Enemy(
                "hollowSoldier",
                1,
                2,
                1,
                1,
                AttackTypeEnum.HEAVY,
                3,
                null,
                new List<BoardPosition> { new BoardPosition(0, 2) },
                false,
                new BoardPosition(0, 0),
                null,
                "enemies_00007");

        return new List<Enemy>{
            irithyllianBeastHound,
                hollowManservant,
                hollowSoldier};
    }

    public static List<Enemy> initLevelTwoEnemyList(){
        return new List<Enemy>();
    }

    public static List<Enemy> initLevelThreeEnemyList(){
        Enemy blackKnightUltraGreatSwordsman = new Enemy(
               "blackKnightUltraGreatSwordsman",
               3,
               11,
               3,
               2,
               AttackTypeEnum.MAGICAL,
               4,
               null,
               new List<BoardPosition> {
                   new BoardPosition(0, 1),
                   new BoardPosition(0, 1),
                   new BoardPosition(0, 2),
               },
               true,
               new BoardPosition(0, 0),
               null,
               "enemies_00032");
       

        return new List<Enemy> { blackKnightUltraGreatSwordsman };
    }

}
