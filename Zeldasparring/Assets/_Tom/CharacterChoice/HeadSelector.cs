using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ZeldaSparring
{


    public class HeadSelector : MonoBehaviour
    {

        [SerializeField] private Sprite[] headSprites;
        [SerializeField] private Image headDisplay;

        private int selectedIndex;

        private void Start()
        {
            selectedIndex = PlayerPrefs.GetInt(ConnectionConstants.SelectedFaceKey);
            headDisplay.sprite = headSprites[Mathf.Clamp(selectedIndex, 0, headSprites.Length - 1)];
        }

        public void NextFace()
        {
            selectedIndex = ++selectedIndex % headSprites.Length;
            headDisplay.sprite = headSprites[selectedIndex];
        }

        public void SaveSelection()
        {
            PlayerPrefs.SetInt(ConnectionConstants.SelectedFaceKey, selectedIndex);
        }

    }

}