using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Unity.IO.Archive;

public sealed class ArchiveFileInfo : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Filename;

	private static readonly System.IntPtr NativeFieldInfoPtr_FileSize;

	public unsafe string Filename
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Filename);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Filename)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe ulong FileSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FileSize);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FileSize)) = value;
		}
	}

	static ArchiveFileInfo()
	{
		Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.Archive", "ArchiveFileInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr);
		NativeFieldInfoPtr_Filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr, "Filename");
		NativeFieldInfoPtr_FileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr, "FileSize");
	}

	public ArchiveFileInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ArchiveFileInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr))
	{
	}
}
