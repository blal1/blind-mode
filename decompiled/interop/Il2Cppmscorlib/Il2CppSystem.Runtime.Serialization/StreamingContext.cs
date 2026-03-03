using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization;

[System.Serializable]
public sealed class StreamingContext : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_additionalContext;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_state;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_State_Public_get_StreamingContextStates_0;

	public unsafe Object m_additionalContext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_additionalContext);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_additionalContext)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe StreamingContextStates m_state
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_state);
			return *(StreamingContextStates*)num;
		}
		set
		{
			*(StreamingContextStates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_state)) = value;
		}
	}

	public unsafe StreamingContextStates State
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 719678, RefRangeEnd = 719702, XrefRangeStart = 719678, XrefRangeEnd = 719702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_State_Public_get_StreamingContextStates_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(StreamingContextStates*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static StreamingContext()
	{
		Il2CppClassPointerStore<StreamingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "StreamingContext");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr);
		NativeFieldInfoPtr_m_additionalContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, "m_additionalContext");
		NativeFieldInfoPtr_m_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, "m_state");
		NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100670811);
		NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100670812);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100670813);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100670814);
		NativeMethodInfoPtr_get_State_Public_get_StreamingContextStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100670815);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 799864, RefRangeEnd = 799865, XrefRangeStart = 799863, XrefRangeEnd = 799864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StreamingContext(StreamingContextStates state)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&state);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 799865, XrefRangeEnd = 799866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StreamingContext(StreamingContextStates state, Object additional)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&state);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additional);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 799866, XrefRangeEnd = 799871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 719678, RefRangeEnd = 719702, XrefRangeStart = 719678, XrefRangeEnd = 719702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public StreamingContext(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public StreamingContext()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr))
	{
	}
}
