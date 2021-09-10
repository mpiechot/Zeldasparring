using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZeldaSparring
{

    public class ConnectionSetup : MonoBehaviour
    {
        [SerializeField] private TMPro.TMP_InputField nickNameTextField;

        private string nickName;

        private void Awake()
        {
            PhotonNetwork.AutomaticallySyncScene = true;
        }

        private void Start()
        {
            LoadValues();
        }

        private void LoadValues()
        {
            nickName = PlayerPrefs.GetString(ConnectionConstants.NickNamePrefKey);
            nickNameTextField.text = nickName;
        }

        public void SetNickName(string name)
        {
            nickName = name;
        }


        public void SaveValues()
        {
            PlayerPrefs.SetString(ConnectionConstants.NickNamePrefKey, nickName);
        }

    }

}