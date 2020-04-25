using System;
using System.Collections.Generic;

public class GameBoard {
    public Person[,] board { get; set; }

    public GameBoard(){
        board = new Person[2, 3];
    }

    public bool isOccupied(BoardPosition position){
        return board[position.x, position.y] != null;
    }

    public Person getAtPosition(BoardPosition position){
        try{
            return board[position.x, position.y];
        }catch(IndexOutOfRangeException e){
            return null;
        }
    }

    public bool setAtPosition(BoardPosition position, Person person) {
        var atPosition = getAtPosition(position);
        if (atPosition != null) {
            Console.WriteLine(atPosition.name + " is already present on this position " + position);
            return false;
        } else {
            person.position = position;
            board[position.x, position.y] = person;
            return true;
        }
    }

    public List<Person> getAllPlaced() {
        List<Person> result = new List<Person>();
        for (int i = 0; i <= board.GetLength(0)-1; i++) {
            for (int j = 0; j <= board.GetLength(1)-1; j++) {
                Person current = this.board[i, j];
                if (current != null)
                    result.Add(current);
            }
        }
        return result;
    }

    public void flush() {
        board = new Person[2,3];
    }

    /**
     * Print in console the actual model view
     */
    public void print() {
        String result = "";
        for (int i = 0; i <= board.GetLength(0) ; i++) {
            for (int j = 0; j <= board.GetLength(1) ; j++) {
                String value = board[i, j] != null ? board[i,j].name : "null";
                result += " | " + value + " | ";
            }
            result += Environment.NewLine;
        }
        Console.Write(result);
    }
}
