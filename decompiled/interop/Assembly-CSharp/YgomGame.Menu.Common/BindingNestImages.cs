using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200144B")]
[RequireComponent(typeof(Image))]
public class BindingNestImages : BindingAsyncBase
{
	[Token(Token = "0x200144C")]
	[CompilerGenerated]
	private sealed class _003CyBindingRoutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C631")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C632")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C633")]
		[FieldOffset(Offset = "0x20")]
		public BindingNestImages _003C_003E4__this;

		[Token(Token = "0x400C634")]
		[FieldOffset(Offset = "0x28")]
		private List<string>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x400C635")]
		[FieldOffset(Offset = "0x40")]
		private string _003CusingSpritePath_003E5__3;

		[Token(Token = "0x17001375")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007E67")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001376")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007E69")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007E63")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyBindingRoutine_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007E64")]
		[Address(RVA = "0xC80360", Offset = "0xC7F560", VA = "0x180C80360", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007E65")]
		[Address(RVA = "0xC7FC20", Offset = "0xC7EE20", VA = "0x180C7FC20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007E66")]
		[Address(RVA = "0xC803F0", Offset = "0xC7F5F0", VA = "0x180C803F0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6007E68")]
		[Address(RVA = "0xC80320", Offset = "0xC7F520", VA = "0x180C80320", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C62C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<string> m_SpritePaths;

	[Token(Token = "0x400C62D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AspectRatioFitter.AspectMode m_AspectMode;

	[Token(Token = "0x400C62E")]
	[FieldOffset(Offset = "0x40")]
	private Image m_ImageCache;

	[Token(Token = "0x400C62F")]
	[FieldOffset(Offset = "0x48")]
	private List<string> m_UsingSpritePaths;

	[Token(Token = "0x400C630")]
	[FieldOffset(Offset = "0x50")]
	private List<Image> m_ChildImages;

	[Token(Token = "0x17001371")]
	public List<string> spritePaths
	{
		[Token(Token = "0x6007E53")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001372")]
	private Image image
	{
		[Token(Token = "0x6007E54")]
		[Address(RVA = "0xC6D5C0", Offset = "0xC6C7C0", VA = "0x180C6D5C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001373")]
	public AspectRatioFitter.AspectMode aspectMode
	{
		[Token(Token = "0x6007E55")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450")]
		get
		{
			return default(AspectRatioFitter.AspectMode);
		}
		[Token(Token = "0x6007E56")]
		[Address(RVA = "0xC6D660", Offset = "0xC6C860", VA = "0x180C6D660")]
		set
		{
		}
	}

	[Token(Token = "0x17001374")]
	public bool IsValidSource
	{
		[Token(Token = "0x6007E57")]
		[Address(RVA = "0xC6D570", Offset = "0xC6C770", VA = "0x180C6D570")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6007E58")]
	[Address(RVA = "0xC6CB60", Offset = "0xC6BD60", VA = "0x180C6CB60")]
	public static BindingNestImages Binding(GameObject target, AspectRatioFitter.AspectMode aspectMode, params string[] spritePaths)
	{
		return null;
	}

	[Token(Token = "0x6007E59")]
	[Address(RVA = "0xC6CA80", Offset = "0xC6BC80", VA = "0x180C6CA80")]
	public static BindingNestImages Binding(Image target, AspectRatioFitter.AspectMode aspectMode, params string[] spritePaths)
	{
		return null;
	}

	[Token(Token = "0x6007E5A")]
	[Address(RVA = "0xC6D670", Offset = "0xC6C870", VA = "0x180C6D670", Slot = "17")]
	[IteratorStateMachine(typeof(_003CyBindingRoutine_003Ed__16))]
	protected override IEnumerator yBindingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6007E5B")]
	[Address(RVA = "0xC6CE60", Offset = "0xC6C060", VA = "0x180C6CE60", Slot = "18")]
	protected override void OnReleaseResources()
	{
	}

	[Token(Token = "0x6007E5C")]
	[Address(RVA = "0xC6D1B0", Offset = "0xC6C3B0", VA = "0x180C6D1B0")]
	protected bool TryBinding()
	{
		return default(bool);
	}

	[Token(Token = "0x6007E5D")]
	[Address(RVA = "0xC6D320", Offset = "0xC6C520", VA = "0x180C6D320")]
	private void UpdateChildrenCount(int cnt)
	{
	}

	[Token(Token = "0x6007E5E")]
	[Address(RVA = "0xC6CBD0", Offset = "0xC6BDD0", VA = "0x180C6CBD0")]
	private Image CreateChild()
	{
		return null;
	}

	[Token(Token = "0x6007E5F")]
	[Address(RVA = "0xC6C960", Offset = "0xC6BB60", VA = "0x180C6C960")]
	private void ApplyAspectRatio()
	{
	}

	[Token(Token = "0x6007E60")]
	[Address(RVA = "0xC6C7A0", Offset = "0xC6B9A0", VA = "0x180C6C7A0")]
	private void ApplyAspectRatio(Image targetImage)
	{
	}

	[Token(Token = "0x6007E61")]
	[Address(RVA = "0xC6D060", Offset = "0xC6C260", VA = "0x180C6D060")]
	private void Release()
	{
	}

	[Token(Token = "0x6007E62")]
	[Address(RVA = "0xC6D4F0", Offset = "0xC6C6F0", VA = "0x180C6D4F0")]
	public BindingNestImages()
	{
	}
}
