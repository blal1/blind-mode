using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp;

[System.Serializable]
public sealed class ThumbPath : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_gateID;

	private static readonly System.IntPtr NativeFieldInfoPtr_path;

	private static readonly System.IntPtr NativeFieldInfoPtr_textureSize;

	public unsafe int gateID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gateID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gateID)) = value;
		}
	}

	public unsafe string path
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Vector2 textureSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureSize)) = value;
		}
	}

	static ThumbPath()
	{
		Il2CppClassPointerStore<ThumbPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ThumbPath");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThumbPath>.NativeClassPtr);
		NativeFieldInfoPtr_gateID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThumbPath>.NativeClassPtr, "gateID");
		NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThumbPath>.NativeClassPtr, "path");
		NativeFieldInfoPtr_textureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThumbPath>.NativeClassPtr, "textureSize");
	}

	public ThumbPath(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ThumbPath()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThumbPath>.NativeClassPtr))
	{
	}
}
