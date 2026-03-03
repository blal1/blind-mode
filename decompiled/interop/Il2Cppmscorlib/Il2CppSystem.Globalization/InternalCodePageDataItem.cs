using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Globalization;

public sealed class InternalCodePageDataItem : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_codePage;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiFamilyCodePage;

	private static readonly System.IntPtr NativeFieldInfoPtr_flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_Names;

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

	public unsafe ushort uiFamilyCodePage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiFamilyCodePage);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiFamilyCodePage)) = value;
		}
	}

	public unsafe uint flags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flags);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flags)) = value;
		}
	}

	public unsafe string Names
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Names);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Names)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static InternalCodePageDataItem()
	{
		Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "InternalCodePageDataItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr);
		NativeFieldInfoPtr_codePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr, "codePage");
		NativeFieldInfoPtr_uiFamilyCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr, "uiFamilyCodePage");
		NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr, "flags");
		NativeFieldInfoPtr_Names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr, "Names");
	}

	public InternalCodePageDataItem(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public InternalCodePageDataItem()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr))
	{
	}
}
