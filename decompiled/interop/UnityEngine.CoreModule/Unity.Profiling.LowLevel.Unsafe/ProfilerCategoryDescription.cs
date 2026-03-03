using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Unity.Profiling.LowLevel.Unsafe;

[StructLayout(LayoutKind.Explicit)]
public struct ProfilerCategoryDescription
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Id;

	private static readonly System.IntPtr NativeFieldInfoPtr_Flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color;

	private static readonly System.IntPtr NativeFieldInfoPtr_reserved0;

	private static readonly System.IntPtr NativeFieldInfoPtr_NameUtf8Len;

	private static readonly System.IntPtr NativeFieldInfoPtr_NameUtf8;

	[FieldOffset(0)]
	public readonly ushort Id;

	[FieldOffset(2)]
	public readonly ushort Flags;

	[FieldOffset(4)]
	public readonly Color32 Color;

	[FieldOffset(8)]
	public readonly int reserved0;

	[FieldOffset(12)]
	public readonly int NameUtf8Len;

	[FieldOffset(16)]
	public readonly System.IntPtr NameUtf8;

	public unsafe string Name => ProfilerUnsafeUtility.Utf8ToString((byte*)NameUtf8, NameUtf8Len);

	static ProfilerCategoryDescription()
	{
		Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.LowLevel.Unsafe", "ProfilerCategoryDescription");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr);
		NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "Id");
		NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "Flags");
		NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "Color");
		NativeFieldInfoPtr_reserved0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "reserved0");
		NativeFieldInfoPtr_NameUtf8Len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "NameUtf8Len");
		NativeFieldInfoPtr_NameUtf8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "NameUtf8");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
