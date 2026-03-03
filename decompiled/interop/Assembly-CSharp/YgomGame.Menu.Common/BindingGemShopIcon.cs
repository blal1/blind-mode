using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.GemShop;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200142F")]
[RequireComponent(typeof(ElementObjectManager))]
[DisallowMultipleComponent]
public class BindingGemShopIcon : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x2001430")]
	[CompilerGenerated]
	private sealed class _003CyOnBindingRoutine_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C58E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C58F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C590")]
		[FieldOffset(Offset = "0x20")]
		public BindingGemShopIcon _003C_003E4__this;

		[Token(Token = "0x400C591")]
		[FieldOffset(Offset = "0x28")]
		private BindingImageEx _003CiconBinding_003E5__2;

		[Token(Token = "0x17001333")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007D7B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001334")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007D7D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007D78")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyOnBindingRoutine_003Ed__33(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007D79")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007D7A")]
		[Address(RVA = "0xC69440", Offset = "0xC68640", VA = "0x180C69440", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007D7C")]
		[Address(RVA = "0xC69850", Offset = "0xC68A50", VA = "0x180C69850", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C582")]
	private const string k_ELabelIconImage = "IconImage";

	[Token(Token = "0x400C583")]
	private const string k_ELabelEffectRoot = "EffectRoot";

	[Token(Token = "0x400C584")]
	private const string k_ELabelFxpPrefix = "fxp_UI_Gem";

	[Token(Token = "0x400C585")]
	private const string k_ELabelFxpFormat = "fxp_UI_Gem_{0:D2}";

	[Token(Token = "0x400C586")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int m_IconId;

	[Token(Token = "0x400C587")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private bool m_UseEffect;

	[Token(Token = "0x400C588")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GemShopIconSetting m_Setting;

	[Token(Token = "0x400C589")]
	[FieldOffset(Offset = "0x30")]
	private Image m_IconImageCache;

	[Token(Token = "0x400C58A")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_EffectRootCache;

	[Token(Token = "0x400C58B")]
	[FieldOffset(Offset = "0x40")]
	private bool m_Visible;

	[Token(Token = "0x400C58C")]
	[FieldOffset(Offset = "0x48")]
	private IEnumerator m_OnBindingRoutine;

	[Token(Token = "0x1700132E")]
	public int iconId
	{
		[Token(Token = "0x6007D66")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007D67")]
		[Address(RVA = "0xC5C390", Offset = "0xC5B590", VA = "0x180C5C390")]
		set
		{
		}
	}

	[Token(Token = "0x1700132F")]
	public Image iconImage
	{
		[Token(Token = "0x6007D68")]
		[Address(RVA = "0xC5C210", Offset = "0xC5B410", VA = "0x180C5C210")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001330")]
	public GameObject effectRoot
	{
		[Token(Token = "0x6007D69")]
		[Address(RVA = "0xC5C150", Offset = "0xC5B350", VA = "0x180C5C150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001331")]
	public bool visible
	{
		[Token(Token = "0x6007D6A")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007D6B")]
		[Address(RVA = "0xC5C3A0", Offset = "0xC5B5A0", VA = "0x180C5C3A0")]
		set
		{
		}
	}

	[Token(Token = "0x17001332")]
	public bool validIconId
	{
		[Token(Token = "0x6007D6C")]
		[Address(RVA = "0xC5C2E0", Offset = "0xC5B4E0", VA = "0x180C5C2E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1400009B")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6007D6D")]
		[Address(RVA = "0xC5C0B0", Offset = "0xC5B2B0", VA = "0x180C5C0B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6007D6E")]
		[Address(RVA = "0xC5C2F0", Offset = "0xC5B4F0", VA = "0x180C5C2F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6007D6F")]
	[Address(RVA = "0xC5BBC0", Offset = "0xC5ADC0", VA = "0x180C5BBC0", Slot = "7")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007D70")]
	[Address(RVA = "0xC5BB30", Offset = "0xC5AD30", VA = "0x180C5BB30")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007D71")]
	[Address(RVA = "0xC5BF60", Offset = "0xC5B160", VA = "0x180C5BF60")]
	private void Update()
	{
	}

	[Token(Token = "0x6007D72")]
	[Address(RVA = "0xC5BF70", Offset = "0xC5B170", VA = "0x180C5BF70")]
	private void VisibleRefresh()
	{
	}

	[Token(Token = "0x6007D73")]
	[Address(RVA = "0xC5BDB0", Offset = "0xC5AFB0", VA = "0x180C5BDB0")]
	public void SourceChanged()
	{
	}

	[Token(Token = "0x6007D74")]
	[Address(RVA = "0xC5BBF0", Offset = "0xC5ADF0", VA = "0x180C5BBF0")]
	public void OnRebind()
	{
	}

	[Token(Token = "0x6007D75")]
	[Address(RVA = "0xC5BCA0", Offset = "0xC5AEA0", VA = "0x180C5BCA0", Slot = "5")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007D76")]
	[Address(RVA = "0xC5C3B0", Offset = "0xC5B5B0", VA = "0x180C5C3B0")]
	[IteratorStateMachine(typeof(_003CyOnBindingRoutine_003Ed__33))]
	private IEnumerator yOnBindingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6007D77")]
	[Address(RVA = "0xC5C090", Offset = "0xC5B290", VA = "0x180C5C090")]
	public BindingGemShopIcon()
	{
	}
}
