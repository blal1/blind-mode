using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI;

[Token(Token = "0x200049E")]
public class Selector : MonoBehaviour
{
	[Token(Token = "0x200049F")]
	public enum OverAreaDirectionMode
	{
		[Token(Token = "0x40016B1")]
		Clamp,
		[Token(Token = "0x40016B2")]
		Loop
	}

	[Token(Token = "0x20004A0")]
	[Flags]
	public enum InputMode
	{
		[Token(Token = "0x40016B4")]
		Select = 1,
		[Token(Token = "0x40016B5")]
		Callback = 2
	}

	[Token(Token = "0x20004A1")]
	public delegate void InputCallback();

	[Token(Token = "0x20004A2")]
	public delegate void SelectedCallback(SelectionItem item);

	[Token(Token = "0x20004A3")]
	public enum MaskMode
	{
		[Token(Token = "0x40016B7")]
		None,
		[Token(Token = "0x40016B8")]
		RectTransformArea,
		[Token(Token = "0x40016B9")]
		RectTransformAreaAllPoints
	}

	[Token(Token = "0x20004A4")]
	[Flags]
	public enum MaskOperation
	{
		[Token(Token = "0x40016BB")]
		ScreenInput = 1,
		[Token(Token = "0x40016BC")]
		KeyInput = 2
	}

	[Token(Token = "0x20004A5")]
	public enum RegistStatus
	{
		[Token(Token = "0x40016BE")]
		None,
		[Token(Token = "0x40016BF")]
		Previsional,
		[Token(Token = "0x40016C0")]
		Registed
	}

	[Token(Token = "0x400168C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<SelectionItem> items;

	[Token(Token = "0x400168D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private SelectionItem preSelectedItem;

	[Token(Token = "0x400168E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string _groupLabel;

	[Token(Token = "0x4001690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int storedGroupPriority;

	[Token(Token = "0x4001691")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int storedGroupPriorityInCluster;

	[Token(Token = "0x4001692")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Camera _viewCamera;

	[Token(Token = "0x4001694")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	protected OverAreaDirectionMode _overAreaDirectionMode;

	[Token(Token = "0x4001695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private InputMode upInputMode;

	[Token(Token = "0x4001696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private InputMode downInputMode;

	[Token(Token = "0x4001697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private InputMode rightInputMode;

	[Token(Token = "0x4001698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	private InputMode leftInputMode;

	[Token(Token = "0x400169F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private MaskMode _maskMode;

	[Token(Token = "0x40016A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Selector _maskRefSelector;

	[Token(Token = "0x40016A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private MaskOperation _maskOperation;

	[Token(Token = "0x40016A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3[] rectWorldCorners;

	[Token(Token = "0x40016A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private RaycastHit _currentRaycastHit;

	[Token(Token = "0x40016A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private UnityEvent onActivatedCallback;

	[Token(Token = "0x40016A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private UnityEvent onDeactivatedCallback;

	[Token(Token = "0x40016AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Selector selectionParentSelector;

	[Token(Token = "0x40016AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public List<Selector> selectionChildrenSelector;

	[Token(Token = "0x40016AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[SerializeField]
	private SelectionItem selectionTargetItem;

	[Token(Token = "0x40016AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public bool isSelectorSelectoredOverride;

	[Token(Token = "0x40016AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private RegistStatus registStatus;

	[Token(Token = "0x170002F1")]
	public string groupLabel
	{
		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0x62D920", Offset = "0x62CB20", VA = "0x18062D920")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F2")]
	public SelectorGroup group
	{
		[Token(Token = "0x6001E3E")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001E3F")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170002F3")]
	public int groupPriority
	{
		[Token(Token = "0x6001E40")]
		[Address(RVA = "0x62D960", Offset = "0x62CB60", VA = "0x18062D960")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002F4")]
	public Camera viewCamera
	{
		[Token(Token = "0x6001E41")]
		[Address(RVA = "0x62DA90", Offset = "0x62CC90", VA = "0x18062DA90")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001E42")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		set
		{
		}
	}

	[Token(Token = "0x170002F5")]
	public bool isDisabledDepthCheck
	{
		[Token(Token = "0x6001E43")]
		[Address(RVA = "0x3E1DE0", Offset = "0x3E0FE0", VA = "0x1803E1DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001E44")]
		[Address(RVA = "0x3E1DF0", Offset = "0x3E0FF0", VA = "0x1803E1DF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170002F6")]
	public OverAreaDirectionMode overAreaDrectionMode
	{
		[Token(Token = "0x6001E45")]
		[Address(RVA = "0x49BDA0", Offset = "0x49AFA0", VA = "0x18049BDA0")]
		get
		{
			return default(OverAreaDirectionMode);
		}
	}

	[Token(Token = "0x170002F7")]
	public MaskMode maskMode
	{
		[Token(Token = "0x6001E52")]
		[Address(RVA = "0x3DDD20", Offset = "0x3DCF20", VA = "0x1803DDD20")]
		get
		{
			return default(MaskMode);
		}
		[Token(Token = "0x6001E53")]
		[Address(RVA = "0x62DFF0", Offset = "0x62D1F0", VA = "0x18062DFF0")]
		set
		{
		}
	}

	[Token(Token = "0x170002F8")]
	public Selector maskRefSelector
	{
		[Token(Token = "0x6001E54")]
		[Address(RVA = "0x62DA00", Offset = "0x62CC00", VA = "0x18062DA00")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001E55")]
		[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
		set
		{
		}
	}

	[Token(Token = "0x170002F9")]
	public MaskOperation maskOperation
	{
		[Token(Token = "0x6001E56")]
		[Address(RVA = "0x42D5E0", Offset = "0x42C7E0", VA = "0x18042D5E0")]
		get
		{
			return default(MaskOperation);
		}
		[Token(Token = "0x6001E57")]
		[Address(RVA = "0x42D690", Offset = "0x42C890", VA = "0x18042D690")]
		set
		{
		}
	}

	[Token(Token = "0x170002FA")]
	public RaycastHit currentRaycastHit
	{
		[Token(Token = "0x6001E58")]
		[Address(RVA = "0x62D8F0", Offset = "0x62CAF0", VA = "0x18062D8F0")]
		get
		{
			return default(RaycastHit);
		}
	}

	[Token(Token = "0x170002FB")]
	public bool isRaycastHit
	{
		[Token(Token = "0x6001E59")]
		[Address(RVA = "0x62D9F0", Offset = "0x62CBF0", VA = "0x18062D9F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001E5A")]
		[Address(RVA = "0x62DFE0", Offset = "0x62D1E0", VA = "0x18062DFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170002FC")]
	public int hierarchyIndexCache
	{
		[Token(Token = "0x6001E5B")]
		[Address(RVA = "0x62D9C0", Offset = "0x62CBC0", VA = "0x18062D9C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001E5C")]
		[Address(RVA = "0x62DFB0", Offset = "0x62D1B0", VA = "0x18062DFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170002FD")]
	private bool isDirty
	{
		[Token(Token = "0x6001E5D")]
		[Address(RVA = "0x62D9E0", Offset = "0x62CBE0", VA = "0x18062D9E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001E5E")]
		[Address(RVA = "0x62DFD0", Offset = "0x62D1D0", VA = "0x18062DFD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170002FE")]
	public bool isActivated
	{
		[Token(Token = "0x6001E5F")]
		[Address(RVA = "0x62D9D0", Offset = "0x62CBD0", VA = "0x18062D9D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001E60")]
		[Address(RVA = "0x62DFC0", Offset = "0x62D1C0", VA = "0x18062DFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170002FF")]
	public Func<bool, bool> onSelectorSelectoredFunc
	{
		[Token(Token = "0x6001E61")]
		[Address(RVA = "0x62DA80", Offset = "0x62CC80", VA = "0x18062DA80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001E62")]
		[Address(RVA = "0x62E000", Offset = "0x62D200", VA = "0x18062E000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x14000027")]
	public event InputCallback upInputCallback
	{
		[Token(Token = "0x6001E46")]
		[Address(RVA = "0x62D850", Offset = "0x62CA50", VA = "0x18062D850")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001E47")]
		[Address(RVA = "0x62DF10", Offset = "0x62D110", VA = "0x18062DF10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000028")]
	public event InputCallback downInputCallback
	{
		[Token(Token = "0x6001E48")]
		[Address(RVA = "0x62D5B0", Offset = "0x62C7B0", VA = "0x18062D5B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001E49")]
		[Address(RVA = "0x62DC70", Offset = "0x62CE70", VA = "0x18062DC70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000029")]
	public event InputCallback rightInputCallback
	{
		[Token(Token = "0x6001E4A")]
		[Address(RVA = "0x62D700", Offset = "0x62C900", VA = "0x18062D700")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001E4B")]
		[Address(RVA = "0x62DDC0", Offset = "0x62CFC0", VA = "0x18062DDC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400002A")]
	public event InputCallback leftInputCallback
	{
		[Token(Token = "0x6001E4C")]
		[Address(RVA = "0x62D650", Offset = "0x62C850", VA = "0x18062D650")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001E4D")]
		[Address(RVA = "0x62DD10", Offset = "0x62CF10", VA = "0x18062DD10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400002B")]
	public event SelectedCallback selectedCallback
	{
		[Token(Token = "0x6001E4E")]
		[Address(RVA = "0x62D7A0", Offset = "0x62C9A0", VA = "0x18062D7A0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001E4F")]
		[Address(RVA = "0x62DE60", Offset = "0x62D060", VA = "0x18062DE60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400002C")]
	public event SelectedCallback deselectedCallback
	{
		[Token(Token = "0x6001E50")]
		[Address(RVA = "0x62D500", Offset = "0x62C700", VA = "0x18062D500")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001E51")]
		[Address(RVA = "0x62DBC0", Offset = "0x62CDC0", VA = "0x18062DBC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6001E63")]
	[Address(RVA = "0x62BBB0", Offset = "0x62ADB0", VA = "0x18062BBB0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001E64")]
	[Address(RVA = "0x62BB20", Offset = "0x62AD20", VA = "0x18062BB20")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001E65")]
	[Address(RVA = "0x62B9A0", Offset = "0x62ABA0", VA = "0x18062B9A0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001E66")]
	[Address(RVA = "0x629F20", Offset = "0x629120", VA = "0x180629F20")]
	public void AddItem(SelectionItem item)
	{
	}

	[Token(Token = "0x6001E67")]
	[Address(RVA = "0x62C110", Offset = "0x62B310", VA = "0x18062C110")]
	public void RemoveItem(SelectionItem item)
	{
	}

	[Token(Token = "0x6001E68")]
	[Address(RVA = "0x62D2A0", Offset = "0x62C4A0", VA = "0x18062D2A0")]
	public SelectionItem.UpdateItemStatus UpdateAllItems()
	{
		return default(SelectionItem.UpdateItemStatus);
	}

	[Token(Token = "0x6001E69")]
	[Address(RVA = "0x62CED0", Offset = "0x62C0D0", VA = "0x18062CED0")]
	public void SetupItemDepthIfDirty()
	{
	}

	[Token(Token = "0x6001E6A")]
	[Address(RVA = "0x62AB20", Offset = "0x629D20", VA = "0x18062AB20")]
	public (SelectionItem, float) GetSelectionItem(Vector2 current_position, Vector2 direction, float angle, [Optional] SelectionItem ignore_item)
	{
		return default((SelectionItem, float));
	}

	[Token(Token = "0x6001E6B")]
	[Address(RVA = "0x62A380", Offset = "0x629580", VA = "0x18062A380")]
	public SelectionItem GetHiestPrioritySelectableItem()
	{
		return null;
	}

	[Token(Token = "0x6001E6C")]
	[Address(RVA = "0x62AFF0", Offset = "0x62A1F0", VA = "0x18062AFF0")]
	public (SelectionItem, float) GetSelectionItem(Vector2 view_position)
	{
		return default((SelectionItem, float));
	}

	[Token(Token = "0x6001E6D")]
	[Address(RVA = "0x62A6B0", Offset = "0x6298B0", VA = "0x18062A6B0")]
	public bool GetSelectionItemAll(Vector2 view_position, List<SelectionItem> hitItems, bool containNoneInteractable = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E6E")]
	[Address(RVA = "0x62A1A0", Offset = "0x6293A0", VA = "0x18062A1A0")]
	public bool ContainCurrentItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6001E6F")]
	[Address(RVA = "0x62B760", Offset = "0x62A960", VA = "0x18062B760")]
	private bool IsContainsItem(GameObject obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E70")]
	[Address(RVA = "0x62A480", Offset = "0x629680", VA = "0x18062A480")]
	private SelectionItem GetItem(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x6001E71")]
	[Address(RVA = "0x62B440", Offset = "0x62A640", VA = "0x18062B440")]
	private bool GetViewRect(out Vector2 rect_point0, out Vector2 rect_point1, out Vector2 rect_point2, out Vector2 rect_point3)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E72")]
	[Address(RVA = "0x62B7D0", Offset = "0x62A9D0", VA = "0x18062B7D0")]
	private bool IsContainsPoint(Vector2 point)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E73")]
	[Address(RVA = "0x62CBB0", Offset = "0x62BDB0", VA = "0x18062CBB0")]
	public void SetDefaultItem(SelectionItem item)
	{
	}

	[Token(Token = "0x6001E74")]
	[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
	public void SetViewCamera(Camera view_camera)
	{
	}

	[Token(Token = "0x6001E75")]
	[Address(RVA = "0x62B370", Offset = "0x62A570", VA = "0x18062B370")]
	public Vector2 GetViewPosition(Vector3 item_position)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001E76")]
	[Address(RVA = "0x62C5E0", Offset = "0x62B7E0", VA = "0x18062C5E0")]
	public bool Select(SelectionItem selection_item, bool initializeSelection = false, bool force = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E77")]
	[Address(RVA = "0x62C770", Offset = "0x62B970", VA = "0x18062C770")]
	public bool Select(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E78")]
	[Address(RVA = "0x62C510", Offset = "0x62B710", VA = "0x18062C510")]
	public bool SelectPreSelectedItem(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E79")]
	[Address(RVA = "0x62C370", Offset = "0x62B570", VA = "0x18062C370")]
	public bool SelectDeufaltItem(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E7A")]
	[Address(RVA = "0x62C410", Offset = "0x62B610", VA = "0x18062C410")]
	public bool SelectParentSelector(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E7B")]
	[Address(RVA = "0x62C170", Offset = "0x62B370", VA = "0x18062C170")]
	public bool SelectChildSelector(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E7C")]
	[Address(RVA = "0x62CD20", Offset = "0x62BF20", VA = "0x18062CD20")]
	public void SetGroupPriority(int group_priority)
	{
	}

	[Token(Token = "0x6001E7D")]
	[Address(RVA = "0x62CD00", Offset = "0x62BF00", VA = "0x18062CD00")]
	public void SetGroupPriorityInCluster(int priority_in_cluster)
	{
	}

	[Token(Token = "0x6001E7E")]
	[Address(RVA = "0x629FD0", Offset = "0x6291D0", VA = "0x180629FD0")]
	public void ChangeGroupLabel(string group_label)
	{
	}

	[Token(Token = "0x6001E7F")]
	[Address(RVA = "0x62A450", Offset = "0x629650", VA = "0x18062A450")]
	public InputMode GetInputMode(PadInputDirection direction)
	{
		return default(InputMode);
	}

	[Token(Token = "0x6001E80")]
	[Address(RVA = "0x62CDA0", Offset = "0x62BFA0", VA = "0x18062CDA0")]
	public void SetInputMode(PadInputDirection direction, InputMode mode)
	{
	}

	[Token(Token = "0x6001E81")]
	[Address(RVA = "0x62B6F0", Offset = "0x62A8F0", VA = "0x18062B6F0")]
	public void InvokeInputCallback(PadInputDirection direction)
	{
	}

	[Token(Token = "0x6001E82")]
	[Address(RVA = "0x629CE0", Offset = "0x628EE0", VA = "0x180629CE0")]
	public void AddInputCallback(PadInputDirection direction, InputCallback callback)
	{
	}

	[Token(Token = "0x6001E83")]
	[Address(RVA = "0x62BED0", Offset = "0x62B0D0", VA = "0x18062BED0")]
	public void RemoveInputCallback(PadInputDirection direction, InputCallback callback)
	{
	}

	[Token(Token = "0x6001E84")]
	[Address(RVA = "0x62BE60", Offset = "0x62B060", VA = "0x18062BE60")]
	public void RemoveInputCallbackAll(PadInputDirection direction)
	{
	}

	[Token(Token = "0x6001E85")]
	[Address(RVA = "0x62B740", Offset = "0x62A940", VA = "0x18062B740")]
	public void InvokeSelectedCallback(SelectionItem item)
	{
	}

	[Token(Token = "0x6001E86")]
	[Address(RVA = "0x62B6D0", Offset = "0x62A8D0", VA = "0x18062B6D0")]
	public void InvokeDeselectedCallback(SelectionItem item)
	{
	}

	[Token(Token = "0x6001E87")]
	[Address(RVA = "0x62A600", Offset = "0x629800", VA = "0x18062A600")]
	public SelectionItem GetSelectedItem()
	{
		return null;
	}

	[Token(Token = "0x6001E88")]
	[Address(RVA = "0x62B8A0", Offset = "0x62AAA0", VA = "0x18062B8A0")]
	public bool IsSelected()
	{
		return default(bool);
	}

	[Token(Token = "0x6001E89")]
	[Address(RVA = "0x62A260", Offset = "0x629460", VA = "0x18062A260")]
	public SelectionItem GetDefaultItem()
	{
		return null;
	}

	[Token(Token = "0x6001E8A")]
	[Address(RVA = "0x62C990", Offset = "0x62BB90", VA = "0x18062C990")]
	public void SetAsDefaultItem(SelectionItem target)
	{
	}

	[Token(Token = "0x6001E8B")]
	[Address(RVA = "0x62CAA0", Offset = "0x62BCA0", VA = "0x18062CAA0")]
	public void SetAsSelectionTargetItem(SelectionItem target)
	{
	}

	[Token(Token = "0x6001E8C")]
	[Address(RVA = "0x62D0E0", Offset = "0x62C2E0", VA = "0x18062D0E0")]
	public void SetupItemDepth(bool force = false)
	{
	}

	[Token(Token = "0x6001E8D")]
	[Address(RVA = "0x62CF00", Offset = "0x62C100", VA = "0x18062CF00")]
	public void SetupItemDepth(SelectionItem targetItem)
	{
	}

	[Token(Token = "0x6001E8E")]
	[Address(RVA = "0x62CCF0", Offset = "0x62BEF0", VA = "0x18062CCF0")]
	public void SetDirty()
	{
	}

	[Token(Token = "0x6001E8F")]
	[Address(RVA = "0x629C80", Offset = "0x628E80", VA = "0x180629C80")]
	public void AddClusterActivateCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6001E90")]
	[Address(RVA = "0x62BE00", Offset = "0x62B000", VA = "0x18062BE00")]
	public void RemoveClusterActivateCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6001E91")]
	[Address(RVA = "0x62BDA0", Offset = "0x62AFA0", VA = "0x18062BDA0")]
	public void RemoveAllClusterActivateCallback()
	{
	}

	[Token(Token = "0x6001E92")]
	[Address(RVA = "0x629CB0", Offset = "0x628EB0", VA = "0x180629CB0")]
	public void AddClusterDeactivateCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6001E93")]
	[Address(RVA = "0x62BE30", Offset = "0x62B030", VA = "0x18062BE30")]
	public void RemoveClusterDeactivateCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6001E94")]
	[Address(RVA = "0x62BDD0", Offset = "0x62AFD0", VA = "0x18062BDD0")]
	public void RemoveAllClusterDeactivateCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6001E95")]
	[Address(RVA = "0x62B690", Offset = "0x62A890", VA = "0x18062B690")]
	public void InvokeClusterActivateCallback()
	{
	}

	[Token(Token = "0x6001E96")]
	[Address(RVA = "0x62B6B0", Offset = "0x62A8B0", VA = "0x18062B6B0")]
	public void InvokeClusterDeactivateCallback()
	{
	}

	[Token(Token = "0x6001E97")]
	[Address(RVA = "0x62CDD0", Offset = "0x62BFD0", VA = "0x18062CDD0")]
	public void SetResistStatus(RegistStatus regist_status)
	{
	}

	[Token(Token = "0x6001E98")]
	[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
	public List<SelectionItem> GetItems()
	{
		return null;
	}

	[Token(Token = "0x6001E99")]
	[Address(RVA = "0x62D370", Offset = "0x62C570", VA = "0x18062D370")]
	public Selector()
	{
	}
}
