using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode;

public class CodePointIndexer : Il2CppSystem.Object
{
	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct TableRange
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Start;

		private static readonly System.IntPtr NativeFieldInfoPtr_End;

		private static readonly System.IntPtr NativeFieldInfoPtr_Count;

		private static readonly System.IntPtr NativeFieldInfoPtr_IndexStart;

		private static readonly System.IntPtr NativeFieldInfoPtr_IndexEnd;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		[FieldOffset(0)]
		public readonly int Start;

		[FieldOffset(4)]
		public readonly int End;

		[FieldOffset(8)]
		public readonly int Count;

		[FieldOffset(12)]
		public readonly int IndexStart;

		[FieldOffset(16)]
		public readonly int IndexEnd;

		static TableRange()
		{
			Il2CppClassPointerStore<TableRange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, "TableRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TableRange>.NativeClassPtr);
			NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableRange>.NativeClassPtr, "Start");
			NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableRange>.NativeClassPtr, "End");
			NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableRange>.NativeClassPtr, "Count");
			NativeFieldInfoPtr_IndexStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableRange>.NativeClassPtr, "IndexStart");
			NativeFieldInfoPtr_IndexEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableRange>.NativeClassPtr, "IndexEnd");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableRange>.NativeClassPtr, 100663473);
		}

		[CallerCount(0)]
		public unsafe TableRange(int start, int end, int indexStart)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&start);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexStart;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TableRange>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_ranges;

	private static readonly System.IntPtr NativeFieldInfoPtr_TotalCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultCP;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToIndex_Public_Int32_Int32_0;

	public unsafe Il2CppStructArray<TableRange> ranges
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ranges);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<TableRange>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ranges)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int TotalCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TotalCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TotalCount)) = value;
		}
	}

	public unsafe int defaultIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultIndex)) = value;
		}
	}

	public unsafe int defaultCP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultCP);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultCP)) = value;
		}
	}

	static CodePointIndexer()
	{
		Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "CodePointIndexer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr);
		NativeFieldInfoPtr_ranges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, "ranges");
		NativeFieldInfoPtr_TotalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, "TotalCount");
		NativeFieldInfoPtr_defaultIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, "defaultIndex");
		NativeFieldInfoPtr_defaultCP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, "defaultCP");
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, 100663471);
		NativeMethodInfoPtr_ToIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, 100663472);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 697036, RefRangeEnd = 697041, XrefRangeStart = 697028, XrefRangeEnd = 697036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CodePointIndexer(Il2CppStructArray<int> starts, Il2CppStructArray<int> ends, int defaultIndex, int defaultCP)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)starts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ends);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultCP;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 697042, RefRangeEnd = 697055, XrefRangeStart = 697041, XrefRangeEnd = 697042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ToIndex(int cp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public CodePointIndexer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
