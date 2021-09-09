using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace com.TheGameProgrammers.Sparring.PunSetup
{


    public class GameManager : MonoBehaviourPunCallbacks
    {

        [SerializeField] private GameObject playerPrefab;

        private void Start()
        {
            if(playerPrefab)
            {
                PhotonNetwork.Instantiate(playerPrefab.name, Vector2.zero, Quaternion.identity, 0);
            }
        }

        public override void OnLeftRoom()
        {
            SceneManager.LoadScene(0);
        }


        public void LeaveRoom()
        {
            PhotonNetwork.LeaveRoom();
        }

    }

}