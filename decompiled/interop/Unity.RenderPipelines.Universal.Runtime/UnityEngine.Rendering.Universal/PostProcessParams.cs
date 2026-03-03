using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal;

public sealed class PostProcessParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_blitMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_requestColorFormat;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_PostProcessParams_0;

	public unsafe Material blitMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blitMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blitMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsFormat requestColorFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requestColorFormat);
			return *(GraphicsFormat*)num;
		}
		set
		{
			*(GraphicsFormat*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requestColorFormat)) = value;
		}
	}

	static PostProcessParams()
	{
		Il2CppClassPointerStore<PostProcessParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PostProcessParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessParams>.NativeClassPtr);
		NativeFieldInfoPtr_blitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessParams>.NativeClassPtr, "blitMaterial");
		NativeFieldInfoPtr_requestColorFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessParams>.NativeClassPtr, "requestColorFormat");
		NativeMethodInfoPtr_Create_Public_Static_PostProcessParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessParams>.NativeClassPtr, 100665156);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1096008, RefRangeEnd = 1096009, XrefRangeStart = 1096007, XrefRangeEnd = 1096008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PostProcessParams Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_PostProcessParams_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new PostProcessParams(pointer);
	}

	public PostProcessParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PostProcessParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessParams>.NativeClassPtr))
	{
	}
}
