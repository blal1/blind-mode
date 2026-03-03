using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Profiling.LowLevel.Unsafe;

[StructLayout(LayoutKind.Explicit)]
public struct ProfilerRecorderDescription
{
	private static readonly System.IntPtr NativeFieldInfoPtr_category;

	private static readonly System.IntPtr NativeFieldInfoPtr_flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataType;

	private static readonly System.IntPtr NativeFieldInfoPtr_unitType;

	private static readonly System.IntPtr NativeFieldInfoPtr_reserved0;

	private static readonly System.IntPtr NativeFieldInfoPtr_nameUtf8Len;

	private static readonly System.IntPtr NativeFieldInfoPtr_nameUtf8;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Flags_Public_get_MarkerFlags_0;

	[FieldOffset(0)]
	public readonly ProfilerCategory category;

	[FieldOffset(2)]
	public readonly MarkerFlags flags;

	[FieldOffset(4)]
	public readonly ProfilerMarkerDataType dataType;

	[FieldOffset(5)]
	public readonly ProfilerMarkerDataUnit unitType;

	[FieldOffset(8)]
	public readonly int reserved0;

	[FieldOffset(12)]
	public readonly int nameUtf8Len;

	[FieldOffset(16)]
	public readonly System.IntPtr nameUtf8;

	public unsafe MarkerFlags Flags
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Flags_Public_get_MarkerFlags_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(MarkerFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public ProfilerCategory Category => category;

	public ProfilerMarkerDataType DataType => dataType;

	public ProfilerMarkerDataUnit UnitType => unitType;

	public int NameUtf8Len => nameUtf8Len;

	public unsafe byte* NameUtf8 => (byte*)nameUtf8;

	public unsafe string Name => ProfilerUnsafeUtility.Utf8ToString((byte*)nameUtf8, nameUtf8Len);

	static ProfilerRecorderDescription()
	{
		Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.LowLevel.Unsafe", "ProfilerRecorderDescription");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr);
		NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "category");
		NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "flags");
		NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "dataType");
		NativeFieldInfoPtr_unitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "unitType");
		NativeFieldInfoPtr_reserved0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "reserved0");
		NativeFieldInfoPtr_nameUtf8Len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "nameUtf8Len");
		NativeFieldInfoPtr_nameUtf8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "nameUtf8");
		NativeMethodInfoPtr_get_Flags_Public_get_MarkerFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, 100663443);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
