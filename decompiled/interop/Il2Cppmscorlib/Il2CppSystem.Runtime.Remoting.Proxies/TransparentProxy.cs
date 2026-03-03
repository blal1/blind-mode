using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono;
using Il2CppSystem.Runtime.Remoting.Contexts;

namespace Il2CppSystem.Runtime.Remoting.Proxies;

public class TransparentProxy : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__rp;

	private static readonly System.IntPtr NativeFieldInfoPtr__class;

	private static readonly System.IntPtr NativeFieldInfoPtr__custom_type_info;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProxyType_Internal_RuntimeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsContextBoundObject_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetContext_Private_get_Context_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InCurrentContext_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadRemoteFieldNew_Internal_Object_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoreRemoteField_Internal_Void_IntPtr_IntPtr_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RealProxy _rp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rp);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RealProxy>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RuntimeRemoteClassHandle _class
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__class);
			return *(RuntimeRemoteClassHandle*)num;
		}
		set
		{
			*(RuntimeRemoteClassHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__class)) = value;
		}
	}

	public unsafe bool _custom_type_info
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__custom_type_info);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__custom_type_info)) = value;
		}
	}

	public unsafe bool IsContextBoundObject
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792551, XrefRangeEnd = 792559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsContextBoundObject_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Context TargetContext
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 663063, RefRangeEnd = 663064, XrefRangeStart = 663063, XrefRangeEnd = 663064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TargetContext_Private_get_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
		}
	}

	static TransparentProxy()
	{
		Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Proxies", "TransparentProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr);
		NativeFieldInfoPtr__rp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, "_rp");
		NativeFieldInfoPtr__class = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, "_class");
		NativeFieldInfoPtr__custom_type_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, "_custom_type_info");
		NativeMethodInfoPtr_GetProxyType_Internal_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100670004);
		NativeMethodInfoPtr_get_IsContextBoundObject_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100670005);
		NativeMethodInfoPtr_get_TargetContext_Private_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100670006);
		NativeMethodInfoPtr_InCurrentContext_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100670007);
		NativeMethodInfoPtr_LoadRemoteFieldNew_Internal_Object_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100670008);
		NativeMethodInfoPtr_StoreRemoteField_Internal_Void_IntPtr_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100670009);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100670010);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792544, XrefRangeEnd = 792551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RuntimeType GetProxyType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProxyType_Internal_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 792567, RefRangeEnd = 792569, XrefRangeStart = 792559, XrefRangeEnd = 792567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool InCurrentContext()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InCurrentContext_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792569, XrefRangeEnd = 792596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Object LoadRemoteFieldNew(System.IntPtr classPtr, System.IntPtr fieldPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&classPtr);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadRemoteFieldNew_Internal_Object_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792596, XrefRangeEnd = 792625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StoreRemoteField(System.IntPtr classPtr, System.IntPtr fieldPtr, Object arg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&classPtr);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoreRemoteField_Internal_Void_IntPtr_IntPtr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TransparentProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TransparentProxy(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
