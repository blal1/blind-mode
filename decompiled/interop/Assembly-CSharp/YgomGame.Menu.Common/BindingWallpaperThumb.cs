using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001454")]
[RequireComponent(typeof(Image))]
[DisallowMultipleComponent]
public class BindingWallpaperThumb : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x2001455")]
	[CompilerGenerated]
	private sealed class _003CyOnBindingRoutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C66E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C66F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C670")]
		[FieldOffset(Offset = "0x20")]
		public BindingWallpaperThumb _003C_003E4__this;

		[Token(Token = "0x400C671")]
		[FieldOffset(Offset = "0x28")]
		private BindingImageEx _003CimageBInding_003E5__2;

		[Token(Token = "0x1700138F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007ECD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001390")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007ECF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007ECA")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyOnBindingRoutine_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007ECB")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007ECC")]
		[Address(RVA = "0xC82740", Offset = "0xC81940", VA = "0x180C82740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007ECE")]
		[Address(RVA = "0xC82890", Offset = "0xC81A90", VA = "0x180C82890", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C669")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int m_WallpaperId;

	[Token(Token = "0x400C66A")]
	[FieldOffset(Offset = "0x28")]
	private Image m_ImageCache;

	[Token(Token = "0x400C66B")]
	[FieldOffset(Offset = "0x30")]
	private bool m_Visible;

	[Token(Token = "0x400C66C")]
	[FieldOffset(Offset = "0x38")]
	private IEnumerator m_OnBindingRoutine;

	[Token(Token = "0x1700138B")]
	public int wallpaperId
	{
		[Token(Token = "0x6007EB9")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007EBA")]
		[Address(RVA = "0xC6FAA0", Offset = "0xC6ECA0", VA = "0x180C6FAA0")]
		set
		{
		}
	}

	[Token(Token = "0x1700138C")]
	public Image image
	{
		[Token(Token = "0x6007EBB")]
		[Address(RVA = "0xC6F960", Offset = "0xC6EB60", VA = "0x180C6F960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700138D")]
	public bool visible
	{
		[Token(Token = "0x6007EBC")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007EBD")]
		[Address(RVA = "0xC6FA90", Offset = "0xC6EC90", VA = "0x180C6FA90")]
		set
		{
		}
	}

	[Token(Token = "0x1700138E")]
	public bool validIconId
	{
		[Token(Token = "0x6007EBE")]
		[Address(RVA = "0x61B860", Offset = "0x61AA60", VA = "0x18061B860")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x140000A5")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6007EBF")]
		[Address(RVA = "0xC6F8C0", Offset = "0xC6EAC0", VA = "0x180C6F8C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6007EC0")]
		[Address(RVA = "0xC6F9F0", Offset = "0xC6EBF0", VA = "0x180C6F9F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6007EC1")]
	[Address(RVA = "0xC6F500", Offset = "0xC6E700", VA = "0x180C6F500", Slot = "7")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007EC2")]
	[Address(RVA = "0xC6F470", Offset = "0xC6E670", VA = "0x180C6F470")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007EC3")]
	[Address(RVA = "0xC6F800", Offset = "0xC6EA00", VA = "0x180C6F800")]
	private void Update()
	{
	}

	[Token(Token = "0x6007EC4")]
	[Address(RVA = "0xC6F810", Offset = "0xC6EA10", VA = "0x180C6F810")]
	private void VisibleRefresh()
	{
	}

	[Token(Token = "0x6007EC5")]
	[Address(RVA = "0xC6F6A0", Offset = "0xC6E8A0", VA = "0x180C6F6A0")]
	public void SourceChanged()
	{
	}

	[Token(Token = "0x6007EC6")]
	[Address(RVA = "0xC6F530", Offset = "0xC6E730", VA = "0x180C6F530")]
	public void OnRebind()
	{
	}

	[Token(Token = "0x6007EC7")]
	[Address(RVA = "0xC6F590", Offset = "0xC6E790", VA = "0x180C6F590", Slot = "5")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007EC8")]
	[Address(RVA = "0xC6FC10", Offset = "0xC6EE10", VA = "0x180C6FC10")]
	[IteratorStateMachine(typeof(_003CyOnBindingRoutine_003Ed__24))]
	private IEnumerator yOnBindingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6007EC9")]
	[Address(RVA = "0x51AA40", Offset = "0x519C40", VA = "0x18051AA40")]
	public BindingWallpaperThumb()
	{
	}
}
