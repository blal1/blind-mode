using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule;

public sealed class RendererListResource : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_desc;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererList;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_byref_RendererListParams_0;

	public unsafe RendererListParams desc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desc);
			return new RendererListParams(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desc), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe RendererList rendererList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererList);
			return *(RendererList*)num;
		}
		set
		{
			*(RendererList*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererList)) = value;
		}
	}

	static RendererListResource()
	{
		Il2CppClassPointerStore<RendererListResource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "RendererListResource");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererListResource>.NativeClassPtr);
		NativeFieldInfoPtr_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListResource>.NativeClassPtr, "desc");
		NativeFieldInfoPtr_rendererList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListResource>.NativeClassPtr, "rendererList");
		NativeMethodInfoPtr__ctor_Internal_Void_byref_RendererListParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListResource>.NativeClassPtr, 100667678);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060674, RefRangeEnd = 1060675, XrefRangeStart = 1060674, XrefRangeEnd = 1060674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListResource([In] ref RendererListParams desc)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererListResource>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_byref_RendererListParams_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RendererListResource(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RendererListResource()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererListResource>.NativeClassPtr))
	{
	}
}
