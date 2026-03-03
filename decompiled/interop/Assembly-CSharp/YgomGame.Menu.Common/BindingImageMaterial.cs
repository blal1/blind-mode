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

[Token(Token = "0x2001436")]
[RequireComponent(typeof(Image))]
public class BindingImageMaterial : BindingAsyncBase, IAsyncProgressContent, ILoadingIconHandler, IMaterialModifier
{
	[Token(Token = "0x2001437")]
	[CompilerGenerated]
	private sealed class _003CyBindingRoutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C5B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C5B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C5B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BindingImageMaterial _003C_003E4__this;

		[Token(Token = "0x400C5B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private uint _003CspriteCrc_003E5__2;

		[Token(Token = "0x400C5B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private uint _003CmaterialCrc_003E5__3;

		[Token(Token = "0x17001344")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007DC1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001345")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007DC3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007DBE")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyBindingRoutine_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007DBF")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007DC0")]
		[Address(RVA = "0xC69190", Offset = "0xC68390", VA = "0x180C69190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007DC2")]
		[Address(RVA = "0xC69400", Offset = "0xC68600", VA = "0x180C69400", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C5AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string m_SpritePath;

	[Token(Token = "0x400C5AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string m_MaterialPath;

	[Token(Token = "0x400C5AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool m_InstantiateMaterial;

	[Token(Token = "0x400C5AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private AspectRatioFitter.AspectMode m_AspectMode;

	[Token(Token = "0x400C5AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Image m_ImageCache;

	[Token(Token = "0x400C5AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material m_AssignMaterial;

	[Token(Token = "0x400C5B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material m_InstantiatedMaterial;

	[Token(Token = "0x400C5B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private uint m_UsingSpriteCrc;

	[Token(Token = "0x400C5B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private uint m_UsingMaterialCrc;

	[Token(Token = "0x1700133E")]
	private Image image
	{
		[Token(Token = "0x6007DAB")]
		[Address(RVA = "0xC5E1F0", Offset = "0xC5D3F0", VA = "0x180C5E1F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700133F")]
	public string spritePath
	{
		[Token(Token = "0x6007DAC")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007DAD")]
		[Address(RVA = "0xC5CE20", Offset = "0xC5C020", VA = "0x180C5CE20")]
		set
		{
		}
	}

	[Token(Token = "0x17001340")]
	public string materialPath
	{
		[Token(Token = "0x6007DAE")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007DAF")]
		[Address(RVA = "0xC5CEB0", Offset = "0xC5C0B0", VA = "0x180C5CEB0")]
		set
		{
		}
	}

	[Token(Token = "0x17001341")]
	public bool instantiateMaterial
	{
		[Token(Token = "0x6007DB0")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007DB1")]
		[Address(RVA = "0xC5E2A0", Offset = "0xC5D4A0", VA = "0x180C5E2A0")]
		set
		{
		}
	}

	[Token(Token = "0x17001342")]
	public bool existsMaterialPath
	{
		[Token(Token = "0x6007DB2")]
		[Address(RVA = "0xC5CD50", Offset = "0xC5BF50", VA = "0x180C5CD50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001343")]
	public AspectRatioFitter.AspectMode aspectMode
	{
		[Token(Token = "0x6007DB3")]
		[Address(RVA = "0x5FA7A0", Offset = "0x5F99A0", VA = "0x1805FA7A0")]
		get
		{
			return default(AspectRatioFitter.AspectMode);
		}
		[Token(Token = "0x6007DB4")]
		[Address(RVA = "0xC5E290", Offset = "0xC5D490", VA = "0x180C5E290")]
		set
		{
		}
	}

	[Token(Token = "0x6007DB5")]
	[Address(RVA = "0xC5D970", Offset = "0xC5CB70", VA = "0x180C5D970")]
	public static BindingImageMaterial Binding(GameObject target, string spritePath, [Optional] string subSpritePath, AspectRatioFitter.AspectMode aspectMode = AspectRatioFitter.AspectMode.None)
	{
		return null;
	}

	[Token(Token = "0x6007DB6")]
	[Address(RVA = "0xC5DB30", Offset = "0xC5CD30", VA = "0x180C5DB30")]
	public static BindingImageMaterial Binding(Image target, string spritePath, [Optional] string materialPath, AspectRatioFitter.AspectMode aspectMode = AspectRatioFitter.AspectMode.None, bool instantiateMaterial = false)
	{
		return null;
	}

	[Token(Token = "0x6007DB7")]
	[Address(RVA = "0xC5E310", Offset = "0xC5D510", VA = "0x180C5E310", Slot = "17")]
	[IteratorStateMachine(typeof(_003CyBindingRoutine_003Ed__27))]
	protected override IEnumerator yBindingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6007DB8")]
	[Address(RVA = "0xC5DD40", Offset = "0xC5CF40", VA = "0x180C5DD40", Slot = "18")]
	protected override void OnReleaseResources()
	{
	}

	[Token(Token = "0x6007DB9")]
	[Address(RVA = "0xC5DCC0", Offset = "0xC5CEC0", VA = "0x180C5DCC0", Slot = "19")]
	public Material GetModifiedMaterial(Material baseMaterial)
	{
		return null;
	}

	[Token(Token = "0x6007DBA")]
	[Address(RVA = "0xC5DEC0", Offset = "0xC5D0C0", VA = "0x180C5DEC0")]
	protected bool TryBinding()
	{
		return default(bool);
	}

	[Token(Token = "0x6007DBB")]
	[Address(RVA = "0xC5D790", Offset = "0xC5C990", VA = "0x180C5D790")]
	private void ApplyAspectRatio()
	{
	}

	[Token(Token = "0x6007DBC")]
	[Address(RVA = "0xC5DDF0", Offset = "0xC5CFF0", VA = "0x180C5DDF0")]
	private void Release()
	{
	}

	[Token(Token = "0x6007DBD")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public BindingImageMaterial()
	{
	}
}
