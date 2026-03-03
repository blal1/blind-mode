using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Threading;

namespace Il2CppSystem;

public class LazyHelper : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_NoneViaConstructor;

	private static readonly System.IntPtr NativeFieldInfoPtr_NoneViaFactory;

	private static readonly System.IntPtr NativeFieldInfoPtr_PublicationOnlyViaConstructor;

	private static readonly System.IntPtr NativeFieldInfoPtr_PublicationOnlyViaFactory;

	private static readonly System.IntPtr NativeFieldInfoPtr_PublicationOnlyWaitForOtherThreadToPublish;

	private static readonly System.IntPtr NativeFieldInfoPtr__State_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__exceptionDispatch;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_State_Internal_get_LazyState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_LazyState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_LazyThreadSafetyMode_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowException_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Internal_Static_LazyHelper_LazyThreadSafetyMode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateViaDefaultConstructor_Internal_Static_Object_Type_0;

	public unsafe static LazyHelper NoneViaConstructor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NoneViaConstructor, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LazyHelper>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NoneViaConstructor, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static LazyHelper NoneViaFactory
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NoneViaFactory, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LazyHelper>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NoneViaFactory, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static LazyHelper PublicationOnlyViaConstructor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PublicationOnlyViaConstructor, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LazyHelper>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PublicationOnlyViaConstructor, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static LazyHelper PublicationOnlyViaFactory
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PublicationOnlyViaFactory, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LazyHelper>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PublicationOnlyViaFactory, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static LazyHelper PublicationOnlyWaitForOtherThreadToPublish
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PublicationOnlyWaitForOtherThreadToPublish, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LazyHelper>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PublicationOnlyWaitForOtherThreadToPublish, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe LazyState _State_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__State_k__BackingField);
			return *(LazyState*)num;
		}
		set
		{
			*(LazyState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__State_k__BackingField)) = value;
		}
	}

	public unsafe ExceptionDispatchInfo _exceptionDispatch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__exceptionDispatch);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__exceptionDispatch)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe LazyState State
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_State_Internal_get_LazyState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LazyState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static LazyHelper()
	{
		Il2CppClassPointerStore<LazyHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "LazyHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr);
		NativeFieldInfoPtr_NoneViaConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, "NoneViaConstructor");
		NativeFieldInfoPtr_NoneViaFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, "NoneViaFactory");
		NativeFieldInfoPtr_PublicationOnlyViaConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, "PublicationOnlyViaConstructor");
		NativeFieldInfoPtr_PublicationOnlyViaFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, "PublicationOnlyViaFactory");
		NativeFieldInfoPtr_PublicationOnlyWaitForOtherThreadToPublish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, "PublicationOnlyWaitForOtherThreadToPublish");
		NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, "<State>k__BackingField");
		NativeFieldInfoPtr__exceptionDispatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, "_exceptionDispatch");
		NativeMethodInfoPtr_get_State_Internal_get_LazyState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, 100665320);
		NativeMethodInfoPtr__ctor_Internal_Void_LazyState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, 100665321);
		NativeMethodInfoPtr__ctor_Internal_Void_LazyThreadSafetyMode_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, 100665322);
		NativeMethodInfoPtr_ThrowException_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, 100665323);
		NativeMethodInfoPtr_Create_Internal_Static_LazyHelper_LazyThreadSafetyMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, 100665324);
		NativeMethodInfoPtr_CreateViaDefaultConstructor_Internal_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, 100665325);
	}

	[CallerCount(207)]
	[CachedScanResults(RefRangeStart = 25387, RefRangeEnd = 25594, XrefRangeStart = 25387, XrefRangeEnd = 25594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LazyHelper(LazyState state)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&state);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_LazyState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731462, XrefRangeEnd = 731467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LazyHelper(LazyThreadSafetyMode mode, Exception exception)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&mode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_LazyThreadSafetyMode_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 731500, RefRangeEnd = 731501, XrefRangeStart = 731467, XrefRangeEnd = 731500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ThrowException()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowException_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 731505, RefRangeEnd = 731510, XrefRangeStart = 731501, XrefRangeEnd = 731505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LazyHelper Create(LazyThreadSafetyMode mode, bool useDefaultConstructor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&mode);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDefaultConstructor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Internal_Static_LazyHelper_LazyThreadSafetyMode_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LazyHelper>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 731511, RefRangeEnd = 731512, XrefRangeStart = 731510, XrefRangeEnd = 731511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object CreateViaDefaultConstructor(Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateViaDefaultConstructor_Internal_Static_Object_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	public LazyHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
