using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002BD")]
public class BuiltInLoader : BaseLoader
{
	[Token(Token = "0x20002BE")]
	[CompilerGenerated]
	private sealed class _003CLoadAsync_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F4B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F4C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F4D")]
		[FieldOffset(Offset = "0x20")]
		public Resource res;

		[Token(Token = "0x4000F4E")]
		[FieldOffset(Offset = "0x28")]
		public BuiltInLoader _003C_003E4__this;

		[Token(Token = "0x4000F4F")]
		[FieldOffset(Offset = "0x30")]
		private ResourceRequest _003Creq_003E5__2;

		[Token(Token = "0x170001AA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60010C3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60010C5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010C0")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadAsync_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60010C1")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60010C2")]
		[Address(RVA = "0xE7F350", Offset = "0xE7E550", VA = "0x180E7F350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60010C4")]
		[Address(RVA = "0xE7F6D0", Offset = "0xE7E8D0", VA = "0x180E7F6D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x60010BD")]
	[Address(RVA = "0xE6C300", Offset = "0xE6B500", VA = "0x180E6C300", Slot = "12")]
	public override void Load(Resource res, uint crc)
	{
	}

	[Token(Token = "0x60010BE")]
	[Address(RVA = "0xE6C270", Offset = "0xE6B470", VA = "0x180E6C270", Slot = "13")]
	[IteratorStateMachine(typeof(_003CLoadAsync_003Ed__1))]
	public override IEnumerator LoadAsync(Resource res, uint key)
	{
		return null;
	}

	[Token(Token = "0x60010BF")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public BuiltInLoader()
	{
	}
}
