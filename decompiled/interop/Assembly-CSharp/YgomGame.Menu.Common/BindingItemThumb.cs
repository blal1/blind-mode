using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using YgomSystem.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200143A")]
public class BindingItemThumb : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x200143B")]
	public enum BindingStep
	{
		[Token(Token = "0x400C5D6")]
		PreBegin
	}

	[Token(Token = "0x200143C")]
	public interface IHandler
	{
		[Token(Token = "0x6007DF5")]
		void OnBindingItemThumb(BindingItemThumb bindingItemThumb, BindingStep bindingStep);
	}

	[Token(Token = "0x200143D")]
	public enum IconStyle
	{
		[Token(Token = "0x400C5D8")]
		Normal = 0,
		[Token(Token = "0x400C5D9")]
		Box = 1,
		[Token(Token = "0x400C5DA")]
		LegacyBox = 100
	}

	[Token(Token = "0x200143E")]
	public enum DxBadgeMode
	{
		[Token(Token = "0x400C5DC")]
		None,
		[Token(Token = "0x400C5DD")]
		Floating,
		[Token(Token = "0x400C5DE")]
		Based
	}

	[Token(Token = "0x400C5C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool m_IsPeriod;

	[Token(Token = "0x400C5C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int m_ItemCategory;

	[Token(Token = "0x400C5C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int m_ItemId;

	[Token(Token = "0x400C5C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private bool m_IsLargeIcon;

	[Token(Token = "0x400C5C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	[SerializeField]
	[FormerlySerializedAs("m_IconScaleEnabled")]
	private bool m_IsBoxScale;

	[Token(Token = "0x400C5C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private IconStyle m_IconStyle;

	[Token(Token = "0x400C5CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private DxBadgeMode m_DxBadgeMode;

	[Token(Token = "0x400C5CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool m_IsReverse;

	[Token(Token = "0x400C5CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	[SerializeField]
	private bool m_UseLargeDeckCase;

	[Token(Token = "0x400C5CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<GameObject> m_BindingHandlers;

	[Token(Token = "0x400C5CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Dictionary<string, object> m_ItemArgs;

	[Token(Token = "0x400C5CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool m_LoadOnStart;

	[Token(Token = "0x400C5D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool m_DirtyChild;

	[Token(Token = "0x400C5D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject m_BindChild;

	[Token(Token = "0x400C5D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject m_DXBadge;

	[Token(Token = "0x400C5D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private IAsyncProgressContent m_BindProgress;

	[Token(Token = "0x1700134E")]
	public bool isPeriod
	{
		[Token(Token = "0x6007DDD")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700134F")]
	public int itemCategory
	{
		[Token(Token = "0x6007DDE")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001350")]
	public int itemId
	{
		[Token(Token = "0x6007DDF")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001351")]
	public bool isLargeIcon
	{
		[Token(Token = "0x6007DE0")]
		[Address(RVA = "0x66A190", Offset = "0x669390", VA = "0x18066A190")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007DE1")]
		[Address(RVA = "0x6B2310", Offset = "0x6B1510", VA = "0x1806B2310")]
		set
		{
		}
	}

	[Token(Token = "0x17001352")]
	public bool isBoxScale
	{
		[Token(Token = "0x6007DE2")]
		[Address(RVA = "0xC5F940", Offset = "0xC5EB40", VA = "0x180C5F940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007DE3")]
		[Address(RVA = "0xC5F9F0", Offset = "0xC5EBF0", VA = "0x180C5F9F0")]
		set
		{
		}
	}

	[Token(Token = "0x17001353")]
	public bool useLargeDeckCase
	{
		[Token(Token = "0x6007DE4")]
		[Address(RVA = "0x689960", Offset = "0x688B60", VA = "0x180689960")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007DE5")]
		[Address(RVA = "0x74E7C0", Offset = "0x74D9C0", VA = "0x18074E7C0")]
		set
		{
		}
	}

	[Token(Token = "0x17001354")]
	public bool IsDxBadgeItem
	{
		[Token(Token = "0x6007DE6")]
		[Address(RVA = "0xC5F900", Offset = "0xC5EB00", VA = "0x180C5F900")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001355")]
	public Dictionary<string, object> itemArgs
	{
		[Token(Token = "0x6007DE7")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007DE8")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		set
		{
		}
	}

	[Token(Token = "0x17001356")]
	public bool visible
	{
		[Token(Token = "0x6007DE9")]
		[Address(RVA = "0x521190", Offset = "0x520390", VA = "0x180521190", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1400009E")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6007DEA")]
		[Address(RVA = "0xC5F860", Offset = "0xC5EA60", VA = "0x180C5F860", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6007DEB")]
		[Address(RVA = "0xC5F950", Offset = "0xC5EB50", VA = "0x180C5F950", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6007DEC")]
	[Address(RVA = "0xC5EC10", Offset = "0xC5DE10", VA = "0x180C5EC10")]
	public static BindingItemThumb Binding(GameObject target, bool isPeriod, int itemCategory, int itemId, bool isLargeIcon = false, DxBadgeMode dxBadgeMode = DxBadgeMode.None, bool isBoxScale = false, bool useLargeDeckCase = false, [Optional] Dictionary<string, object> itemArgs)
	{
		return null;
	}

	[Token(Token = "0x6007DED")]
	[Address(RVA = "0xC5F6E0", Offset = "0xC5E8E0", VA = "0x180C5F6E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6007DEE")]
	[Address(RVA = "0xC5F700", Offset = "0xC5E900", VA = "0x180C5F700")]
	private void UpdateData(bool isPeriod, int itemCategory, int itemId, bool isLargeIcon, DxBadgeMode dxBadgeMode = DxBadgeMode.None, bool isReverse = false, bool useLargeDeckCase = false)
	{
	}

	[Token(Token = "0x6007DEF")]
	[Address(RVA = "0xC5EDA0", Offset = "0xC5DFA0", VA = "0x180C5EDA0")]
	private void LoadItemThumb()
	{
	}

	[Token(Token = "0x6007DF0")]
	[Address(RVA = "0xC5F780", Offset = "0xC5E980", VA = "0x180C5F780", Slot = "7")]
	private bool YgomSystem_002EUI_002EILoadingIconHandler_002EIsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007DF1")]
	[Address(RVA = "0xC5ED20", Offset = "0xC5DF20", VA = "0x180C5ED20", Slot = "4")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007DF2")]
	[Address(RVA = "0xC5F520", Offset = "0xC5E720", VA = "0x180C5F520", Slot = "5")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007DF3")]
	[Address(RVA = "0xC5F570", Offset = "0xC5E770", VA = "0x180C5F570")]
	private void SendBindBindingHandler(BindingStep bindingStep)
	{
	}

	[Token(Token = "0x6007DF4")]
	[Address(RVA = "0xC5F840", Offset = "0xC5EA40", VA = "0x180C5F840")]
	public BindingItemThumb()
	{
	}
}
