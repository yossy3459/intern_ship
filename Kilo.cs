using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Ateam
{
    public class Kilo : BaseBattleAISystem
    {

        public List<CharacterModel.Data> playerList;
        public List<CharacterModel.Data> enemyList;	
        public int[,] stageData;
        public Vector2 stageDataBlockNum;
        //---------------------------------------------------
        // InitializeAI
        //---------------------------------------------------
        override public void InitializeAI()
        {
            // 取得
            playerList = GetTeamCharacterDataList(TEAM_TYPE.PLAYER);
            enemyList = GetTeamCharacterDataList(TEAM_TYPE.ENEMY);
            stageDataBlockNum = GetStageDataBlockNum();
            stageData = GetStageData();

            // デバッグ
            Debug.Log(playerList);
            Debug.Log(enemyList);
            Debug.Log(stageDataBlockNum);
            Debug.Log(stageData);

        }

        //---------------------------------------------------
        // UpdateAI
        //---------------------------------------------------
        override public void UpdateAI()
        {
            foreach (var player in playerList)
            {
                // 全プレイヤーの処理
                Debug.Log(player.ActorId);

                // player[0]の処理
                if (player.ActorId == 0)
                {
                    
                }



            }
        }

        //---------------------------------------------------
        // ItemSpawnCallback
        //---------------------------------------------------
        override public void ItemSpawnCallback(ItemSpawnData itemData)
        {
        }
    }
}