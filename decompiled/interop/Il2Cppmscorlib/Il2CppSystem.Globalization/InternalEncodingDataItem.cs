using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Globalization;

public sealed class InternalEncodingDataItem : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_webName;

	private static readonly System.IntPtr NativeFieldInfoPtr_codePage;

	public unsafe string webName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_webName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_webName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe ushort codePage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_codePage);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_codePage)) = value;
		}
	}

	static InternalEncodingDataItem()
	{
		Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "InternalEncodingDataItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr);
		NativeFieldInfoPtr_webName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr, "webName");
		NativeFieldInfoPtr_codePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr, "codePage");
	}

	public InternalEncodingDataItem(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public InternalEncodingDataItem()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr))
	{
	}
}
