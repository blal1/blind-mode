using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;
using UnityEngine.Bindings;

namespace UnityEngine;

public class AsyncInstantiateOperation : AsyncOperation
{
	public new static class BindingsMarshaller
	{
	}

	private delegate float get_IntegrationTimeMSDelegate();

	private delegate void set_IntegrationTimeMSDelegate(float value);

	private delegate bool IsWaitingForSceneActivation_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void WaitForCompletion_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void Cancel_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeFieldInfoPtr_s_GlobalCancellation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Result;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CancellationToken;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCancellationRequested_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateResultArray_Internal_Virtual_New_Il2CppReferenceArray_1_Object_Int32_0;

	private static readonly get_IntegrationTimeMSDelegate get_IntegrationTimeMSDelegateField;

	private static readonly set_IntegrationTimeMSDelegate set_IntegrationTimeMSDelegateField;

	private static readonly IsWaitingForSceneActivation_InjectedDelegate IsWaitingForSceneActivation_InjectedDelegateField;

	private static readonly WaitForCompletion_InjectedDelegate WaitForCompletion_InjectedDelegateField;

	private static readonly Cancel_InjectedDelegate Cancel_InjectedDelegateField;

	public unsafe static CancellationTokenSource s_GlobalCancellation
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_GlobalCancellation, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_GlobalCancellation, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<Object> m_Result
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Result);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Result)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CancellationToken m_CancellationToken
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CancellationToken);
			return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public Il2CppReferenceArray<Object> Result => m_Result;

	public static float IntegrationTimeMS
	{
		get
		{
			return get_IntegrationTimeMSDelegateField();
		}
		set
		{
			set_IntegrationTimeMSDelegateField(value);
		}
	}

	static AsyncInstantiateOperation()
	{
		Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AsyncInstantiateOperation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr);
		NativeFieldInfoPtr_s_GlobalCancellation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr, "s_GlobalCancellation");
		NativeFieldInfoPtr_m_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr, "m_Result");
		NativeFieldInfoPtr_m_CancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr, "m_CancellationToken");
		NativeMethodInfoPtr_IsCancellationRequested_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr, 100666148);
		NativeMethodInfoPtr_CreateResultArray_Internal_Virtual_New_Il2CppReferenceArray_1_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr, 100666149);
		get_IntegrationTimeMSDelegateField = IL2CPP.ResolveICall<get_IntegrationTimeMSDelegate>("UnityEngine.AsyncInstantiateOperation::get_IntegrationTimeMS");
		set_IntegrationTimeMSDelegateField = IL2CPP.ResolveICall<set_IntegrationTimeMSDelegate>("UnityEngine.AsyncInstantiateOperation::set_IntegrationTimeMS");
		IsWaitingForSceneActivation_InjectedDelegateField = IL2CPP.ResolveICall<IsWaitingForSceneActivation_InjectedDelegate>("UnityEngine.AsyncInstantiateOperation::IsWaitingForSceneActivation_Injected");
		WaitForCompletion_InjectedDelegateField = IL2CPP.ResolveICall<WaitForCompletion_InjectedDelegate>("UnityEngine.AsyncInstantiateOperation::WaitForCompletion_Injected");
		Cancel_InjectedDelegateField = IL2CPP.ResolveICall<Cancel_InjectedDelegate>("UnityEngine.AsyncInstantiateOperation::Cancel_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185854, XrefRangeEnd = 1185866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsCancellationRequested()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCancellationRequested_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185866, XrefRangeEnd = 1185870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppReferenceArray<Object> CreateResultArray(int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateResultArray_Internal_Virtual_New_Il2CppReferenceArray_1_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	public AsyncInstantiateOperation(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public bool IsWaitingForSceneActivation()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsWaitingForSceneActivation_Injected(intPtr);
	}

	public void WaitForCompletion()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		WaitForCompletion_Injected(intPtr);
	}

	public void Cancel()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Cancel_Injected(intPtr);
	}

	public static float GetIntegrationTimeMS()
	{
		return IntegrationTimeMS;
	}

	public static void SetIntegrationTimeMS(float integrationTimeMS)
	{
		if (integrationTimeMS <= 0f)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("integrationTimeMS", "integrationTimeMS was out of range. Must be greater than zero.");
		}
		IntegrationTimeMS = integrationTimeMS;
	}

	public static bool IsWaitingForSceneActivation_Injected(System.IntPtr _unity_self)
	{
		return IsWaitingForSceneActivation_InjectedDelegateField(_unity_self);
	}

	public static void WaitForCompletion_Injected(System.IntPtr _unity_self)
	{
		WaitForCompletion_InjectedDelegateField(_unity_self);
	}

	public static void Cancel_Injected(System.IntPtr _unity_self)
	{
		Cancel_InjectedDelegateField(_unity_self);
	}
}
