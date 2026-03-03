using System;
using Il2CppDummyDll;

namespace Unity.Collections;

[Token(Token = "0x2000030")]
[GenerateTestsForBurstCompatibility]
internal struct Memory
{
	[Token(Token = "0x2000031")]
	[GenerateTestsForBurstCompatibility]
	internal struct Unmanaged
	{
		[Token(Token = "0x2000032")]
		[GenerateTestsForBurstCompatibility]
		internal struct Array
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x22FC550", Offset = "0x22FB750", VA = "0x1822FC550")]
			private static bool IsCustom(AllocatorManager.AllocatorHandle allocator)
			{
				return default(bool);
			}

			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x22FC430", Offset = "0x22FB630", VA = "0x1822FC430")]
			private unsafe static void* CustomResize(void* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator, long size, int align)
			{
				//IL_0002: Expected I, but got O
				return (void*)unchecked((nint)null);
			}

			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x22FC560", Offset = "0x22FB760", VA = "0x1822FC560")]
			internal unsafe static void* Resize(void* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator, long size, int align)
			{
				//IL_0002: Expected I, but got O
				return (void*)unchecked((nint)null);
			}

			[Token(Token = "0x60000C9")]
			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
			internal unsafe static T* Resize<T>(T* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator) where T : struct
			{
				//IL_0002: Expected I, but got O
				return (T*)unchecked((nint)null);
			}
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x22FD420", Offset = "0x22FC620", VA = "0x1822FD420")]
		internal unsafe static void* Allocate(long size, int align, AllocatorManager.AllocatorHandle allocator)
		{
			//IL_0002: Expected I, but got O
			return (void*)unchecked((nint)null);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x22FD450", Offset = "0x22FC650", VA = "0x1822FD450")]
		internal unsafe static void Free(void* pointer, AllocatorManager.AllocatorHandle allocator)
		{
		}

		[Token(Token = "0x60000C5")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		internal unsafe static void Free<T>(T* pointer, AllocatorManager.AllocatorHandle allocator) where T : struct
		{
		}
	}
}
