// GENERATED AUTOMATICALLY FROM 'Assets/Exo/Game.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Game : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Game()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Game"",
    ""maps"": [
        {
            ""name"": ""Play"",
            ""id"": ""137c3f45-500f-43f7-908a-c099b94cfcc8"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""ce6c43f9-f08e-4611-9c6d-791f2e96a3f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""e148d40e-e6bc-4598-a67d-388738e6fa5d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Gravity"",
                    ""type"": ""Button"",
                    ""id"": ""7c3e301d-e6e4-4a83-88b8-a257ab0f4f40"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4d61e000-964b-4b10-b433-e286347ab970"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gravity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e104c038-be44-44e5-bd60-0bf9def0dd5a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gravity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80bd7526-e917-4098-a3b0-a50a1e81f668"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gravity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8060248-1e57-47ac-9b66-cc1a737fa02b"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gravity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""595b7110-76c1-4c60-a967-3ebb691edd32"",
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
                    ""id"": ""a975e84c-a56b-4624-aa53-82aadf93b886"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a942141-6a93-49c0-907f-c2728bb20f32"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5bdc6400-c013-4377-9677-c1dc251ac7ef"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d47e8644-ca79-48c2-b1bf-9935ba96e272"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Play
        m_Play = asset.FindActionMap("Play", throwIfNotFound: true);
        m_Play_Move = m_Play.FindAction("Move", throwIfNotFound: true);
        m_Play_Jump = m_Play.FindAction("Jump", throwIfNotFound: true);
        m_Play_Gravity = m_Play.FindAction("Gravity", throwIfNotFound: true);
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

    // Play
    private readonly InputActionMap m_Play;
    private IPlayActions m_PlayActionsCallbackInterface;
    private readonly InputAction m_Play_Move;
    private readonly InputAction m_Play_Jump;
    private readonly InputAction m_Play_Gravity;
    public struct PlayActions
    {
        private @Game m_Wrapper;
        public PlayActions(@Game wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Play_Move;
        public InputAction @Jump => m_Wrapper.m_Play_Jump;
        public InputAction @Gravity => m_Wrapper.m_Play_Gravity;
        public InputActionMap Get() { return m_Wrapper.m_Play; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayActions set) { return set.Get(); }
        public void SetCallbacks(IPlayActions instance)
        {
            if (m_Wrapper.m_PlayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnJump;
                @Gravity.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnGravity;
                @Gravity.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnGravity;
                @Gravity.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnGravity;
            }
            m_Wrapper.m_PlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Gravity.started += instance.OnGravity;
                @Gravity.performed += instance.OnGravity;
                @Gravity.canceled += instance.OnGravity;
            }
        }
    }
    public PlayActions @Play => new PlayActions(this);
    public interface IPlayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnGravity(InputAction.CallbackContext context);
    }
}
