using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering;

public sealed class ResourcePathAttribute : ResourcePathsBaseAttribute
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_SearchType_0;

	static ResourcePathAttribute()
	{
		Il2CppClassPointerStore<ResourcePathAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ResourcePathAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourcePathAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_String_SearchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcePathAttribute>.NativeClassPtr, 100667742);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResourcePathAttribute(string path, SearchType location = SearchType.ProjectPath)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourcePathAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(SearchType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_SearchType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ResourcePathAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
