using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule;

public sealed class RasterGraphContext : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_wrappedContext;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmd;

	private static readonly System.IntPtr NativeFieldInfoPtr_rastercmd;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultResources_Public_get_RenderGraphDefaultResources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderGraphPool_Public_get_RenderGraphObjectPool_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromInternalContext_Public_Virtual_Final_New_Void_InternalRenderGraphContext_0;

	public unsafe InternalRenderGraphContext wrappedContext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wrappedContext);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InternalRenderGraphContext>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wrappedContext)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RasterCommandBuffer cmd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RasterCommandBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RasterCommandBuffer rastercmd
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rastercmd, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RasterCommandBuffer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rastercmd, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderGraphDefaultResources defaultResources
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultResources_Public_get_RenderGraphDefaultResources_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphDefaultResources>(intPtr2) : null;
		}
	}

	public unsafe RenderGraphObjectPool renderGraphPool
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 953698, RefRangeEnd = 953700, XrefRangeStart = 953698, XrefRangeEnd = 953700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderGraphPool_Public_get_RenderGraphObjectPool_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphObjectPool>(intPtr2) : null;
		}
	}

	static RasterGraphContext()
	{
		Il2CppClassPointerStore<RasterGraphContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "RasterGraphContext");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RasterGraphContext>.NativeClassPtr);
		NativeFieldInfoPtr_wrappedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterGraphContext>.NativeClassPtr, "wrappedContext");
		NativeFieldInfoPtr_cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterGraphContext>.NativeClassPtr, "cmd");
		NativeFieldInfoPtr_rastercmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterGraphContext>.NativeClassPtr, "rastercmd");
		NativeMethodInfoPtr_get_defaultResources_Public_get_RenderGraphDefaultResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterGraphContext>.NativeClassPtr, 100667286);
		NativeMethodInfoPtr_get_renderGraphPool_Public_get_RenderGraphObjectPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterGraphContext>.NativeClassPtr, 100667287);
		NativeMethodInfoPtr_FromInternalContext_Public_Virtual_Final_New_Void_InternalRenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterGraphContext>.NativeClassPtr, 100667288);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1057845, RefRangeEnd = 1057846, XrefRangeStart = 1057826, XrefRangeEnd = 1057845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void FromInternalContext(InternalRenderGraphContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromInternalContext_Public_Virtual_Final_New_Void_InternalRenderGraphContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RasterGraphContext(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RasterGraphContext()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RasterGraphContext>.NativeClassPtr))
	{
	}
}
