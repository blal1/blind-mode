using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IO.LowLevel.Unsafe;

[StructLayout(LayoutKind.Explicit)]
public struct FileInfoResult
{
	private static readonly System.IntPtr NativeFieldInfoPtr_FileSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_FileState;

	[FieldOffset(0)]
	public long FileSize;

	[FieldOffset(8)]
	public FileState FileState;

	static FileInfoResult()
	{
		Il2CppClassPointerStore<FileInfoResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", "FileInfoResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileInfoResult>.NativeClassPtr);
		NativeFieldInfoPtr_FileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileInfoResult>.NativeClassPtr, "FileSize");
		NativeFieldInfoPtr_FileState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileInfoResult>.NativeClassPtr, "FileState");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FileInfoResult>.NativeClassPtr, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
