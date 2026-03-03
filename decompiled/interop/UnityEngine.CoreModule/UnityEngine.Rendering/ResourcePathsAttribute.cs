using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Rendering;

public sealed class ResourcePathsAttribute : ResourcePathsBaseAttribute
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_SearchType_0;

	static ResourcePathsAttribute()
	{
		Il2CppClassPointerStore<ResourcePathsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ResourcePathsAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourcePathsAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_SearchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcePathsAttribute>.NativeClassPtr, 100667743);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResourcePathsAttribute(Il2CppStringArray paths, SearchType location = SearchType.ProjectPath)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourcePathsAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paths);
		*(SearchType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_SearchType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ResourcePathsAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
