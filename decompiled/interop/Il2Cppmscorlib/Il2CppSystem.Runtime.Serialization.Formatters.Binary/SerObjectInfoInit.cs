using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary;

public sealed class SerObjectInfoInit : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_seenBeforeTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectInfoIdCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_oiPool;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Hashtable seenBeforeTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seenBeforeTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seenBeforeTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int objectInfoIdCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectInfoIdCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectInfoIdCount)) = value;
		}
	}

	public unsafe SerStack oiPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oiPool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerStack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oiPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static SerObjectInfoInit()
	{
		Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "SerObjectInfoInit");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr);
		NativeFieldInfoPtr_seenBeforeTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr, "seenBeforeTable");
		NativeFieldInfoPtr_objectInfoIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr, "objectInfoIdCount");
		NativeFieldInfoPtr_oiPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr, "oiPool");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr, 100671033);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 801650, RefRangeEnd = 801652, XrefRangeStart = 801637, XrefRangeEnd = 801650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SerObjectInfoInit()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SerObjectInfoInit(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
