using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization;

public static class FormatterServices : Object
{
	[ObfuscatedName("System.Runtime.Serialization.FormatterServices+<>c__DisplayClass9_0")]
	public sealed class __c__DisplayClass9_0 : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_type;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetSerializableMembers_b__0_Internal_Il2CppReferenceArray_1_MemberInfo_MemberHolder_0;

		public unsafe Type type
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass9_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "<>c__DisplayClass9_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr);
			NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, "type");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, 100670635);
			NativeMethodInfoPtr__GetSerializableMembers_b__0_Internal_Il2CppReferenceArray_1_MemberInfo_MemberHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, 100670636);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass9_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 797842, XrefRangeEnd = 797857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<MemberInfo> _GetSerializableMembers_b__0(MemberHolder _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetSerializableMembers_b__0_Internal_Il2CppReferenceArray_1_MemberInfo_MemberHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr2) : null;
		}

		public __c__DisplayClass9_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MemberInfoTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_unsafeTypeForwardersIsEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_unsafeTypeForwardersIsEnabledInitialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_advancedTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_binder;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckSerializable_Private_Static_Boolean_RuntimeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParentTypes_Private_Static_Boolean_RuntimeType_byref_Il2CppReferenceArray_1_RuntimeType_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSerializableMembers_Public_Static_Il2CppReferenceArray_1_MemberInfo_Type_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUninitializedObject_Public_Static_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_nativeGetUninitializedObject_Private_Static_Object_RuntimeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEnableUnsafeTypeForwarders_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnsafeTypeForwardersIsEnabled_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializationSetValue_Internal_Static_Void_MemberInfo_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateObjectMembers_Public_Static_Object_Object_Il2CppReferenceArray_1_MemberInfo_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectData_Public_Static_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_MemberInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeFromAssembly_Public_Static_Type_Assembly_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAssemblyFromString_Internal_Static_Assembly_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAssemblyFromStringNoThrow_Internal_Static_Assembly_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClrAssemblyName_Internal_Static_String_Type_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClrTypeFullName_Internal_Static_String_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClrTypeFullNameForArray_Private_Static_String_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClrTypeFullNameForNonArrayTypes_Private_Static_String_Type_0;

	public unsafe static ConcurrentDictionary<MemberHolder, Il2CppReferenceArray<MemberInfo>> m_MemberInfoTable
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_MemberInfoTable, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConcurrentDictionary<MemberHolder, Il2CppReferenceArray<MemberInfo>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_MemberInfoTable, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool unsafeTypeForwardersIsEnabled
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unsafeTypeForwardersIsEnabled, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unsafeTypeForwardersIsEnabled, (void*)(&value));
		}
	}

	public unsafe static bool unsafeTypeForwardersIsEnabledInitialized
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unsafeTypeForwardersIsEnabledInitialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unsafeTypeForwardersIsEnabledInitialized, (void*)(&value));
		}
	}

	public unsafe static Il2CppReferenceArray<Type> advancedTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_advancedTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_advancedTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Binder s_binder
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_binder, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Binder>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_binder, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static FormatterServices()
	{
		Il2CppClassPointerStore<FormatterServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "FormatterServices");
		NativeFieldInfoPtr_m_MemberInfoTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "m_MemberInfoTable");
		NativeFieldInfoPtr_unsafeTypeForwardersIsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "unsafeTypeForwardersIsEnabled");
		NativeFieldInfoPtr_unsafeTypeForwardersIsEnabledInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "unsafeTypeForwardersIsEnabledInitialized");
		NativeFieldInfoPtr_advancedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "advancedTypes");
		NativeFieldInfoPtr_s_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "s_binder");
		NativeMethodInfoPtr_GetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670616);
		NativeMethodInfoPtr_CheckSerializable_Private_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670617);
		NativeMethodInfoPtr_InternalGetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670618);
		NativeMethodInfoPtr_GetParentTypes_Private_Static_Boolean_RuntimeType_byref_Il2CppReferenceArray_1_RuntimeType_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670619);
		NativeMethodInfoPtr_GetSerializableMembers_Public_Static_Il2CppReferenceArray_1_MemberInfo_Type_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670620);
		NativeMethodInfoPtr_GetUninitializedObject_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670621);
		NativeMethodInfoPtr_nativeGetUninitializedObject_Private_Static_Object_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670622);
		NativeMethodInfoPtr_GetEnableUnsafeTypeForwarders_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670623);
		NativeMethodInfoPtr_UnsafeTypeForwardersIsEnabled_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670624);
		NativeMethodInfoPtr_SerializationSetValue_Internal_Static_Void_MemberInfo_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670625);
		NativeMethodInfoPtr_PopulateObjectMembers_Public_Static_Object_Object_Il2CppReferenceArray_1_MemberInfo_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670626);
		NativeMethodInfoPtr_GetObjectData_Public_Static_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670627);
		NativeMethodInfoPtr_GetTypeFromAssembly_Public_Static_Type_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670628);
		NativeMethodInfoPtr_LoadAssemblyFromString_Internal_Static_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670629);
		NativeMethodInfoPtr_LoadAssemblyFromStringNoThrow_Internal_Static_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670630);
		NativeMethodInfoPtr_GetClrAssemblyName_Internal_Static_String_Type_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670631);
		NativeMethodInfoPtr_GetClrTypeFullName_Internal_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670632);
		NativeMethodInfoPtr_GetClrTypeFullNameForArray_Private_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670633);
		NativeMethodInfoPtr_GetClrTypeFullNameForNonArrayTypes_Private_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100670634);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 797859, RefRangeEnd = 797860, XrefRangeStart = 797857, XrefRangeEnd = 797859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<MemberInfo> GetSerializableMembers(RuntimeType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static bool CheckSerializable(RuntimeType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckSerializable_Private_Static_Boolean_RuntimeType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 797913, RefRangeEnd = 797915, XrefRangeStart = 797860, XrefRangeEnd = 797913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<MemberInfo> InternalGetSerializableMembers(RuntimeType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 797948, RefRangeEnd = 797949, XrefRangeStart = 797915, XrefRangeEnd = 797948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetParentTypes(RuntimeType parentType, out Il2CppReferenceArray<RuntimeType> parentTypes, out int parentTypeCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentType);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref parentTypeCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParentTypes_Private_Static_Boolean_RuntimeType_byref_Il2CppReferenceArray_1_RuntimeType_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		parentTypes = ((num3 == 0) ? null : new Il2CppReferenceArray<RuntimeType>((System.IntPtr)num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 797997, RefRangeEnd = 797999, XrefRangeStart = 797949, XrefRangeEnd = 797997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<MemberInfo> GetSerializableMembers(Type type, StreamingContext context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSerializableMembers_Public_Static_Il2CppReferenceArray_1_MemberInfo_Type_StreamingContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 798027, RefRangeEnd = 798030, XrefRangeStart = 797999, XrefRangeEnd = 798027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object GetUninitializedObject(Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUninitializedObject_Public_Static_Object_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 798030, XrefRangeEnd = 798031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object nativeGetUninitializedObject(RuntimeType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_nativeGetUninitializedObject_Private_Static_Object_RuntimeType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetEnableUnsafeTypeForwarders()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnableUnsafeTypeForwarders_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 798044, RefRangeEnd = 798049, XrefRangeStart = 798031, XrefRangeEnd = 798044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool UnsafeTypeForwardersIsEnabled()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnsafeTypeForwardersIsEnabled_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 798061, RefRangeEnd = 798064, XrefRangeStart = 798049, XrefRangeEnd = 798061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializationSetValue(MemberInfo fi, Object target, Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fi);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializationSetValue_Internal_Static_Void_MemberInfo_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 798070, RefRangeEnd = 798071, XrefRangeStart = 798064, XrefRangeEnd = 798070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object PopulateObjectMembers(Object obj, Il2CppReferenceArray<MemberInfo> members, Il2CppReferenceArray<Object> data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)members);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateObjectMembers_Public_Static_Object_Object_Il2CppReferenceArray_1_MemberInfo_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 798086, RefRangeEnd = 798087, XrefRangeStart = 798071, XrefRangeEnd = 798086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Object> GetObjectData(Object obj, Il2CppReferenceArray<MemberInfo> members)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)members);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetObjectData_Public_Static_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_MemberInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 798088, RefRangeEnd = 798090, XrefRangeStart = 798087, XrefRangeEnd = 798088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Type GetTypeFromAssembly(Assembly assem, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)assem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypeFromAssembly_Public_Static_Type_Assembly_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 798091, RefRangeEnd = 798092, XrefRangeStart = 798090, XrefRangeEnd = 798091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Assembly LoadAssemblyFromString(string assemblyName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAssemblyFromString_Internal_Static_Assembly_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 798096, RefRangeEnd = 798097, XrefRangeStart = 798092, XrefRangeEnd = 798096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Assembly LoadAssemblyFromStringNoThrow(string assemblyName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAssemblyFromStringNoThrow_Internal_Static_Assembly_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 798104, RefRangeEnd = 798106, XrefRangeStart = 798097, XrefRangeEnd = 798104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hasTypeForwardedFrom);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClrAssemblyName_Internal_Static_String_Type_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 798114, RefRangeEnd = 798117, XrefRangeStart = 798106, XrefRangeEnd = 798114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetClrTypeFullName(Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClrTypeFullName_Internal_Static_String_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 798147, RefRangeEnd = 798149, XrefRangeStart = 798117, XrefRangeEnd = 798147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetClrTypeFullNameForArray(Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClrTypeFullNameForArray_Private_Static_String_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 798177, RefRangeEnd = 798179, XrefRangeStart = 798149, XrefRangeEnd = 798177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetClrTypeFullNameForNonArrayTypes(Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClrTypeFullNameForNonArrayTypes_Private_Static_String_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public FormatterServices(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
