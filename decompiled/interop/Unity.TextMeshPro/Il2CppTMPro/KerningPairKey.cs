using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro;

[StructLayout(LayoutKind.Explicit)]
public struct KerningPairKey
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ascii_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_ascii_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_key;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0;

	[FieldOffset(0)]
	public uint ascii_Left;

	[FieldOffset(4)]
	public uint ascii_Right;

	[FieldOffset(8)]
	public uint key;

	static KerningPairKey()
	{
		Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "KerningPairKey");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr);
		NativeFieldInfoPtr_ascii_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr, "ascii_Left");
		NativeFieldInfoPtr_ascii_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr, "ascii_Right");
		NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr, "key");
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr, 100663964);
	}

	[CallerCount(0)]
	public unsafe KerningPairKey(uint ascii_left, uint ascii_right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ascii_left);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ascii_right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
