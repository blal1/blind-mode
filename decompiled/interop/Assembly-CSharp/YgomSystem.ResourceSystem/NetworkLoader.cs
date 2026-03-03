using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002C1")]
public class NetworkLoader : BaseLoader
{
	[Token(Token = "0x20002C2")]
	[CompilerGenerated]
	private sealed class _003CLoadAsync_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F53")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F54")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F55")]
		[FieldOffset(Offset = "0x20")]
		public NetworkLoader _003C_003E4__this;

		[Token(Token = "0x4000F56")]
		[FieldOffset(Offset = "0x28")]
		public Resource res;

		[Token(Token = "0x4000F57")]
		[FieldOffset(Offset = "0x30")]
		private bool _003Cnetready_003E5__2;

		[Token(Token = "0x4000F58")]
		[FieldOffset(Offset = "0x38")]
		private UnityWebRequest _003Cwww_003E5__3;

		[Token(Token = "0x4000F59")]
		[FieldOffset(Offset = "0x40")]
		private float _003CendTime_003E5__4;

		[Token(Token = "0x4000F5A")]
		[FieldOffset(Offset = "0x48")]
		private AssetBundleCreateRequest _003CcreateReq_003E5__5;

		[Token(Token = "0x4000F5B")]
		[FieldOffset(Offset = "0x50")]
		private AssetBundle _003CassetBundle_003E5__6;

		[Token(Token = "0x4000F5C")]
		[FieldOffset(Offset = "0x58")]
		private AssetBundleRequest _003Creq_003E5__7;

		[Token(Token = "0x170001AE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60010D5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60010D7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010D1")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadAsync_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60010D2")]
		[Address(RVA = "0xE80F30", Offset = "0xE80130", VA = "0x180E80F30", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60010D3")]
		[Address(RVA = "0xE80280", Offset = "0xE7F480", VA = "0x180E80280", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60010D4")]
		[Address(RVA = "0xE80FC0", Offset = "0xE801C0", VA = "0x180E80FC0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x60010D6")]
		[Address(RVA = "0xE80EF0", Offset = "0xE800F0", VA = "0x180E80EF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000F50")]
	[FieldOffset(Offset = "0x10")]
	public ResourceManager.ProgressHandler progressHandler;

	[Token(Token = "0x4000F51")]
	[FieldOffset(Offset = "0x18")]
	public ResourceManager.RetryHandler retryHandler;

	[Token(Token = "0x4000F52")]
	[FieldOffset(Offset = "0x20")]
	public float HttpTimeOut;

	[Token(Token = "0x170001AD")]
	public override bool DisablePathForErrorHandler
	{
		[Token(Token = "0x60010CD")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60010CE")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "12")]
	public override void Load(Resource res, uint crc)
	{
	}

	[Token(Token = "0x60010CF")]
	[Address(RVA = "0xE701F0", Offset = "0xE6F3F0", VA = "0x180E701F0", Slot = "13")]
	[IteratorStateMachine(typeof(_003CLoadAsync_003Ed__6))]
	public override IEnumerator LoadAsync(Resource res, uint key)
	{
		return null;
	}

	[Token(Token = "0x60010D0")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public NetworkLoader()
	{
	}
}
