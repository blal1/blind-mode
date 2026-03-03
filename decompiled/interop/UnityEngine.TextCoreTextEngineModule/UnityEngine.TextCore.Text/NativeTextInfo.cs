using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text;

public sealed class NativeTextInfo : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_meshInfos;

	public unsafe Il2CppReferenceArray<ATGMeshInfo> meshInfos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshInfos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ATGMeshInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshInfos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static NativeTextInfo()
	{
		Il2CppClassPointerStore<NativeTextInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "NativeTextInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeTextInfo>.NativeClassPtr);
		NativeFieldInfoPtr_meshInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextInfo>.NativeClassPtr, "meshInfos");
	}

	public NativeTextInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public NativeTextInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTextInfo>.NativeClassPtr))
	{
	}
}
