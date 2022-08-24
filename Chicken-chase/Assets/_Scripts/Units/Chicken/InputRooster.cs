//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Chicken/InputRooster.inputactions
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

public partial class @InputRooster : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputRooster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputRooster"",
    ""maps"": [
        {
            ""name"": ""Chicken"",
            ""id"": ""f9003980-4b99-4fe6-b9c9-4a30c3e64008"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""cb0038cc-6263-45bb-bd86-f398abf265ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Duck"",
                    ""type"": ""Button"",
                    ""id"": ""34abbd4d-4bb4-4a13-adbe-64b6e3ea307d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a0a393db-28e6-49ed-b6c2-b42728a9020a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9cc34f93-0028-40f3-b5ac-9eeeb8dcb99b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c60596e-f1f6-4ab1-b8bb-06eb2d8bcc90"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Duck"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": []
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": []
        }
    ]
}");
        // Chicken
        m_Chicken = asset.FindActionMap("Chicken", throwIfNotFound: true);
        m_Chicken_Jump = m_Chicken.FindAction("Jump", throwIfNotFound: true);
        m_Chicken_Duck = m_Chicken.FindAction("Duck", throwIfNotFound: true);
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

    // Chicken
    private readonly InputActionMap m_Chicken;
    private IChickenActions m_ChickenActionsCallbackInterface;
    private readonly InputAction m_Chicken_Jump;
    private readonly InputAction m_Chicken_Duck;
    public struct ChickenActions
    {
        private @InputRooster m_Wrapper;
        public ChickenActions(@InputRooster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Chicken_Jump;
        public InputAction @Duck => m_Wrapper.m_Chicken_Duck;
        public InputActionMap Get() { return m_Wrapper.m_Chicken; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ChickenActions set) { return set.Get(); }
        public void SetCallbacks(IChickenActions instance)
        {
            if (m_Wrapper.m_ChickenActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_ChickenActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ChickenActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ChickenActionsCallbackInterface.OnJump;
                @Duck.started -= m_Wrapper.m_ChickenActionsCallbackInterface.OnDuck;
                @Duck.performed -= m_Wrapper.m_ChickenActionsCallbackInterface.OnDuck;
                @Duck.canceled -= m_Wrapper.m_ChickenActionsCallbackInterface.OnDuck;
            }
            m_Wrapper.m_ChickenActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Duck.started += instance.OnDuck;
                @Duck.performed += instance.OnDuck;
                @Duck.canceled += instance.OnDuck;
            }
        }
    }
    public ChickenActions @Chicken => new ChickenActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IChickenActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnDuck(InputAction.CallbackContext context);
    }
}