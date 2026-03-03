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

[Token(Token = "0x2001461")]
public class ColorContainerBinding : ColorContainer
{
	[Token(Token = "0x2001462")]
	[CompilerGenerated]
	private sealed class _003CSetupBindindgOutputRoutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C692")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C693")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C694")]
		[FieldOffset(Offset = "0x20")]
		public ColorContainerBinding _003C_003E4__this;

		[Token(Token = "0x17001392")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007EFE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001393")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007F00")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007EFB")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSetupBindindgOutputRoutine_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007EFC")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007EFD")]
		[Address(RVA = "0xC7E620", Offset = "0xC7D820", VA = "0x180C7E620", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007EFF")]
		[Address(RVA = "0xC7EBD0", Offset = "0xC7DDD0", VA = "0x180C7EBD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C68C")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Tooltip("制御下に置く親ボタンを設定")]
	private SelectionButton m_OwnerButton;

	[Token(Token = "0x400C68D")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Tooltip("出力されたObjectに既に設定されているColorContainerの値を上書きするかどうか")]
	private bool m_KeepOutputObjSetting;

	[Token(Token = "0x400C68E")]
	[FieldOffset(Offset = "0xF8")]
	private ILoadingIconHandler _targetBinding;

	[Token(Token = "0x400C68F")]
	[FieldOffset(Offset = "0x100")]
	private IEnumerator m_SetupBindindgOutputRoutine;

	[Token(Token = "0x400C690")]
	[FieldOffset(Offset = "0x108")]
	private List<Graphic> m_SearchGraphics;

	[Token(Token = "0x400C691")]
	[FieldOffset(Offset = "0x110")]
	private List<ColorContainerGraphic> m_SearchColorContainers;

	[Token(Token = "0x17001391")]
	public ILoadingIconHandler targetBinding
	{
		[Token(Token = "0x6007EF3")]
		[Address(RVA = "0xC736B0", Offset = "0xC728B0", VA = "0x180C736B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007EF4")]
	[Address(RVA = "0xC73620", Offset = "0xC72820", VA = "0x180C73620")]
	private void Start()
	{
	}

	[Token(Token = "0x6007EF5")]
	[Address(RVA = "0xC73630", Offset = "0xC72830", VA = "0x180C73630")]
	private void Update()
	{
	}

	[Token(Token = "0x6007EF6")]
	[Address(RVA = "0xC733B0", Offset = "0xC725B0", VA = "0x180C733B0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007EF7")]
	[Address(RVA = "0xC73540", Offset = "0xC72740", VA = "0x180C73540")]
	private void SetupBindingOutput()
	{
	}

	[Token(Token = "0x6007EF8")]
	[Address(RVA = "0xC73460", Offset = "0xC72660", VA = "0x180C73460")]
	private bool ProgressSetupBindindgOutputRoutine()
	{
		return default(bool);
	}

	[Token(Token = "0x6007EF9")]
	[Address(RVA = "0xC734D0", Offset = "0xC726D0", VA = "0x180C734D0")]
	[IteratorStateMachine(typeof(_003CSetupBindindgOutputRoutine_003Ed__13))]
	private IEnumerator SetupBindindgOutputRoutine()
	{
		return null;
	}

	[Token(Token = "0x6007EFA")]
	[Address(RVA = "0x5FB770", Offset = "0x5FA970", VA = "0x1805FB770")]
	public ColorContainerBinding()
	{
	}
}
