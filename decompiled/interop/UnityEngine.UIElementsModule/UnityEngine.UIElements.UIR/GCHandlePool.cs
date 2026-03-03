using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000511")]
internal class GCHandlePool : IDisposable
{
	[Token(Token = "0x40010A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<GCHandle> m_Handles;

	[Token(Token = "0x40010A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int m_UsedHandlesCount;

	[Token(Token = "0x40010A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private readonly int k_AllocBatchSize;

	[Token(Token = "0x17000974")]
	internal bool disposed
	{
		[Token(Token = "0x6002469")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600246A")]
		[Address(RVA = "0x4166E0", Offset = "0x4158E0", VA = "0x1804166E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6002465")]
	[Address(RVA = "0x2A31A90", Offset = "0x2A30C90", VA = "0x182A31A90")]
	public GCHandlePool(int capacity = 256, int allocBatchSize = 64)
	{
	}

	[Token(Token = "0x6002466")]
	[Address(RVA = "0x2A31800", Offset = "0x2A30A00", VA = "0x182A31800")]
	public GCHandle Get(object target)
	{
		return default(GCHandle);
	}

	[Token(Token = "0x6002467")]
	[Address(RVA = "0x2A317D0", Offset = "0x2A309D0", VA = "0x182A317D0")]
	public IntPtr GetIntPtr(object target)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6002468")]
	[Address(RVA = "0x2A319B0", Offset = "0x2A30BB0", VA = "0x182A319B0")]
	public void ReturnAll()
	{
	}

	[Token(Token = "0x600246B")]
	[Address(RVA = "0x2A31610", Offset = "0x2A30810", VA = "0x182A31610", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600246C")]
	[Address(RVA = "0x2A31670", Offset = "0x2A30870", VA = "0x182A31670")]
	private void Dispose(bool disposing)
	{
	}
}
