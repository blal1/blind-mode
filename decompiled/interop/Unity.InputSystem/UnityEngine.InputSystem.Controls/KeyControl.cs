using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.InputSystem.Controls;

public class KeyControl : ButtonControl
{
	private static readonly IntPtr NativeFieldInfoPtr__keyCode_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_m_ScanCode;

	private static readonly IntPtr NativeMethodInfoPtr_get_keyCode_Public_get_Key_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_keyCode_Public_set_Void_Key_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_scanCode_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_RefreshConfiguration_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Key _keyCode_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyCode_k__BackingField);
			return *(Key*)num;
		}
		set
		{
			*(Key*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyCode_k__BackingField)) = value;
		}
	}

	public unsafe int m_ScanCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScanCode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScanCode)) = value;
		}
	}

	public unsafe Key keyCode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_keyCode_Public_get_Key_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Key*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_keyCode_Public_set_Void_Key_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int scanCode
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014837, XrefRangeEnd = 1014838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scanCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static KeyControl()
	{
		Il2CppClassPointerStore<KeyControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Controls", "KeyControl");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyControl>.NativeClassPtr);
		NativeFieldInfoPtr__keyCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyControl>.NativeClassPtr, "<keyCode>k__BackingField");
		NativeFieldInfoPtr_m_ScanCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyControl>.NativeClassPtr, "m_ScanCode");
		NativeMethodInfoPtr_get_keyCode_Public_get_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyControl>.NativeClassPtr, 100668453);
		NativeMethodInfoPtr_set_keyCode_Public_set_Void_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyControl>.NativeClassPtr, 100668454);
		NativeMethodInfoPtr_get_scanCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyControl>.NativeClassPtr, 100668455);
		NativeMethodInfoPtr_RefreshConfiguration_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyControl>.NativeClassPtr, 100668456);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyControl>.NativeClassPtr, 100668457);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014838, XrefRangeEnd = 1014854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void RefreshConfiguration()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RefreshConfiguration_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(137)]
	[CachedScanResults(RefRangeStart = 1014540, RefRangeEnd = 1014677, XrefRangeStart = 1014540, XrefRangeEnd = 1014677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KeyControl()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyControl>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public KeyControl(IntPtr pointer)
		: base(pointer)
	{
	}
}
