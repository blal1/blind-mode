using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem;

[Token(Token = "0x200016A")]
public class ShaderResourceCache
{
	[Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[Token(Token = "0x4000898")]
		[FieldOffset(Offset = "0x10")]
		public List<Material> mtrlAssets;

		[Token(Token = "0x4000899")]
		[FieldOffset(Offset = "0x18")]
		public bool loading;

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0xB0B720", Offset = "0xB0A920", VA = "0x180B0B720")]
		internal void _003CInitializeImpl_003Eb__0(string resPath)
		{
		}
	}

	[Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class _003CInitializeImpl_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400089A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400089B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400089C")]
		[FieldOffset(Offset = "0x20")]
		public ShaderResourceCache _003C_003E4__this;

		[Token(Token = "0x400089D")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

		[Token(Token = "0x400089E")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, Shader> _003CcachingShaders_003E5__2;

		[Token(Token = "0x400089F")]
		[FieldOffset(Offset = "0x38")]
		private int _003CnumCachings_003E5__3;

		[Token(Token = "0x40008A0")]
		[FieldOffset(Offset = "0x40")]
		private List<Material>.Enumerator _003C_003E7__wrap3;

		[Token(Token = "0x170000FA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000940")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000942")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitializeImpl_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0xB0A0B0", Offset = "0xB092B0", VA = "0x180B0A0B0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0xB09AC0", Offset = "0xB08CC0", VA = "0x180B09AC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0xB0A140", Offset = "0xB09340", VA = "0x180B0A140")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0xB0A070", Offset = "0xB09270", VA = "0x180B0A070", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000893")]
	[FieldOffset(Offset = "0x10")]
	public Material[] preloadMaterials;

	[Token(Token = "0x4000894")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, Shader> shaders;

	[Token(Token = "0x4000895")]
	public const string shaderSetResPath = "BundleMaterials/MaterialPack.Unity2018_4_2f1";

	[Token(Token = "0x4000896")]
	[FieldOffset(Offset = "0x0")]
	private static ShaderResourceCache m_instance;

	[Token(Token = "0x170000F8")]
	public static ShaderResourceCache instance
	{
		[Token(Token = "0x6000931")]
		[Address(RVA = "0xB047F0", Offset = "0xB039F0", VA = "0x180B047F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000F9")]
	public bool busy
	{
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000935")]
		[Address(RVA = "0x4166E0", Offset = "0x4158E0", VA = "0x1804166E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000932")]
	[Address(RVA = "0xB047D0", Offset = "0xB039D0", VA = "0x180B047D0")]
	public ShaderResourceCache()
	{
	}

	[Token(Token = "0x6000933")]
	[Address(RVA = "0xB04700", Offset = "0xB03900", VA = "0x180B04700")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000936")]
	[Address(RVA = "0xB04690", Offset = "0xB03890", VA = "0x180B04690")]
	[IteratorStateMachine(typeof(_003CInitializeImpl_003Ed__12))]
	private IEnumerator InitializeImpl()
	{
		return null;
	}

	[Token(Token = "0x6000937")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void Terminate()
	{
	}

	[Token(Token = "0x6000938")]
	[Address(RVA = "0xB045C0", Offset = "0xB037C0", VA = "0x180B045C0")]
	public Shader GetShader(string shaderLabel)
	{
		return null;
	}

	[Token(Token = "0x6000939")]
	[Address(RVA = "0xB04480", Offset = "0xB03680", VA = "0x180B04480")]
	private Shader GetShaderImpl(string shaderLabel)
	{
		return null;
	}
}
