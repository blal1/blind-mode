using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x200119C")]
public class ToastMessageInform : InformContentBase
{
	[Token(Token = "0x200119D")]
	public enum IconType
	{
		[Token(Token = "0x400B844")]
		None,
		[Token(Token = "0x400B845")]
		Inform
	}

	[Token(Token = "0x20011A0")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B84B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B84C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B84D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ToastMessageInform _003C_003E4__this;

		[Token(Token = "0x1700116A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006EB2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700116B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006EB4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006EAF")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__33(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006EB0")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006EB1")]
		[Address(RVA = "0xB6C0F0", Offset = "0xB6B2F0", VA = "0x180B6C0F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006EB3")]
		[Address(RVA = "0xB6C3D0", Offset = "0xB6B5D0", VA = "0x180B6C3D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400B82D")]
	private const string k_PrefPath = "Common/ToastMessage/ToastMessage";

	[Token(Token = "0x400B82E")]
	private const string k_ArgKeyMessage = "message";

	[Token(Token = "0x400B82F")]
	private const string k_ArgKeyYPos = "yPos";

	[Token(Token = "0x400B830")]
	private const string k_ArgKeyIconType = "icon";

	[Token(Token = "0x400B831")]
	private const int k_SkipStep_Prepare = 0;

	[Token(Token = "0x400B832")]
	private const int k_SkipStep_ImmediateShow = 1;

	[Token(Token = "0x400B833")]
	private const int k_SkipStep_ImmediateEnd = 2;

	[Token(Token = "0x400B834")]
	internal const string k_ArgKeyCallback = "callback";

	[Token(Token = "0x400B835")]
	internal const string k_ArgKey_Skippable = "skippable";

	[Token(Token = "0x400B836")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelMessageText;

	[Token(Token = "0x400B837")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelIconImage;

	[Token(Token = "0x400B838")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelSkipBlockerRoot;

	[Token(Token = "0x400B839")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelSkipBlockerButton;

	[Token(Token = "0x400B83A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly string k_TweenShow;

	[Token(Token = "0x400B83B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly string k_TweenHide;

	[Token(Token = "0x400B83C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ViewCreater m_ViewCreater;

	[Token(Token = "0x400B83D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float m_LifeSecond;

	[Token(Token = "0x400B83E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Sprite m_InformSprite;

	[Token(Token = "0x400B83F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ElementObjectManager m_View;

	[Token(Token = "0x400B840")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool m_IsSkippable;

	[Token(Token = "0x400B841")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int m_SkipStep;

	[Token(Token = "0x400B842")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _end;

	[Token(Token = "0x6006E9B")]
	[Address(RVA = "0xB6AA00", Offset = "0xB69C00", VA = "0x180B6AA00")]
	private Sprite GetArgIcon()
	{
		return null;
	}

	[Token(Token = "0x6006E9C")]
	[Address(RVA = "0xB6B830", Offset = "0xB6AA30", VA = "0x180B6B830")]
	public static void OpenMulti([Optional] Action callback, params string[] messages)
	{
	}

	[Token(Token = "0x6006E9D")]
	[Address(RVA = "0xB6B860", Offset = "0xB6AA60", VA = "0x180B6B860")]
	public static void OpenMulti(IReadOnlyList<string> messages, [Optional] Action callback, int idx = 0, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006E9E")]
	[Address(RVA = "0xB6BB00", Offset = "0xB6AD00", VA = "0x180B6BB00")]
	public static void OpenWithBlock(string message, [Optional] Action callback)
	{
	}

	[Token(Token = "0x6006E9F")]
	[Address(RVA = "0xB6BBE0", Offset = "0xB6ADE0", VA = "0x180B6BBE0")]
	public static void Open(string message, [Optional] Action callback, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006EA0")]
	[Address(RVA = "0xB6BBF0", Offset = "0xB6ADF0", VA = "0x180B6BBF0")]
	public static void Open(string message, IconType iconType, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006EA1")]
	[Address(RVA = "0xB6BCD0", Offset = "0xB6AED0", VA = "0x180B6BCD0")]
	public static void Open(string message, float yPos, IconType iconType)
	{
	}

	[Token(Token = "0x6006EA2")]
	[Address(RVA = "0xB6AB10", Offset = "0xB69D10", VA = "0x180B6AB10")]
	private static void InnerOpen(string message, [Optional] Action callback, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006EA3")]
	[Address(RVA = "0xB6B6D0", Offset = "0xB6A8D0", VA = "0x180B6B6D0", Slot = "4")]
	public override void OnPush()
	{
	}

	[Token(Token = "0x6006EA4")]
	[Address(RVA = "0xB6B060", Offset = "0xB6A260", VA = "0x180B6B060")]
	private void OnCreatedView(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6006EA5")]
	[Address(RVA = "0xB6BE00", Offset = "0xB6B000", VA = "0x180B6BE00")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__33))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6006EA6")]
	[Address(RVA = "0xB6B610", Offset = "0xB6A810", VA = "0x180B6B610")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6006EA7")]
	[Address(RVA = "0xB6AF60", Offset = "0xB6A160", VA = "0x180B6AF60")]
	private void OnClickSkipBlocker()
	{
	}

	[Token(Token = "0x6006EA8")]
	[Address(RVA = "0xB6BF90", Offset = "0xB6B190", VA = "0x180B6BF90")]
	public ToastMessageInform()
	{
	}
}
