using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace ZeldaSparring
{


    public class ArenaConnection : MonoBehaviourPunCallbacks
    {

        [SerializeField] private UnityEvent onLeave;

        public override void OnLeftRoom()
        {
            SceneManager.LoadScene(0);
        }


        public void LeaveRoom()
        {
            onLeave?.Invoke();
            PhotonNetwork.LeaveRoom();
        }


    }

}