using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class AssetBundleCreateRequest : AsyncOperation
{
	public new static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToManaged_Public_Static_AssetBundleCreateRequest_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_AssetBundleCreateRequest_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetBundleCreateRequest>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToManaged_Public_Static_AssetBundleCreateRequest_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100663323);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_AssetBundleCreateRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100663324);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162778, XrefRangeEnd = 1162782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssetBundleCreateRequest ConvertToManaged(System.IntPtr ptr)
		{
			System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
			*ptr2 = (nint)(&ptr);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToManaged_Public_Static_AssetBundleCreateRequest_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr2) : null;
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(AssetBundleCreateRequest assetBundleCreateRequest)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)assetBundleCreateRequest);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_AssetBundleCreateRequest_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate void SetEnableCompatibilityChecks_InjectedDelegate(System.IntPtr _unity_self, bool set);

	private static readonly System.IntPtr NativeMethodInfoPtr_get_assetBundle_Public_get_AssetBundle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_assetBundle_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly SetEnableCompatibilityChecks_InjectedDelegate SetEnableCompatibilityChecks_InjectedDelegateField;

	public unsafe AssetBundle assetBundle
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1162789, RefRangeEnd = 1162790, XrefRangeStart = 1162782, XrefRangeEnd = 1162789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_assetBundle_Public_get_AssetBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
		}
	}

	static AssetBundleCreateRequest()
	{
		Il2CppClassPointerStore<AssetBundleCreateRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AssetBundleModule.dll", "UnityEngine", "AssetBundleCreateRequest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleCreateRequest>.NativeClassPtr);
		NativeMethodInfoPtr_get_assetBundle_Public_get_AssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleCreateRequest>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleCreateRequest>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_get_assetBundle_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleCreateRequest>.NativeClassPtr, 100663322);
		SetEnableCompatibilityChecks_InjectedDelegateField = IL2CPP.ResolveICall<SetEnableCompatibilityChecks_InjectedDelegate>("UnityEngine.AssetBundleCreateRequest::SetEnableCompatibilityChecks_Injected");
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 581313, RefRangeEnd = 581317, XrefRangeStart = 581313, XrefRangeEnd = 581317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssetBundleCreateRequest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleCreateRequest>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162790, XrefRangeEnd = 1162792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_assetBundle_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_assetBundle_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AssetBundleCreateRequest(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void SetEnableCompatibilityChecks(bool set)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetEnableCompatibilityChecks_Injected(intPtr, set);
	}

	public void DisableCompatibilityChecks()
	{
		SetEnableCompatibilityChecks(set: false);
	}

	public static void SetEnableCompatibilityChecks_Injected(System.IntPtr _unity_self, bool set)
	{
		SetEnableCompatibilityChecks_InjectedDelegateField(_unity_self, set);
	}
}
