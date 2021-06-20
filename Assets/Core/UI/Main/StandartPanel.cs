﻿using UnityEngine;

namespace Core.UI.Main
{
    public class StandartPanel : IPanel
    {
        [SerializeField]
        private GameObject _panel;

        public override void Show()
        {
            _panel.SetActive(true);
        }

        public override void Hide()
        {
            _panel.SetActive(false);
        }
    }
}
