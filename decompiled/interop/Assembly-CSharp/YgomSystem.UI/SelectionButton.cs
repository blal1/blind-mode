using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI;

[Token(Token = "0x200047D")]
public class SelectionButton : RectSelectionItem
{
	[Serializable]
	[Token(Token = "0x200047E")]
	public class OnClickEvent : UnityEvent
	{
		[Token(Token = "0x6001D4D")]
		[Address(RVA = "0x600F90", Offset = "0x600190", VA = "0x180600F90")]
		public OnClickEvent()
		{
		}
	}

	[Token(Token = "0x200047F")]
	public delegate void PointerCallback(SelectionItem this_item);

	[Token(Token = "0x40015F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private Dictionary<GameObject, List<ColorContainer>> colorContainers;

	[Token(Token = "0x40015FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	private string tweenLabelInitialize;

	[Token(Token = "0x40015FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	private string tweenLabelEnter;

	[Token(Token = "0x40015FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	private string tweenLabelDown;

	[Token(Token = "0x40015FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	private string tweenLabelClick;

	[Token(Token = "0x40015FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	private string tweenLabelExit;

	[Token(Token = "0x4001600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	private string tweenLabelSelected;

	[Token(Token = "0x4001601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	private string tweenLabelDeselected;

	[Token(Token = "0x4001602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	public bool playTweenInitialize;

	[Token(Token = "0x4001603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
	[SerializeField]
	public bool playTweenEnter;

	[Token(Token = "0x4001604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DA")]
	[SerializeField]
	public bool playTweenDown;

	[Token(Token = "0x4001605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DB")]
	[SerializeField]
	public bool playTweenClick;

	[Token(Token = "0x4001606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
	[SerializeField]
	public bool playTweenExit;

	[Token(Token = "0x4001607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DD")]
	[SerializeField]
	public bool playTweenSelected;

	[Token(Token = "0x4001608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DE")]
	[SerializeField]
	public bool playTweenDeselected;

	[Token(Token = "0x4001609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DF")]
	[SerializeField]
	public bool playSound;

	[Token(Token = "0x400160A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	private string _soundLabelClick;

	[Token(Token = "0x400160B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public bool muteSoundLabelClick;

	[Token(Token = "0x400160C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	[SerializeField]
	private string _soundLabelClickInactive;

	[Token(Token = "0x400160D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	[SerializeField]
	private string _soundLabelPointerEnter;

	[Token(Token = "0x400160E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	[SerializeField]
	private string _soundLabelSelectedGamePad;

	[Token(Token = "0x400160F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private ColorContainer.SelectMode currentSelectMode;

	[Token(Token = "0x4001610")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	private ColorContainer.StatusMode currentStatusMode;

	[Token(Token = "0x4001611")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public OnClickEvent onClick;

	[Token(Token = "0x4001612")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public OnClickEvent onDoubleClick;

	[Token(Token = "0x170002D7")]
	public int colorContainerIndex
	{
		[Token(Token = "0x6001D0A")]
		[Address(RVA = "0x608CB0", Offset = "0x607EB0", VA = "0x180608CB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001D0B")]
		[Address(RVA = "0x608FA0", Offset = "0x6081A0", VA = "0x180608FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170002D8")]
	public string soundLabelClick
	{
		[Token(Token = "0x6001D0C")]
		[Address(RVA = "0x3F2280", Offset = "0x3F1480", VA = "0x1803F2280")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x3F2450", Offset = "0x3F1650", VA = "0x1803F2450")]
		set
		{
		}
	}

	[Token(Token = "0x170002D9")]
	public string soundLabelClickInactive
	{
		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0x49BF40", Offset = "0x49B140", VA = "0x18049BF40")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001D0F")]
		[Address(RVA = "0x49C690", Offset = "0x49B890", VA = "0x18049C690")]
		set
		{
		}
	}

	[Token(Token = "0x170002DA")]
	public string soundLabelPointerEnter
	{
		[Token(Token = "0x6001D10")]
		[Address(RVA = "0x49BCD0", Offset = "0x49AED0", VA = "0x18049BCD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001D11")]
		[Address(RVA = "0x49C390", Offset = "0x49B590", VA = "0x18049C390")]
		set
		{
		}
	}

	[Token(Token = "0x170002DB")]
	public string soundLabelSelectedGamePad
	{
		[Token(Token = "0x6001D12")]
		[Address(RVA = "0x49BF10", Offset = "0x49B110", VA = "0x18049BF10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001D13")]
		[Address(RVA = "0x49C640", Offset = "0x49B840", VA = "0x18049C640")]
		set
		{
		}
	}

	[Token(Token = "0x170002DC")]
	public override bool interactable
	{
		[Token(Token = "0x6001D14")]
		[Address(RVA = "0x608CC0", Offset = "0x607EC0", VA = "0x180608CC0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001D15")]
		[Address(RVA = "0x608FB0", Offset = "0x6081B0", VA = "0x180608FB0", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x170002DD")]
	public bool isClickExclusive
	{
		[Token(Token = "0x6001D16")]
		[Address(RVA = "0x608CD0", Offset = "0x607ED0", VA = "0x180608CD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001D17")]
		[Address(RVA = "0x609020", Offset = "0x608220", VA = "0x180609020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1400001A")]
	public event PointerCallback onEnter
	{
		[Token(Token = "0x6001D18")]
		[Address(RVA = "0x608AA0", Offset = "0x607CA0", VA = "0x180608AA0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001D19")]
		[Address(RVA = "0x608D90", Offset = "0x607F90", VA = "0x180608D90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400001B")]
	public event PointerCallback onExit
	{
		[Token(Token = "0x6001D1A")]
		[Address(RVA = "0x608B50", Offset = "0x607D50", VA = "0x180608B50")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001D1B")]
		[Address(RVA = "0x608E40", Offset = "0x608040", VA = "0x180608E40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400001C")]
	public event PointerCallback onDown
	{
		[Token(Token = "0x6001D1C")]
		[Address(RVA = "0x6089F0", Offset = "0x607BF0", VA = "0x1806089F0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001D1D")]
		[Address(RVA = "0x608CE0", Offset = "0x607EE0", VA = "0x180608CE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400001D")]
	public event PointerCallback onUp
	{
		[Token(Token = "0x6001D1E")]
		[Address(RVA = "0x608C00", Offset = "0x607E00", VA = "0x180608C00")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001D1F")]
		[Address(RVA = "0x608EF0", Offset = "0x6080F0", VA = "0x180608EF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6001D20")]
	[Address(RVA = "0x605FB0", Offset = "0x6051B0", VA = "0x180605FB0", Slot = "6")]
	protected override void Awaked()
	{
	}

	[Token(Token = "0x6001D21")]
	[Address(RVA = "0x6063F0", Offset = "0x6055F0", VA = "0x1806063F0", Slot = "7")]
	protected override void Enabled()
	{
	}

	[Token(Token = "0x6001D22")]
	[Address(RVA = "0x606340", Offset = "0x605540", VA = "0x180606340", Slot = "8")]
	protected override void Disabled()
	{
	}

	[Token(Token = "0x6001D23")]
	[Address(RVA = "0x606260", Offset = "0x605460", VA = "0x180606260", Slot = "9")]
	protected override void Destroyed()
	{
	}

	[Token(Token = "0x6001D24")]
	[Address(RVA = "0x608640", Offset = "0x607840", VA = "0x180608640", Slot = "10")]
	public override UpdateItemStatus UpdateItem()
	{
		return default(UpdateItemStatus);
	}

	[Token(Token = "0x6001D25")]
	[Address(RVA = "0x6086B0", Offset = "0x6078B0", VA = "0x1806086B0", Slot = "11")]
	public override UpdateItemStatus UpdateSelectedItem()
	{
		return default(UpdateItemStatus);
	}

	[Token(Token = "0x6001D26")]
	[Address(RVA = "0x608420", Offset = "0x607620", VA = "0x180608420")]
	public void SetupColorContainer()
	{
	}

	[Token(Token = "0x6001D27")]
	[Address(RVA = "0x605D80", Offset = "0x604F80", VA = "0x180605D80")]
	public void AddColorContainer(ColorContainer colorContainer, bool withApplyCurrentColor = true)
	{
	}

	[Token(Token = "0x6001D28")]
	[Address(RVA = "0x605F90", Offset = "0x605190", VA = "0x180605F90")]
	public void ApplyCurrentColor()
	{
	}

	[Token(Token = "0x6001D29")]
	[Address(RVA = "0x608140", Offset = "0x607340", VA = "0x180608140")]
	private void SetColorContainerColor(ColorContainer.SelectMode select_mode, ColorContainer.StatusMode status_mode)
	{
	}

	[Token(Token = "0x6001D2A")]
	[Address(RVA = "0x6083F0", Offset = "0x6075F0", VA = "0x1806083F0")]
	public void SetColorContainerIndex(int index)
	{
	}

	[Token(Token = "0x6001D2B")]
	[Address(RVA = "0x606770", Offset = "0x605970", VA = "0x180606770", Slot = "21")]
	public override bool OnPointerClick()
	{
		return default(bool);
	}

	[Token(Token = "0x6001D2C")]
	[Address(RVA = "0x6067F0", Offset = "0x6059F0", VA = "0x1806067F0", Slot = "22")]
	public override bool OnPointerDoubleClick()
	{
		return default(bool);
	}

	[Token(Token = "0x6001D2D")]
	[Address(RVA = "0x606890", Offset = "0x605A90", VA = "0x180606890", Slot = "20")]
	public override bool OnPointerDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6001D2E")]
	[Address(RVA = "0x607000", Offset = "0x606200", VA = "0x180607000")]
	public void PointerDownEffect()
	{
	}

	[Token(Token = "0x6001D2F")]
	[Address(RVA = "0x606960", Offset = "0x605B60", VA = "0x180606960", Slot = "18")]
	public override bool OnPointerEnter()
	{
		return default(bool);
	}

	[Token(Token = "0x6001D30")]
	[Address(RVA = "0x607040", Offset = "0x606240", VA = "0x180607040")]
	public void PointerEnterEffect(bool pointerDown)
	{
	}

	[Token(Token = "0x6001D31")]
	[Address(RVA = "0x606AD0", Offset = "0x605CD0", VA = "0x180606AD0", Slot = "19")]
	public override bool OnPointerExit()
	{
		return default(bool);
	}

	[Token(Token = "0x6001D32")]
	[Address(RVA = "0x607140", Offset = "0x606340", VA = "0x180607140")]
	public void PointerExitEffect(bool pointerDown)
	{
	}

	[Token(Token = "0x6001D33")]
	[Address(RVA = "0x606C10", Offset = "0x605E10", VA = "0x180606C10", Slot = "23")]
	public override bool OnPointerUp()
	{
		return default(bool);
	}

	[Token(Token = "0x6001D34")]
	[Address(RVA = "0x607220", Offset = "0x606420", VA = "0x180607220")]
	public void PointerUpEffect()
	{
	}

	[Token(Token = "0x6001D35")]
	[Address(RVA = "0x606CC0", Offset = "0x605EC0", VA = "0x180606CC0", Slot = "16")]
	public override bool OnSelected(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D36")]
	[Address(RVA = "0x607740", Offset = "0x606940", VA = "0x180607740")]
	public void SelectEffect(bool initializeSelection = false)
	{
	}

	[Token(Token = "0x6001D37")]
	[Address(RVA = "0x6065D0", Offset = "0x6057D0", VA = "0x1806065D0", Slot = "17")]
	public override bool OnDeselected()
	{
		return default(bool);
	}

	[Token(Token = "0x6001D38")]
	[Address(RVA = "0x6061A0", Offset = "0x6053A0", VA = "0x1806061A0")]
	public void DeselectEffect()
	{
	}

	[Token(Token = "0x6001D39")]
	[Address(RVA = "0x6064D0", Offset = "0x6056D0", VA = "0x1806064D0")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6001D3A")]
	[Address(RVA = "0x606730", Offset = "0x605930", VA = "0x180606730")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x6001D3B")]
	[Address(RVA = "0x606190", Offset = "0x605390", VA = "0x180606190")]
	public void Click()
	{
	}

	[Token(Token = "0x6001D3C")]
	[Address(RVA = "0x606170", Offset = "0x605370", VA = "0x180606170")]
	private bool ClickFunc()
	{
		return default(bool);
	}

	[Token(Token = "0x6001D3D")]
	[Address(RVA = "0x606F10", Offset = "0x606110", VA = "0x180606F10")]
	private void PlayTween(string play_label, [Optional] string stop_label)
	{
	}

	[Token(Token = "0x6001D3E")]
	[Address(RVA = "0x606E80", Offset = "0x606080", VA = "0x180606E80")]
	private void PlaySound(string label)
	{
	}

	[Token(Token = "0x6001D3F")]
	[Address(RVA = "0x607AC0", Offset = "0x606CC0", VA = "0x180607AC0")]
	public void SetClickShortCutKeyDown(int gamepad_key_type)
	{
	}

	[Token(Token = "0x6001D40")]
	[Address(RVA = "0x607840", Offset = "0x606A40", VA = "0x180607840")]
	public void SetClickShortCutKeyDown(SelectorManager.KeyType key_type)
	{
	}

	[Token(Token = "0x6001D41")]
	[Address(RVA = "0x607980", Offset = "0x606B80", VA = "0x180607980")]
	public void SetClickShortCutKeyDown(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub)
	{
	}

	[Token(Token = "0x6001D42")]
	[Address(RVA = "0x6072A0", Offset = "0x6064A0", VA = "0x1806072A0")]
	public void RemoveClickShortCutKeyDown(SelectorManager.KeyType key_type)
	{
	}

	[Token(Token = "0x6001D43")]
	[Address(RVA = "0x607360", Offset = "0x606560", VA = "0x180607360")]
	public void RemoveClickShortCutKeyDown(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub)
	{
	}

	[Token(Token = "0x6001D44")]
	[Address(RVA = "0x607D80", Offset = "0x606F80", VA = "0x180607D80")]
	public void SetClickShortCutKeyRelease(SelectorManager.KeyType key_type)
	{
	}

	[Token(Token = "0x6001D45")]
	[Address(RVA = "0x607C40", Offset = "0x606E40", VA = "0x180607C40")]
	public void SetClickShortCutKeyRelease(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub)
	{
	}

	[Token(Token = "0x6001D46")]
	[Address(RVA = "0x607500", Offset = "0x606700", VA = "0x180607500")]
	public void RemoveClickShortCutKeyRelease(SelectorManager.KeyType key_type)
	{
	}

	[Token(Token = "0x6001D47")]
	[Address(RVA = "0x607430", Offset = "0x606630", VA = "0x180607430")]
	public void RemoveClickShortCutKeyRelease(SelectorManager.KeyType key_type_main, SelectorManager.KeyType key_type_sub)
	{
	}

	[Token(Token = "0x6001D48")]
	[Address(RVA = "0x608000", Offset = "0x607200", VA = "0x180608000")]
	public void SetClickShortCutMouseRelease(SelectorManager.MouseType mouse_type)
	{
	}

	[Token(Token = "0x6001D49")]
	[Address(RVA = "0x607680", Offset = "0x606880", VA = "0x180607680")]
	public void RemoveClickShortCutMouseRelease(SelectorManager.MouseType mouse_type)
	{
	}

	[Token(Token = "0x6001D4A")]
	[Address(RVA = "0x607EC0", Offset = "0x6070C0", VA = "0x180607EC0")]
	public void SetClickShortCutMouseDown(SelectorManager.MouseType mouse_type)
	{
	}

	[Token(Token = "0x6001D4B")]
	[Address(RVA = "0x6075C0", Offset = "0x6067C0", VA = "0x1806075C0")]
	public void RemoveClickShortCutMouseDown(SelectorManager.MouseType mouse_type)
	{
	}

	[Token(Token = "0x6001D4C")]
	[Address(RVA = "0x608720", Offset = "0x607920", VA = "0x180608720")]
	public SelectionButton()
	{
	}
}
