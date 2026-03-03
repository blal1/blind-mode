using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging;

public class CADMessageBase : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__args;

	private static readonly System.IntPtr NativeFieldInfoPtr__serializedArgs;

	private static readonly System.IntPtr NativeFieldInfoPtr__propertyCount;

	private static readonly System.IntPtr NativeFieldInfoPtr__callContext;

	private static readonly System.IntPtr NativeFieldInfoPtr_serializedMethod;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethod_Internal_MethodBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSignature_Protected_Static_Il2CppReferenceArray_1_Type_MethodBase_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarshalProperties_Internal_Static_Int32_IDictionary_byref_ArrayList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnmarshalProperties_Internal_Static_Void_IDictionary_Int32_ArrayList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPossibleToIgnoreMarshal_Private_Static_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarshalArgument_Protected_Object_Object_byref_ArrayList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnmarshalArgument_Protected_Object_Object_ArrayList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_byref_ArrayList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnmarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_ArrayList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveLogicalCallContext_Protected_Void_IMethodMessage_byref_ArrayList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLogicalCallContext_Internal_LogicalCallContext_ArrayList_0;

	public unsafe Il2CppReferenceArray<Object> _args
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__args);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__args)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<byte> _serializedArgs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serializedArgs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serializedArgs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int _propertyCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__propertyCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__propertyCount)) = value;
		}
	}

	public unsafe CADArgHolder _callContext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__callContext);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CADArgHolder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__callContext)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<byte> serializedMethod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_serializedMethod);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_serializedMethod)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static CADMessageBase()
	{
		Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADMessageBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr);
		NativeFieldInfoPtr__args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "_args");
		NativeFieldInfoPtr__serializedArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "_serializedArgs");
		NativeFieldInfoPtr__propertyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "_propertyCount");
		NativeFieldInfoPtr__callContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "_callContext");
		NativeFieldInfoPtr_serializedMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "serializedMethod");
		NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670301);
		NativeMethodInfoPtr_GetMethod_Internal_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670302);
		NativeMethodInfoPtr_GetSignature_Protected_Static_Il2CppReferenceArray_1_Type_MethodBase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670303);
		NativeMethodInfoPtr_MarshalProperties_Internal_Static_Int32_IDictionary_byref_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670304);
		NativeMethodInfoPtr_UnmarshalProperties_Internal_Static_Void_IDictionary_Int32_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670305);
		NativeMethodInfoPtr_IsPossibleToIgnoreMarshal_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670306);
		NativeMethodInfoPtr_MarshalArgument_Protected_Object_Object_byref_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670307);
		NativeMethodInfoPtr_UnmarshalArgument_Protected_Object_Object_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670308);
		NativeMethodInfoPtr_MarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_byref_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670309);
		NativeMethodInfoPtr_UnmarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670310);
		NativeMethodInfoPtr_SaveLogicalCallContext_Protected_Void_IMethodMessage_byref_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670311);
		NativeMethodInfoPtr_GetLogicalCallContext_Internal_LogicalCallContext_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670312);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 795397, RefRangeEnd = 795399, XrefRangeStart = 795389, XrefRangeEnd = 795397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CADMessageBase(IMethodMessage msg)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 795418, RefRangeEnd = 795420, XrefRangeStart = 795399, XrefRangeEnd = 795418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MethodBase GetMethod()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMethod_Internal_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 795435, RefRangeEnd = 795436, XrefRangeStart = 795420, XrefRangeEnd = 795435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Type> GetSignature(MethodBase methodBase, bool load)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)methodBase);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &load;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSignature_Protected_Static_Il2CppReferenceArray_1_Type_MethodBase_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 795488, RefRangeEnd = 795490, XrefRangeStart = 795436, XrefRangeEnd = 795488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int MarshalProperties(IDictionary dict, ref ArrayList args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dict);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarshalProperties_Internal_Static_Int32_IDictionary_byref_ArrayList_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		args = ((intPtr4 == (System.IntPtr)0) ? null : new ArrayList(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 795496, RefRangeEnd = 795497, XrefRangeStart = 795490, XrefRangeEnd = 795496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnmarshalProperties(IDictionary dict, int count, ArrayList args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dict);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnmarshalProperties_Internal_Static_Void_IDictionary_Int32_ArrayList_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795497, XrefRangeEnd = 795513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPossibleToIgnoreMarshal(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPossibleToIgnoreMarshal_Private_Static_Boolean_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 795542, RefRangeEnd = 795544, XrefRangeStart = 795513, XrefRangeEnd = 795542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Object MarshalArgument(Object arg, ref ArrayList args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarshalArgument_Protected_Object_Object_byref_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		args = ((intPtr4 == (System.IntPtr)0) ? null : new ArrayList(intPtr4));
		return (intPtr3 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 795564, RefRangeEnd = 795566, XrefRangeStart = 795544, XrefRangeEnd = 795564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Object UnmarshalArgument(Object arg, ArrayList args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnmarshalArgument_Protected_Object_Object_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 795573, RefRangeEnd = 795575, XrefRangeStart = 795566, XrefRangeEnd = 795573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Object> MarshalArguments(Il2CppReferenceArray<Object> arguments, ref ArrayList args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arguments);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_byref_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		args = ((intPtr4 == (System.IntPtr)0) ? null : new ArrayList(intPtr4));
		return (intPtr3 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 795582, RefRangeEnd = 795585, XrefRangeStart = 795575, XrefRangeEnd = 795582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Object> UnmarshalArguments(Il2CppReferenceArray<Object> arguments, ArrayList args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arguments);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnmarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 795602, RefRangeEnd = 795603, XrefRangeStart = 795585, XrefRangeEnd = 795602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializeList);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveLogicalCallContext_Protected_Void_IMethodMessage_byref_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		serializeList = ((intPtr4 == (System.IntPtr)0) ? null : new ArrayList(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 795606, RefRangeEnd = 795607, XrefRangeStart = 795603, XrefRangeEnd = 795606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LogicalCallContext GetLogicalCallContext(ArrayList args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLogicalCallContext_Internal_LogicalCallContext_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr2) : null;
	}

	public CADMessageBase(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
