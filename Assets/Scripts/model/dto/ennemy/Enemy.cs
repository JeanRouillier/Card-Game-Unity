using System;
using System.Collections.Generic;

public class Enemy : Person {
    public Enemy(string name, int level, int souls, int armor, int hp, AttackTypeEnum? sensibility, int attack, ConditionEnum? attackType, 
        List<BoardPosition> attackTarget, bool isAreaAttack, BoardPosition position, BoardPosition effectivePosition,
        string textureName)
    {
        this.name = name;
        this.level = level;
        this.souls = souls;
        this.armor = armor;
        this.hp = hp;
        this.sensibility = sensibility;
        this.attack = attack;
        this.attackType = attackType;
        this.attackTarget = attackTarget;
        this.isAreaAttack = isAreaAttack;
        this.position = position;
        this.effectivePosition = effectivePosition;
        this.textureName = textureName;
    }

    public int level { get; set; }
    public int souls { get; set; }
    public int armor { get; set; }
    public int hp { get; set; }
    public AttackTypeEnum? sensibility { get; set; }
    public int attack { get; set; }
    public ConditionEnum? attackType { get; set; }
    public List<BoardPosition> attackTarget { get; set; }
    public bool isAreaAttack { get; set; }
    public BoardPosition effectivePosition { get; set; }
}
