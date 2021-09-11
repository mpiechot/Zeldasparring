using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ZeldaSparring
{
    public class CharacterMovement : MonoBehaviourPunCallbacks
    {
        [SerializeField] private float moveSpeed = 3f;
        private PlayerControls controls;
        private Vector2 moveVector = Vector2.zero;
        private Rigidbody2D rb;

        // Start is called before the first frame update
        void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
            if (!photonView.IsMine)
            {
                rb.isKinematic = true;
                rb.useFullKinematicContacts = true;
            }

            controls = new PlayerControls();
            controls.Player.Movement.performed += context => moveVector = context.ReadValue<Vector2>();
            controls.Player.Movement.canceled += _ => moveVector = Vector2.zero;
        }

        private void Update()
        {
            
            if (photonView.IsMine || !PhotonNetwork.IsConnected)
            {
                rb.velocity = moveVector * moveSpeed;
            }

            //transform.Translate(moveVector*Time.deltaTime*moveSpeed);
        }

        private void OnEnable()
        {
            controls.Enable();
        }

        private void OnDisable()
        {
            controls.Disable();
        }
    }
}
