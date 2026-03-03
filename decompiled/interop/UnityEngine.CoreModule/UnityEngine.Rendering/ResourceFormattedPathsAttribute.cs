using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Rendering;

public sealed class ResourceFormattedPathsAttribute : ResourcePathsBaseAttribute
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_SearchType_0;

	static ResourceFormattedPathsAttribute()
	{
		Il2CppClassPointerStore<ResourceFormattedPathsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ResourceFormattedPathsAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceFormattedPathsAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_SearchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFormattedPathsAttribute>.NativeClassPtr, 100667744);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResourceFormattedPathsAttribute(string pathFormat, int rangeMin, int rangeMax, SearchType location = SearchType.ProjectPath)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceFormattedPathsAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pathFormat);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &rangeMin;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &rangeMax;
		*(SearchType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_SearchType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ResourceFormattedPathsAttribute(IntPtr pointer)
		: base(pointer)
	{
	}

	public static Il2CppStringArray CreateFormattedPaths(string format, int rangeMin, int rangeMax)
	{
		throw new NotSupportedException("Method unstripping failed");
	}
}
