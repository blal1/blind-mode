using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO;

[StructLayout(LayoutKind.Explicit)]
public struct MonoIOStat
{
	private static readonly System.IntPtr NativeFieldInfoPtr_fileAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_Length;

	private static readonly System.IntPtr NativeFieldInfoPtr_CreationTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastAccessTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastWriteTime;

	[FieldOffset(0)]
	public FileAttributes fileAttributes;

	[FieldOffset(8)]
	public long Length;

	[FieldOffset(16)]
	public long CreationTime;

	[FieldOffset(24)]
	public long LastAccessTime;

	[FieldOffset(32)]
	public long LastWriteTime;

	static MonoIOStat()
	{
		Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "MonoIOStat");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr);
		NativeFieldInfoPtr_fileAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "fileAttributes");
		NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "Length");
		NativeFieldInfoPtr_CreationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "CreationTime");
		NativeFieldInfoPtr_LastAccessTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "LastAccessTime");
		NativeFieldInfoPtr_LastWriteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "LastWriteTime");
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
