using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001431")]
[RequireComponent(typeof(Image))]
public class BindingImageDX : BindingAsyncBase, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x2001432")]
	[CompilerGenerated]
	private sealed class _003CyBindingRoutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C59A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C59B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C59C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BindingImageDX _003C_003E4__this;

		[Token(Token = "0x400C59D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private uint _003CspriteCrc_003E5__2;

		[Token(Token = "0x400C59E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private uint _003CsubSpriteCrc_003E5__3;

		[Token(Token = "0x1700133A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007D91")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700133B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007D93")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007D8E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyBindingRoutine_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007D8F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007D90")]
		[Address(RVA = "0xC68E20", Offset = "0xC68020", VA = "0x180C68E20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007D92")]
		[Address(RVA = "0xC69150", Offset = "0xC68350", VA = "0x180C69150", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C592")]
	private const string k_MaterialPath = "Images/Materials/ImageDX";

	[Token(Token = "0x400C593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string m_SpritePath;

	[Token(Token = "0x400C594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string m_SubSpritePath;

	[Token(Token = "0x400C595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AspectRatioFitter.AspectMode m_AspectMode;

	[Token(Token = "0x400C596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Image m_ImageCache;

	[Token(Token = "0x400C597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material m_ModifiedMaterial;

	[Token(Token = "0x400C598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private uint m_UsingSpriteCrc;

	[Token(Token = "0x400C599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private uint m_UsingSubSpriteCrc;

	[Token(Token = "0x17001335")]
	private Image image
	{
		[Token(Token = "0x6007D7E")]
		[Address(RVA = "0xC5CD70", Offset = "0xC5BF70", VA = "0x180C5CD70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001336")]
	public string spritePath
	{
		[Token(Token = "0x6007D7F")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007D80")]
		[Address(RVA = "0xC5CE20", Offset = "0xC5C020", VA = "0x180C5CE20")]
		set
		{
		}
	}

	[Token(Token = "0x17001337")]
	public string subSpritePath
	{
		[Token(Token = "0x6007D81")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007D82")]
		[Address(RVA = "0xC5CEB0", Offset = "0xC5C0B0", VA = "0x180C5CEB0")]
		set
		{
		}
	}

	[Token(Token = "0x17001338")]
	public bool existsSubSprite
	{
		[Token(Token = "0x6007D83")]
		[Address(RVA = "0xC5CD50", Offset = "0xC5BF50", VA = "0x180C5CD50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001339")]
	public AspectRatioFitter.AspectMode aspectMode
	{
		[Token(Token = "0x6007D84")]
		[Address(RVA = "0x5FA7B0", Offset = "0x5F99B0", VA = "0x1805FA7B0")]
		get
		{
			return default(AspectRatioFitter.AspectMode);
		}
		[Token(Token = "0x6007D85")]
		[Address(RVA = "0xC5CE10", Offset = "0xC5C010", VA = "0x180C5CE10")]
		set
		{
		}
	}

	[Token(Token = "0x6007D86")]
	[Address(RVA = "0xC5C800", Offset = "0xC5BA00", VA = "0x180C5C800")]
	public static BindingImageDX Binding(GameObject target, string spritePath, [Optional] string subSpritePath, AspectRatioFitter.AspectMode aspectMode = AspectRatioFitter.AspectMode.None)
	{
		return null;
	}

	[Token(Token = "0x6007D87")]
	[Address(RVA = "0xC5C600", Offset = "0xC5B800", VA = "0x180C5C600")]
	public static BindingImageDX Binding(Image target, string spritePath, [Optional] string subSpritePath, AspectRatioFitter.AspectMode aspectMode = AspectRatioFitter.AspectMode.None)
	{
		return null;
	}

	[Token(Token = "0x6007D88")]
	[Address(RVA = "0xC5CF40", Offset = "0xC5C140", VA = "0x180C5CF40", Slot = "17")]
	[IteratorStateMachine(typeof(_003CyBindingRoutine_003Ed__23))]
	protected override IEnumerator yBindingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6007D89")]
	[Address(RVA = "0xC5C880", Offset = "0xC5BA80", VA = "0x180C5C880", Slot = "18")]
	protected override void OnReleaseResources()
	{
	}

	[Token(Token = "0x6007D8A")]
	[Address(RVA = "0xC5C9F0", Offset = "0xC5BBF0", VA = "0x180C5C9F0")]
	protected bool TryBinding()
	{
		return default(bool);
	}

	[Token(Token = "0x6007D8B")]
	[Address(RVA = "0xC5C420", Offset = "0xC5B620", VA = "0x180C5C420")]
	private void ApplyAspectRatio()
	{
	}

	[Token(Token = "0x6007D8C")]
	[Address(RVA = "0xC5C920", Offset = "0xC5BB20", VA = "0x180C5C920")]
	private void Release()
	{
	}

	[Token(Token = "0x6007D8D")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public BindingImageDX()
	{
	}
}
