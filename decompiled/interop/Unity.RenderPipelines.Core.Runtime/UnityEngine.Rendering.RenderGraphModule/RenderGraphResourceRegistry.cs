using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RendererUtils;

namespace UnityEngine.Rendering.RenderGraphModule;

public class RenderGraphResourceRegistry : Il2CppSystem.Object
{
	public sealed class ResourceCreateCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_InternalRenderGraphContext_IRenderGraphResource_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_InternalRenderGraphContext_IRenderGraphResource_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;

		static ResourceCreateCallback()
		{
			Il2CppClassPointerStore<ResourceCreateCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "ResourceCreateCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceCreateCallback>.NativeClassPtr, 100667659);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_InternalRenderGraphContext_IRenderGraphResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceCreateCallback>.NativeClassPtr, 100667660);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_InternalRenderGraphContext_IRenderGraphResource_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceCreateCallback>.NativeClassPtr, 100667661);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceCreateCallback>.NativeClassPtr, 100667662);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1059557, RefRangeEnd = 1059559, XrefRangeStart = 1059547, XrefRangeEnd = 1059557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceCreateCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceCreateCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual bool Invoke(InternalRenderGraphContext rgContext, IRenderGraphResource res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)res);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_InternalRenderGraphContext_IRenderGraphResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(InternalRenderGraphContext rgContext, IRenderGraphResource res, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)res);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_InternalRenderGraphContext_IRenderGraphResource_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public ResourceCreateCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator ResourceCreateCallback(System.Func<InternalRenderGraphContext, IRenderGraphResource, bool> P_0)
		{
			return DelegateSupport.ConvertDelegate<ResourceCreateCallback>((System.Delegate)P_0);
		}

		public static ResourceCreateCallback operator +(ResourceCreateCallback P_0, ResourceCreateCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<ResourceCreateCallback>();
		}

		public static ResourceCreateCallback operator -(ResourceCreateCallback P_0, ResourceCreateCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<ResourceCreateCallback>();
			}
			return (ResourceCreateCallback)obj;
		}
	}

	public sealed class ResourceCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_InternalRenderGraphContext_IRenderGraphResource_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_InternalRenderGraphContext_IRenderGraphResource_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static ResourceCallback()
		{
			Il2CppClassPointerStore<ResourceCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "ResourceCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceCallback>.NativeClassPtr, 100667663);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_InternalRenderGraphContext_IRenderGraphResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceCallback>.NativeClassPtr, 100667664);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_InternalRenderGraphContext_IRenderGraphResource_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceCallback>.NativeClassPtr, 100667665);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceCallback>.NativeClassPtr, 100667666);
		}

		[CallerCount(110)]
		[CachedScanResults(RefRangeStart = 49659, RefRangeEnd = 49769, XrefRangeStart = 49659, XrefRangeEnd = 49769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(InternalRenderGraphContext rgContext, IRenderGraphResource res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)res);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_InternalRenderGraphContext_IRenderGraphResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(InternalRenderGraphContext rgContext, IRenderGraphResource res, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)res);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_InternalRenderGraphContext_IRenderGraphResource_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ResourceCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator ResourceCallback(System.Action<InternalRenderGraphContext, IRenderGraphResource> P_0)
		{
			return DelegateSupport.ConvertDelegate<ResourceCallback>((System.Delegate)P_0);
		}

		public static ResourceCallback operator +(ResourceCallback P_0, ResourceCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<ResourceCallback>();
		}

		public static ResourceCallback operator -(ResourceCallback P_0, ResourceCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<ResourceCallback>();
			}
			return (ResourceCallback)obj;
		}
	}

	public class RenderGraphResourcesData : Il2CppSystem.Object
	{
		private sealed class MethodInfoStoreGeneric_AddNewRenderGraphResource_Public_Int32_byref_ResType_Boolean_0<ResType>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddNewRenderGraphResource_Public_Int32_byref_ResType_Boolean_0, Il2CppClassPointerStore<RenderGraphResourcesData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ResType>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_resourceArray;

		private static readonly System.IntPtr NativeFieldInfoPtr_sharedResourcesCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_pool;

		private static readonly System.IntPtr NativeFieldInfoPtr_createResourceCallback;

		private static readonly System.IntPtr NativeFieldInfoPtr_releaseResourceCallback;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_PurgeUnusedGraphicsResources_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddNewRenderGraphResource_Public_Int32_byref_ResType_Boolean_0;

		public unsafe DynamicArray<IRenderGraphResource> resourceArray
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceArray);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<IRenderGraphResource>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceArray)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int sharedResourcesCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedResourcesCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedResourcesCount)) = value;
			}
		}

		public unsafe IRenderGraphResourcePool pool
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pool);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IRenderGraphResourcePool>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ResourceCreateCallback createResourceCallback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createResourceCallback);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResourceCreateCallback>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createResourceCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ResourceCallback releaseResourceCallback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_releaseResourceCallback);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResourceCallback>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_releaseResourceCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static RenderGraphResourcesData()
		{
			Il2CppClassPointerStore<RenderGraphResourcesData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "RenderGraphResourcesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphResourcesData>.NativeClassPtr);
			NativeFieldInfoPtr_resourceArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourcesData>.NativeClassPtr, "resourceArray");
			NativeFieldInfoPtr_sharedResourcesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourcesData>.NativeClassPtr, "sharedResourcesCount");
			NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourcesData>.NativeClassPtr, "pool");
			NativeFieldInfoPtr_createResourceCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourcesData>.NativeClassPtr, "createResourceCallback");
			NativeFieldInfoPtr_releaseResourceCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourcesData>.NativeClassPtr, "releaseResourceCallback");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcesData>.NativeClassPtr, 100667667);
			NativeMethodInfoPtr_Clear_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcesData>.NativeClassPtr, 100667668);
			NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcesData>.NativeClassPtr, 100667669);
			NativeMethodInfoPtr_PurgeUnusedGraphicsResources_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcesData>.NativeClassPtr, 100667670);
			NativeMethodInfoPtr_AddNewRenderGraphResource_Public_Int32_byref_ResType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcesData>.NativeClassPtr, 100667671);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059559, XrefRangeEnd = 1059571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphResourcesData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphResourcesData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059571, XrefRangeEnd = 1059574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(bool onException, int frameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&onException);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059574, XrefRangeEnd = 1059577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe void PurgeUnusedGraphicsResources(int frameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&frameIndex);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PurgeUnusedGraphicsResources_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1059597, RefRangeEnd = 1059605, XrefRangeStart = 1059577, XrefRangeEnd = 1059597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddNewRenderGraphResource<ResType>(out ResType outRes, bool pooledResource = true) where ResType : IRenderGraphResource, new()
		{
			//IL_002d->IL002f: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			Unsafe.SkipInit(out nint num);
			ref ResType reference;
			if (!typeof(ResType).IsValueType)
			{
				num = 0;
				reference = ref *(_003F*)(&num);
			}
			else
			{
				reference = ref outRes;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pooledResource;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddNewRenderGraphResource_Public_Int32_byref_ResType_Boolean_0<ResType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			if (!typeof(ResType).IsValueType)
			{
				nint num2 = num;
				outRes = ((num2 == 0) ? null : IL2CPP.PointerToValueGeneric<ResType>((System.IntPtr)num2, false, false));
			}
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public RenderGraphResourcesData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_kSharedResourceLifetime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentRegistry;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderGraphResources;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RendererListResources;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RendererListLegacyResources;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderGraphDebug;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ResourceLogger;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FrameInformationLogger;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentFrameIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ExecutionCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentBackbuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_kInitialRendererListCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveRendererLists;

	private static readonly System.IntPtr NativeFieldInfoPtr_emptyId;

	private static readonly System.IntPtr NativeFieldInfoPtr_builtinCameraRenderTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceManualClearOfResource;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_current_Internal_Static_get_RenderGraphResourceRegistry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_current_Internal_Static_set_Void_RenderGraphResourceRegistry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckTextureResource_Private_Void_TextureResource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTexture_Internal_RTHandle_byref_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTexture_Internal_RTHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TextureNeedsFallback_Internal_Boolean_byref_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRendererList_Internal_RendererList_byref_RendererListHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckBufferResource_Private_Void_BufferResource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffer_Internal_GraphicsBuffer_byref_BufferHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffer_Internal_GraphicsBuffer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayTracingAccelerationStructure_Internal_RayTracingAccelerationStructure_byref_RayTracingAccelerationStructureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSharedResourceCount_Internal_Int32_RenderGraphResourceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RenderGraphDebugParams_RenderGraphLogger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginRenderGraph_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginExecute_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndExecute_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckHandleValidity_Private_Void_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckHandleValidity_Private_Void_RenderGraphResourceType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncrementWriteCount_Internal_Void_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncrementReadCount_Internal_Void_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewVersion_Internal_Void_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLatestVersionHandle_Internal_ResourceHandle_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLatestVersionNumber_Internal_Int32_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetZeroVersionedHandle_Internal_ResourceHandle_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNewVersionedHandle_Internal_ResourceHandle_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceLowLevel_Internal_IRenderGraphResource_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderGraphResourceName_Internal_String_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderGraphResourceName_Internal_String_RenderGraphResourceType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRenderGraphResourceImported_Internal_Boolean_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRenderGraphResourceForceReleased_Internal_Boolean_RenderGraphResourceType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRenderGraphResourceShared_Internal_Boolean_RenderGraphResourceType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRenderGraphResourceShared_Internal_Boolean_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGraphicsResourceCreated_Internal_Boolean_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRendererListCreated_Internal_Boolean_byref_RendererListHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRenderGraphResourceImported_Internal_Boolean_RenderGraphResourceType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderGraphResourceTransientIndex_Internal_Int32_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportTexture_Internal_TextureHandle_byref_RTHandle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportTexture_Internal_TextureHandle_byref_RTHandle_byref_ImportResourceParams_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportTexture_Internal_TextureHandle_byref_RTHandle_RenderTargetInfo_byref_ImportResourceParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSharedTexture_Internal_TextureHandle_byref_TextureDesc_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshSharedTextureDesc_Internal_Void_byref_TextureHandle_byref_TextureDesc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseSharedTexture_Internal_Void_byref_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportBackbuffer_Internal_TextureHandle_RenderTargetIdentifier_byref_RenderTargetInfo_byref_ImportResourceParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateRenderTarget_Private_Void_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderTargetInfo_Internal_Void_byref_ResourceHandle_byref_RenderTargetInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFormat_Internal_GraphicsFormat_GraphicsFormat_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Void_GraphicsFormat_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTexture_Internal_TextureHandle_byref_TextureDesc_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceCount_Internal_Int32_RenderGraphResourceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureResourceCount_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureResource_Internal_TextureResource_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureResource_Internal_TextureResource_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureResourceDesc_Internal_TextureDesc_byref_ResourceHandle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererList_Internal_RendererListHandle_byref_RendererListDesc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererList_Internal_RendererListHandle_byref_RendererListParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateShadowRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_ShadowDrawingSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGizmoRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_byref_GizmoSubset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUIOverlayRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_byref_UISubset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateWireOverlayRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportBuffer_Internal_BufferHandle_GraphicsBuffer_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBuffer_Internal_BufferHandle_byref_BufferDesc_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBufferResourceDesc_Internal_BufferDesc_byref_ResourceHandle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBufferResourceCount_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBufferResource_Private_BufferResource_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBufferResource_Private_BufferResource_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayTracingAccelerationStructureResource_Private_RayTracingAccelerationStructureResource_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayTracingAccelerationStructureResourceCount_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportRayTracingAccelerationStructure_Internal_RayTracingAccelerationStructureHandle_byref_RayTracingAccelerationStructure_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSharedResourceLastFrameIndex_Internal_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSharedResourceLastFrameIndex_Internal_Void_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManageSharedRenderGraphResources_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreatePooledResource_Internal_Boolean_InternalRenderGraphContext_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreatePooledResource_Internal_Boolean_InternalRenderGraphContext_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTextureCallback_Private_Boolean_InternalRenderGraphContext_IRenderGraphResource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearResource_Internal_Void_InternalRenderGraphContext_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearTexture_Private_Void_InternalRenderGraphContext_TextureResource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleasePooledResource_Internal_Void_InternalRenderGraphContext_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleasePooledResource_Internal_Void_InternalRenderGraphContext_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseTextureCallback_Private_Void_InternalRenderGraphContext_IRenderGraphResource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateTextureDesc_Private_Void_byref_TextureDesc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateRendererListDesc_Private_Void_byref_RendererListDesc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateBufferDesc_Private_Void_byref_BufferDesc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererLists_Internal_Void_List_1_RendererListHandle_ScriptableRenderContext_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Internal_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PurgeUnusedGraphicsResources_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlushLogs_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogResources_Private_Void_0;

	public unsafe static int kSharedResourceLifetime
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kSharedResourceLifetime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kSharedResourceLifetime, (void*)(&value));
		}
	}

	public unsafe static RenderGraphResourceRegistry m_CurrentRegistry
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_CurrentRegistry, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphResourceRegistry>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_CurrentRegistry, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<RenderGraphResourcesData> m_RenderGraphResources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderGraphResources);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RenderGraphResourcesData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderGraphResources)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DynamicArray<RendererListResource> m_RendererListResources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererListResources);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<RendererListResource>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererListResources)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DynamicArray<RendererListLegacyResource> m_RendererListLegacyResources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererListLegacyResources);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<RendererListLegacyResource>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererListLegacyResources)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderGraphDebugParams m_RenderGraphDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderGraphDebug);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphDebugParams>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderGraphDebug)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderGraphLogger m_ResourceLogger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ResourceLogger);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphLogger>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ResourceLogger)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderGraphLogger m_FrameInformationLogger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrameInformationLogger);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphLogger>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrameInformationLogger)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_CurrentFrameIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentFrameIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentFrameIndex)) = value;
		}
	}

	public unsafe int m_ExecutionCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExecutionCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExecutionCount)) = value;
		}
	}

	public unsafe RTHandle m_CurrentBackbuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentBackbuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentBackbuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int kInitialRendererListCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kInitialRendererListCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kInitialRendererListCount, (void*)(&value));
		}
	}

	public unsafe List<RendererList> m_ActiveRendererLists
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveRendererLists);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RendererList>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveRendererLists)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RenderTargetIdentifier emptyId
	{
		get
		{
			Unsafe.SkipInit(out RenderTargetIdentifier result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_emptyId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_emptyId, (void*)(&value));
		}
	}

	public unsafe static RenderTargetIdentifier builtinCameraRenderTarget
	{
		get
		{
			Unsafe.SkipInit(out RenderTargetIdentifier result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_builtinCameraRenderTarget, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_builtinCameraRenderTarget, (void*)(&value));
		}
	}

	public unsafe bool forceManualClearOfResource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceManualClearOfResource);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceManualClearOfResource)) = value;
		}
	}

	public unsafe static RenderGraphResourceRegistry current
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059605, XrefRangeEnd = 1059609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_current_Internal_Static_get_RenderGraphResourceRegistry_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphResourceRegistry>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059609, XrefRangeEnd = 1059615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_current_Internal_Static_set_Void_RenderGraphResourceRegistry_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static RenderGraphResourceRegistry()
	{
		Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "RenderGraphResourceRegistry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr);
		NativeFieldInfoPtr_kSharedResourceLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "kSharedResourceLifetime");
		NativeFieldInfoPtr_m_CurrentRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_CurrentRegistry");
		NativeFieldInfoPtr_m_RenderGraphResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_RenderGraphResources");
		NativeFieldInfoPtr_m_RendererListResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_RendererListResources");
		NativeFieldInfoPtr_m_RendererListLegacyResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_RendererListLegacyResources");
		NativeFieldInfoPtr_m_RenderGraphDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_RenderGraphDebug");
		NativeFieldInfoPtr_m_ResourceLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_ResourceLogger");
		NativeFieldInfoPtr_m_FrameInformationLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_FrameInformationLogger");
		NativeFieldInfoPtr_m_CurrentFrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_CurrentFrameIndex");
		NativeFieldInfoPtr_m_ExecutionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_ExecutionCount");
		NativeFieldInfoPtr_m_CurrentBackbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_CurrentBackbuffer");
		NativeFieldInfoPtr_kInitialRendererListCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "kInitialRendererListCount");
		NativeFieldInfoPtr_m_ActiveRendererLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_ActiveRendererLists");
		NativeFieldInfoPtr_emptyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "emptyId");
		NativeFieldInfoPtr_builtinCameraRenderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "builtinCameraRenderTarget");
		NativeFieldInfoPtr_forceManualClearOfResource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "forceManualClearOfResource");
		NativeMethodInfoPtr_get_current_Internal_Static_get_RenderGraphResourceRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667566);
		NativeMethodInfoPtr_set_current_Internal_Static_set_Void_RenderGraphResourceRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667567);
		NativeMethodInfoPtr_CheckTextureResource_Private_Void_TextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667568);
		NativeMethodInfoPtr_GetTexture_Internal_RTHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667569);
		NativeMethodInfoPtr_GetTexture_Internal_RTHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667570);
		NativeMethodInfoPtr_TextureNeedsFallback_Internal_Boolean_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667571);
		NativeMethodInfoPtr_GetRendererList_Internal_RendererList_byref_RendererListHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667572);
		NativeMethodInfoPtr_CheckBufferResource_Private_Void_BufferResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667573);
		NativeMethodInfoPtr_GetBuffer_Internal_GraphicsBuffer_byref_BufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667574);
		NativeMethodInfoPtr_GetBuffer_Internal_GraphicsBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667575);
		NativeMethodInfoPtr_GetRayTracingAccelerationStructure_Internal_RayTracingAccelerationStructure_byref_RayTracingAccelerationStructureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667576);
		NativeMethodInfoPtr_GetSharedResourceCount_Internal_Int32_RenderGraphResourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667577);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667578);
		NativeMethodInfoPtr__ctor_Internal_Void_RenderGraphDebugParams_RenderGraphLogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667579);
		NativeMethodInfoPtr_BeginRenderGraph_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667580);
		NativeMethodInfoPtr_BeginExecute_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667581);
		NativeMethodInfoPtr_EndExecute_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667582);
		NativeMethodInfoPtr_CheckHandleValidity_Private_Void_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667583);
		NativeMethodInfoPtr_CheckHandleValidity_Private_Void_RenderGraphResourceType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667584);
		NativeMethodInfoPtr_IncrementWriteCount_Internal_Void_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667585);
		NativeMethodInfoPtr_IncrementReadCount_Internal_Void_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667586);
		NativeMethodInfoPtr_NewVersion_Internal_Void_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667587);
		NativeMethodInfoPtr_GetLatestVersionHandle_Internal_ResourceHandle_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667588);
		NativeMethodInfoPtr_GetLatestVersionNumber_Internal_Int32_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667589);
		NativeMethodInfoPtr_GetZeroVersionedHandle_Internal_ResourceHandle_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667590);
		NativeMethodInfoPtr_GetNewVersionedHandle_Internal_ResourceHandle_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667591);
		NativeMethodInfoPtr_GetResourceLowLevel_Internal_IRenderGraphResource_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667592);
		NativeMethodInfoPtr_GetRenderGraphResourceName_Internal_String_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667593);
		NativeMethodInfoPtr_GetRenderGraphResourceName_Internal_String_RenderGraphResourceType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667594);
		NativeMethodInfoPtr_IsRenderGraphResourceImported_Internal_Boolean_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667595);
		NativeMethodInfoPtr_IsRenderGraphResourceForceReleased_Internal_Boolean_RenderGraphResourceType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667596);
		NativeMethodInfoPtr_IsRenderGraphResourceShared_Internal_Boolean_RenderGraphResourceType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667597);
		NativeMethodInfoPtr_IsRenderGraphResourceShared_Internal_Boolean_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667598);
		NativeMethodInfoPtr_IsGraphicsResourceCreated_Internal_Boolean_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667599);
		NativeMethodInfoPtr_IsRendererListCreated_Internal_Boolean_byref_RendererListHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667600);
		NativeMethodInfoPtr_IsRenderGraphResourceImported_Internal_Boolean_RenderGraphResourceType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667601);
		NativeMethodInfoPtr_GetRenderGraphResourceTransientIndex_Internal_Int32_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667602);
		NativeMethodInfoPtr_ImportTexture_Internal_TextureHandle_byref_RTHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667603);
		NativeMethodInfoPtr_ImportTexture_Internal_TextureHandle_byref_RTHandle_byref_ImportResourceParams_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667604);
		NativeMethodInfoPtr_ImportTexture_Internal_TextureHandle_byref_RTHandle_RenderTargetInfo_byref_ImportResourceParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667605);
		NativeMethodInfoPtr_CreateSharedTexture_Internal_TextureHandle_byref_TextureDesc_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667606);
		NativeMethodInfoPtr_RefreshSharedTextureDesc_Internal_Void_byref_TextureHandle_byref_TextureDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667607);
		NativeMethodInfoPtr_ReleaseSharedTexture_Internal_Void_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667608);
		NativeMethodInfoPtr_ImportBackbuffer_Internal_TextureHandle_RenderTargetIdentifier_byref_RenderTargetInfo_byref_ImportResourceParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667609);
		NativeMethodInfoPtr_ValidateRenderTarget_Private_Void_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667610);
		NativeMethodInfoPtr_GetRenderTargetInfo_Internal_Void_byref_ResourceHandle_byref_RenderTargetInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667611);
		NativeMethodInfoPtr_GetFormat_Internal_GraphicsFormat_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667612);
		NativeMethodInfoPtr_ValidateFormat_Internal_Void_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667613);
		NativeMethodInfoPtr_CreateTexture_Internal_TextureHandle_byref_TextureDesc_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667614);
		NativeMethodInfoPtr_GetResourceCount_Internal_Int32_RenderGraphResourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667615);
		NativeMethodInfoPtr_GetTextureResourceCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667616);
		NativeMethodInfoPtr_GetTextureResource_Internal_TextureResource_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667617);
		NativeMethodInfoPtr_GetTextureResource_Internal_TextureResource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667618);
		NativeMethodInfoPtr_GetTextureResourceDesc_Internal_TextureDesc_byref_ResourceHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667619);
		NativeMethodInfoPtr_CreateRendererList_Internal_RendererListHandle_byref_RendererListDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667620);
		NativeMethodInfoPtr_CreateRendererList_Internal_RendererListHandle_byref_RendererListParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667621);
		NativeMethodInfoPtr_CreateShadowRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_ShadowDrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667622);
		NativeMethodInfoPtr_CreateGizmoRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_byref_GizmoSubset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667623);
		NativeMethodInfoPtr_CreateUIOverlayRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_byref_UISubset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667624);
		NativeMethodInfoPtr_CreateWireOverlayRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667625);
		NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667626);
		NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667627);
		NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667628);
		NativeMethodInfoPtr_ImportBuffer_Internal_BufferHandle_GraphicsBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667629);
		NativeMethodInfoPtr_CreateBuffer_Internal_BufferHandle_byref_BufferDesc_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667630);
		NativeMethodInfoPtr_GetBufferResourceDesc_Internal_BufferDesc_byref_ResourceHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667631);
		NativeMethodInfoPtr_GetBufferResourceCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667632);
		NativeMethodInfoPtr_GetBufferResource_Private_BufferResource_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667633);
		NativeMethodInfoPtr_GetBufferResource_Private_BufferResource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667634);
		NativeMethodInfoPtr_GetRayTracingAccelerationStructureResource_Private_RayTracingAccelerationStructureResource_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667635);
		NativeMethodInfoPtr_GetRayTracingAccelerationStructureResourceCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667636);
		NativeMethodInfoPtr_ImportRayTracingAccelerationStructure_Internal_RayTracingAccelerationStructureHandle_byref_RayTracingAccelerationStructure_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667637);
		NativeMethodInfoPtr_UpdateSharedResourceLastFrameIndex_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667638);
		NativeMethodInfoPtr_UpdateSharedResourceLastFrameIndex_Internal_Void_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667639);
		NativeMethodInfoPtr_ManageSharedRenderGraphResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667640);
		NativeMethodInfoPtr_CreatePooledResource_Internal_Boolean_InternalRenderGraphContext_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667641);
		NativeMethodInfoPtr_CreatePooledResource_Internal_Boolean_InternalRenderGraphContext_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667642);
		NativeMethodInfoPtr_CreateTextureCallback_Private_Boolean_InternalRenderGraphContext_IRenderGraphResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667643);
		NativeMethodInfoPtr_ClearResource_Internal_Void_InternalRenderGraphContext_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667644);
		NativeMethodInfoPtr_ClearTexture_Private_Void_InternalRenderGraphContext_TextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667645);
		NativeMethodInfoPtr_ReleasePooledResource_Internal_Void_InternalRenderGraphContext_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667646);
		NativeMethodInfoPtr_ReleasePooledResource_Internal_Void_InternalRenderGraphContext_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667647);
		NativeMethodInfoPtr_ReleaseTextureCallback_Private_Void_InternalRenderGraphContext_IRenderGraphResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667648);
		NativeMethodInfoPtr_ValidateTextureDesc_Private_Void_byref_TextureDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667649);
		NativeMethodInfoPtr_ValidateRendererListDesc_Private_Void_byref_RendererListDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667650);
		NativeMethodInfoPtr_ValidateBufferDesc_Private_Void_byref_BufferDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667651);
		NativeMethodInfoPtr_CreateRendererLists_Internal_Void_List_1_RendererListHandle_ScriptableRenderContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667652);
		NativeMethodInfoPtr_Clear_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667653);
		NativeMethodInfoPtr_PurgeUnusedGraphicsResources_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667654);
		NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667655);
		NativeMethodInfoPtr_FlushLogs_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667656);
		NativeMethodInfoPtr_LogResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100667657);
	}

	[CallerCount(0)]
	public unsafe void CheckTextureResource(TextureResource texResource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texResource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckTextureResource_Private_Void_TextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1059623, RefRangeEnd = 1059630, XrefRangeStart = 1059615, XrefRangeEnd = 1059623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RTHandle GetTexture([In] ref TextureHandle handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTexture_Internal_RTHandle_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1059635, RefRangeEnd = 1059636, XrefRangeStart = 1059630, XrefRangeEnd = 1059635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RTHandle GetTexture(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTexture_Internal_RTHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1059644, RefRangeEnd = 1059646, XrefRangeStart = 1059636, XrefRangeEnd = 1059644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TextureNeedsFallback([In] ref TextureHandle handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TextureNeedsFallback_Internal_Boolean_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1059662, RefRangeEnd = 1059664, XrefRangeStart = 1059646, XrefRangeEnd = 1059662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererList GetRendererList([In] ref RendererListHandle handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRendererList_Internal_RendererList_byref_RendererListHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererList*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void CheckBufferResource(BufferResource bufferResource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bufferResource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckBufferResource_Private_Void_BufferResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059664, XrefRangeEnd = 1059679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphicsBuffer GetBuffer([In] ref BufferHandle handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuffer_Internal_GraphicsBuffer_byref_BufferHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059679, XrefRangeEnd = 1059684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphicsBuffer GetBuffer(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuffer_Internal_GraphicsBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059684, XrefRangeEnd = 1059699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RayTracingAccelerationStructure GetRayTracingAccelerationStructure([In] ref RayTracingAccelerationStructureHandle handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayTracingAccelerationStructure_Internal_RayTracingAccelerationStructure_byref_RayTracingAccelerationStructureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RayTracingAccelerationStructure>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1059699, RefRangeEnd = 1059701, XrefRangeStart = 1059699, XrefRangeEnd = 1059699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetSharedResourceCount(RenderGraphResourceType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSharedResourceCount_Internal_Int32_RenderGraphResourceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059701, XrefRangeEnd = 1059732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderGraphResourceRegistry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1059839, RefRangeEnd = 1059840, XrefRangeStart = 1059732, XrefRangeEnd = 1059839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderGraphResourceRegistry(RenderGraphDebugParams renderGraphDebug, RenderGraphLogger frameInformationLogger)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraphDebug);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameInformationLogger);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_RenderGraphDebugParams_RenderGraphLogger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1059867, RefRangeEnd = 1059868, XrefRangeStart = 1059840, XrefRangeEnd = 1059867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginRenderGraph(int executionCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&executionCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginRenderGraph_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1059884, RefRangeEnd = 1059886, XrefRangeStart = 1059868, XrefRangeEnd = 1059884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginExecute(int currentFrameIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currentFrameIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginExecute_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059886, XrefRangeEnd = 1059895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndExecute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndExecute_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckHandleValidity([In] ref ResourceHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckHandleValidity_Private_Void_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059895, XrefRangeEnd = 1059903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckHandleValidity(RenderGraphResourceType type, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckHandleValidity_Private_Void_RenderGraphResourceType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1059914, RefRangeEnd = 1059923, XrefRangeStart = 1059903, XrefRangeEnd = 1059914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncrementWriteCount([In] ref ResourceHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncrementWriteCount_Internal_Void_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1059934, RefRangeEnd = 1059936, XrefRangeStart = 1059923, XrefRangeEnd = 1059934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncrementReadCount([In] ref ResourceHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncrementReadCount_Internal_Void_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059936, XrefRangeEnd = 1059947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NewVersion([In] ref ResourceHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewVersion_Internal_Void_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1059960, RefRangeEnd = 1059963, XrefRangeStart = 1059947, XrefRangeEnd = 1059960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResourceHandle GetLatestVersionHandle([In] ref ResourceHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLatestVersionHandle_Internal_ResourceHandle_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ResourceHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059963, XrefRangeEnd = 1059973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetLatestVersionNumber([In] ref ResourceHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLatestVersionNumber_Internal_Int32_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059973, XrefRangeEnd = 1059976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResourceHandle GetZeroVersionedHandle([In] ref ResourceHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetZeroVersionedHandle_Internal_ResourceHandle_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ResourceHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059976, XrefRangeEnd = 1059989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResourceHandle GetNewVersionedHandle([In] ref ResourceHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewVersionedHandle_Internal_ResourceHandle_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ResourceHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1059998, RefRangeEnd = 1059999, XrefRangeStart = 1059989, XrefRangeEnd = 1059998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IRenderGraphResource GetResourceLowLevel([In] ref ResourceHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourceLowLevel_Internal_IRenderGraphResource_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IRenderGraphResource>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059999, XrefRangeEnd = 1060010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetRenderGraphResourceName([In] ref ResourceHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderGraphResourceName_Internal_String_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060015, RefRangeEnd = 1060016, XrefRangeStart = 1060010, XrefRangeEnd = 1060015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetRenderGraphResourceName(RenderGraphResourceType type, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderGraphResourceName_Internal_String_RenderGraphResourceType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1060025, RefRangeEnd = 1060030, XrefRangeStart = 1060016, XrefRangeEnd = 1060025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsRenderGraphResourceImported([In] ref ResourceHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRenderGraphResourceImported_Internal_Boolean_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060033, RefRangeEnd = 1060034, XrefRangeStart = 1060030, XrefRangeEnd = 1060033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsRenderGraphResourceForceReleased(RenderGraphResourceType type, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRenderGraphResourceForceReleased_Internal_Boolean_RenderGraphResourceType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060034, RefRangeEnd = 1060035, XrefRangeStart = 1060034, XrefRangeEnd = 1060034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsRenderGraphResourceShared(RenderGraphResourceType type, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRenderGraphResourceShared_Internal_Boolean_RenderGraphResourceType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1060038, RefRangeEnd = 1060044, XrefRangeStart = 1060035, XrefRangeEnd = 1060038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsRenderGraphResourceShared([In] ref ResourceHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRenderGraphResourceShared_Internal_Boolean_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060055, RefRangeEnd = 1060056, XrefRangeStart = 1060044, XrefRangeEnd = 1060055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsGraphicsResourceCreated([In] ref ResourceHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGraphicsResourceCreated_Internal_Boolean_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060071, RefRangeEnd = 1060072, XrefRangeStart = 1060056, XrefRangeEnd = 1060071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsRendererListCreated([In] ref RendererListHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRendererListCreated_Internal_Boolean_byref_RendererListHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060075, RefRangeEnd = 1060076, XrefRangeStart = 1060072, XrefRangeEnd = 1060075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsRenderGraphResourceImported(RenderGraphResourceType type, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRenderGraphResourceImported_Internal_Boolean_RenderGraphResourceType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1060085, RefRangeEnd = 1060089, XrefRangeStart = 1060076, XrefRangeEnd = 1060085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRenderGraphResourceTransientIndex([In] ref ResourceHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderGraphResourceTransientIndex_Internal_Int32_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1060090, RefRangeEnd = 1060092, XrefRangeStart = 1060089, XrefRangeEnd = 1060090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle ImportTexture([In] ref RTHandle rt, bool isBuiltin = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		*ptr = (nint)(&intPtr);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBuiltin;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportTexture_Internal_TextureHandle_byref_RTHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		rt = ((intPtr4 == (System.IntPtr)0) ? null : new RTHandle(intPtr4));
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1060129, RefRangeEnd = 1060131, XrefRangeStart = 1060092, XrefRangeEnd = 1060129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle ImportTexture([In] ref RTHandle rt, [In] ref ImportResourceParams importParams, bool isBuiltin = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref importParams);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBuiltin;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportTexture_Internal_TextureHandle_byref_RTHandle_byref_ImportResourceParams_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		rt = ((intPtr4 == (System.IntPtr)0) ? null : new RTHandle(intPtr4));
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060145, RefRangeEnd = 1060146, XrefRangeStart = 1060131, XrefRangeEnd = 1060145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle ImportTexture([In] ref RTHandle rt, RenderTargetInfo info, [In] ref ImportResourceParams importParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		*ptr = (nint)(&intPtr);
		*(RenderTargetInfo**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &info;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref importParams);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportTexture_Internal_TextureHandle_byref_RTHandle_RenderTargetInfo_byref_ImportResourceParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		rt = ((intPtr4 == (System.IntPtr)0) ? null : new RTHandle(intPtr4));
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060163, RefRangeEnd = 1060164, XrefRangeStart = 1060146, XrefRangeEnd = 1060163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle CreateSharedTexture([In] ref TextureDesc desc, bool explicitRelease)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &explicitRelease;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSharedTexture_Internal_TextureHandle_byref_TextureDesc_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060167, RefRangeEnd = 1060168, XrefRangeStart = 1060164, XrefRangeEnd = 1060167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshSharedTextureDesc([In] ref TextureHandle texture, [In] ref TextureDesc desc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref texture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshSharedTextureDesc_Internal_Void_byref_TextureHandle_byref_TextureDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060174, RefRangeEnd = 1060175, XrefRangeStart = 1060168, XrefRangeEnd = 1060174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseSharedTexture([In] ref TextureHandle texture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref texture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseSharedTexture_Internal_Void_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1060193, RefRangeEnd = 1060195, XrefRangeStart = 1060175, XrefRangeEnd = 1060193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle ImportBackbuffer(RenderTargetIdentifier rt, [In] ref RenderTargetInfo info, [In] ref ImportResourceParams importParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rt);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref info);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref importParams);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportBackbuffer_Internal_TextureHandle_RenderTargetIdentifier_byref_RenderTargetInfo_byref_ImportResourceParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060195, XrefRangeEnd = 1060203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateRenderTarget([In] ref ResourceHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateRenderTarget_Private_Void_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1060209, RefRangeEnd = 1060216, XrefRangeStart = 1060203, XrefRangeEnd = 1060209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetRenderTargetInfo([In] ref ResourceHandle res, out RenderTargetInfo outInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref res);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref outInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderTargetInfo_Internal_Void_byref_ResourceHandle_byref_RenderTargetInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe GraphicsFormat GetFormat(GraphicsFormat color, GraphicsFormat depthStencil)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&color);
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthStencil;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFormat_Internal_GraphicsFormat_GraphicsFormat_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060216, XrefRangeEnd = 1060223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateFormat(GraphicsFormat color, GraphicsFormat depthStencil)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&color);
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthStencil;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateFormat_Internal_Void_GraphicsFormat_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1060232, RefRangeEnd = 1060242, XrefRangeStart = 1060223, XrefRangeEnd = 1060232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle CreateTexture([In] ref TextureDesc desc, int transientPassIndex = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &transientPassIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTexture_Internal_TextureHandle_byref_TextureDesc_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060243, RefRangeEnd = 1060244, XrefRangeStart = 1060242, XrefRangeEnd = 1060243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetResourceCount(RenderGraphResourceType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourceCount_Internal_Int32_RenderGraphResourceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060244, XrefRangeEnd = 1060245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetTextureResourceCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureResourceCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1060253, RefRangeEnd = 1060260, XrefRangeStart = 1060245, XrefRangeEnd = 1060253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureResource GetTextureResource([In] ref ResourceHandle handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureResource_Internal_TextureResource_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureResource>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060260, XrefRangeEnd = 1060265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureResource GetTextureResource(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureResource_Internal_TextureResource_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureResource>(intPtr2) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1060273, RefRangeEnd = 1060282, XrefRangeStart = 1060265, XrefRangeEnd = 1060273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureDesc GetTextureResourceDesc([In] ref ResourceHandle handle, bool noThrowOnInvalidDesc = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &noThrowOnInvalidDesc;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureResourceDesc_Internal_TextureDesc_byref_ResourceHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new TextureDesc(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060290, RefRangeEnd = 1060291, XrefRangeStart = 1060282, XrefRangeEnd = 1060290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateRendererList([In] ref RendererListDesc desc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererList_Internal_RendererListHandle_byref_RendererListDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060296, RefRangeEnd = 1060297, XrefRangeStart = 1060291, XrefRangeEnd = 1060296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateRendererList([In] ref RendererListParams desc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererList_Internal_RendererListHandle_byref_RendererListParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060304, RefRangeEnd = 1060305, XrefRangeStart = 1060297, XrefRangeEnd = 1060304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateShadowRendererList(ScriptableRenderContext context, ref ShadowDrawingSettings shadowDrawinSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowDrawinSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateShadowRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_ShadowDrawingSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060312, RefRangeEnd = 1060313, XrefRangeStart = 1060305, XrefRangeEnd = 1060312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateGizmoRendererList(ScriptableRenderContext context, [In] ref Camera camera, [In] ref GizmoSubset gizmoSubset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&context);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref gizmoSubset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGizmoRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_byref_GizmoSubset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		camera = ((intPtr4 == (System.IntPtr)0) ? null : new Camera(intPtr4));
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1060320, RefRangeEnd = 1060322, XrefRangeStart = 1060313, XrefRangeEnd = 1060320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateUIOverlayRendererList(ScriptableRenderContext context, [In] ref Camera camera, [In] ref UISubset uiSubset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&context);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref uiSubset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUIOverlayRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_byref_UISubset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		camera = ((intPtr4 == (System.IntPtr)0) ? null : new Camera(intPtr4));
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060329, RefRangeEnd = 1060330, XrefRangeStart = 1060322, XrefRangeEnd = 1060329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateWireOverlayRendererList(ScriptableRenderContext context, [In] ref Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWireOverlayRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		camera = ((intPtr4 == (System.IntPtr)0) ? null : new Camera(intPtr4));
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060337, RefRangeEnd = 1060338, XrefRangeStart = 1060330, XrefRangeEnd = 1060337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateSkyboxRendererList(ScriptableRenderContext context, [In] ref Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		camera = ((intPtr4 == (System.IntPtr)0) ? null : new Camera(intPtr4));
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060345, RefRangeEnd = 1060346, XrefRangeStart = 1060338, XrefRangeEnd = 1060345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateSkyboxRendererList(ScriptableRenderContext context, [In] ref Camera camera, Matrix4x4 projectionMatrix, Matrix4x4 viewMatrix)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&context);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr**)num = &intPtr;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &projectionMatrix;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewMatrix;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_Matrix4x4_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		camera = ((intPtr4 == (System.IntPtr)0) ? null : new Camera(intPtr4));
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060353, RefRangeEnd = 1060354, XrefRangeStart = 1060346, XrefRangeEnd = 1060353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateSkyboxRendererList(ScriptableRenderContext context, [In] ref Camera camera, Matrix4x4 projectionMatrixL, Matrix4x4 viewMatrixL, Matrix4x4 projectionMatrixR, Matrix4x4 viewMatrixR)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&context);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr**)num = &intPtr;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &projectionMatrixL;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewMatrixL;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &projectionMatrixR;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewMatrixR;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_RendererListHandle_ScriptableRenderContext_byref_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		camera = ((intPtr4 == (System.IntPtr)0) ? null : new Camera(intPtr4));
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060363, RefRangeEnd = 1060364, XrefRangeStart = 1060354, XrefRangeEnd = 1060363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BufferHandle ImportBuffer(GraphicsBuffer graphicsBuffer, bool forceRelease = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphicsBuffer);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceRelease;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportBuffer_Internal_BufferHandle_GraphicsBuffer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BufferHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1060373, RefRangeEnd = 1060382, XrefRangeStart = 1060364, XrefRangeEnd = 1060373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BufferHandle CreateBuffer([In] ref BufferDesc desc, int transientPassIndex = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &transientPassIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBuffer_Internal_BufferHandle_byref_BufferDesc_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BufferHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1060390, RefRangeEnd = 1060396, XrefRangeStart = 1060382, XrefRangeEnd = 1060390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BufferDesc GetBufferResourceDesc([In] ref ResourceHandle handle, bool noThrowOnInvalidDesc = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &noThrowOnInvalidDesc;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBufferResourceDesc_Internal_BufferDesc_byref_ResourceHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BufferDesc(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060396, XrefRangeEnd = 1060397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBufferResourceCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBufferResourceCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060397, XrefRangeEnd = 1060405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BufferResource GetBufferResource([In] ref ResourceHandle handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBufferResource_Private_BufferResource_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BufferResource>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060405, XrefRangeEnd = 1060410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BufferResource GetBufferResource(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBufferResource_Private_BufferResource_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BufferResource>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060410, XrefRangeEnd = 1060418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RayTracingAccelerationStructureResource GetRayTracingAccelerationStructureResource([In] ref ResourceHandle handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayTracingAccelerationStructureResource_Private_RayTracingAccelerationStructureResource_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RayTracingAccelerationStructureResource>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060418, XrefRangeEnd = 1060419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRayTracingAccelerationStructureResourceCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayTracingAccelerationStructureResourceCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060425, RefRangeEnd = 1060426, XrefRangeStart = 1060419, XrefRangeEnd = 1060425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RayTracingAccelerationStructureHandle ImportRayTracingAccelerationStructure([In] ref RayTracingAccelerationStructure accelStruct, string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)accelStruct);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportRayTracingAccelerationStructure_Internal_RayTracingAccelerationStructureHandle_byref_RayTracingAccelerationStructure_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		accelStruct = ((intPtr4 == (System.IntPtr)0) ? null : new RayTracingAccelerationStructure(intPtr4));
		return *(RayTracingAccelerationStructureHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1060429, RefRangeEnd = 1060432, XrefRangeStart = 1060426, XrefRangeEnd = 1060429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSharedResourceLastFrameIndex(int type, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSharedResourceLastFrameIndex_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060432, XrefRangeEnd = 1060438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSharedResourceLastFrameIndex([In] ref ResourceHandle handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSharedResourceLastFrameIndex_Internal_Void_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060438, XrefRangeEnd = 1060443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManageSharedRenderGraphResources()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManageSharedRenderGraphResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1060453, RefRangeEnd = 1060457, XrefRangeStart = 1060443, XrefRangeEnd = 1060453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CreatePooledResource(InternalRenderGraphContext rgContext, int type, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePooledResource_Internal_Boolean_InternalRenderGraphContext_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060457, XrefRangeEnd = 1060464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CreatePooledResource(InternalRenderGraphContext rgContext, [In] ref ResourceHandle handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePooledResource_Internal_Boolean_InternalRenderGraphContext_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060464, XrefRangeEnd = 1060468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CreateTextureCallback(InternalRenderGraphContext rgContext, IRenderGraphResource res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTextureCallback_Private_Boolean_InternalRenderGraphContext_IRenderGraphResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1060474, RefRangeEnd = 1060476, XrefRangeStart = 1060468, XrefRangeEnd = 1060474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearResource(InternalRenderGraphContext rgContext, int type, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearResource_Internal_Void_InternalRenderGraphContext_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1060485, RefRangeEnd = 1060487, XrefRangeStart = 1060476, XrefRangeEnd = 1060485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearTexture(InternalRenderGraphContext rgContext, TextureResource resource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearTexture_Private_Void_InternalRenderGraphContext_TextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1060490, RefRangeEnd = 1060495, XrefRangeStart = 1060487, XrefRangeEnd = 1060490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleasePooledResource(InternalRenderGraphContext rgContext, int type, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleasePooledResource_Internal_Void_InternalRenderGraphContext_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060495, XrefRangeEnd = 1060502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleasePooledResource(InternalRenderGraphContext rgContext, [In] ref ResourceHandle handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleasePooledResource_Internal_Void_InternalRenderGraphContext_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060502, XrefRangeEnd = 1060514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseTextureCallback(InternalRenderGraphContext rgContext, IRenderGraphResource res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)res);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseTextureCallback_Private_Void_InternalRenderGraphContext_IRenderGraphResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060514, XrefRangeEnd = 1060522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateTextureDesc([In] ref TextureDesc desc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateTextureDesc_Private_Void_byref_TextureDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060522, XrefRangeEnd = 1060541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateRendererListDesc([In] ref RendererListDesc desc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateRendererListDesc_Private_Void_byref_RendererListDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060541, XrefRangeEnd = 1060548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateBufferDesc([In] ref BufferDesc desc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateBufferDesc_Private_Void_byref_BufferDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1060580, RefRangeEnd = 1060584, XrefRangeStart = 1060548, XrefRangeEnd = 1060580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateRendererLists(List<RendererListHandle> rendererLists, ScriptableRenderContext context, bool manualDispatch = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rendererLists);
		*(ScriptableRenderContext**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &context;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &manualDispatch;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererLists_Internal_Void_List_1_RendererListHandle_ScriptableRenderContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1060605, RefRangeEnd = 1060608, XrefRangeStart = 1060584, XrefRangeEnd = 1060605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear(bool onException)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&onException);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060608, RefRangeEnd = 1060609, XrefRangeStart = 1060608, XrefRangeEnd = 1060608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PurgeUnusedGraphicsResources()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PurgeUnusedGraphicsResources_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060618, RefRangeEnd = 1060619, XrefRangeStart = 1060609, XrefRangeEnd = 1060618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1060625, RefRangeEnd = 1060626, XrefRangeStart = 1060619, XrefRangeEnd = 1060625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FlushLogs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlushLogs_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060626, XrefRangeEnd = 1060637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LogResources()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RenderGraphResourceRegistry(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
