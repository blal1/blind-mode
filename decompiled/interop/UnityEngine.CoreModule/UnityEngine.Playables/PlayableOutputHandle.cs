using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.Bindings;

namespace UnityEngine.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct PlayableOutputHandle
{
	private sealed class MethodInfoStoreGeneric_IsPlayableOutputOfType_Internal_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_IsPlayableOutputOfType_Internal_Boolean_0, Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private delegate bool IsNullDelegate(System.IntPtr @this);

	private delegate float GetWeightDelegate(System.IntPtr @this);

	private delegate System.IntPtr GetNotificationReceiversDelegate(System.IntPtr @this);

	private delegate void RemoveNotificationReceiverDelegate(System.IntPtr @this, System.IntPtr receiver);

	private delegate System.IntPtr GetReferenceObject_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Version;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Null;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayableOutputOfType_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayableOutputType_Internal_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetReferenceObject_Internal_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUserData_Internal_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUserData_Internal_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSourcePlayable_Internal_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSourcePlayable_Internal_Void_PlayableHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSourceOutputPort_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWeight_Internal_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushNotification_Internal_Void_PlayableHandle_INotification_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNotificationReceiver_Internal_Void_INotificationReceiver_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetReferenceObject_Injected_Private_Static_Void_byref_PlayableOutputHandle_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUserData_Injected_Private_Static_IntPtr_byref_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushNotification_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_INotification_Object_0;

	[FieldOffset(0)]
	public System.IntPtr m_Handle;

	[FieldOffset(8)]
	public uint m_Version;

	private static readonly IsNullDelegate IsNullDelegateField;

	private static readonly GetWeightDelegate GetWeightDelegateField;

	private static readonly GetNotificationReceiversDelegate GetNotificationReceiversDelegateField;

	private static readonly RemoveNotificationReceiverDelegate RemoveNotificationReceiverDelegateField;

	private static readonly GetReferenceObject_InjectedDelegate GetReferenceObject_InjectedDelegateField;

	public unsafe static PlayableOutputHandle m_Null
	{
		get
		{
			Unsafe.SkipInit(out PlayableOutputHandle result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Null, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Null, (void*)(&value));
		}
	}

	public unsafe static PlayableOutputHandle Null
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1230719, RefRangeEnd = 1230721, XrefRangeStart = 1230715, XrefRangeEnd = 1230719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PlayableOutputHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static PlayableOutputHandle()
	{
		Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableOutputHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, "m_Handle");
		NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, "m_Version");
		NativeFieldInfoPtr_m_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, "m_Null");
		NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667555);
		NativeMethodInfoPtr_IsPlayableOutputOfType_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667556);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667557);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667558);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667559);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667560);
		NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667561);
		NativeMethodInfoPtr_IsValid_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667562);
		NativeMethodInfoPtr_GetPlayableOutputType_Internal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667563);
		NativeMethodInfoPtr_SetReferenceObject_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667564);
		NativeMethodInfoPtr_GetUserData_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667565);
		NativeMethodInfoPtr_SetUserData_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667566);
		NativeMethodInfoPtr_GetSourcePlayable_Internal_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667567);
		NativeMethodInfoPtr_SetSourcePlayable_Internal_Void_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667568);
		NativeMethodInfoPtr_GetSourceOutputPort_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667569);
		NativeMethodInfoPtr_SetWeight_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667570);
		NativeMethodInfoPtr_PushNotification_Internal_Void_PlayableHandle_INotification_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667571);
		NativeMethodInfoPtr_AddNotificationReceiver_Internal_Void_INotificationReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667572);
		NativeMethodInfoPtr_SetReferenceObject_Injected_Private_Static_Void_byref_PlayableOutputHandle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667574);
		NativeMethodInfoPtr_GetUserData_Injected_Private_Static_IntPtr_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667575);
		NativeMethodInfoPtr_GetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667576);
		NativeMethodInfoPtr_SetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667577);
		NativeMethodInfoPtr_PushNotification_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_INotification_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667578);
		IsNullDelegateField = IL2CPP.ResolveICall<IsNullDelegate>("UnityEngine.Playables.PlayableOutputHandle::IsNull");
		GetWeightDelegateField = IL2CPP.ResolveICall<GetWeightDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetWeight");
		GetNotificationReceiversDelegateField = IL2CPP.ResolveICall<GetNotificationReceiversDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetNotificationReceivers");
		RemoveNotificationReceiverDelegateField = IL2CPP.ResolveICall<RemoveNotificationReceiverDelegate>("UnityEngine.Playables.PlayableOutputHandle::RemoveNotificationReceiver");
		GetReferenceObject_InjectedDelegateField = IL2CPP.ResolveICall<GetReferenceObject_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetReferenceObject_Injected");
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1230730, RefRangeEnd = 1230741, XrefRangeStart = 1230721, XrefRangeEnd = 1230730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPlayableOutputOfType<T>()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_IsPlayableOutputOfType_Internal_Boolean_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230741, XrefRangeEnd = 1230744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(PlayableOutputHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230744, XrefRangeEnd = 1230752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230752, XrefRangeEnd = 1230755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(PlayableOutputHandle other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1165558, RefRangeEnd = 1165561, XrefRangeStart = 1165558, XrefRangeEnd = 1165561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(PlayableOutputHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1230757, RefRangeEnd = 1230767, XrefRangeStart = 1230755, XrefRangeEnd = 1230757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValid()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Internal_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1230769, RefRangeEnd = 1230771, XrefRangeStart = 1230767, XrefRangeEnd = 1230769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Type GetPlayableOutputType()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayableOutputType_Internal_Type_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230779, RefRangeEnd = 1230780, XrefRangeStart = 1230771, XrefRangeEnd = 1230779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetReferenceObject(Object target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetReferenceObject_Internal_Void_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230788, RefRangeEnd = 1230789, XrefRangeStart = 1230780, XrefRangeEnd = 1230788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Object GetUserData()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUserData_Internal_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230791, RefRangeEnd = 1230792, XrefRangeStart = 1230789, XrefRangeEnd = 1230791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetUserData(Object target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUserData_Internal_Void_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230797, RefRangeEnd = 1230798, XrefRangeStart = 1230792, XrefRangeEnd = 1230797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayableHandle GetSourcePlayable()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSourcePlayable_Internal_PlayableHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1230803, RefRangeEnd = 1230805, XrefRangeStart = 1230798, XrefRangeEnd = 1230803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSourcePlayable(PlayableHandle target, int port)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&target);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &port;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSourcePlayable_Internal_Void_PlayableHandle_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1230807, RefRangeEnd = 1230809, XrefRangeStart = 1230805, XrefRangeEnd = 1230807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetSourceOutputPort()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSourceOutputPort_Internal_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230813, RefRangeEnd = 1230814, XrefRangeStart = 1230809, XrefRangeEnd = 1230813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWeight(float weight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&weight);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWeight_Internal_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230819, RefRangeEnd = 1230820, XrefRangeStart = 1230814, XrefRangeEnd = 1230819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PushNotification(PlayableHandle origin, INotification notification, Il2CppSystem.Object context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&origin);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)notification);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushNotification_Internal_Void_PlayableHandle_INotification_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1230822, RefRangeEnd = 1230824, XrefRangeStart = 1230820, XrefRangeEnd = 1230822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNotificationReceiver(INotificationReceiver receiver)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)receiver);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNotificationReceiver_Internal_Void_INotificationReceiver_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230824, XrefRangeEnd = 1230826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetReferenceObject_Injected(ref PlayableOutputHandle _unity_self, System.IntPtr target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &target;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetReferenceObject_Injected_Private_Static_Void_byref_PlayableOutputHandle_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230826, XrefRangeEnd = 1230828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetUserData_Injected(ref PlayableOutputHandle _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUserData_Injected_Private_Static_IntPtr_byref_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230828, XrefRangeEnd = 1230830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, out PlayableHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230830, XrefRangeEnd = 1230832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, [In] ref PlayableHandle target, int port)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref target);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &port;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230832, XrefRangeEnd = 1230834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PushNotification_Injected(ref PlayableOutputHandle _unity_self, [In] ref PlayableHandle origin, INotification notification, Il2CppSystem.Object context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref origin);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)notification);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushNotification_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_INotification_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator !=(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
	{
		return !CompareVersion(lhs, rhs);
	}

	public unsafe bool IsNull()
	{
		//IL_000b: Expected O, but got Ref
		return IsNullDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public Object GetReferenceObject()
	{
		return Unmarshal.UnmarshalUnityObject<Object>(GetReferenceObject_Injected(ref this));
	}

	public unsafe float GetWeight()
	{
		//IL_000b: Expected O, but got Ref
		return GetWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe Il2CppReferenceArray<INotificationReceiver> GetNotificationReceivers()
	{
		//IL_000b: Expected O, but got Ref
		System.IntPtr intPtr = GetNotificationReceiversDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<INotificationReceiver>>(intPtr) : null;
	}

	public unsafe void RemoveNotificationReceiver(INotificationReceiver receiver)
	{
		//IL_000b: Expected O, but got Ref
		RemoveNotificationReceiverDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)receiver));
	}

	public unsafe static System.IntPtr GetReferenceObject_Injected(ref PlayableOutputHandle _unity_self)
	{
		return GetReferenceObject_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self));
	}
}
