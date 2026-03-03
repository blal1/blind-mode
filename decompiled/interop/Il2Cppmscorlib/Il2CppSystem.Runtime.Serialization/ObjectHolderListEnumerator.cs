using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization;

public class ObjectHolderListEnumerator : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_isFixupEnumerator;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_list;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_startingVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_currPos;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ObjectHolderList_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Internal_get_ObjectHolder_0;

	public unsafe bool m_isFixupEnumerator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isFixupEnumerator);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isFixupEnumerator)) = value;
		}
	}

	public unsafe ObjectHolderList m_list
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_list);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectHolderList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_list)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_startingVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_startingVersion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_startingVersion)) = value;
		}
	}

	public unsafe int m_currPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currPos);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currPos)) = value;
		}
	}

	public unsafe ObjectHolder Current
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Current_Internal_get_ObjectHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectHolder>(intPtr2) : null;
		}
	}

	static ObjectHolderListEnumerator()
	{
		Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ObjectHolderListEnumerator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr);
		NativeFieldInfoPtr_m_isFixupEnumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, "m_isFixupEnumerator");
		NativeFieldInfoPtr_m_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, "m_list");
		NativeFieldInfoPtr_m_startingVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, "m_startingVersion");
		NativeFieldInfoPtr_m_currPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, "m_currPos");
		NativeMethodInfoPtr__ctor_Internal_Void_ObjectHolderList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, 100670736);
		NativeMethodInfoPtr_MoveNext_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, 100670737);
		NativeMethodInfoPtr_get_Current_Internal_get_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, 100670738);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 798903, XrefRangeEnd = 798905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObjectHolderListEnumerator(ObjectHolderList list, bool isFixupEnumerator)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFixupEnumerator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_ObjectHolderList_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 798905, RefRangeEnd = 798906, XrefRangeStart = 798905, XrefRangeEnd = 798905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MoveNext()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ObjectHolderListEnumerator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
