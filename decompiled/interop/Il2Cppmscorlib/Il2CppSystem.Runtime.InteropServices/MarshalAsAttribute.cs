using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.InteropServices;

public sealed class MarshalAsAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MarshalCookie;

	private static readonly System.IntPtr NativeFieldInfoPtr_MarshalType;

	private static readonly System.IntPtr NativeFieldInfoPtr_MarshalTypeRef;

	private static readonly System.IntPtr NativeFieldInfoPtr_SafeArrayUserDefinedSubType;

	private static readonly System.IntPtr NativeFieldInfoPtr_utype;

	private static readonly System.IntPtr NativeFieldInfoPtr_ArraySubType;

	private static readonly System.IntPtr NativeFieldInfoPtr_SafeArraySubType;

	private static readonly System.IntPtr NativeFieldInfoPtr_SizeConst;

	private static readonly System.IntPtr NativeFieldInfoPtr_IidParameterIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_SizeParamIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnmanagedType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_UnmanagedType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Internal_MarshalAsAttribute_0;

	public unsafe string MarshalCookie
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MarshalCookie);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MarshalCookie)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string MarshalType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MarshalType);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MarshalType)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Type MarshalTypeRef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MarshalTypeRef);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MarshalTypeRef)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Type SafeArrayUserDefinedSubType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SafeArrayUserDefinedSubType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SafeArrayUserDefinedSubType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UnmanagedType utype
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_utype);
			return *(UnmanagedType*)num;
		}
		set
		{
			*(UnmanagedType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_utype)) = value;
		}
	}

	public unsafe UnmanagedType ArraySubType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ArraySubType);
			return *(UnmanagedType*)num;
		}
		set
		{
			*(UnmanagedType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ArraySubType)) = value;
		}
	}

	public unsafe VarEnum SafeArraySubType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SafeArraySubType);
			return *(VarEnum*)num;
		}
		set
		{
			*(VarEnum*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SafeArraySubType)) = value;
		}
	}

	public unsafe int SizeConst
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeConst);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeConst)) = value;
		}
	}

	public unsafe int IidParameterIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IidParameterIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IidParameterIndex)) = value;
		}
	}

	public unsafe short SizeParamIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeParamIndex);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeParamIndex)) = value;
		}
	}

	public unsafe UnmanagedType Value
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66330, RefRangeEnd = 66331, XrefRangeStart = 66330, XrefRangeEnd = 66331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Value_Public_get_UnmanagedType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(UnmanagedType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static MarshalAsAttribute()
	{
		Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "MarshalAsAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_MarshalCookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "MarshalCookie");
		NativeFieldInfoPtr_MarshalType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "MarshalType");
		NativeFieldInfoPtr_MarshalTypeRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "MarshalTypeRef");
		NativeFieldInfoPtr_SafeArrayUserDefinedSubType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "SafeArrayUserDefinedSubType");
		NativeFieldInfoPtr_utype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "utype");
		NativeFieldInfoPtr_ArraySubType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "ArraySubType");
		NativeFieldInfoPtr_SafeArraySubType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "SafeArraySubType");
		NativeFieldInfoPtr_SizeConst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "SizeConst");
		NativeFieldInfoPtr_IidParameterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "IidParameterIndex");
		NativeFieldInfoPtr_SizeParamIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "SizeParamIndex");
		NativeMethodInfoPtr__ctor_Public_Void_UnmanagedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, 100671348);
		NativeMethodInfoPtr_get_Value_Public_get_UnmanagedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, 100671349);
		NativeMethodInfoPtr_Copy_Internal_MarshalAsAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, 100671350);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805379, XrefRangeEnd = 805380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MarshalAsAttribute(UnmanagedType unmanagedType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&unmanagedType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UnmanagedType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 805383, RefRangeEnd = 805384, XrefRangeStart = 805380, XrefRangeEnd = 805383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MarshalAsAttribute Copy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Internal_MarshalAsAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MarshalAsAttribute>(intPtr2) : null;
	}

	public MarshalAsAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
