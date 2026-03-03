using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002B7")]
public abstract class BaseLoader : IResourceLoader
{
	[Token(Token = "0x20002B8")]
	[CompilerGenerated]
	private sealed class _003CLoadAsync_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F3E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F3F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x170001A4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60010A6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60010A8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010A3")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadAsync_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60010A4")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60010A5")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60010A7")]
		[Address(RVA = "0xE80240", Offset = "0xE7F440", VA = "0x180E80240", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x170001A3")]
	public virtual bool DisablePathForErrorHandler
	{
		[Token(Token = "0x6001099")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600109A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "11")]
	public virtual void Initialize()
	{
	}

	[Token(Token = "0x600109B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "12")]
	public virtual void Load(Resource res, uint crc)
	{
	}

	[Token(Token = "0x600109C")]
	[Address(RVA = "0xE6B7D0", Offset = "0xE6A9D0", VA = "0x180E6B7D0", Slot = "13")]
	[IteratorStateMachine(typeof(_003CLoadAsync_003Ed__4))]
	public virtual IEnumerator LoadAsync(Resource res, uint crc)
	{
		return null;
	}

	[Token(Token = "0x600109D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	public virtual void LateUpdate()
	{
	}

	[Token(Token = "0x600109E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "15")]
	public virtual void ClearCache()
	{
	}

	[Token(Token = "0x600109F")]
	[Address(RVA = "0xE6BA40", Offset = "0xE6AC40", VA = "0x180E6BA40")]
	protected byte[] decompressedData(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x60010A0")]
	[Address(RVA = "0xE6B9D0", Offset = "0xE6ABD0", VA = "0x180E6B9D0")]
	protected byte[] decompressedData(TextAsset textasset)
	{
		return null;
	}

	[Token(Token = "0x60010A1")]
	[Address(RVA = "0xE6B820", Offset = "0xE6AA20", VA = "0x180E6B820")]
	protected bool checkLoadedAssets(Resource res)
	{
		return default(bool);
	}

	[Token(Token = "0x60010A2")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected BaseLoader()
	{
	}
}
