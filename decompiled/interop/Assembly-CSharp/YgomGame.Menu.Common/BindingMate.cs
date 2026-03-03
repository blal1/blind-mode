using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Bg;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001440")]
[RequireComponent(typeof(Image))]
public class BindingMate : BindingAsyncBase
{
	[Token(Token = "0x2001441")]
	[CompilerGenerated]
	private sealed class _003CyBindingRoutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C5E6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C5E7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C5E8")]
		[FieldOffset(Offset = "0x20")]
		public BindingMate _003C_003E4__this;

		[Token(Token = "0x1700135A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007E07")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700135B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007E09")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007E04")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyBindingRoutine_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007E05")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007E06")]
		[Address(RVA = "0xC7F870", Offset = "0xC7EA70", VA = "0x180C7F870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007E08")]
		[Address(RVA = "0xC7FBE0", Offset = "0xC7EDE0", VA = "0x180C7FBE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C5E2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int m_ItemId;

	[Token(Token = "0x400C5E3")]
	[FieldOffset(Offset = "0x38")]
	private AvatarModelSetting m_AvatarModelSetting;

	[Token(Token = "0x400C5E4")]
	[FieldOffset(Offset = "0x40")]
	private Image m_ImageCache;

	[Token(Token = "0x400C5E5")]
	[FieldOffset(Offset = "0x48")]
	private BindingImageDX m_BindingImageDXCache;

	[Token(Token = "0x17001357")]
	private Image image
	{
		[Token(Token = "0x6007DF9")]
		[Address(RVA = "0xC6C690", Offset = "0xC6B890", VA = "0x180C6C690")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001358")]
	public int itemId
	{
		[Token(Token = "0x6007DFA")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007DFB")]
		[Address(RVA = "0xC6C3D0", Offset = "0xC6B5D0", VA = "0x180C6C3D0")]
		set
		{
		}
	}

	[Token(Token = "0x17001359")]
	private BindingImageDX bindingImageDX
	{
		[Token(Token = "0x6007DFC")]
		[Address(RVA = "0xC6C5E0", Offset = "0xC6B7E0", VA = "0x180C6C5E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007DFD")]
	[Address(RVA = "0xC6C450", Offset = "0xC6B650", VA = "0x180C6C450")]
	public static BindingMate Binding(GameObject target, int itemid)
	{
		return null;
	}

	[Token(Token = "0x6007DFE")]
	[Address(RVA = "0xC6C4F0", Offset = "0xC6B6F0", VA = "0x180C6C4F0")]
	public static BindingMate Binding(Image target, int itemid)
	{
		return null;
	}

	[Token(Token = "0x6007DFF")]
	[Address(RVA = "0xC6C5A0", Offset = "0xC6B7A0", VA = "0x180C6C5A0", Slot = "16")]
	protected override void OnSourceChange()
	{
	}

	[Token(Token = "0x6007E00")]
	[Address(RVA = "0xC6C730", Offset = "0xC6B930", VA = "0x180C6C730", Slot = "17")]
	[IteratorStateMachine(typeof(_003CyBindingRoutine_003Ed__14))]
	protected override IEnumerator yBindingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6007E01")]
	[Address(RVA = "0xC6C570", Offset = "0xC6B770", VA = "0x180C6C570", Slot = "18")]
	protected override void OnReleaseResources()
	{
	}

	[Token(Token = "0x6007E02")]
	[Address(RVA = "0x422F60", Offset = "0x422160", VA = "0x180422F60")]
	public BindingMate()
	{
	}
}
