using System;
public class BoardPosition {

    public int x { get; set; }
    public int y { get; set; }

    public BoardPosition(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public BoardPosition offsetSameRow(){
        y = Math.Abs((y + 1) % 2);
        return new BoardPosition(x, y);
    }

    public BoardPosition negativeOffsetSameRow(){
        y = Math.Abs((y - 1) % 2);
        return new BoardPosition(x, y);
    }
}
