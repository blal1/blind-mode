using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public class ResourcePathsBaseAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Il2CppStringArray_Boolean_SearchType_0;

	public SearchType location
	{
		get
		{
			Debug.LogWarning("ResourcePathsBaseAttribute.location cannot be reliable at runtime as data is not stored.");
			return SearchType.ProjectPath;
		}
	}

	public Il2CppStringArray paths
	{
		get
		{
			Debug.LogWarning("ResourcePathsBaseAttribute.paths cannot be reliable at runtime as data is not stored.");
			return null;
		}
	}

	public bool isField
	{
		get
		{
			Debug.LogWarning("ResourcePathsBaseAttribute.isField cannot be reliable at runtime as data is not stored.");
			return false;
		}
	}

	static ResourcePathsBaseAttribute()
	{
		Il2CppClassPointerStore<ResourcePathsBaseAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ResourcePathsBaseAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourcePathsBaseAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Protected_Void_Il2CppStringArray_Boolean_SearchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcePathsBaseAttribute>.NativeClassPtr, 100667741);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResourcePathsBaseAttribute(Il2CppStringArray paths, bool isField, SearchType location)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourcePathsBaseAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paths);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isField;
		*(SearchType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_Il2CppStringArray_Boolean_SearchType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ResourcePathsBaseAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
