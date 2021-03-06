﻿using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UnityMVVM.View
{
    [RequireComponent(typeof(Toggle))]
    public class ToggleControl : MonoBehaviour
    {
        Toggle _toggle;

        public bool IsOn
        {
            get => _toggle.isOn;
            set => _toggle.isOn = value;
        }

        public Toggle.ToggleEvent OnValueChanged { get; set; } = new Toggle.ToggleEvent();

        private void Awake()
        {
            _toggle = GetComponent<Toggle>();
            _toggle.onValueChanged.AddListener(newVal => OnValueChanged?.Invoke(newVal));
        }
    }
}