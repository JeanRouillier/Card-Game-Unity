using System;
using System.Collections.Generic;
using UnityEngine;


public class CardGame
{
	public static Players players = new Players();
	public static AlliesBoard alliesBoard = new AlliesBoard();
	public static EnemiesBoard enemiesBoard = new EnemiesBoard();

	public Encounters encounterList = new Encounters();
	public Round currentRound = new Round();

	//public AssetLoader assetLoader;

	public void initActivePlayers(HashSet<PlayersAvailable> list)
	{
		players.InitActivePlayers(list);
	}

	void Start() {
		
	}

	void Update() {
		if (RoundState.START.Equals(currentRound.state)) {
			currentRound.activeEncounter = null;
			enemiesBoard.flush();
			alliesBoard.flush();
		}
		if (RoundState.ENCOUNTER_PICKED.Equals(currentRound.state)) {
			//PLACE ENEMIES
			Dictionary<int?, EncounterRow> detail = currentRound.activeEncounter.detail;
			List<Enemy> enemies = EnemyService.pickEnemies(detail[1]);
			enemiesBoard.placeEnemies(enemies);
			currentRound.state = RoundState.ENEMIES_PLACED;
		}
		if (RoundState.ENEMIES_PLACED.Equals(currentRound.state)) {
			//Place allies

		}

		if (RoundState.ALLIES_PLACED.Equals(currentRound.state)) {
			//ENEMY ATTACK
			//All enemies
			List<Enemy> enemies = new List<Enemy>(enemiesBoard.BackLineEnemyWaitingList);
			enemies.AddRange(enemiesBoard.FrontLineEnemyWaitingList);
			EnemyService.enemyAttack(enemies, alliesBoard);
			currentRound.state = RoundState.ENEMIES_ATTACKED;
		}
		if (RoundState.ENEMIES_ATTACKED.Equals(currentRound.state)) {
			currentRound.state = RoundState.ALLIES_ATTACKED;
		}
		if (RoundState.ALLIES_ATTACKED.Equals(currentRound.state)) {

		}
	}
}
