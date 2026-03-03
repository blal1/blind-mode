using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppYgomSystem;

public class SelectEnvData : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_envSettingList;

	private static readonly IntPtr NativeFieldInfoPtr_bgSettingList;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<SelectEnvSetting> envSettingList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_envSettingList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<SelectEnvSetting>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_envSettingList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<SelectEnvBGSetting> bgSettingList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bgSettingList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<SelectEnvBGSetting>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bgSettingList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static SelectEnvData()
	{
		Il2CppClassPointerStore<SelectEnvData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomSystem", "SelectEnvData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectEnvData>.NativeClassPtr);
		NativeFieldInfoPtr_envSettingList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectEnvData>.NativeClassPtr, "envSettingList");
		NativeFieldInfoPtr_bgSettingList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectEnvData>.NativeClassPtr, "bgSettingList");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEnvData>.NativeClassPtr, 100665469);
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 26528, RefRangeEnd = 26564, XrefRangeStart = 26528, XrefRangeEnd = 26564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SelectEnvData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectEnvData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SelectEnvData(IntPtr pointer)
		: base(pointer)
	{
	}
}
