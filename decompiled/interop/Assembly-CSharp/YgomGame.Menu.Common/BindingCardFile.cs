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

[Token(Token = "0x2001417")]
public class BindingCardFile : BindingAsyncBase, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x2001418")]
	[CompilerGenerated]
	private sealed class _003CyBindingRoutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C50C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C50D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C50E")]
		[FieldOffset(Offset = "0x20")]
		public BindingCardFile _003C_003E4__this;

		[Token(Token = "0x1700131D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007CF4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700131E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007CF6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007CF1")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyBindingRoutine_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007CF2")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007CF3")]
		[Address(RVA = "0xC68B70", Offset = "0xC67D70", VA = "0x180C68B70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007CF5")]
		[Address(RVA = "0xC69110", Offset = "0xC68310", VA = "0x180C69110", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C506")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private CardFileBinder.CardFileType m_CardFileType;

	[Token(Token = "0x400C507")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private int m_ItemId;

	[Token(Token = "0x400C508")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int m_CompleteStatus;

	[Token(Token = "0x400C509")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool m_IsLarge;

	[Token(Token = "0x400C50A")]
	[FieldOffset(Offset = "0x3D")]
	[SerializeField]
	private bool m_IsBoxScale;

	[Token(Token = "0x400C50B")]
	[FieldOffset(Offset = "0x40")]
	private IBinding m_Binding;

	[Token(Token = "0x17001318")]
	public CardFileBinder.CardFileType bindingType
	{
		[Token(Token = "0x6007CE2")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840")]
		get
		{
			return default(CardFileBinder.CardFileType);
		}
		[Token(Token = "0x6007CE3")]
		[Address(RVA = "0xC55E90", Offset = "0xC55090", VA = "0x180C55E90")]
		set
		{
		}
	}

	[Token(Token = "0x17001319")]
	public int itemId
	{
		[Token(Token = "0x6007CE4")]
		[Address(RVA = "0x6333C0", Offset = "0x6325C0", VA = "0x1806333C0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007CE5")]
		[Address(RVA = "0xC56050", Offset = "0xC55250", VA = "0x180C56050")]
		set
		{
		}
	}

	[Token(Token = "0x1700131A")]
	public int completeStatus
	{
		[Token(Token = "0x6007CE6")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007CE7")]
		[Address(RVA = "0xC55F00", Offset = "0xC55100", VA = "0x180C55F00")]
		set
		{
		}
	}

	[Token(Token = "0x1700131B")]
	public bool isLarge
	{
		[Token(Token = "0x6007CE8")]
		[Address(RVA = "0x994170", Offset = "0x993370", VA = "0x180994170")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007CE9")]
		[Address(RVA = "0xC55FE0", Offset = "0xC551E0", VA = "0x180C55FE0")]
		set
		{
		}
	}

	[Token(Token = "0x1700131C")]
	public bool isBoxScale
	{
		[Token(Token = "0x6007CEA")]
		[Address(RVA = "0xC55E80", Offset = "0xC55080", VA = "0x180C55E80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007CEB")]
		[Address(RVA = "0xC55F70", Offset = "0xC55170", VA = "0x180C55F70")]
		set
		{
		}
	}

	[Token(Token = "0x6007CEC")]
	[Address(RVA = "0xC55CA0", Offset = "0xC54EA0", VA = "0x180C55CA0")]
	public static BindingCardFile Binding(Image target, int itemId, int completeStatus, bool isLarge = false, bool isBoxScale = false, CardFileBinder.CardFileType cardFileType = CardFileBinder.CardFileType.Icon)
	{
		return null;
	}

	[Token(Token = "0x6007CED")]
	[Address(RVA = "0xC55B20", Offset = "0xC54D20", VA = "0x180C55B20")]
	public static BindingCardFile Binding(GameObject target, int itemId, int completeStatus, bool isLarge = false, bool isBoxScale = false, CardFileBinder.CardFileType cardFileType = CardFileBinder.CardFileType.Icon)
	{
		return null;
	}

	[Token(Token = "0x6007CEE")]
	[Address(RVA = "0xC560C0", Offset = "0xC552C0", VA = "0x180C560C0", Slot = "17")]
	[IteratorStateMachine(typeof(_003CyBindingRoutine_003Ed__23))]
	protected override IEnumerator yBindingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6007CEF")]
	[Address(RVA = "0xC55E30", Offset = "0xC55030", VA = "0x180C55E30", Slot = "18")]
	protected override void OnReleaseResources()
	{
	}

	[Token(Token = "0x6007CF0")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public BindingCardFile()
	{
	}
}
