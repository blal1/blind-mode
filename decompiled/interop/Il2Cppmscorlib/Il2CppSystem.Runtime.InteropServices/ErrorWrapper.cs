using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.InteropServices;

public sealed class ErrorWrapper : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_ErrorCode;

	public unsafe int m_ErrorCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ErrorCode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ErrorCode)) = value;
		}
	}

	static ErrorWrapper()
	{
		Il2CppClassPointerStore<ErrorWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ErrorWrapper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorWrapper>.NativeClassPtr);
		NativeFieldInfoPtr_m_ErrorCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorWrapper>.NativeClassPtr, "m_ErrorCode");
	}

	public ErrorWrapper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
