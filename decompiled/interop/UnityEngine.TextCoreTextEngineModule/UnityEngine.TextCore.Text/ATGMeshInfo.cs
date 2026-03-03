using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text;

public sealed class ATGMeshInfo : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_textElementInfos;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontAssetId;

	private static readonly System.IntPtr NativeFieldInfoPtr_textElementCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_textElementInfoIndicesByAtlas;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasMultipleColors;

	public unsafe Il2CppStructArray<NativeTextElementInfo> textElementInfos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textElementInfos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<NativeTextElementInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textElementInfos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int fontAssetId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontAssetId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontAssetId)) = value;
		}
	}

	public unsafe int textElementCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textElementCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textElementCount)) = value;
		}
	}

	public unsafe FontAsset fontAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontAsset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<List<int>> textElementInfoIndicesByAtlas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textElementInfoIndicesByAtlas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textElementInfoIndicesByAtlas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool hasMultipleColors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasMultipleColors);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasMultipleColors)) = value;
		}
	}

	static ATGMeshInfo()
	{
		Il2CppClassPointerStore<ATGMeshInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "ATGMeshInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ATGMeshInfo>.NativeClassPtr);
		NativeFieldInfoPtr_textElementInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATGMeshInfo>.NativeClassPtr, "textElementInfos");
		NativeFieldInfoPtr_fontAssetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATGMeshInfo>.NativeClassPtr, "fontAssetId");
		NativeFieldInfoPtr_textElementCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATGMeshInfo>.NativeClassPtr, "textElementCount");
		NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATGMeshInfo>.NativeClassPtr, "fontAsset");
		NativeFieldInfoPtr_textElementInfoIndicesByAtlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATGMeshInfo>.NativeClassPtr, "textElementInfoIndicesByAtlas");
		NativeFieldInfoPtr_hasMultipleColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATGMeshInfo>.NativeClassPtr, "hasMultipleColors");
	}

	public ATGMeshInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ATGMeshInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ATGMeshInfo>.NativeClassPtr))
	{
	}
}
