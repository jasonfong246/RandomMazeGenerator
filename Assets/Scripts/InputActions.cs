//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/InputActions/InputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace ShareefSoftware.Input
{
    public partial class @InputActions: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Rotation"",
            ""id"": ""dd4eae4b-38e1-440b-ae54-a72089976e76"",
            ""actions"": [
                {
                    ""name"": ""RotateScene"",
                    ""type"": ""Button"",
                    ""id"": ""211238d1-8fdc-483a-bf91-ed3b24186c93"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c5f114bf-e382-40b5-a776-10196b03cd63"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Rotation
            m_Rotation = asset.FindActionMap("Rotation", throwIfNotFound: true);
            m_Rotation_RotateScene = m_Rotation.FindAction("RotateScene", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }

        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Rotation
        private readonly InputActionMap m_Rotation;
        private List<IRotationActions> m_RotationActionsCallbackInterfaces = new List<IRotationActions>();
        private readonly InputAction m_Rotation_RotateScene;
        public struct RotationActions
        {
            private @InputActions m_Wrapper;
            public RotationActions(@InputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @RotateScene => m_Wrapper.m_Rotation_RotateScene;
            public InputActionMap Get() { return m_Wrapper.m_Rotation; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(RotationActions set) { return set.Get(); }
            public void AddCallbacks(IRotationActions instance)
            {
                if (instance == null || m_Wrapper.m_RotationActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_RotationActionsCallbackInterfaces.Add(instance);
                @RotateScene.started += instance.OnRotateScene;
                @RotateScene.performed += instance.OnRotateScene;
                @RotateScene.canceled += instance.OnRotateScene;
            }

            private void UnregisterCallbacks(IRotationActions instance)
            {
                @RotateScene.started -= instance.OnRotateScene;
                @RotateScene.performed -= instance.OnRotateScene;
                @RotateScene.canceled -= instance.OnRotateScene;
            }

            public void RemoveCallbacks(IRotationActions instance)
            {
                if (m_Wrapper.m_RotationActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IRotationActions instance)
            {
                foreach (var item in m_Wrapper.m_RotationActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_RotationActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public RotationActions @Rotation => new RotationActions(this);
        public interface IRotationActions
        {
            void OnRotateScene(InputAction.CallbackContext context);
        }
    }
}
