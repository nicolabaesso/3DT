//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Player inputs.inputactions
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

public partial class @Playerinputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Playerinputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player inputs"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""d8a696ae-2484-46ef-bd52-5bf85699fdb3"",
            ""actions"": [
                {
                    ""name"": ""Movements"",
                    ""type"": ""Value"",
                    ""id"": ""56150ebd-254d-4ab9-a021-472fa33ccc56"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""966d21b4-7fa8-4c99-b5b2-72be750bed72"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""f31a28ce-f7f7-42e1-8dfe-32ae47e0ce61"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a469b855-0249-4aab-82ee-788860ad22b8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""57ac1cdf-546e-4c80-9b9b-975faba5f602"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a574882d-c8ed-489d-a3c1-0ed00ff9e14e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bf264156-3bdb-45ea-951e-c1770556b507"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ControllerMovements"",
                    ""id"": ""23fa5f19-73ba-4894-9347-f193b1b7e8b3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""53f8ecba-effa-4074-a861-f7d8b791e29e"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""13e0b240-349d-4f9a-bf4b-da2f0109048f"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""36cf2320-a330-4bbf-94c0-906a0e89dc92"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""23a64d67-0d6f-4937-a6d3-2b5fda5a9177"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e9507672-f330-44a1-89b6-254f74981831"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38e7fb30-d008-4801-9571-3a459779b7f0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""a2bb81e9-88b2-4499-97c1-a205818d81b0"",
            ""actions"": [
                {
                    ""name"": ""MoveCamera"",
                    ""type"": ""Value"",
                    ""id"": ""84bbcde9-048e-4a37-9c6b-1199c9f5625c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""161c8473-1947-4d76-9c96-70f3c7dd9abb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9cbcdd38-6985-4750-954e-67a1a63a51b2"",
                    ""path"": ""<Mouse>/delta/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2e5d74f0-17dd-4d0c-b0cf-c7c58149d8b5"",
                    ""path"": ""<Mouse>/delta/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""98315b9a-ff52-469a-a9aa-f003df672f6a"",
                    ""path"": ""<Mouse>/delta/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""679b045c-c145-48e5-b97e-4a15b283eee1"",
                    ""path"": ""<Mouse>/delta/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movements = m_Player.FindAction("Movements", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_MoveCamera = m_Camera.FindAction("MoveCamera", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Movements;
    private readonly InputAction m_Player_Jump;
    public struct PlayerActions
    {
        private @Playerinputs m_Wrapper;
        public PlayerActions(@Playerinputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movements => m_Wrapper.m_Player_Movements;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Movements.started += instance.OnMovements;
            @Movements.performed += instance.OnMovements;
            @Movements.canceled += instance.OnMovements;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Movements.started -= instance.OnMovements;
            @Movements.performed -= instance.OnMovements;
            @Movements.canceled -= instance.OnMovements;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private List<ICameraActions> m_CameraActionsCallbackInterfaces = new List<ICameraActions>();
    private readonly InputAction m_Camera_MoveCamera;
    public struct CameraActions
    {
        private @Playerinputs m_Wrapper;
        public CameraActions(@Playerinputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveCamera => m_Wrapper.m_Camera_MoveCamera;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void AddCallbacks(ICameraActions instance)
        {
            if (instance == null || m_Wrapper.m_CameraActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CameraActionsCallbackInterfaces.Add(instance);
            @MoveCamera.started += instance.OnMoveCamera;
            @MoveCamera.performed += instance.OnMoveCamera;
            @MoveCamera.canceled += instance.OnMoveCamera;
        }

        private void UnregisterCallbacks(ICameraActions instance)
        {
            @MoveCamera.started -= instance.OnMoveCamera;
            @MoveCamera.performed -= instance.OnMoveCamera;
            @MoveCamera.canceled -= instance.OnMoveCamera;
        }

        public void RemoveCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICameraActions instance)
        {
            foreach (var item in m_Wrapper.m_CameraActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CameraActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    public interface IPlayerActions
    {
        void OnMovements(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnMoveCamera(InputAction.CallbackContext context);
    }
}
