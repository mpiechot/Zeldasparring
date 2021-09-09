using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZeldaSparring
{

    public class ConnectionSetup : MonoBehaviour
    {

        private string nickName;

        private void Start()
        {
            LoadValues();
        }

        private void LoadValues()
        {
            nickName = PlayerPrefs.GetString(ConnectionConstants.NickNamePrefKey);
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