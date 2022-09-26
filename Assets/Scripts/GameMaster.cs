using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster gm;
    public Player_2 player_2;
    private PlayerTeleport_2 playerRespanws;
    public Transform WhitePlayer2Spawn;
    void Start()
    {
        if(gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        }
    }
   /* public void SpawnParticalsWhite()
    {
        if (playerRespanws.Player2Respawn())
        {
            Instantiate(WhitePlayer2Spawn, player_2.GetPosition(), Quaternion.identity);
        }
        
    }
   */

}
