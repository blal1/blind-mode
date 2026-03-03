using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public sealed class ReloadAttribute : Il2CppSystem.Attribute
{
	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "Package")]
	public enum Package
	{
		Builtin,
		Root,
		BuiltinExtra
	}

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Package_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Package_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Package_0;

	static ReloadAttribute()
	{
		Il2CppClassPointerStore<ReloadAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ReloadAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReloadAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Package_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReloadAttribute>.NativeClassPtr, 100664542);
		NativeMethodInfoPtr__ctor_Public_Void_String_Package_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReloadAttribute>.NativeClassPtr, 100664543);
		NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Package_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReloadAttribute>.NativeClassPtr, 100664544);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReloadAttribute(Il2CppStringArray paths, Package package = Package.Root)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReloadAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paths);
		*(Package**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &package;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Package_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030147, XrefRangeEnd = 1030154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReloadAttribute(string path, Package package = Package.Root)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReloadAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(Package**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &package;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Package_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReloadAttribute(string pathFormat, int rangeMin, int rangeMax, Package package = Package.Root)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReloadAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pathFormat);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rangeMin;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rangeMax;
		*(Package**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &package;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Package_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ReloadAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
