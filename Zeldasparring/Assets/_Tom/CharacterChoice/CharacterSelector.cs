using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ZeldaSparring
{
    public enum CharacterType
    {
        Head,
        Body
    }

    public class CharacterSelector : MonoBehaviour
    {

        [SerializeField] private Sprite[] sprites;
        [SerializeField] private Image display;
        [SerializeField] private CharacterType type;

        private int selectedIndex;

        private void Start()
        {
            selectedIndex = PlayerPrefs.GetInt(GetKey());
            display.sprite = sprites[Mathf.Clamp(selectedIndex, 0, sprites.Length - 1)];
        }

        private string GetKey()
        {
            return type == CharacterType.Head ? ConnectionConstants.SelectedFaceKey : ConnectionConstants.SelectedBodyKey;
        }

        public void NextFace()
        {
            selectedIndex = ++selectedIndex % sprites.Length;
            display.sprite = sprites[selectedIndex];
        }

        public void SaveSelection()
        {
            PlayerPrefs.SetInt(GetKey(), selectedIndex);
        }

    }

}