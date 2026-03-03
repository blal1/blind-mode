using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem;

public sealed class ParsingInfo : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_calendar;

	private static readonly System.IntPtr NativeFieldInfoPtr_dayOfWeek;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeMark;

	private static readonly System.IntPtr NativeFieldInfoPtr_fUseHour12;

	private static readonly System.IntPtr NativeFieldInfoPtr_fUseTwoDigitYear;

	private static readonly System.IntPtr NativeFieldInfoPtr_fAllowInnerWhite;

	private static readonly System.IntPtr NativeFieldInfoPtr_fAllowTrailingWhite;

	private static readonly System.IntPtr NativeFieldInfoPtr_fCustomNumberParser;

	private static readonly System.IntPtr NativeFieldInfoPtr_parseNumberDelegate;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;

	public unsafe Calendar calendar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calendar);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Calendar>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calendar)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int dayOfWeek
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayOfWeek);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayOfWeek)) = value;
		}
	}

	public unsafe DateTimeParse.TM timeMark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeMark);
			return *(DateTimeParse.TM*)num;
		}
		set
		{
			*(DateTimeParse.TM*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeMark)) = value;
		}
	}

	public unsafe bool fUseHour12
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fUseHour12);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fUseHour12)) = value;
		}
	}

	public unsafe bool fUseTwoDigitYear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fUseTwoDigitYear);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fUseTwoDigitYear)) = value;
		}
	}

	public unsafe bool fAllowInnerWhite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fAllowInnerWhite);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fAllowInnerWhite)) = value;
		}
	}

	public unsafe bool fAllowTrailingWhite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fAllowTrailingWhite);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fAllowTrailingWhite)) = value;
		}
	}

	public unsafe bool fCustomNumberParser
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fCustomNumberParser);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fCustomNumberParser)) = value;
		}
	}

	public unsafe DateTimeParse.MatchNumberDelegate parseNumberDelegate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parseNumberDelegate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DateTimeParse.MatchNumberDelegate>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parseNumberDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ParsingInfo()
	{
		Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParsingInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr);
		NativeFieldInfoPtr_calendar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "calendar");
		NativeFieldInfoPtr_dayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "dayOfWeek");
		NativeFieldInfoPtr_timeMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "timeMark");
		NativeFieldInfoPtr_fUseHour12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fUseHour12");
		NativeFieldInfoPtr_fUseTwoDigitYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fUseTwoDigitYear");
		NativeFieldInfoPtr_fAllowInnerWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fAllowInnerWhite");
		NativeFieldInfoPtr_fAllowTrailingWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fAllowTrailingWhite");
		NativeFieldInfoPtr_fCustomNumberParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fCustomNumberParser");
		NativeFieldInfoPtr_parseNumberDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "parseNumberDelegate");
		NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, 100665111);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 727824, RefRangeEnd = 727825, XrefRangeStart = 727824, XrefRangeEnd = 727824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ParsingInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ParsingInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr))
	{
	}
}
