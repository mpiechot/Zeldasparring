using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.TheGameProgrammers.Sparring.PunSetup
{

    public class PlayerSetup : MonoBehaviourPunCallbacks, IPunObservable
    {

        private SpriteRenderer spriteRenderer;
        private float randomOffset;

        private float srColorHue;

        public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
        {
            if (stream.IsWriting)
            {
                stream.SendNext(srColorHue);
            }
            else
            {
                srColorHue = (float)stream.ReceiveNext();
            }
        }

        private void Start()
        {
            spriteRenderer = GetComponentInChildren<SpriteRenderer>();
            randomOffset = Random.Range(0.0f, 10.0f);
        }

        private void Update()
        {
            if (photonView.IsMine || !PhotonNetwork.IsConnected)
            {
                srColorHue = (-Mathf.Cos(Time.time + randomOffset / 10.0f) + 1) / 2;

                transform.Translate(new Vector2(Mathf.PerlinNoise(Time.time, randomOffset) - 0.5f, Mathf.PerlinNoise(randomOffset, Time.time) - 0.5f) * Time.deltaTime * 2.0f, Space.World);
                if (transform.position.magnitude > 5)
                {
                    transform.position = transform.position.normalized * 5;
                }
            }
            spriteRenderer.color = Color.HSVToRGB(srColorHue, 1, 1);
        }

    }
}
