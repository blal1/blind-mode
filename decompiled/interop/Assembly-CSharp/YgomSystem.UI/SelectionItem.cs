using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI;

[Token(Token = "0x2000483")]
public class SelectionItem : MonoBehaviour
{
	[Token(Token = "0x2000484")]
	public enum DragStatus
	{
		[Token(Token = "0x400164C")]
		Begin,
		[Token(Token = "0x400164D")]
		Dragging,
		[Token(Token = "0x400164E")]
		End
	}

	[Token(Token = "0x2000485")]
	public enum HoldStatus
	{
		[Token(Token = "0x4001650")]
		Begin,
		[Token(Token = "0x4001651")]
		Holding,
		[Token(Token = "0x4001652")]
		End
	}

	[Token(Token = "0x2000486")]
	public class DragEvent : UnityEvent<DragStatus, Vector2>
	{
		[Token(Token = "0x6001E01")]
		[Address(RVA = "0x5FDF70", Offset = "0x5FD170", VA = "0x1805FDF70")]
		public DragEvent()
		{
		}
	}

	[Token(Token = "0x2000487")]
	public class HoldEvent : UnityEvent<HoldStatus, Vector2>
	{
		[Token(Token = "0x6001E02")]
		[Address(RVA = "0x5FF290", Offset = "0x5FE490", VA = "0x1805FF290")]
		public HoldEvent()
		{
		}
	}

	[Token(Token = "0x2000488")]
	public class AnalogEvent
	{
		[Token(Token = "0x4001653")]
		[FieldOffset(Offset = "0x10")]
		private List<Func<Vector2, bool>> callbackList;

		[Token(Token = "0x6001E03")]
		[Address(RVA = "0x5FA7C0", Offset = "0x5F99C0", VA = "0x1805FA7C0")]
		public void Add(Func<Vector2, bool> func)
		{
		}

		[Token(Token = "0x6001E04")]
		[Address(RVA = "0x5FAA30", Offset = "0x5F9C30", VA = "0x1805FAA30")]
		public void Remove(Func<Vector2, bool> func)
		{
		}

		[Token(Token = "0x6001E05")]
		[Address(RVA = "0x5FA870", Offset = "0x5F9A70", VA = "0x1805FA870")]
		public void Clear()
		{
		}

		[Token(Token = "0x6001E06")]
		[Address(RVA = "0x5FA8D0", Offset = "0x5F9AD0", VA = "0x1805FA8D0")]
		public bool Invoke(Vector2 analogInput)
		{
			return default(bool);
		}

		[Token(Token = "0x6001E07")]
		[Address(RVA = "0x5FAA90", Offset = "0x5F9C90", VA = "0x1805FAA90")]
		public AnalogEvent()
		{
		}
	}

	[Token(Token = "0x2000489")]
	public delegate void InputCallback();

	[Token(Token = "0x200048A")]
	public enum TransitionMode
	{
		[Token(Token = "0x4001655")]
		Automatic,
		[Token(Token = "0x4001656")]
		Manual,
		[Token(Token = "0x4001657")]
		None,
		[Token(Token = "0x4001658")]
		SelectorParent,
		[Token(Token = "0x4001659")]
		SelectorChild,
		[Token(Token = "0x400165A")]
		SelectorManual
	}

	[Token(Token = "0x200048B")]
	public enum RegistStatus
	{
		[Token(Token = "0x400165C")]
		None,
		[Token(Token = "0x400165D")]
		Previsional,
		[Token(Token = "0x400165E")]
		Registed
	}

	[Token(Token = "0x200048C")]
	public enum UpdateItemStatus
	{
		[Token(Token = "0x4001660")]
		Unknown = 0,
		[Token(Token = "0x4001661")]
		None = 1,
		[Token(Token = "0x4001662")]
		Inactive = 2,
		[Token(Token = "0x4001663")]
		InvokeShortcutCallback = 4,
		[Token(Token = "0x4001664")]
		InvokeSelectedCallback = 8,
		[Token(Token = "0x4001665")]
		InvokeClickCallback = 16,
		[Token(Token = "0x4001666")]
		Invalid = 3,
		[Token(Token = "0x4001667")]
		InvokeNotClickCallback = 12,
		[Token(Token = "0x4001668")]
		InvokeAnyCallback = 28
	}

	[Token(Token = "0x400161C")]
	[FieldOffset(Offset = "0x20")]
	private Selector _selector;

	[Token(Token = "0x400161D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Tooltip("初期化時選択設定")]
	private bool defaultItem;

	[Token(Token = "0x400161E")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Tooltip("このアイテムから遷移するときの内積閾値.\nこのアイテムからの移動を評価するとき、方向キーと遷移先アイテムとの相対座標との角度の内積が閾値以上の時のみ有効となる。\nすなわち、小さければ移動しやすく、大きければ移動しにくい")]
	[Range(0f, 1f)]
	private float _selectionAngle;

	[Token(Token = "0x400161F")]
	[FieldOffset(Offset = "0x30")]
	protected UnityEvent onSelectedCallback;

	[Token(Token = "0x4001620")]
	[FieldOffset(Offset = "0x38")]
	protected UnityEvent onDeselectedCallback;

	[Token(Token = "0x4001621")]
	[FieldOffset(Offset = "0x40")]
	protected Dictionary<(SelectorManager.AnalogType, SelectorManager.KeyType), AnalogEvent> onSelectedAnalogInputCallback;

	[Token(Token = "0x4001622")]
	[FieldOffset(Offset = "0x48")]
	protected Dictionary<(SelectorManager.AnalogType, SelectorManager.KeyType), AnalogEvent> onShortCutAnalogInputCallback;

	[Token(Token = "0x4001623")]
	[FieldOffset(Offset = "0x50")]
	protected UnityEvent onPointerEnterCallback;

	[Token(Token = "0x4001624")]
	[FieldOffset(Offset = "0x58")]
	protected UnityEvent onPointerExitCallback;

	[Token(Token = "0x4001625")]
	[FieldOffset(Offset = "0x60")]
	protected UnityEvent onPointerDownCallback;

	[Token(Token = "0x4001626")]
	[FieldOffset(Offset = "0x68")]
	protected UnityEvent onPointerClickCallback;

	[Token(Token = "0x4001627")]
	[FieldOffset(Offset = "0x70")]
	protected UnityEvent onPointerDounbleClickCallback;

	[Token(Token = "0x4001628")]
	[FieldOffset(Offset = "0x78")]
	protected UnityEvent onPointerUpCallback;

	[Token(Token = "0x4001629")]
	[FieldOffset(Offset = "0x80")]
	protected Func<Vector2, Vector2, bool> dragStarter;

	[Token(Token = "0x400162A")]
	[FieldOffset(Offset = "0x88")]
	protected DragEvent onDragCallback;

	[Token(Token = "0x400162B")]
	[FieldOffset(Offset = "0x90")]
	protected Func<float, bool> holdStarter;

	[Token(Token = "0x400162C")]
	[FieldOffset(Offset = "0x98")]
	protected HoldEvent onHoldCallback;

	[Token(Token = "0x4001636")]
	[FieldOffset(Offset = "0xE1")]
	[SerializeField]
	protected bool _selectable;

	[Token(Token = "0x4001637")]
	[FieldOffset(Offset = "0xE2")]
	[SerializeField]
	[Tooltip("このアイテムが使用できるか")]
	protected bool _interactable;

	[Token(Token = "0x4001638")]
	[FieldOffset(Offset = "0xE3")]
	protected bool pointerDown;

	[Token(Token = "0x4001639")]
	[FieldOffset(Offset = "0xE4")]
	protected bool pointerEntering;

	[Token(Token = "0x400163A")]
	[FieldOffset(Offset = "0xE5")]
	[SerializeField]
	protected bool _useDoubleClick;

	[Token(Token = "0x400163B")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	protected TransitionMode upMode;

	[Token(Token = "0x400163C")]
	[FieldOffset(Offset = "0xEC")]
	[SerializeField]
	protected TransitionMode downMode;

	[Token(Token = "0x400163D")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	protected TransitionMode rightMode;

	[Token(Token = "0x400163E")]
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	protected TransitionMode leftMode;

	[Token(Token = "0x400163F")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	protected SelectionItem upItem;

	[Token(Token = "0x4001640")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	protected SelectionItem downItem;

	[Token(Token = "0x4001641")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	protected SelectionItem rightItem;

	[Token(Token = "0x4001642")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	protected SelectionItem leftItem;

	[Token(Token = "0x4001643")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	protected Selector upSelector;

	[Token(Token = "0x4001644")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	protected Selector downSelector;

	[Token(Token = "0x4001645")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	protected Selector rightSelector;

	[Token(Token = "0x4001646")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	protected Selector leftSelector;

	[Token(Token = "0x4001647")]
	[FieldOffset(Offset = "0x138")]
	private RegistStatus registStatus;

	[Token(Token = "0x4001648")]
	[FieldOffset(Offset = "0x13C")]
	protected float _priority;

	[Token(Token = "0x4001649")]
	[FieldOffset(Offset = "0x140")]
	private CanvasRenderer canvasRenderer;

	[Token(Token = "0x400164A")]
	[FieldOffset(Offset = "0x148")]
	protected List<uint> callbackIDList;

	[Token(Token = "0x170002E0")]
	public Selector selector
	{
		[Token(Token = "0x6001D60")]
		[Address(RVA = "0x60EDB0", Offset = "0x60DFB0", VA = "0x18060EDB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E1")]
	public bool isDefaultItem
	{
		[Token(Token = "0x6001D61")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002E2")]
	public float selectionAngle
	{
		[Token(Token = "0x6001D62")]
		[Address(RVA = "0x60EDA0", Offset = "0x60DFA0", VA = "0x18060EDA0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001D63")]
		[Address(RVA = "0x60F4C0", Offset = "0x60E6C0", VA = "0x18060F4C0")]
		set
		{
		}
	}

	[Token(Token = "0x170002E3")]
	public bool isSelected
	{
		[Token(Token = "0x6001D74")]
		[Address(RVA = "0x60ECE0", Offset = "0x60DEE0", VA = "0x18060ECE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001D75")]
		[Address(RVA = "0x60F490", Offset = "0x60E690", VA = "0x18060F490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170002E4")]
	public bool selectable
	{
		[Token(Token = "0x6001D76")]
		[Address(RVA = "0x60ED90", Offset = "0x60DF90", VA = "0x18060ED90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001D77")]
		[Address(RVA = "0x60F4B0", Offset = "0x60E6B0", VA = "0x18060F4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170002E5")]
	public virtual bool interactable
	{
		[Token(Token = "0x6001D78")]
		[Address(RVA = "0x608CC0", Offset = "0x607EC0", VA = "0x180608CC0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001D79")]
		[Address(RVA = "0x60F440", Offset = "0x60E640", VA = "0x18060F440", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x170002E6")]
	public bool isActivate
	{
		[Token(Token = "0x6001D7A")]
		[Address(RVA = "0x60EB60", Offset = "0x60DD60", VA = "0x18060EB60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002E7")]
	public bool isClusterActivated
	{
		[Token(Token = "0x6001D7B")]
		[Address(RVA = "0x60EC40", Offset = "0x60DE40", VA = "0x18060EC40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002E8")]
	public bool useDoubleClick
	{
		[Token(Token = "0x6001D7C")]
		[Address(RVA = "0x60EE40", Offset = "0x60E040", VA = "0x18060EE40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001D7D")]
		[Address(RVA = "0x60F4D0", Offset = "0x60E6D0", VA = "0x18060F4D0")]
		set
		{
		}
	}

	[Token(Token = "0x170002E9")]
	public bool isRegisted
	{
		[Token(Token = "0x6001D7E")]
		[Address(RVA = "0x60ECD0", Offset = "0x60DED0", VA = "0x18060ECD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002EA")]
	public float priority
	{
		[Token(Token = "0x6001D7F")]
		[Address(RVA = "0x60ECF0", Offset = "0x60DEF0", VA = "0x18060ECF0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001D80")]
		[Address(RVA = "0x60F4A0", Offset = "0x60E6A0", VA = "0x18060F4A0")]
		set
		{
		}
	}

	[Token(Token = "0x170002EB")]
	public virtual Vector2 viewCenterPosition
	{
		[Token(Token = "0x6001D8B")]
		[Address(RVA = "0x60EE50", Offset = "0x60E050", VA = "0x18060EE50", Slot = "12")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x1400001E")]
	public event InputCallback upInputCallback
	{
		[Token(Token = "0x6001D64")]
		[Address(RVA = "0x60EA00", Offset = "0x60DC00", VA = "0x18060EA00")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001D65")]
		[Address(RVA = "0x60F2E0", Offset = "0x60E4E0", VA = "0x18060F2E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400001F")]
	public event InputCallback downInputCallback
	{
		[Token(Token = "0x6001D66")]
		[Address(RVA = "0x60E5E0", Offset = "0x60D7E0", VA = "0x18060E5E0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001D67")]
		[Address(RVA = "0x60EEC0", Offset = "0x60E0C0", VA = "0x18060EEC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000020")]
	public event InputCallback rightInputCallback
	{
		[Token(Token = "0x6001D68")]
		[Address(RVA = "0x60E8A0", Offset = "0x60DAA0", VA = "0x18060E8A0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001D69")]
		[Address(RVA = "0x60F180", Offset = "0x60E380", VA = "0x18060F180")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000021")]
	public event InputCallback leftInputCallback
	{
		[Token(Token = "0x6001D6A")]
		[Address(RVA = "0x60E740", Offset = "0x60D940", VA = "0x18060E740")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001D6B")]
		[Address(RVA = "0x60F020", Offset = "0x60E220", VA = "0x18060F020")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000022")]
	public event InputCallback upTransitionFailedCallback
	{
		[Token(Token = "0x6001D6C")]
		[Address(RVA = "0x60EAB0", Offset = "0x60DCB0", VA = "0x18060EAB0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001D6D")]
		[Address(RVA = "0x60F390", Offset = "0x60E590", VA = "0x18060F390")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000023")]
	public event InputCallback downTransitionFailedCallback
	{
		[Token(Token = "0x6001D6E")]
		[Address(RVA = "0x60E690", Offset = "0x60D890", VA = "0x18060E690")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001D6F")]
		[Address(RVA = "0x60EF70", Offset = "0x60E170", VA = "0x18060EF70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000024")]
	public event InputCallback rightTransitionFailedCallback
	{
		[Token(Token = "0x6001D70")]
		[Address(RVA = "0x60E950", Offset = "0x60DB50", VA = "0x18060E950")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001D71")]
		[Address(RVA = "0x60F230", Offset = "0x60E430", VA = "0x18060F230")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000025")]
	public event InputCallback leftTransitionFailedCallback
	{
		[Token(Token = "0x6001D72")]
		[Address(RVA = "0x60E7F0", Offset = "0x60D9F0", VA = "0x18060E7F0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001D73")]
		[Address(RVA = "0x60F0D0", Offset = "0x60E2D0", VA = "0x18060F0D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6001D81")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	protected virtual void Awaked()
	{
	}

	[Token(Token = "0x6001D82")]
	[Address(RVA = "0x60A470", Offset = "0x609670", VA = "0x18060A470", Slot = "7")]
	protected virtual void Enabled()
	{
	}

	[Token(Token = "0x6001D83")]
	[Address(RVA = "0x60A3D0", Offset = "0x6095D0", VA = "0x18060A3D0", Slot = "8")]
	protected virtual void Disabled()
	{
	}

	[Token(Token = "0x6001D84")]
	[Address(RVA = "0x60A0F0", Offset = "0x6092F0", VA = "0x18060A0F0", Slot = "9")]
	protected virtual void Destroyed()
	{
	}

	[Token(Token = "0x6001D85")]
	[Address(RVA = "0x6095F0", Offset = "0x6087F0", VA = "0x1806095F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001D86")]
	[Address(RVA = "0x55A020", Offset = "0x559220", VA = "0x18055A020")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001D87")]
	[Address(RVA = "0x558260", Offset = "0x557460", VA = "0x180558260")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001D88")]
	[Address(RVA = "0x60B310", Offset = "0x60A510", VA = "0x18060B310")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001D89")]
	[Address(RVA = "0x608640", Offset = "0x607840", VA = "0x180608640", Slot = "10")]
	public virtual UpdateItemStatus UpdateItem()
	{
		return default(UpdateItemStatus);
	}

	[Token(Token = "0x6001D8A")]
	[Address(RVA = "0x60E260", Offset = "0x60D460", VA = "0x18060E260", Slot = "11")]
	public virtual UpdateItemStatus UpdateSelectedItem()
	{
		return default(UpdateItemStatus);
	}

	[Token(Token = "0x6001D8C")]
	[Address(RVA = "0x60A530", Offset = "0x609730", VA = "0x18060A530", Slot = "13")]
	public virtual Vector2 GetClosestPoint(Vector2 base_position, Vector2 direction, bool contains_check = true)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001D8D")]
	[Address(RVA = "0x60B180", Offset = "0x60A380", VA = "0x18060B180", Slot = "14")]
	public virtual bool IsRectContains(Vector2 rect_point0, Vector2 rect_point1, Vector2 rect_point2, Vector2 rect_point3, bool containedComplete)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D8E")]
	[Address(RVA = "0x60B0C0", Offset = "0x60A2C0", VA = "0x18060B0C0", Slot = "15")]
	public virtual bool IsContainsPoint(Vector2 view_position)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D8F")]
	[Address(RVA = "0x60BE30", Offset = "0x60B030", VA = "0x18060BE30")]
	public bool Select(bool initializeSelection = false, bool force = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D90")]
	[Address(RVA = "0x60BD40", Offset = "0x60AF40", VA = "0x18060BD40")]
	public bool Reselect(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D91")]
	[Address(RVA = "0x60B640", Offset = "0x60A840", VA = "0x18060B640", Slot = "16")]
	public virtual bool OnSelected(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D92")]
	[Address(RVA = "0x60B250", Offset = "0x60A450", VA = "0x18060B250", Slot = "17")]
	public virtual bool OnDeselected()
	{
		return default(bool);
	}

	[Token(Token = "0x6001D93")]
	[Address(RVA = "0x60CB20", Offset = "0x60BD20", VA = "0x18060CB20")]
	public void SetOnSelectedCallback(UnityAction on_selected_callback)
	{
	}

	[Token(Token = "0x6001D94")]
	[Address(RVA = "0x60B780", Offset = "0x60A980", VA = "0x18060B780")]
	public void RemoveAllOnSelectedCallback()
	{
	}

	[Token(Token = "0x6001D95")]
	[Address(RVA = "0x60C620", Offset = "0x60B820", VA = "0x18060C620")]
	public void SetOnDeselectedCallback(UnityAction on_deselected_callback)
	{
	}

	[Token(Token = "0x6001D96")]
	[Address(RVA = "0x60B700", Offset = "0x60A900", VA = "0x18060B700")]
	public void RemoveAllOnDeselectedCallback()
	{
	}

	[Token(Token = "0x6001D97")]
	[Address(RVA = "0x60C0D0", Offset = "0x60B2D0", VA = "0x18060C0D0")]
	protected void SetKeyCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, Func<bool> callback, SelectorManager.KeyStatus keyStatus, bool isSelected)
	{
	}

	[Token(Token = "0x6001D98")]
	[Address(RVA = "0x6098F0", Offset = "0x608AF0", VA = "0x1806098F0")]
	protected void ClearKeyCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, Func<bool> callback, SelectorManager.KeyStatus keyStatus, bool isSelected)
	{
	}

	[Token(Token = "0x6001D99")]
	[Address(RVA = "0x609730", Offset = "0x608930", VA = "0x180609730")]
	protected void ClearKeyCallbackAll(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, SelectorManager.KeyStatus keyStatus, bool isSelected)
	{
	}

	[Token(Token = "0x6001D9A")]
	[Address(RVA = "0x60CFD0", Offset = "0x60C1D0", VA = "0x18060CFD0")]
	public void SetOnSelectedKeyDownCallback(SelectorManager.KeyType key_type, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001D9B")]
	[Address(RVA = "0x60CDD0", Offset = "0x60BFD0", VA = "0x18060CDD0")]
	public void SetOnSelectedKeyDownCallback(SelectorManager.KeyType key_type, UnityAction callback, bool exclusiveFunc = false)
	{
	}

	[Token(Token = "0x6001D9C")]
	[Address(RVA = "0x60CDA0", Offset = "0x60BFA0", VA = "0x18060CDA0")]
	public void SetOnSelectedKeyDownCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001D9D")]
	[Address(RVA = "0x60CED0", Offset = "0x60C0D0", VA = "0x18060CED0")]
	public void SetOnSelectedKeyDownCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, UnityAction callback, bool exclusiveFunc = false)
	{
	}

	[Token(Token = "0x6001D9E")]
	[Address(RVA = "0x609F40", Offset = "0x609140", VA = "0x180609F40")]
	public void ClearOnSelectedKeyDownCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001D9F")]
	[Address(RVA = "0x609F10", Offset = "0x609110", VA = "0x180609F10")]
	public void ClearOnSelectedKeyDownCallbackAll(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub)
	{
	}

	[Token(Token = "0x6001DA0")]
	[Address(RVA = "0x60CC40", Offset = "0x60BE40", VA = "0x18060CC40")]
	public void SetOnSelectedKeyCallback(SelectorManager.KeyType key_type, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001DA1")]
	[Address(RVA = "0x60CCA0", Offset = "0x60BEA0", VA = "0x18060CCA0")]
	public void SetOnSelectedKeyCallback(SelectorManager.KeyType key_type, UnityAction callback, bool exclusiveFunc = false)
	{
	}

	[Token(Token = "0x6001DA2")]
	[Address(RVA = "0x60CC70", Offset = "0x60BE70", VA = "0x18060CC70")]
	public void SetOnSelectedKeyCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001DA3")]
	[Address(RVA = "0x60CB40", Offset = "0x60BD40", VA = "0x18060CB40")]
	public void SetOnSelectedKeyCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, UnityAction callback, bool exclusiveFunc = false)
	{
	}

	[Token(Token = "0x6001DA4")]
	[Address(RVA = "0x609EE0", Offset = "0x6090E0", VA = "0x180609EE0")]
	public void ClearOnSelectedKeyCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001DA5")]
	[Address(RVA = "0x609EB0", Offset = "0x6090B0", VA = "0x180609EB0")]
	public void ClearOnSelectedKeyCallbackAll(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub)
	{
	}

	[Token(Token = "0x6001DA6")]
	[Address(RVA = "0x60D000", Offset = "0x60C200", VA = "0x18060D000")]
	public void SetOnSelectedKeyUpCallback(SelectorManager.KeyType key_type, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001DA7")]
	[Address(RVA = "0x60D030", Offset = "0x60C230", VA = "0x18060D030")]
	public void SetOnSelectedKeyUpCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001DA8")]
	[Address(RVA = "0x609FA0", Offset = "0x6091A0", VA = "0x180609FA0")]
	public void ClearOnSelectedKeyUpCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001DA9")]
	[Address(RVA = "0x609F70", Offset = "0x609170", VA = "0x180609F70")]
	public void ClearOnSelectedKeyUpCallbackAll(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub)
	{
	}

	[Token(Token = "0x6001DAA")]
	[Address(RVA = "0x60D9B0", Offset = "0x60CBB0", VA = "0x18060D9B0")]
	public void SetOnShortCutKeyDownCallback(SelectorManager.KeyType key_type, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001DAB")]
	[Address(RVA = "0x60DA10", Offset = "0x60CC10", VA = "0x18060DA10")]
	public void SetOnShortCutKeyDownCallback(SelectorManager.KeyType key_type, UnityAction callback, bool exclusiveFunc = false)
	{
	}

	[Token(Token = "0x6001DAC")]
	[Address(RVA = "0x60D9E0", Offset = "0x60CBE0", VA = "0x18060D9E0")]
	public void SetOnShortCutKeyDownCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001DAD")]
	[Address(RVA = "0x60D8B0", Offset = "0x60CAB0", VA = "0x18060D8B0")]
	public void SetOnShortCutKeyDownCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, UnityAction callback, bool exclusiveFunc = false)
	{
	}

	[Token(Token = "0x6001DAE")]
	[Address(RVA = "0x60A060", Offset = "0x609260", VA = "0x18060A060")]
	public void ClearOnShortCutKeyDownCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001DAF")]
	[Address(RVA = "0x60A030", Offset = "0x609230", VA = "0x18060A030")]
	public void ClearOnShortCutKeyDownCallbackAll(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub)
	{
	}

	[Token(Token = "0x6001DB0")]
	[Address(RVA = "0x60D850", Offset = "0x60CA50", VA = "0x18060D850")]
	public void SetOnShortCutKeyCallback(SelectorManager.KeyType key_type, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001DB1")]
	[Address(RVA = "0x60D750", Offset = "0x60C950", VA = "0x18060D750")]
	public void SetOnShortCutKeyCallback(SelectorManager.KeyType key_type, UnityAction callback, bool exclusiveFunc = false)
	{
	}

	[Token(Token = "0x6001DB2")]
	[Address(RVA = "0x60D880", Offset = "0x60CA80", VA = "0x18060D880")]
	public void SetOnShortCutKeyCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001DB3")]
	[Address(RVA = "0x60D650", Offset = "0x60C850", VA = "0x18060D650")]
	public void SetOnShortCutKeyCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, UnityAction callback, bool exclusiveFunc = false)
	{
	}

	[Token(Token = "0x6001DB4")]
	[Address(RVA = "0x60A000", Offset = "0x609200", VA = "0x18060A000")]
	public void ClearOnShortCutKeyCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001DB5")]
	[Address(RVA = "0x609FD0", Offset = "0x6091D0", VA = "0x180609FD0")]
	public void ClearOnShortCutKeyCallbackAll(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub)
	{
	}

	[Token(Token = "0x6001DB6")]
	[Address(RVA = "0x60DC40", Offset = "0x60CE40", VA = "0x18060DC40")]
	public void SetOnShortCutKeyUpCallback(SelectorManager.KeyType key_type, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001DB7")]
	[Address(RVA = "0x60DB40", Offset = "0x60CD40", VA = "0x18060DB40")]
	public void SetOnShortCutKeyUpCallback(SelectorManager.KeyType key_type, UnityAction callback, bool exclusiveFunc = false)
	{
	}

	[Token(Token = "0x6001DB8")]
	[Address(RVA = "0x60DB10", Offset = "0x60CD10", VA = "0x18060DB10")]
	public void SetOnShortCutKeyUpCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001DB9")]
	[Address(RVA = "0x60DC70", Offset = "0x60CE70", VA = "0x18060DC70")]
	public void SetOnShortCutKeyUpCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, UnityAction callback, bool exclusiveFunc = false)
	{
	}

	[Token(Token = "0x6001DBA")]
	[Address(RVA = "0x60A0C0", Offset = "0x6092C0", VA = "0x18060A0C0")]
	public void ClearOnShortCutKeyUpCallback(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub, Func<bool> callback)
	{
	}

	[Token(Token = "0x6001DBB")]
	[Address(RVA = "0x60A090", Offset = "0x609290", VA = "0x18060A090")]
	public void ClearOnShortCutKeyUpCallbackAll(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub)
	{
	}

	[Token(Token = "0x6001DBC")]
	[Address(RVA = "0x60CB00", Offset = "0x60BD00", VA = "0x18060CB00")]
	public void SetOnSelectedAnalogInputCallback(SelectorManager.AnalogType analog_type, Func<Vector2, bool> callback)
	{
	}

	[Token(Token = "0x6001DBD")]
	[Address(RVA = "0x60CA20", Offset = "0x60BC20", VA = "0x18060CA20")]
	public void SetOnSelectedAnalogInputCallback(SelectorManager.AnalogType analog_type, Action<Vector2> callback, bool exclusiveFunc = false)
	{
	}

	[Token(Token = "0x6001DBE")]
	[Address(RVA = "0x60C7A0", Offset = "0x60B9A0", VA = "0x18060C7A0")]
	public void SetOnSelectedAnalogInputCallback(SelectorManager.AnalogType analog_type, SelectorManager.KeyType subKeyType, Action<Vector2> callback, bool exclusiveFunc = false)
	{
	}

	[Token(Token = "0x6001DBF")]
	[Address(RVA = "0x60C890", Offset = "0x60BA90", VA = "0x18060C890")]
	public void SetOnSelectedAnalogInputCallback(SelectorManager.AnalogType analog_type, SelectorManager.KeyType subKeyType, Func<Vector2, bool> callback)
	{
	}

	[Token(Token = "0x6001DC0")]
	[Address(RVA = "0x60ABD0", Offset = "0x609DD0", VA = "0x18060ABD0")]
	public bool InvokeOnSelectedAnalogInputCallback()
	{
		return default(bool);
	}

	[Token(Token = "0x6001DC1")]
	[Address(RVA = "0x60D2C0", Offset = "0x60C4C0", VA = "0x18060D2C0")]
	public void SetOnShortCutAnalogInputCallback(SelectorManager.AnalogType analog_type, Func<Vector2, bool> callback)
	{
	}

	[Token(Token = "0x6001DC2")]
	[Address(RVA = "0x60D560", Offset = "0x60C760", VA = "0x18060D560")]
	public void SetOnShortCutAnalogInputCallback(SelectorManager.AnalogType analog_type, Action<Vector2> callback, bool exclusiveFunc = false)
	{
	}

	[Token(Token = "0x6001DC3")]
	[Address(RVA = "0x60D2E0", Offset = "0x60C4E0", VA = "0x18060D2E0")]
	public void SetOnShortCutAnalogInputCallback(SelectorManager.AnalogType analog_type, SelectorManager.KeyType subKeyType, Action<Vector2> callback, bool exclusiveFunc = false)
	{
	}

	[Token(Token = "0x6001DC4")]
	[Address(RVA = "0x60D3D0", Offset = "0x60C5D0", VA = "0x18060D3D0")]
	public void SetOnShortCutAnalogInputCallback(SelectorManager.AnalogType analog_type, SelectorManager.KeyType subKeyType, Func<Vector2, bool> callback)
	{
	}

	[Token(Token = "0x6001DC5")]
	[Address(RVA = "0x60AE20", Offset = "0x60A020", VA = "0x18060AE20")]
	public bool InvokeOnShortCutAnalogInputCallback()
	{
		return default(bool);
	}

	[Token(Token = "0x6001DC6")]
	[Address(RVA = "0x60D060", Offset = "0x60C260", VA = "0x18060D060")]
	public void SetOnSelectedMouseClickCallback(SelectorManager.MouseType mouse_type, UnityAction<bool> callback, bool exclusiveFunc = true)
	{
	}

	[Token(Token = "0x6001DC7")]
	[Address(RVA = "0x60D160", Offset = "0x60C360", VA = "0x18060D160")]
	public void SetOnSelectedMouseClickCallback(SelectorManager.MouseType mouse_type, Func<bool, bool> callback)
	{
	}

	[Token(Token = "0x6001DC8")]
	[Address(RVA = "0x60D1C0", Offset = "0x60C3C0", VA = "0x18060D1C0")]
	public void SetOnSelectedMousePushCallback(SelectorManager.MouseType mouse_type, UnityAction<bool> callback, bool exclusiveFunc = true)
	{
	}

	[Token(Token = "0x6001DC9")]
	[Address(RVA = "0x60D190", Offset = "0x60C390", VA = "0x18060D190")]
	public void SetOnSelectedMousePushCallback(SelectorManager.MouseType mouse_type, Func<bool, bool> callback)
	{
	}

	[Token(Token = "0x6001DCA")]
	[Address(RVA = "0x60DD70", Offset = "0x60CF70", VA = "0x18060DD70")]
	public void SetOnShortCutMouseClickCallback(SelectorManager.MouseType mouse_type, UnityAction<bool> callback, bool exclusiveFunc = true)
	{
	}

	[Token(Token = "0x6001DCB")]
	[Address(RVA = "0x60DE70", Offset = "0x60D070", VA = "0x18060DE70")]
	public void SetOnShortCutMouseClickCallback(SelectorManager.MouseType mouse_type, Func<bool, bool> callback)
	{
	}

	[Token(Token = "0x6001DCC")]
	[Address(RVA = "0x60DEA0", Offset = "0x60D0A0", VA = "0x18060DEA0")]
	public void SetOnShortCutMousePushCallback(SelectorManager.MouseType mouse_type, UnityAction<bool> callback, bool exclusiveFunc = true)
	{
	}

	[Token(Token = "0x6001DCD")]
	[Address(RVA = "0x60D190", Offset = "0x60C390", VA = "0x18060D190")]
	public void SetOnShortCutMousePushCallback(SelectorManager.MouseType mouse_type, Func<bool, bool> callback)
	{
	}

	[Token(Token = "0x6001DCE")]
	[Address(RVA = "0x60C420", Offset = "0x60B620", VA = "0x18060C420")]
	private void SetMouseCallback(SelectorManager.KeyStatus status, SelectorManager.MouseType mouse_type, Func<bool, bool> callback, bool isSelected)
	{
	}

	[Token(Token = "0x6001DCF")]
	[Address(RVA = "0x609C80", Offset = "0x608E80", VA = "0x180609C80")]
	protected void ClearMouseCallback(SelectorManager.MouseType mouse_type, Func<bool> callback, SelectorManager.KeyStatus keyStatus, bool isSelected)
	{
	}

	[Token(Token = "0x6001DD0")]
	[Address(RVA = "0x609AC0", Offset = "0x608CC0", VA = "0x180609AC0")]
	protected void ClearMouseCallbackAll(SelectorManager.MouseType mouse_type, SelectorManager.KeyStatus keyStatus, bool isSelected)
	{
	}

	[Token(Token = "0x6001DD1")]
	[Address(RVA = "0x60C740", Offset = "0x60B940", VA = "0x18060C740")]
	public void SetOnPointerEnterCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6001DD2")]
	[Address(RVA = "0x60B740", Offset = "0x60A940", VA = "0x18060B740")]
	public void RemoveAllOnPointerEnterCallback()
	{
	}

	[Token(Token = "0x6001DD3")]
	[Address(RVA = "0x60B570", Offset = "0x60A770", VA = "0x18060B570", Slot = "18")]
	public virtual bool OnPointerEnter()
	{
		return default(bool);
	}

	[Token(Token = "0x6001DD4")]
	[Address(RVA = "0x60C760", Offset = "0x60B960", VA = "0x18060C760")]
	public void SetOnPointerExitCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6001DD5")]
	[Address(RVA = "0x60B760", Offset = "0x60A960", VA = "0x18060B760")]
	public void RemoveAllOnPointerExitCallback()
	{
	}

	[Token(Token = "0x6001DD6")]
	[Address(RVA = "0x60B5C0", Offset = "0x60A7C0", VA = "0x18060B5C0", Slot = "19")]
	public virtual bool OnPointerExit()
	{
		return default(bool);
	}

	[Token(Token = "0x6001DD7")]
	[Address(RVA = "0x60C720", Offset = "0x60B920", VA = "0x18060C720")]
	public void SetOnPointerDownCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6001DD8")]
	[Address(RVA = "0x60B4F0", Offset = "0x60A6F0", VA = "0x18060B4F0", Slot = "20")]
	public virtual bool OnPointerDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6001DD9")]
	[Address(RVA = "0x60C700", Offset = "0x60B900", VA = "0x18060C700")]
	public void SetOnPointerClickCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6001DDA")]
	[Address(RVA = "0x60B720", Offset = "0x60A920", VA = "0x18060B720")]
	public void RemoveAllOnPointerClickCallback()
	{
	}

	[Token(Token = "0x6001DDB")]
	[Address(RVA = "0x60B450", Offset = "0x60A650", VA = "0x18060B450", Slot = "21")]
	public virtual bool OnPointerClick()
	{
		return default(bool);
	}

	[Token(Token = "0x6001DDC")]
	[Address(RVA = "0x60B4A0", Offset = "0x60A6A0", VA = "0x18060B4A0", Slot = "22")]
	public virtual bool OnPointerDoubleClick()
	{
		return default(bool);
	}

	[Token(Token = "0x6001DDD")]
	[Address(RVA = "0x60C780", Offset = "0x60B980", VA = "0x18060C780")]
	public void SetOnPointerUpCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6001DDE")]
	[Address(RVA = "0x60B610", Offset = "0x60A810", VA = "0x18060B610", Slot = "23")]
	public virtual bool OnPointerUp()
	{
		return default(bool);
	}

	[Token(Token = "0x6001DDF")]
	[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
	public void SetDragStarter(Func<Vector2, Vector2, bool> drag_starter)
	{
	}

	[Token(Token = "0x6001DE0")]
	[Address(RVA = "0x60B120", Offset = "0x60A320", VA = "0x18060B120")]
	public bool IsDragStart(Vector2 screen_point, Vector2 pressed_point)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DE1")]
	[Address(RVA = "0x60C640", Offset = "0x60B840", VA = "0x18060C640")]
	public void SetOnDragCallback(UnityAction<DragStatus, Vector2> callback)
	{
	}

	[Token(Token = "0x6001DE2")]
	[Address(RVA = "0x609E50", Offset = "0x609050", VA = "0x180609E50")]
	public void ClearOnDragCallback()
	{
	}

	[Token(Token = "0x6001DE3")]
	[Address(RVA = "0x60B330", Offset = "0x60A530", VA = "0x18060B330", Slot = "24")]
	public virtual bool OnDrag(DragStatus drag_status, Vector2 screen_position)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DE4")]
	[Address(RVA = "0x60C0B0", Offset = "0x60B2B0", VA = "0x18060C0B0")]
	public void SetAsVerticalScrollItem(float dragThreshold = 0.01f)
	{
	}

	[Token(Token = "0x6001DE5")]
	[Address(RVA = "0x60BF40", Offset = "0x60B140", VA = "0x18060BF40")]
	public void SetAsHorizontalScrollItem(float dragThreshold = 0.01f)
	{
	}

	[Token(Token = "0x6001DE6")]
	[Address(RVA = "0x60BFA0", Offset = "0x60B1A0", VA = "0x18060BFA0")]
	public void SetAsMultiScrollItem(float dragThreshold = 0.01f)
	{
	}

	[Token(Token = "0x6001DE7")]
	[Address(RVA = "0x60BF60", Offset = "0x60B160", VA = "0x18060BF60")]
	public void SetAsMultiScrollItemEnable(bool asMultiScrollItemEnabled, float dragThreshold = 0.01f)
	{
	}

	[Token(Token = "0x6001DE8")]
	[Address(RVA = "0x60BFD0", Offset = "0x60B1D0", VA = "0x18060BFD0")]
	private void SetAsScrollItem(bool verticalScroll, bool horizontalScroll, float dragThreshold = 0.01f)
	{
	}

	[Token(Token = "0x6001DE9")]
	[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
	public void SetHoldStarter(Func<float, bool> hold_starter)
	{
	}

	[Token(Token = "0x6001DEA")]
	[Address(RVA = "0x60B150", Offset = "0x60A350", VA = "0x18060B150")]
	public bool IsHoldStart(float holdTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DEB")]
	[Address(RVA = "0x60C6A0", Offset = "0x60B8A0", VA = "0x18060C6A0")]
	public void SetOnHoldCallback(UnityAction<HoldStatus, Vector2> callback)
	{
	}

	[Token(Token = "0x6001DEC")]
	[Address(RVA = "0x609E80", Offset = "0x609080", VA = "0x180609E80")]
	public void ClearOnHoldCallback()
	{
	}

	[Token(Token = "0x6001DED")]
	[Address(RVA = "0x60B3B0", Offset = "0x60A5B0", VA = "0x18060B3B0", Slot = "25")]
	public virtual bool OnHold(HoldStatus hold_status, Vector2 screen_position)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DEE")]
	[Address(RVA = "0x60A6C0", Offset = "0x6098C0", VA = "0x18060A6C0")]
	public TransitionMode GetTransitionMode(PadInputDirection direction)
	{
		return default(TransitionMode);
	}

	[Token(Token = "0x6001DEF")]
	[Address(RVA = "0x60E190", Offset = "0x60D390", VA = "0x18060E190")]
	public void SetTransitionMode(PadInputDirection direction, TransitionMode mode)
	{
	}

	[Token(Token = "0x6001DF0")]
	[Address(RVA = "0x60A550", Offset = "0x609750", VA = "0x18060A550")]
	public SelectionItem GetManualTransitionItem(PadInputDirection direction)
	{
		return null;
	}

	[Token(Token = "0x6001DF1")]
	[Address(RVA = "0x60C220", Offset = "0x60B420", VA = "0x18060C220")]
	public void SetManualTransitionItem(PadInputDirection direction, SelectionItem item, bool set_mode_manual = true)
	{
	}

	[Token(Token = "0x6001DF2")]
	[Address(RVA = "0x60A680", Offset = "0x609880", VA = "0x18060A680")]
	public Selector GetManualTransitionSelector(PadInputDirection direction)
	{
		return null;
	}

	[Token(Token = "0x6001DF3")]
	[Address(RVA = "0x60C320", Offset = "0x60B520", VA = "0x18060C320")]
	public void SetManualTransitionSelector(PadInputDirection direction, Selector selector, bool set_mode_manual = true)
	{
	}

	[Token(Token = "0x6001DF4")]
	[Address(RVA = "0x60AB80", Offset = "0x609D80", VA = "0x18060AB80")]
	public void InvokeInputCallback(PadInputDirection direction)
	{
	}

	[Token(Token = "0x6001DF5")]
	[Address(RVA = "0x609150", Offset = "0x608350", VA = "0x180609150")]
	public void AddInputCallback(PadInputDirection direction, InputCallback callback)
	{
	}

	[Token(Token = "0x6001DF6")]
	[Address(RVA = "0x60B820", Offset = "0x60AA20", VA = "0x18060B820")]
	public void RemoveInputCallback(PadInputDirection direction, InputCallback callback)
	{
	}

	[Token(Token = "0x6001DF7")]
	[Address(RVA = "0x60B7A0", Offset = "0x60A9A0", VA = "0x18060B7A0")]
	public void RemoveInputCallbackAll(PadInputDirection direction)
	{
	}

	[Token(Token = "0x6001DF8")]
	[Address(RVA = "0x6093A0", Offset = "0x6085A0", VA = "0x1806093A0")]
	public void AddTransitionFailedCallback(PadInputDirection direction, InputCallback callback)
	{
	}

	[Token(Token = "0x6001DF9")]
	[Address(RVA = "0x60BAF0", Offset = "0x60ACF0", VA = "0x18060BAF0")]
	public void RemoveTransitionFailedCallback(PadInputDirection direction, InputCallback callback)
	{
	}

	[Token(Token = "0x6001DFA")]
	[Address(RVA = "0x60BA70", Offset = "0x60AC70", VA = "0x18060BA70")]
	public void RemoveTransitionFailedCallbackAll(PadInputDirection direction)
	{
	}

	[Token(Token = "0x6001DFB")]
	[Address(RVA = "0x60B070", Offset = "0x60A270", VA = "0x18060B070")]
	public void InvokeTransitionFailedCallback(PadInputDirection direction)
	{
	}

	[Token(Token = "0x6001DFC")]
	[Address(RVA = "0x60A700", Offset = "0x609900", VA = "0x18060A700")]
	public void InputDirection(PadInputDirection direction)
	{
	}

	[Token(Token = "0x6001DFD")]
	[Address(RVA = "0x60DFA0", Offset = "0x60D1A0", VA = "0x18060DFA0")]
	public void SetResistStatus(RegistStatus regist_status)
	{
	}

	[Token(Token = "0x6001DFE")]
	[Address(RVA = "0x60BE90", Offset = "0x60B090", VA = "0x18060BE90")]
	public void SetAsDefaultItem(bool isDefaultItem)
	{
	}

	[Token(Token = "0x6001DFF")]
	[Address(RVA = "0x60E1D0", Offset = "0x60D3D0", VA = "0x18060E1D0")]
	public void SetupDepth()
	{
	}

	[Token(Token = "0x6001E00")]
	[Address(RVA = "0x60E2D0", Offset = "0x60D4D0", VA = "0x18060E2D0")]
	public SelectionItem()
	{
	}
}
