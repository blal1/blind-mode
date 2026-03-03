using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

public sealed class RenderPathCompatibleAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_renderPath;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPathCompatibility_0;

	public unsafe RenderPathCompatibility renderPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderPath);
			return *(RenderPathCompatibility*)num;
		}
		set
		{
			*(RenderPathCompatibility*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderPath)) = value;
		}
	}

	static RenderPathCompatibleAttribute()
	{
		Il2CppClassPointerStore<RenderPathCompatibleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "RenderPathCompatibleAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPathCompatibleAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_renderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPathCompatibleAttribute>.NativeClassPtr, "renderPath");
		NativeMethodInfoPtr__ctor_Public_Void_RenderPathCompatibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPathCompatibleAttribute>.NativeClassPtr, 100665876);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166660, RefRangeEnd = 166661, XrefRangeStart = 166660, XrefRangeEnd = 166661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderPathCompatibleAttribute(RenderPathCompatibility renderPath)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderPathCompatibleAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&renderPath);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RenderPathCompatibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RenderPathCompatibleAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
