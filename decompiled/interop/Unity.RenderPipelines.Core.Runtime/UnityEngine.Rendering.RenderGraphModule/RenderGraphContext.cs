using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule;

public sealed class RenderGraphContext : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_wrappedContext;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromInternalContext_Public_Virtual_Final_New_Void_InternalRenderGraphContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderContext_Public_get_ScriptableRenderContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cmd_Public_get_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderGraphPool_Public_get_RenderGraphObjectPool_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultResources_Public_get_RenderGraphDefaultResources_0;

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

	public unsafe ScriptableRenderContext renderContext
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 696511, RefRangeEnd = 696514, XrefRangeStart = 696511, XrefRangeEnd = 696514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderContext_Public_get_ScriptableRenderContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ScriptableRenderContext*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe CommandBuffer cmd
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 953700, RefRangeEnd = 953702, XrefRangeStart = 953700, XrefRangeEnd = 953702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cmd_Public_get_CommandBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
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

	static RenderGraphContext()
	{
		Il2CppClassPointerStore<RenderGraphContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "RenderGraphContext");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphContext>.NativeClassPtr);
		NativeFieldInfoPtr_wrappedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphContext>.NativeClassPtr, "wrappedContext");
		NativeMethodInfoPtr_FromInternalContext_Public_Virtual_Final_New_Void_InternalRenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphContext>.NativeClassPtr, 100667281);
		NativeMethodInfoPtr_get_renderContext_Public_get_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphContext>.NativeClassPtr, 100667282);
		NativeMethodInfoPtr_get_cmd_Public_get_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphContext>.NativeClassPtr, 100667283);
		NativeMethodInfoPtr_get_renderGraphPool_Public_get_RenderGraphObjectPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphContext>.NativeClassPtr, 100667284);
		NativeMethodInfoPtr_get_defaultResources_Public_get_RenderGraphDefaultResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphContext>.NativeClassPtr, 100667285);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 110106, RefRangeEnd = 110111, XrefRangeStart = 110106, XrefRangeEnd = 110111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void FromInternalContext(InternalRenderGraphContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromInternalContext_Public_Virtual_Final_New_Void_InternalRenderGraphContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RenderGraphContext(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RenderGraphContext()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphContext>.NativeClassPtr))
	{
	}
}
