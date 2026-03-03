using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.VFX.Utility;

public class VFXPropertyBindingAttribute : PropertyAttribute
{
	private static readonly IntPtr NativeFieldInfoPtr_EditorTypes;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;

	public unsafe Il2CppStringArray EditorTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EditorTypes);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EditorTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static VFXPropertyBindingAttribute()
	{
		Il2CppClassPointerStore<VFXPropertyBindingAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.VisualEffectGraph.Runtime.dll", "UnityEngine.VFX.Utility", "VFXPropertyBindingAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXPropertyBindingAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_EditorTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXPropertyBindingAttribute>.NativeClassPtr, "EditorTypes");
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXPropertyBindingAttribute>.NativeClassPtr, 100663808);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 110022, RefRangeEnd = 110023, XrefRangeStart = 110022, XrefRangeEnd = 110023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VFXPropertyBindingAttribute([Optional] Il2CppStringArray editorTypes)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		if (editorTypes == null)
		{
			editorTypes = new Il2CppStringArray(0L);
		}
		this._002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXPropertyBindingAttribute>.NativeClassPtr));
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)editorTypes);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VFXPropertyBindingAttribute(params string[] editorTypes)
		: this(new Il2CppStringArray(editorTypes))
	{
	}//IL_0002: Unknown result type (might be due to invalid IL or missing references)
	//IL_000c: Expected O, but got Unknown


	public VFXPropertyBindingAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
