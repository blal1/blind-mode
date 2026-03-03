using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Burst;

namespace Unity.Collections;

[Token(Token = "0x200000B")]
public static class AllocatorManager
{
	[Token(Token = "0x200000C")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int TryFunction(IntPtr allocatorState, ref Block block);

	[Token(Token = "0x200000D")]
	public struct AllocatorHandle : IAllocator, IDisposable, IEquatable<AllocatorHandle>, IComparable<AllocatorHandle>
	{
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ushort Index;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public ushort Version;

		[Token(Token = "0x17000001")]
		internal unsafe ref TableEntry TableEntry
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x22FBA90", Offset = "0x22FAC90", VA = "0x1822FBA90")]
			get
			{
				return ref *(TableEntry*)null;
			}
		}

		[Token(Token = "0x17000002")]
		public int Value
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x9D5900", Offset = "0x9D4B00", VA = "0x1809D5900")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000003")]
		public AllocatorHandle Handle
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x8C8B50", Offset = "0x8C7D50", VA = "0x1808C8B50", Slot = "5")]
			get
			{
				return default(AllocatorHandle);
			}
		}

		[Token(Token = "0x17000004")]
		public Allocator ToAllocator
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x22FBB20", Offset = "0x22FAD20", VA = "0x1822FBB20", Slot = "9")]
			get
			{
				return default(Allocator);
			}
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
		internal void Rewind()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x22FBB30", Offset = "0x22FAD30", VA = "0x1822FBB30")]
		public static implicit operator AllocatorHandle(Allocator a)
		{
			return default(AllocatorHandle);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x22FBA30", Offset = "0x22FAC30", VA = "0x1822FBA30", Slot = "4")]
		public int Try(ref Block block)
		{
			return default(int);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x22FB910", Offset = "0x22FAB10", VA = "0x1822FB910", Slot = "6")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x22FB930", Offset = "0x22FAB30", VA = "0x1822FB930", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1EB7730", Offset = "0x1EB6930", VA = "0x181EB7730", Slot = "7")]
		public bool Equals(AllocatorHandle other)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x9D5900", Offset = "0x9D4B00", VA = "0x1809D5900", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1EB74E0", Offset = "0x1EB66E0", VA = "0x181EB74E0", Slot = "8")]
		public int CompareTo(AllocatorHandle other)
		{
			return default(int);
		}
	}

	[Token(Token = "0x200000E")]
	public struct Range : IDisposable
	{
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr Pointer;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int Items;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AllocatorHandle Allocator;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x22FCE60", Offset = "0x22FC060", VA = "0x1822FCE60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x200000F")]
	public struct Block : IDisposable
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Range Range;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int BytesPerItem;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int AllocatedItems;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte Log2Alignment;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public byte Padding0;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public ushort Padding1;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint Padding2;

		[Token(Token = "0x17000005")]
		public long Bytes
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x22FC790", Offset = "0x22FB990", VA = "0x1822FC790")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000006")]
		public long AllocatedBytes
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x22FC780", Offset = "0x22FB980", VA = "0x1822FC780")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000007")]
		public int Alignment
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x22FC770", Offset = "0x22FB970", VA = "0x1822FC770")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x22FC7A0", Offset = "0x22FB9A0", VA = "0x1822FC7A0")]
			set
			{
			}
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x22FC720", Offset = "0x22FB920", VA = "0x1822FC720", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x22FC720", Offset = "0x22FB920", VA = "0x1822FC720")]
		public int TryFree()
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000010")]
	public interface IAllocator : IDisposable
	{
		[Token(Token = "0x17000008")]
		AllocatorHandle Handle
		{
			[Token(Token = "0x6000039")]
			get;
		}

		[Token(Token = "0x6000038")]
		int Try(ref Block block);
	}

	[Token(Token = "0x2000011")]
	internal struct TableEntry
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal IntPtr function;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal IntPtr state;
	}

	[Token(Token = "0x2000012")]
	internal struct Array16<T> where T : struct
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal T f0;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal T f1;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal T f2;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal T f3;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal T f4;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal T f5;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal T f6;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal T f7;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal T f8;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal T f9;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal T f10;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal T f11;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal T f12;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal T f13;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal T f14;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal T f15;
	}

	[Token(Token = "0x2000013")]
	internal struct Array256<T> where T : struct
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array16<T> f0;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array16<T> f1;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array16<T> f2;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array16<T> f3;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array16<T> f4;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array16<T> f5;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array16<T> f6;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array16<T> f7;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array16<T> f8;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array16<T> f9;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array16<T> f10;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array16<T> f11;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array16<T> f12;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array16<T> f13;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array16<T> f14;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array16<T> f15;
	}

	[Token(Token = "0x2000014")]
	internal struct Array4096<T> where T : struct
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array256<T> f0;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array256<T> f1;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array256<T> f2;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array256<T> f3;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array256<T> f4;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array256<T> f5;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array256<T> f6;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array256<T> f7;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array256<T> f8;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array256<T> f9;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array256<T> f10;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array256<T> f11;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array256<T> f12;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array256<T> f13;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array256<T> f14;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array256<T> f15;
	}

	[Token(Token = "0x2000015")]
	internal struct Array32768<T> : IIndexable<T> where T : struct
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array4096<T> f0;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array4096<T> f1;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array4096<T> f2;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array4096<T> f3;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array4096<T> f4;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array4096<T> f5;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array4096<T> f6;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Array4096<T> f7;

		[Token(Token = "0x17000009")]
		public int Length
		{
			[Token(Token = "0x600003A")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600003B")]
		public unsafe ref T ElementAt(int index)
		{
			return ref *(T*)null;
		}
	}

	[Token(Token = "0x2000016")]
	internal sealed class SharedStatics
	{
		[Token(Token = "0x2000017")]
		internal sealed class TableEntry
		{
			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly SharedStatic<Array32768<AllocatorManager.TableEntry>> Ref;
		}
	}

	[Token(Token = "0x2000018")]
	internal static class Managed
	{
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static TryFunction[] TryFunctionDelegates;
	}

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly AllocatorHandle Invalid;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static readonly AllocatorHandle None;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly AllocatorHandle Temp;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static readonly AllocatorHandle TempJob;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly AllocatorHandle Persistent;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static readonly AllocatorHandle AudioKernel;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal static readonly ushort NumGlobalScratchAllocators;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	internal static readonly ushort MaxNumGlobalAllocators;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	internal static readonly uint GlobalAllocatorBaseIndex;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal static readonly uint FirstGlobalScratchpadAllocatorIndex;

	[Token(Token = "0x6000013")]
	internal static Block AllocateBlock<T>(this ref T t, int sizeOf, int alignOf, int items) where T : struct, IAllocator
	{
		return default(Block);
	}

	[Token(Token = "0x6000014")]
	public unsafe static void* Allocate<T>(this ref T t, int sizeOf, int alignOf, int items = 1) where T : struct, IAllocator
	{
		//IL_0002: Expected I, but got O
		return (void*)unchecked((nint)null);
	}

	[Token(Token = "0x6000015")]
	internal unsafe static U* Allocate<T, U>(this ref T t, U u, int items) where T : struct, IAllocator where U : struct
	{
		//IL_0002: Expected I, but got O
		return (U*)unchecked((nint)null);
	}

	[Token(Token = "0x6000016")]
	internal static void FreeBlock<T>(this ref T t, ref Block block) where T : struct, IAllocator
	{
	}

	[Token(Token = "0x6000017")]
	internal unsafe static void Free<T>(this ref T t, void* pointer, int sizeOf, int alignOf, int items) where T : struct, IAllocator
	{
	}

	[Token(Token = "0x6000018")]
	internal unsafe static void Free<T, U>(this ref T t, U* pointer, int items) where T : struct, IAllocator where U : struct
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x22FBB50", Offset = "0x22FAD50", VA = "0x1822FBB50")]
	public unsafe static void Free(AllocatorHandle handle, void* pointer)
	{
	}

	[Token(Token = "0x600001A")]
	public unsafe static void Free<T>(AllocatorHandle handle, T* pointer, int items = 1) where T : struct
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x15298B0", Offset = "0x1528AB0", VA = "0x1815298B0")]
	[BurstDiscard]
	private static void CheckDelegate(ref bool useDelegate)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x22FC0F0", Offset = "0x22FB2F0", VA = "0x1822FC0F0")]
	private static bool UseDelegate()
	{
		return default(bool);
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x22FC280", Offset = "0x22FB480", VA = "0x1822FC280")]
	private static int allocate_block(ref Block block)
	{
		return default(int);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x22FC310", Offset = "0x22FB510", VA = "0x1822FC310")]
	[BurstDiscard]
	private static void forward_mono_allocate_block(ref Block block, ref int error)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x22FBBC0", Offset = "0x22FADC0", VA = "0x1822FBBC0")]
	internal static Allocator LegacyOf(AllocatorHandle handle)
	{
		return default(Allocator);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x22FBBD0", Offset = "0x22FADD0", VA = "0x1822FBBD0")]
	private static int TryLegacy(ref Block block)
	{
		return default(int);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x22FBD80", Offset = "0x22FAF80", VA = "0x1822FBD80")]
	public static int Try(ref Block block)
	{
		return default(int);
	}
}
