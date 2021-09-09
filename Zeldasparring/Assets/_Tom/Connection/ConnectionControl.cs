using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace ZeldaSparring
{


    public class ConnectionControl : MonoBehaviour
    {

        [SerializeField] private UnityEvent onConnecting;

        public void Connect()
        {
            onConnecting?.Invoke();
        }



    }

}