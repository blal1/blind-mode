using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.LocalFileSystem;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002B9")]
public class BinaryLoader : BaseLoader
{
	[Token(Token = "0x20002BB")]
	[CompilerGenerated]
	private sealed class _003CLoadAsync_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F41")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F42")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F43")]
		[FieldOffset(Offset = "0x20")]
		public Resource res;

		[Token(Token = "0x4000F44")]
		[FieldOffset(Offset = "0x28")]
		public BinaryLoader _003C_003E4__this;

		[Token(Token = "0x170001A6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60010B4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60010B6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010B1")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadAsync_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60010B2")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60010B3")]
		[Address(RVA = "0xE7F1E0", Offset = "0xE7E3E0", VA = "0x180E7F1E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60010B5")]
		[Address(RVA = "0xE7F710", Offset = "0xE7E910", VA = "0x180E7F710", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20002BC")]
	[CompilerGenerated]
	private sealed class _003CLoadFromStreamFile_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F45")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F46")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F47")]
		[FieldOffset(Offset = "0x20")]
		public string path;

		[Token(Token = "0x4000F48")]
		[FieldOffset(Offset = "0x28")]
		public Action<byte[]> callback;

		[Token(Token = "0x4000F49")]
		[FieldOffset(Offset = "0x30")]
		private LocalFileStream _003Cfs_003E5__2;

		[Token(Token = "0x4000F4A")]
		[FieldOffset(Offset = "0x38")]
		private ReadRequest _003Crequest_003E5__3;

		[Token(Token = "0x170001A8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60010BA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60010BC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010B7")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadFromStreamFile_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60010B8")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60010B9")]
		[Address(RVA = "0xE815A0", Offset = "0xE807A0", VA = "0x180E815A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60010BB")]
		[Address(RVA = "0xE81710", Offset = "0xE80910", VA = "0x180E81710", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x60010A9")]
	[Address(RVA = "0xE6BC00", Offset = "0xE6AE00", VA = "0x180E6BC00", Slot = "12")]
	public override void Load(Resource res, uint crc)
	{
	}

	[Token(Token = "0x60010AA")]
	[Address(RVA = "0xE6BA90", Offset = "0xE6AC90", VA = "0x180E6BA90", Slot = "13")]
	[IteratorStateMachine(typeof(_003CLoadAsync_003Ed__1))]
	public override IEnumerator LoadAsync(Resource res, uint key)
	{
		return null;
	}

	[Token(Token = "0x60010AB")]
	[Address(RVA = "0xE6BB20", Offset = "0xE6AD20", VA = "0x180E6BB20", Slot = "16")]
	protected virtual byte[] LoadFromFile(string path)
	{
		return null;
	}

	[Token(Token = "0x60010AC")]
	[Address(RVA = "0x52F690", Offset = "0x52E890", VA = "0x18052F690", Slot = "17")]
	protected virtual string GetNativePath(string path)
	{
		return null;
	}

	[Token(Token = "0x60010AD")]
	[Address(RVA = "0xE6BB70", Offset = "0xE6AD70", VA = "0x180E6BB70", Slot = "18")]
	[IteratorStateMachine(typeof(_003CLoadFromStreamFile_003Ed__4))]
	protected virtual IEnumerator LoadFromStreamFile(string path, Action<byte[]> callback)
	{
		return null;
	}

	[Token(Token = "0x60010AE")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public BinaryLoader()
	{
	}
}
