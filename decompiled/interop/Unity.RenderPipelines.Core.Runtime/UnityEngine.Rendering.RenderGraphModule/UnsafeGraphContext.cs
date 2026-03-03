using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule;

public class UnsafeGraphContext : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_wrappedContext;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmd;

	private static readonly System.IntPtr NativeFieldInfoPtr_unsCmd;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultResources_Public_get_RenderGraphDefaultResources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderGraphPool_Public_get_RenderGraphObjectPool_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromInternalContext_Public_Virtual_Final_New_Void_InternalRenderGraphContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe UnsafeCommandBuffer cmd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnsafeCommandBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UnsafeCommandBuffer unsCmd
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unsCmd, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnsafeCommandBuffer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unsCmd, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderGraphDefaultResources defaultResources
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 663065, RefRangeEnd = 663066, XrefRangeStart = 663065, XrefRangeEnd = 663066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultResources_Public_get_RenderGraphDefaultResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphDefaultResources>(intPtr2) : null;
		}
	}

	public unsafe RenderGraphObjectPool renderGraphPool
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 663064, RefRangeEnd = 663065, XrefRangeStart = 663064, XrefRangeEnd = 663065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderGraphPool_Public_get_RenderGraphObjectPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphObjectPool>(intPtr2) : null;
		}
	}

	static UnsafeGraphContext()
	{
		Il2CppClassPointerStore<UnsafeGraphContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "UnsafeGraphContext");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeGraphContext>.NativeClassPtr);
		NativeFieldInfoPtr_wrappedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeGraphContext>.NativeClassPtr, "wrappedContext");
		NativeFieldInfoPtr_cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeGraphContext>.NativeClassPtr, "cmd");
		NativeFieldInfoPtr_unsCmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeGraphContext>.NativeClassPtr, "unsCmd");
		NativeMethodInfoPtr_get_defaultResources_Public_get_RenderGraphDefaultResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeGraphContext>.NativeClassPtr, 100667295);
		NativeMethodInfoPtr_get_renderGraphPool_Public_get_RenderGraphObjectPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeGraphContext>.NativeClassPtr, 100667296);
		NativeMethodInfoPtr_FromInternalContext_Public_Virtual_Final_New_Void_InternalRenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeGraphContext>.NativeClassPtr, 100667297);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeGraphContext>.NativeClassPtr, 100667298);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1057888, RefRangeEnd = 1057889, XrefRangeStart = 1057866, XrefRangeEnd = 1057888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void FromInternalContext(InternalRenderGraphContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromInternalContext_Public_Virtual_Final_New_Void_InternalRenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnsafeGraphContext()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsafeGraphContext>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UnsafeGraphContext(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
