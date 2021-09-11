using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZeldaSparring
{


    public class ArenaLoader : MonoBehaviour
    {

        [SerializeField] private GameObject playerPrefab;

        private void Start()
        {
            LoadPlayer();
        }

        private void LoadPlayer()
        {
            if (playerPrefab)
            {
                PhotonNetwork.Instantiate(playerPrefab.name, Vector2.zero, Quaternion.identity, 0);
            }
        }

    }

}