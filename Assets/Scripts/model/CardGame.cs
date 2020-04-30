using System;
using System.Collections.Generic;

public class CardGame
{
	public Players players = new Players();
	public AlliesBoard alliesBoard = new AlliesBoard();
	public EnemiesBoard enemiesBoard = new EnemiesBoard();

	public Encounters encounterList = new Encounters();
	public Campaigns campaignPath = new Campaigns();
	public Round currentRound = new Round();

	public CardGame() {
		//currentRound.activeEncounter = null;
		enemiesBoard.flush();
		alliesBoard.flush();
	}

	public void nextStep() {
		
		if (RoundState.START.Equals(currentRound.state)){
			int ? level = campaignPath.currentPath.encounterLevel;
			if(level != null)
			{				
				Encounter e = Rules.selectEncounter(encounterList, level.Value);
				currentRound.activeEncounter = e;
				campaignPath.currentPath.encounter = e;
			}
			else
			{
				//TODO Boss path
			}
			//PLACE ENEMIES
			Dictionary<int?, EncounterRow> detail = campaignPath.currentPath.encounter.detail;
			List<Enemy> enemies = EnemyService.pickEnemies(detail[1]);
			enemiesBoard.placeEnemies(enemies);
			currentRound.state = RoundState.ENCOUNTER_PICKED;
			return;
		}
		if (RoundState.ENCOUNTER_PICKED.Equals(currentRound.state)) {
			//Place allies
			currentRound.state = RoundState.ALLIES_PLACED;
			return;
		}

		if (RoundState.ALLIES_PLACED.Equals(currentRound.state)) {
			//ENEMY ATTACK
			//All enemies
			List<Enemy> enemies = (List<Enemy>) enemiesBoard.getAllPlaced();
			//enemies.AddRange(enemiesBoard.FrontLineEnemyWaitingList);
			EnemyService.enemyAttack(enemies, alliesBoard);
			currentRound.state = RoundState.ENEMIES_ATTACKED;
			return;
		}
		if (RoundState.ENEMIES_ATTACKED.Equals(currentRound.state)) {
			currentRound.state = RoundState.ALLIES_ATTACKED;
			return;
		}
		if (RoundState.ALLIES_ATTACKED.Equals(currentRound.state)) {
			return;
		}
	}
}
