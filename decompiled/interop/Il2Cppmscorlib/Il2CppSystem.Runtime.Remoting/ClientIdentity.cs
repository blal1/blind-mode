using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting;

public class ClientIdentity : Identity
{
	private static readonly System.IntPtr NativeFieldInfoPtr__proxyReference;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ObjRef_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientProxy_Public_get_MarshalByRefObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientProxy_Public_set_Void_MarshalByRefObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetUri_Public_get_String_0;

	public unsafe WeakReference _proxyReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__proxyReference);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WeakReference>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__proxyReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe MarshalByRefObject ClientProxy
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 789762, RefRangeEnd = 789763, XrefRangeStart = 789759, XrefRangeEnd = 789762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ClientProxy_Public_get_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr2) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 789768, RefRangeEnd = 789770, XrefRangeStart = 789763, XrefRangeEnd = 789768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ClientProxy_Public_set_Void_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string TargetUri
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 789771, RefRangeEnd = 789775, XrefRangeStart = 789770, XrefRangeEnd = 789771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TargetUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	static ClientIdentity()
	{
		Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ClientIdentity");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr);
		NativeFieldInfoPtr__proxyReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, "_proxyReference");
		NativeMethodInfoPtr__ctor_Public_Void_String_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100669806);
		NativeMethodInfoPtr_get_ClientProxy_Public_get_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100669807);
		NativeMethodInfoPtr_set_ClientProxy_Public_set_Void_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100669808);
		NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100669809);
		NativeMethodInfoPtr_get_TargetUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100669810);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 789758, RefRangeEnd = 789759, XrefRangeStart = 789750, XrefRangeEnd = 789758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ClientIdentity(string objectUri, ObjRef objRef)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(objectUri);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objRef);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_ObjRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 50653, RefRangeEnd = 50668, XrefRangeStart = 50653, XrefRangeEnd = 50668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override ObjRef CreateObjRef(Type requestedType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requestedType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjRef>(intPtr2) : null;
	}

	public ClientIdentity(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
