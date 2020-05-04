using System;
using System.Collections.Generic;

public class EnemiesBoard : GameBoard {

    public List<Enemy> frontLineEnemyWaitingList = new List<Enemy>();
    public List<Enemy> backLineEnemyWaitingList = new List<Enemy>();

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
                        backLineEnemyWaitingList.Add(e);
                        Console.WriteLine("Added to temp BACK");
                    } else {
                        frontLineEnemyWaitingList.Add(e);
                        Console.WriteLine("Added to temp FRONT");
                    }
                }
            } else {
                setAtPosition(e.position, e);
            }
        }
    }

    public new  List<Enemy> getAllPlaced() {
        List<Enemy> result = new List<Enemy>();
        for (int i = 0; i <= board.GetLength(0)-1; i++) {
            for (int j = 0; j <= board.GetLength(1)-1; j++) {
                Enemy current = (Enemy) this.board[i, j];
                if (current != null)
                    result.Add(current);
            }
        }
        return result;
    }
    public new void flush() {
        base.flush();
        frontLineEnemyWaitingList.Clear();
        backLineEnemyWaitingList.Clear();
    }
}
