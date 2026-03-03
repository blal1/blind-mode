using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging;

public class CADObjRef : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_objref;

	private static readonly System.IntPtr NativeFieldInfoPtr_SourceDomain;

	private static readonly System.IntPtr NativeFieldInfoPtr_TypeInfo;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjRef_Int32_0;

	public unsafe ObjRef objref
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objref);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjRef>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objref)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int SourceDomain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SourceDomain);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SourceDomain)) = value;
		}
	}

	public unsafe Il2CppStructArray<byte> TypeInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TypeInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TypeInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static CADObjRef()
	{
		Il2CppClassPointerStore<CADObjRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADObjRef");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr);
		NativeFieldInfoPtr_objref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr, "objref");
		NativeFieldInfoPtr_SourceDomain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr, "SourceDomain");
		NativeFieldInfoPtr_TypeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr, "TypeInfo");
		NativeMethodInfoPtr__ctor_Public_Void_ObjRef_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr, 100670297);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795324, XrefRangeEnd = 795328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CADObjRef(ObjRef o, int sourceDomain)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceDomain;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ObjRef_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CADObjRef(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
