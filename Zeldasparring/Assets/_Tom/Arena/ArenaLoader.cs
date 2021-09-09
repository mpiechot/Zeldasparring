using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZeldaSparring
{


    public class ArenaLoader : MonoBehaviour
    {

        [SerializeField] private GameObject playerPrefab;

        private void LoadPlayer()
        {
            Instantiate(playerPrefab);
        }

    }

}