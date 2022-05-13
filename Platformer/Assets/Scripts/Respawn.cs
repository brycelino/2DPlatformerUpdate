using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform PlayerPrefab;
    public Transform spawnPoint;

    public void RespawnPLayer()
    {
        Instantiate(PlayerPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
