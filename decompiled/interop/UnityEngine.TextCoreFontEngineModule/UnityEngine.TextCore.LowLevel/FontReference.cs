using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel;

public sealed class FontReference : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_familyName;

	private static readonly System.IntPtr NativeFieldInfoPtr_styleName;

	private static readonly System.IntPtr NativeFieldInfoPtr_faceIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_filePath;

	public unsafe string familyName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_familyName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_familyName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string styleName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_styleName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_styleName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int faceIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceIndex)) = value;
		}
	}

	public unsafe string filePath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePath)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static FontReference()
	{
		Il2CppClassPointerStore<FontReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "FontReference");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontReference>.NativeClassPtr);
		NativeFieldInfoPtr_familyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontReference>.NativeClassPtr, "familyName");
		NativeFieldInfoPtr_styleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontReference>.NativeClassPtr, "styleName");
		NativeFieldInfoPtr_faceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontReference>.NativeClassPtr, "faceIndex");
		NativeFieldInfoPtr_filePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontReference>.NativeClassPtr, "filePath");
	}

	public FontReference(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public FontReference()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontReference>.NativeClassPtr))
	{
	}
}
