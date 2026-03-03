using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices;

[System.Serializable]
public sealed class DateTimeConstantAttribute : CustomConstantAttribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__date;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0;

	public unsafe DateTime _date
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__date);
			return *(DateTime*)num;
		}
		set
		{
			*(DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__date)) = value;
		}
	}

	public unsafe override Object Value
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805589, XrefRangeEnd = 805592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
	}

	static DateTimeConstantAttribute()
	{
		Il2CppClassPointerStore<DateTimeConstantAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "DateTimeConstantAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeConstantAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeConstantAttribute>.NativeClassPtr, "_date");
		NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeConstantAttribute>.NativeClassPtr, 100671377);
	}

	public DateTimeConstantAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
