using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class AsyncOperation : YieldInstruction
{
	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToManaged_Public_Static_AsyncOperation_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_AsyncOperation_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToManaged_Public_Static_AsyncOperation_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100666160);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100666161);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185871, XrefRangeEnd = 1185877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation ConvertToManaged(System.IntPtr ptr)
		{
			System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
			*ptr2 = (nint)(&ptr);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToManaged_Public_Static_AsyncOperation_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(AsyncOperation asyncOperation)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncOperation);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_AsyncOperation_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate float get_progress_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_priority_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_priority_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate bool get_allowSceneActivation_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_allowSceneActivation_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_completeCallback;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetManagedObject_Private_Static_Void_IntPtr_AsyncOperation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isDone_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly get_progress_InjectedDelegate get_progress_InjectedDelegateField;

	private static readonly get_priority_InjectedDelegate get_priority_InjectedDelegateField;

	private static readonly set_priority_InjectedDelegate set_priority_InjectedDelegateField;

	private static readonly get_allowSceneActivation_InjectedDelegate get_allowSceneActivation_InjectedDelegateField;

	private static readonly set_allowSceneActivation_InjectedDelegate set_allowSceneActivation_InjectedDelegateField;

	public unsafe System.IntPtr m_Ptr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr)) = value;
		}
	}

	public unsafe Il2CppSystem.Action<AsyncOperation> m_completeCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_completeCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<AsyncOperation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_completeCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool isDone
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1185885, RefRangeEnd = 1185888, XrefRangeStart = 1185881, XrefRangeEnd = 1185885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public float progress
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_progress_Injected(intPtr);
		}
	}

	public int priority
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_priority_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_priority_Injected(intPtr, value);
		}
	}

	public bool allowSceneActivation
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_allowSceneActivation_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_allowSceneActivation_Injected(intPtr, value);
		}
	}

	static AsyncOperation()
	{
		Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AsyncOperation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_m_completeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, "m_completeCallback");
		NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666152);
		NativeMethodInfoPtr_InternalSetManagedObject_Private_Static_Void_IntPtr_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666153);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666154);
		NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666156);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666157);
		NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666158);
		NativeMethodInfoPtr_get_isDone_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666159);
		get_progress_InjectedDelegateField = IL2CPP.ResolveICall<get_progress_InjectedDelegate>("UnityEngine.AsyncOperation::get_progress_Injected");
		get_priority_InjectedDelegateField = IL2CPP.ResolveICall<get_priority_InjectedDelegate>("UnityEngine.AsyncOperation::get_priority_Injected");
		set_priority_InjectedDelegateField = IL2CPP.ResolveICall<set_priority_InjectedDelegate>("UnityEngine.AsyncOperation::set_priority_Injected");
		get_allowSceneActivation_InjectedDelegateField = IL2CPP.ResolveICall<get_allowSceneActivation_InjectedDelegate>("UnityEngine.AsyncOperation::get_allowSceneActivation_Injected");
		set_allowSceneActivation_InjectedDelegateField = IL2CPP.ResolveICall<set_allowSceneActivation_InjectedDelegate>("UnityEngine.AsyncOperation::set_allowSceneActivation_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185877, XrefRangeEnd = 1185879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalDestroy(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185879, XrefRangeEnd = 1185881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetManagedObject(System.IntPtr ptr, AsyncOperation self)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)(&ptr);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetManagedObject_Private_Static_Void_IntPtr_AsyncOperation_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AsyncOperation()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185888, XrefRangeEnd = 1185893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185893, XrefRangeEnd = 1185894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InvokeCompletionEvent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185894, XrefRangeEnd = 1185896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_isDone_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isDone_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AsyncOperation(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public void add_completed(Il2CppSystem.Action<AsyncOperation> value)
	{
		if (isDone)
		{
			value.Invoke(this);
		}
		else
		{
			m_completeCallback = ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(m_completeCallback, value)).Cast<Il2CppSystem.Action<AsyncOperation>>();
		}
	}

	[SpecialName]
	public void remove_completed(Il2CppSystem.Action<AsyncOperation> value)
	{
		m_completeCallback = ((Il2CppObjectBase)Il2CppSystem.Delegate.Remove(m_completeCallback, value)).Cast<Il2CppSystem.Action<AsyncOperation>>();
	}

	public static float get_progress_Injected(System.IntPtr _unity_self)
	{
		return get_progress_InjectedDelegateField(_unity_self);
	}

	public static int get_priority_Injected(System.IntPtr _unity_self)
	{
		return get_priority_InjectedDelegateField(_unity_self);
	}

	public static void set_priority_Injected(System.IntPtr _unity_self, int value)
	{
		set_priority_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_allowSceneActivation_Injected(System.IntPtr _unity_self)
	{
		return get_allowSceneActivation_InjectedDelegateField(_unity_self);
	}

	public static void set_allowSceneActivation_Injected(System.IntPtr _unity_self, bool value)
	{
		set_allowSceneActivation_InjectedDelegateField(_unity_self, value);
	}
}
