using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.IntegerTime;
using UnityEngine.InputForUI;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000181")]
internal class DefaultEventSystem
{
	[Token(Token = "0x2000182")]
	public enum UpdateMode
	{
		[Token(Token = "0x400075D")]
		Always,
		[Token(Token = "0x400075E")]
		IgnoreIfAppNotFocused
	}

	[Token(Token = "0x2000183")]
	internal struct FocusBasedEventSequenceContext : IDisposable
	{
		[Token(Token = "0x400075F")]
		[FieldOffset(Offset = "0x0")]
		private DefaultEventSystem es;

		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x2AF7CF0", Offset = "0x2AF6EF0", VA = "0x182AF7CF0")]
		public FocusBasedEventSequenceContext(DefaultEventSystem es)
		{
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x2AF7CA0", Offset = "0x2AF6EA0", VA = "0x182AF7CA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x2000184")]
	private class InputForUIProcessor
	{
		[Token(Token = "0x4000760")]
		[FieldOffset(Offset = "0x10")]
		private readonly DefaultEventSystem m_EventSystem;

		[Token(Token = "0x4000761")]
		[FieldOffset(Offset = "0x18")]
		private DiscreteTime m_LastPointerTimestamp;

		[Token(Token = "0x4000762")]
		[FieldOffset(Offset = "0x20")]
		private DiscreteTime m_NextPointerTimestamp;

		[Token(Token = "0x4000763")]
		[FieldOffset(Offset = "0x28")]
		private readonly Queue<UnityEngine.InputForUI.Event> m_EventList;

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x2AFA170", Offset = "0x2AF9370", VA = "0x182AFA170")]
		public InputForUIProcessor(DefaultEventSystem eventSystem)
		{
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x2AF7EB0", Offset = "0x2AF70B0", VA = "0x182AF7EB0")]
		public bool OnEvent(in UnityEngine.InputForUI.Event ev)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x2AF8140", Offset = "0x2AF7340", VA = "0x182AF8140")]
		public void ProcessInputForUIEvents()
		{
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x2AF7E00", Offset = "0x2AF7000", VA = "0x182AF7E00")]
		private EventModifiers GetModifiers(UnityEngine.InputForUI.EventModifiers eventModifiers)
		{
			return default(EventModifiers);
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x2AF9100", Offset = "0x2AF8300", VA = "0x182AF9100")]
		private void ProcessPointerEvent(UnityEngine.InputForUI.PointerEvent pointerEvent)
		{
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x2AF8A70", Offset = "0x2AF7C70", VA = "0x182AF8A70")]
		private void ProcessNavigationEvent(UnityEngine.InputForUI.NavigationEvent navigationEvent)
		{
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x2AF8760", Offset = "0x2AF7960", VA = "0x182AF8760")]
		private void ProcessKeyEvent(UnityEngine.InputForUI.KeyEvent keyEvent)
		{
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x2AF9F90", Offset = "0x2AF9190", VA = "0x182AF9F90")]
		private void ProcessTextInputEvent(UnityEngine.InputForUI.TextInputEvent textInputEvent)
		{
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x2AF7F60", Offset = "0x2AF7160", VA = "0x182AF7F60")]
		private void ProcessCommandEvent(UnityEngine.InputForUI.CommandEvent commandEvent)
		{
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x2AF7FF0", Offset = "0x2AF71F0", VA = "0x182AF7FF0")]
		private void ProcessIMECompositionEvent(UnityEngine.InputForUI.IMECompositionEvent compositionEvent)
		{
		}
	}

	[Token(Token = "0x2000187")]
	internal class LegacyInputProcessor
	{
		[Token(Token = "0x2000188")]
		internal interface IInput
		{
			[Token(Token = "0x17000203")]
			int touchCount
			{
				[Token(Token = "0x6000BA3")]
				get;
			}

			[Token(Token = "0x17000204")]
			bool mousePresent
			{
				[Token(Token = "0x6000BA5")]
				get;
			}

			[Token(Token = "0x17000205")]
			Vector3 mousePosition
			{
				[Token(Token = "0x6000BA8")]
				get;
			}

			[Token(Token = "0x17000206")]
			int mouseButtonCount
			{
				[Token(Token = "0x6000BA9")]
				get;
			}

			[Token(Token = "0x17000207")]
			bool anyKey
			{
				[Token(Token = "0x6000BAA")]
				get;
			}

			[Token(Token = "0x17000208")]
			float unscaledTime
			{
				[Token(Token = "0x6000BAB")]
				get;
			}

			[Token(Token = "0x17000209")]
			float doubleClickTime
			{
				[Token(Token = "0x6000BAC")]
				get;
			}

			[Token(Token = "0x6000B9F")]
			bool GetButtonDown(string button);

			[Token(Token = "0x6000BA0")]
			float GetAxisRaw(string axis);

			[Token(Token = "0x6000BA1")]
			void ClearLastPenContactEvent();

			[Token(Token = "0x6000BA2")]
			PenData GetLastPenContactEvent();

			[Token(Token = "0x6000BA4")]
			Touch GetTouch(int index);

			[Token(Token = "0x6000BA6")]
			bool GetMouseButtonDown(int button);

			[Token(Token = "0x6000BA7")]
			bool GetMouseButtonUp(int button);
		}

		[Token(Token = "0x2000189")]
		private class Input : IInput
		{
			[Token(Token = "0x1700020A")]
			public int touchCount
			{
				[Token(Token = "0x6000BB1")]
				[Address(RVA = "0x5F0B30", Offset = "0x5EFD30", VA = "0x1805F0B30", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700020B")]
			public bool mousePresent
			{
				[Token(Token = "0x6000BB3")]
				[Address(RVA = "0x289B430", Offset = "0x289A630", VA = "0x18289B430", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700020C")]
			public Vector3 mousePosition
			{
				[Token(Token = "0x6000BB6")]
				[Address(RVA = "0x289B400", Offset = "0x289A600", VA = "0x18289B400", Slot = "13")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700020D")]
			public int mouseButtonCount
			{
				[Token(Token = "0x6000BB7")]
				[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "14")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700020E")]
			public bool anyKey
			{
				[Token(Token = "0x6000BB8")]
				[Address(RVA = "0x2AFA280", Offset = "0x2AF9480", VA = "0x182AFA280", Slot = "15")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700020F")]
			public float unscaledTime
			{
				[Token(Token = "0x6000BB9")]
				[Address(RVA = "0x2436270", Offset = "0x2435470", VA = "0x182436270", Slot = "16")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000210")]
			public float doubleClickTime
			{
				[Token(Token = "0x6000BBA")]
				[Address(RVA = "0x2AFA290", Offset = "0x2AF9490", VA = "0x182AFA290", Slot = "17")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000BAD")]
			[Address(RVA = "0x289B310", Offset = "0x289A510", VA = "0x18289B310", Slot = "4")]
			public bool GetButtonDown(string button)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BAE")]
			[Address(RVA = "0x2AFA270", Offset = "0x2AF9470", VA = "0x182AFA270", Slot = "5")]
			public float GetAxisRaw(string axis)
			{
				return default(float);
			}

			[Token(Token = "0x6000BAF")]
			[Address(RVA = "0x2AFA260", Offset = "0x2AF9460", VA = "0x182AFA260", Slot = "6")]
			public void ClearLastPenContactEvent()
			{
			}

			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0x289B330", Offset = "0x289A530", VA = "0x18289B330", Slot = "7")]
			public PenData GetLastPenContactEvent()
			{
				return default(PenData);
			}

			[Token(Token = "0x6000BB2")]
			[Address(RVA = "0x289B3A0", Offset = "0x289A5A0", VA = "0x18289B3A0", Slot = "9")]
			public Touch GetTouch(int index)
			{
				return default(Touch);
			}

			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0x289B370", Offset = "0x289A570", VA = "0x18289B370", Slot = "11")]
			public bool GetMouseButtonDown(int button)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0x289B380", Offset = "0x289A580", VA = "0x18289B380", Slot = "12")]
			public bool GetMouseButtonUp(int button)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public Input()
			{
			}
		}

		[Token(Token = "0x200018A")]
		private class NoInput : IInput
		{
			[Token(Token = "0x17000211")]
			public int touchCount
			{
				[Token(Token = "0x6000BBE")]
				[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000212")]
			public bool mousePresent
			{
				[Token(Token = "0x6000BC2")]
				[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000213")]
			public Vector3 mousePosition
			{
				[Token(Token = "0x6000BC5")]
				[Address(RVA = "0x2AFCE50", Offset = "0x2AFC050", VA = "0x182AFCE50", Slot = "13")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000214")]
			public int mouseButtonCount
			{
				[Token(Token = "0x6000BC6")]
				[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "14")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000215")]
			public bool anyKey
			{
				[Token(Token = "0x6000BC7")]
				[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "15")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000216")]
			public float unscaledTime
			{
				[Token(Token = "0x6000BC8")]
				[Address(RVA = "0x6496C0", Offset = "0x6488C0", VA = "0x1806496C0", Slot = "16")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000217")]
			public float doubleClickTime
			{
				[Token(Token = "0x6000BC9")]
				[Address(RVA = "0x2AFCE40", Offset = "0x2AFC040", VA = "0x182AFCE40", Slot = "17")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "4")]
			public bool GetButtonDown(string button)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0x6496C0", Offset = "0x6488C0", VA = "0x1806496C0", Slot = "5")]
			public float GetAxisRaw(string axis)
			{
				return default(float);
			}

			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0x2AFCE20", Offset = "0x2AFC020", VA = "0x182AFCE20", Slot = "9")]
			public Touch GetTouch(int index)
			{
				return default(Touch);
			}

			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
			public void ClearLastPenContactEvent()
			{
			}

			[Token(Token = "0x6000BC1")]
			[Address(RVA = "0x270A280", Offset = "0x2709480", VA = "0x18270A280", Slot = "7")]
			public PenData GetLastPenContactEvent()
			{
				return default(PenData);
			}

			[Token(Token = "0x6000BC3")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "11")]
			public bool GetMouseButtonDown(int button)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "12")]
			public bool GetMouseButtonUp(int button)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public NoInput()
			{
			}
		}

		[Token(Token = "0x4000772")]
		[FieldOffset(Offset = "0x10")]
		private bool m_SendingTouchEvents;

		[Token(Token = "0x4000773")]
		[FieldOffset(Offset = "0x11")]
		private bool m_SendingPenEvent;

		[Token(Token = "0x4000774")]
		[FieldOffset(Offset = "0x14")]
		private EventModifiers m_CurrentModifiers;

		[Token(Token = "0x4000775")]
		[FieldOffset(Offset = "0x18")]
		private int m_LastMousePressButton;

		[Token(Token = "0x4000776")]
		[FieldOffset(Offset = "0x1C")]
		private float m_NextMousePressTime;

		[Token(Token = "0x4000777")]
		[FieldOffset(Offset = "0x20")]
		private int m_LastMouseClickCount;

		[Token(Token = "0x4000778")]
		[FieldOffset(Offset = "0x24")]
		private Vector2 m_LastMousePosition;

		[Token(Token = "0x4000779")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_MouseProcessedAtLeastOnce;

		[Token(Token = "0x400077A")]
		[FieldOffset(Offset = "0x30")]
		private IInput m_Input;

		[Token(Token = "0x400077B")]
		[FieldOffset(Offset = "0x38")]
		private readonly Event m_Event;

		[Token(Token = "0x400077C")]
		[FieldOffset(Offset = "0x40")]
		private readonly DefaultEventSystem m_EventSystem;

		[Token(Token = "0x400077D")]
		[FieldOffset(Offset = "0x48")]
		private int m_ConsecutiveMoveCount;

		[Token(Token = "0x400077E")]
		[FieldOffset(Offset = "0x4C")]
		private Vector2 m_LastMoveVector;

		[Token(Token = "0x400077F")]
		[FieldOffset(Offset = "0x54")]
		private float m_PrevActionTime;

		[Token(Token = "0x4000780")]
		[FieldOffset(Offset = "0x58")]
		private bool m_IsMoveFromKeyboard;

		[Token(Token = "0x17000201")]
		private EventModifiers m_CurrentPointerModifiers
		{
			[Token(Token = "0x6000B92")]
			[Address(RVA = "0x2AFCE10", Offset = "0x2AFC010", VA = "0x182AFCE10")]
			get
			{
				return default(EventModifiers);
			}
		}

		[Token(Token = "0x17000202")]
		public IInput input
		{
			[Token(Token = "0x6000B93")]
			[Address(RVA = "0x2AFCDD0", Offset = "0x2AFBFD0", VA = "0x182AFCDD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x2AFCD00", Offset = "0x2AFBF00", VA = "0x182AFCD00")]
		public LegacyInputProcessor(DefaultEventSystem eventSystem)
		{
		}

		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x2AFA2B0", Offset = "0x2AF94B0", VA = "0x182AFA2B0")]
		public IInput GetDefaultInput()
		{
			return null;
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x2AFA5A0", Offset = "0x2AF97A0", VA = "0x182AFA5A0")]
		public void ProcessLegacyInputEvents()
		{
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x2AFBDF0", Offset = "0x2AFAFF0", VA = "0x182AFBDF0")]
		private void SendIMGUIEvents()
		{
		}

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x2AFA710", Offset = "0x2AF9910", VA = "0x182AFA710")]
		private void ProcessMouseEvents()
		{
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x2AFC690", Offset = "0x2AFB890", VA = "0x182AFC690")]
		private void SendInputEvents()
		{
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x2AFB7C0", Offset = "0x2AFA9C0", VA = "0x182AFB7C0")]
		private bool ProcessTouchEvents()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x2AFB220", Offset = "0x2AFA420", VA = "0x182AFB220")]
		private bool ProcessPenEvents()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x2AFA3A0", Offset = "0x2AF95A0", VA = "0x182AFA3A0")]
		private Vector2 GetRawMoveVector()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x2AFCA20", Offset = "0x2AFBC20", VA = "0x182AFCA20")]
		private bool ShouldSendMoveFromInput()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x2AFB5E0", Offset = "0x2AFA7E0", VA = "0x182AFB5E0")]
		private void ProcessTabEvent(Event e, EventModifiers modifiers)
		{
		}
	}

	[Token(Token = "0x400074F")]
	[FieldOffset(Offset = "0x0")]
	internal static Func<bool> IsEditorRemoteConnected;

	[Token(Token = "0x4000750")]
	[FieldOffset(Offset = "0x10")]
	private BaseRuntimePanel m_FocusedPanel;

	[Token(Token = "0x4000751")]
	[FieldOffset(Offset = "0x18")]
	private BaseRuntimePanel m_PreviousFocusedPanel;

	[Token(Token = "0x4000752")]
	[FieldOffset(Offset = "0x20")]
	private Focusable m_PreviousFocusedElement;

	[Token(Token = "0x4000753")]
	[FieldOffset(Offset = "0x28")]
	private LegacyInputProcessor m_LegacyInputProcessor;

	[Token(Token = "0x4000754")]
	[FieldOffset(Offset = "0x30")]
	private InputForUIProcessor m_InputForUIProcessor;

	[Token(Token = "0x4000755")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsInputReady;

	[Token(Token = "0x4000756")]
	[FieldOffset(Offset = "0x39")]
	private bool m_UseInputForUI;

	[Token(Token = "0x4000757")]
	[FieldOffset(Offset = "0x3A")]
	private bool m_IsInputForUIActive;

	[Token(Token = "0x4000758")]
	[FieldOffset(Offset = "0x3B")]
	internal bool verbose;

	[Token(Token = "0x4000759")]
	[FieldOffset(Offset = "0x3C")]
	internal bool logToGameScreen;

	[Token(Token = "0x400075A")]
	[FieldOffset(Offset = "0x40")]
	private Label m_LogLabel;

	[Token(Token = "0x400075B")]
	[FieldOffset(Offset = "0x48")]
	private List<string> m_LogLines;

	[Token(Token = "0x170001FC")]
	private bool isAppFocused
	{
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x2AF6170", Offset = "0x2AF5370", VA = "0x182AF6170")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001FD")]
	public BaseRuntimePanel focusedPanel
	{
		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x2AF5B40", Offset = "0x2AF4D40", VA = "0x182AF5B40")]
		set
		{
		}
	}

	[Token(Token = "0x170001FE")]
	internal LegacyInputProcessor legacyInputProcessor
	{
		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x2AF61B0", Offset = "0x2AF53B0", VA = "0x182AF61B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001FF")]
	private InputForUIProcessor inputForUIProcessor
	{
		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x2AF6040", Offset = "0x2AF5240", VA = "0x182AF6040")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000200")]
	internal bool isInputReady
	{
		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x2AF62D0", Offset = "0x2AF54D0", VA = "0x182AF62D0")]
		set
		{
		}
	}

	[Token(Token = "0x6000B61")]
	[Address(RVA = "0x2AF5C60", Offset = "0x2AF4E60", VA = "0x182AF5C60")]
	private bool ShouldIgnoreEventsOnAppNotFocused()
	{
		return default(bool);
	}

	[Token(Token = "0x6000B64")]
	[Address(RVA = "0x2AF5D30", Offset = "0x2AF4F30", VA = "0x182AF5D30")]
	public void Update(UpdateMode updateMode = UpdateMode.Always)
	{
	}

	[Token(Token = "0x6000B68")]
	[Address(RVA = "0x2AF5250", Offset = "0x2AF4450", VA = "0x182AF5250")]
	internal FocusBasedEventSequenceContext FocusBasedEventSequence()
	{
		return default(FocusBasedEventSequenceContext);
	}

	[Token(Token = "0x6000B69")]
	[Address(RVA = "0x2AF5BA0", Offset = "0x2AF4DA0", VA = "0x182AF5BA0")]
	private void RemoveInputProcessor()
	{
	}

	[Token(Token = "0x6000B6A")]
	[Address(RVA = "0x2AF52E0", Offset = "0x2AF44E0", VA = "0x182AF52E0")]
	private void InitInputProcessor()
	{
	}

	[Token(Token = "0x6000B6B")]
	[Address(RVA = "0x2AF5B40", Offset = "0x2AF4D40", VA = "0x182AF5B40")]
	internal void OnFocusEvent(RuntimePanel panel, FocusEvent evt)
	{
	}

	[Token(Token = "0x6000B6C")]
	internal void SendFocusBasedEvent<TArg>(Func<TArg, EventBase> evtFactory, TArg arg)
	{
	}

	[Token(Token = "0x6000B6D")]
	private void SendPositionBasedEvent<TArg>(Vector3 mousePosition, Vector3 delta, int pointerId, int? targetDisplay, Func<Vector3, Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false)
	{
	}

	[Token(Token = "0x6000B6E")]
	[Address(RVA = "0x2AF5C80", Offset = "0x2AF4E80", VA = "0x182AF5C80")]
	private void UpdateFocusedPanel(BaseRuntimePanel runtimePanel)
	{
	}

	[Token(Token = "0x6000B6F")]
	[Address(RVA = "0x2AF5A50", Offset = "0x2AF4C50", VA = "0x182AF5A50")]
	private static EventBase MakeTouchEvent(Touch touch, EventModifiers modifiers, int targetDisplay)
	{
		return null;
	}

	[Token(Token = "0x6000B70")]
	[Address(RVA = "0x2AF5970", Offset = "0x2AF4B70", VA = "0x182AF5970")]
	private static EventBase MakePenEvent(PenData pen, EventModifiers modifiers, int targetDisplay)
	{
		return null;
	}

	[Token(Token = "0x6000B71")]
	[Address(RVA = "0x2AF58D0", Offset = "0x2AF4AD0", VA = "0x182AF58D0")]
	private void Log(object o)
	{
	}

	[Token(Token = "0x6000B72")]
	[Address(RVA = "0x2AF5810", Offset = "0x2AF4A10", VA = "0x182AF5810")]
	private void LogWarning(object o)
	{
	}

	[Token(Token = "0x6000B73")]
	[Address(RVA = "0x2AF5410", Offset = "0x2AF4610", VA = "0x182AF5410")]
	private void LogToGameScreen(string s)
	{
	}

	[Token(Token = "0x6000B74")]
	[Address(RVA = "0x2AF5FB0", Offset = "0x2AF51B0", VA = "0x182AF5FB0")]
	public DefaultEventSystem()
	{
	}
}
