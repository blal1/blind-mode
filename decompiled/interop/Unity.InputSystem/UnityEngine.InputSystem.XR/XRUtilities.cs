using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem.XR;

public static class XRUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_InterfaceMatchAnyVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_InterfaceV1;

	private static readonly System.IntPtr NativeFieldInfoPtr_InterfaceCurrent;

	public unsafe static string InterfaceMatchAnyVersion
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InterfaceMatchAnyVersion, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InterfaceMatchAnyVersion, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string InterfaceV1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InterfaceV1, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InterfaceV1, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string InterfaceCurrent
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InterfaceCurrent, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InterfaceCurrent, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static XRUtilities()
	{
		Il2CppClassPointerStore<XRUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.XR", "XRUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRUtilities>.NativeClassPtr);
		NativeFieldInfoPtr_InterfaceMatchAnyVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRUtilities>.NativeClassPtr, "InterfaceMatchAnyVersion");
		NativeFieldInfoPtr_InterfaceV1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRUtilities>.NativeClassPtr, "InterfaceV1");
		NativeFieldInfoPtr_InterfaceCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRUtilities>.NativeClassPtr, "InterfaceCurrent");
	}

	public XRUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
