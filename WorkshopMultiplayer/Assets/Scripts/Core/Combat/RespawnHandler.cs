using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class RespawnHandler : NetworkBehaviour
{
    [SerializeField] private NetworkObject playerPrefab;

    public override void OnNetworkSpawn()
    {
        if (!IsServer) { return; }

        TankPlayer[] players = FindObjectsByType<TankPlayer>(FindObjectsSortMode.None);
    }
    
    public override void OnNetworkDespawn()
    {
        if (!IsServer) { return; }
    }

    private void HandlePlayerSpawned(TankPlayer player)
    {
        
    }
    
    private void HandlePlayerDespawned(TankPlayer player)
    {
        
    }
}
