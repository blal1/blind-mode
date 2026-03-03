using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class BatchCullingOutput : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_drawCommands;

	private static readonly System.IntPtr NativeFieldInfoPtr_customCullingResult;

	public unsafe NativeArray<BatchCullingOutputDrawCommands> drawCommands
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawCommands);
			return new NativeArray<BatchCullingOutputDrawCommands>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<BatchCullingOutputDrawCommands>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawCommands), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<BatchCullingOutputDrawCommands>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<System.IntPtr> customCullingResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customCullingResult);
			return new NativeArray<System.IntPtr>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<System.IntPtr>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customCullingResult), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<System.IntPtr>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static BatchCullingOutput()
	{
		Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchCullingOutput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr);
		NativeFieldInfoPtr_drawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr, "drawCommands");
		NativeFieldInfoPtr_customCullingResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr, "customCullingResult");
	}

	public BatchCullingOutput(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public BatchCullingOutput()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr))
	{
	}
}
