using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel;

[System.Serializable]
public sealed class MultipleSubstitutionRecord : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetGlyphID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SubstituteGlyphIDs;

	public unsafe uint m_TargetGlyphID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TargetGlyphID);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TargetGlyphID)) = value;
		}
	}

	public unsafe Il2CppStructArray<uint> m_SubstituteGlyphIDs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SubstituteGlyphIDs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SubstituteGlyphIDs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public uint targetGlyphID
	{
		get
		{
			return m_TargetGlyphID;
		}
		set
		{
			m_TargetGlyphID = value;
		}
	}

	public Il2CppStructArray<uint> substituteGlyphIDs
	{
		get
		{
			return m_SubstituteGlyphIDs;
		}
		set
		{
			m_SubstituteGlyphIDs = value;
		}
	}

	static MultipleSubstitutionRecord()
	{
		Il2CppClassPointerStore<MultipleSubstitutionRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "MultipleSubstitutionRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleSubstitutionRecord>.NativeClassPtr);
		NativeFieldInfoPtr_m_TargetGlyphID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSubstitutionRecord>.NativeClassPtr, "m_TargetGlyphID");
		NativeFieldInfoPtr_m_SubstituteGlyphIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSubstitutionRecord>.NativeClassPtr, "m_SubstituteGlyphIDs");
	}

	public MultipleSubstitutionRecord(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public MultipleSubstitutionRecord()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleSubstitutionRecord>.NativeClassPtr))
	{
	}
}
