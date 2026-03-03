using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks;

public static class Packsize : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct ValvePackingSentinel_t
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_u32;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_u64;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_u16;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_d;

		[FieldOffset(0)]
		public uint m_u32;

		[FieldOffset(8)]
		public ulong m_u64;

		[FieldOffset(16)]
		public ushort m_u16;

		[FieldOffset(24)]
		public double m_d;

		static ValvePackingSentinel_t()
		{
			Il2CppClassPointerStore<ValvePackingSentinel_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Packsize>.NativeClassPtr, "ValvePackingSentinel_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValvePackingSentinel_t>.NativeClassPtr);
			NativeFieldInfoPtr_m_u32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValvePackingSentinel_t>.NativeClassPtr, "m_u32");
			NativeFieldInfoPtr_m_u64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValvePackingSentinel_t>.NativeClassPtr, "m_u64");
			NativeFieldInfoPtr_m_u16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValvePackingSentinel_t>.NativeClassPtr, "m_u16");
			NativeFieldInfoPtr_m_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValvePackingSentinel_t>.NativeClassPtr, "m_d");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValvePackingSentinel_t>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Test_Public_Static_Boolean_0;

	static Packsize()
	{
		Il2CppClassPointerStore<Packsize>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "Packsize");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Packsize>.NativeClassPtr);
		NativeMethodInfoPtr_Test_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packsize>.NativeClassPtr, 100663433);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 687554, RefRangeEnd = 687555, XrefRangeStart = 687541, XrefRangeEnd = 687554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Test()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Test_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Packsize(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
