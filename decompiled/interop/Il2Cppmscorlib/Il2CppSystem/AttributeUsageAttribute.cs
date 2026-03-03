using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem;

[System.Serializable]
public sealed class AttributeUsageAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__attributeTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr__allowMultiple;

	private static readonly System.IntPtr NativeFieldInfoPtr__inherited;

	private static readonly System.IntPtr NativeFieldInfoPtr_Default;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeTargets_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AllowMultiple_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_AllowMultiple_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Inherited_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Inherited_Public_set_Void_Boolean_0;

	public unsafe AttributeTargets _attributeTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__attributeTarget);
			return *(AttributeTargets*)num;
		}
		set
		{
			*(AttributeTargets*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__attributeTarget)) = value;
		}
	}

	public unsafe bool _allowMultiple
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowMultiple);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowMultiple)) = value;
		}
	}

	public unsafe bool _inherited
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inherited);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inherited)) = value;
		}
	}

	public unsafe static AttributeUsageAttribute Default
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Default, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Default, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool AllowMultiple
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AllowMultiple_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_AllowMultiple_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool Inherited
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Inherited_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Inherited_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static AttributeUsageAttribute()
	{
		Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AttributeUsageAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__attributeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, "_attributeTarget");
		NativeFieldInfoPtr__allowMultiple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, "_allowMultiple");
		NativeFieldInfoPtr__inherited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, "_inherited");
		NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, "Default");
		NativeMethodInfoPtr__ctor_Public_Void_AttributeTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664330);
		NativeMethodInfoPtr_get_AllowMultiple_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664331);
		NativeMethodInfoPtr_set_AllowMultiple_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664332);
		NativeMethodInfoPtr_get_Inherited_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664333);
		NativeMethodInfoPtr_set_Inherited_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664334);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719793, XrefRangeEnd = 719794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AttributeUsageAttribute(AttributeTargets validOn)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&validOn);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AttributeTargets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AttributeUsageAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
