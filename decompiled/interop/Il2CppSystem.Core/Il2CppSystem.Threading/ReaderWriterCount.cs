using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading;

public class ReaderWriterCount : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_lockID;

	private static readonly System.IntPtr NativeFieldInfoPtr_readercount;

	private static readonly System.IntPtr NativeFieldInfoPtr_writercount;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradecount;

	private static readonly System.IntPtr NativeFieldInfoPtr_next;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe long lockID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockID);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockID)) = value;
		}
	}

	public unsafe int readercount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readercount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readercount)) = value;
		}
	}

	public unsafe int writercount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writercount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writercount)) = value;
		}
	}

	public unsafe int upgradecount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradecount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradecount)) = value;
		}
	}

	public unsafe ReaderWriterCount next
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_next);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReaderWriterCount>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_next)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ReaderWriterCount()
	{
		Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Threading", "ReaderWriterCount");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr);
		NativeFieldInfoPtr_lockID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr, "lockID");
		NativeFieldInfoPtr_readercount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr, "readercount");
		NativeFieldInfoPtr_writercount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr, "writercount");
		NativeFieldInfoPtr_upgradecount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr, "upgradecount");
		NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr, "next");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr, 100663661);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReaderWriterCount()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReaderWriterCount>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ReaderWriterCount(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
