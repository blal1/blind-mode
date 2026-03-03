using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Unity.Profiling;

[StructLayout(LayoutKind.Explicit)]
public struct ProfilerCategory
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_CategoryId;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Scripts_Public_Static_get_ProfilerCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ProfilerCategory_0;

	[FieldOffset(0)]
	public readonly ushort m_CategoryId;

	public unsafe string Name
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1164517, RefRangeEnd = 1164518, XrefRangeStart = 1164506, XrefRangeEnd = 1164517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Name_Public_get_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static ProfilerCategory Scripts
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 63528, RefRangeEnd = 63535, XrefRangeStart = 63528, XrefRangeEnd = 63535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Scripts_Public_Static_get_ProfilerCategory_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ProfilerCategory*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public Color32 Color => ProfilerUnsafeUtility.GetCategoryDescription(m_CategoryId).Color;

	public static ProfilerCategory Render => new ProfilerCategory(0);

	public static ProfilerCategory Gui => new ProfilerCategory(4);

	public static ProfilerCategory Physics => new ProfilerCategory(5);

	public static ProfilerCategory Physics2D => new ProfilerCategory(33);

	public static ProfilerCategory Animation => new ProfilerCategory(6);

	public static ProfilerCategory Ai => new ProfilerCategory(7);

	public static ProfilerCategory Audio => new ProfilerCategory(8);

	public static ProfilerCategory Video => new ProfilerCategory(11);

	public static ProfilerCategory Particles => new ProfilerCategory(12);

	public static ProfilerCategory Lighting => new ProfilerCategory(13);

	public static ProfilerCategory Network => new ProfilerCategory(14);

	public static ProfilerCategory Loading => new ProfilerCategory(15);

	public static ProfilerCategory Vr => new ProfilerCategory(22);

	public static ProfilerCategory Input => new ProfilerCategory(30);

	public static ProfilerCategory Memory => new ProfilerCategory(23);

	public static ProfilerCategory VirtualTexturing => new ProfilerCategory(31);

	public static ProfilerCategory FileIO => new ProfilerCategory(25);

	public static ProfilerCategory Internal => new ProfilerCategory(24);

	public static ProfilerCategory Any => new ProfilerCategory(ushort.MaxValue);

	public static ProfilerCategory GPU => new ProfilerCategory(32);

	static ProfilerCategory()
	{
		Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "ProfilerCategory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr);
		NativeFieldInfoPtr_m_CategoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, "m_CategoryId");
		NativeMethodInfoPtr__ctor_Internal_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663404);
		NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663405);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663406);
		NativeMethodInfoPtr_get_Scripts_Public_Static_get_ProfilerCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663407);
		NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ProfilerCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663408);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 545397, RefRangeEnd = 545401, XrefRangeStart = 545397, XrefRangeEnd = 545401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProfilerCategory(ushort category)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&category);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_UInt16_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164518, XrefRangeEnd = 1164519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static implicit operator ushort(ProfilerCategory category)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&category);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ProfilerCategory_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
