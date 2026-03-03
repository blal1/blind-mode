using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro;

[System.Serializable]
public sealed class TMP_FontWeightPair : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_regularTypeface;

	private static readonly System.IntPtr NativeFieldInfoPtr_italicTypeface;

	public unsafe TMP_FontAsset regularTypeface
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regularTypeface);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regularTypeface)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TMP_FontAsset italicTypeface
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_italicTypeface);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_italicTypeface)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static TMP_FontWeightPair()
	{
		Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontWeightPair");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr);
		NativeFieldInfoPtr_regularTypeface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr, "regularTypeface");
		NativeFieldInfoPtr_italicTypeface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr, "italicTypeface");
	}

	public TMP_FontWeightPair(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public TMP_FontWeightPair()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr))
	{
	}
}
