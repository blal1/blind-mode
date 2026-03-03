using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002C3")]
public class StreamingBinaryLoader : BinaryLoader
{
	[Token(Token = "0x20002C4")]
	[CompilerGenerated]
	private sealed class _003CLoadFromStreamFile_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F5D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F5E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F5F")]
		[FieldOffset(Offset = "0x20")]
		public string path;

		[Token(Token = "0x4000F60")]
		[FieldOffset(Offset = "0x28")]
		public Action<byte[]> callback;

		[Token(Token = "0x4000F61")]
		[FieldOffset(Offset = "0x30")]
		public StreamingBinaryLoader _003C_003E4__this;

		[Token(Token = "0x4000F62")]
		[FieldOffset(Offset = "0x38")]
		private bool _003CisError_003E5__2;

		[Token(Token = "0x4000F63")]
		[FieldOffset(Offset = "0x40")]
		private FileStream _003Cfs_003E5__3;

		[Token(Token = "0x4000F64")]
		[FieldOffset(Offset = "0x48")]
		private MemoryStream _003Cms_003E5__4;

		[Token(Token = "0x4000F65")]
		[FieldOffset(Offset = "0x50")]
		private int _003CreadSize_003E5__5;

		[Token(Token = "0x170001B0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60010E2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60010E4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010DD")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadFromStreamFile_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60010DE")]
		[Address(RVA = "0xE813B0", Offset = "0xE805B0", VA = "0x180E813B0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60010DF")]
		[Address(RVA = "0xE81010", Offset = "0xE80210", VA = "0x180E81010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60010E0")]
		[Address(RVA = "0xE81500", Offset = "0xE80700", VA = "0x180E81500")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x60010E1")]
		[Address(RVA = "0xE81550", Offset = "0xE80750", VA = "0x180E81550")]
		private void _003C_003Em__Finally2()
		{
		}

		[Token(Token = "0x60010E3")]
		[Address(RVA = "0xE81370", Offset = "0xE80570", VA = "0x180E81370", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x60010D8")]
	[Address(RVA = "0xE7A910", Offset = "0xE79B10", VA = "0x180E7A910", Slot = "16")]
	protected override byte[] LoadFromFile(string path)
	{
		return null;
	}

	[Token(Token = "0x60010D9")]
	[Address(RVA = "0xE7A8C0", Offset = "0xE79AC0", VA = "0x180E7A8C0", Slot = "17")]
	protected override string GetNativePath(string path)
	{
		return null;
	}

	[Token(Token = "0x60010DA")]
	[Address(RVA = "0xE7A960", Offset = "0xE79B60", VA = "0x180E7A960", Slot = "18")]
	[IteratorStateMachine(typeof(_003CLoadFromStreamFile_003Ed__2))]
	protected override IEnumerator LoadFromStreamFile(string path, Action<byte[]> callback)
	{
		return null;
	}

	[Token(Token = "0x60010DB")]
	[Address(RVA = "0xE7AA10", Offset = "0xE79C10", VA = "0x180E7AA10")]
	private static int StreamLoad(Stream readStream, MemoryStream writeStream, int bufsize = 1048576)
	{
		return default(int);
	}

	[Token(Token = "0x60010DC")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public StreamingBinaryLoader()
	{
	}
}
