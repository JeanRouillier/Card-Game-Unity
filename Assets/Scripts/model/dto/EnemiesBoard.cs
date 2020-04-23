using System;
using System.Collections.Generic;

public class EnemiesBoard : GameBoard {

    private List<Enemy> frontLineEnemyWaitingList = new List<Enemy>();
    private List<Enemy> backLineEnemyWaitingList = new List<Enemy>();

    public List<Enemy> FrontLineEnemyWaitingList { get => frontLineEnemyWaitingList; set => frontLineEnemyWaitingList = value; }
    public List<Enemy> BackLineEnemyWaitingList { get => backLineEnemyWaitingList; set => backLineEnemyWaitingList = value; }

    public void placeEnemies(List<Enemy> enemies) {
        foreach (Enemy e in enemies){
            Console.WriteLine(e.name + " " +e.position);

            //si place pas dispo on offset jusqu'à dispo
            bool isPositionOccupied = isOccupied(e.position);
            if(isPositionOccupied){
                BoardPosition positiveEffective = e.position.offsetSameRow();
                BoardPosition negativeEffective = e.position.negativeOffsetSameRow();
                if(!isOccupied(e.position.offsetSameRow())){
                    setAtPosition(positiveEffective, e);

                }else if (!isOccupied(e.position.negativeOffsetSameRow())){
                    setAtPosition(negativeEffective, e);

                } else {
                    if ((e.position.x % 1) != 0) {
                        BackLineEnemyWaitingList.Add(e);
                        Console.WriteLine("Added to temp BACK");
                    } else {
                        FrontLineEnemyWaitingList.Add(e);
                        Console.WriteLine("Added to temp FRONT");
                    }
                }
            } else {
                setAtPosition(e.position, e);
            }
        }
    }

    public new void flush() {
        base.flush();
        FrontLineEnemyWaitingList.Clear();
        BackLineEnemyWaitingList.Clear();
    }

    public List<Person> getAllPlacedEnemies() {
        List<Person> result = new List<Person>();
        for (int i = 0; i <= board.GetLength(0); i++) {
            for (int j = 0; j <= board.GetLength(1); j++) {
                Person current = this.board[i, j];
                if (current != null)
                    result.Add(current);
            }
        }
        return result;
    }

}
