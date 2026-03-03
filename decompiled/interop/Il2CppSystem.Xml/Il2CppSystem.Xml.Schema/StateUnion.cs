using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema;

[StructLayout(LayoutKind.Explicit)]
public struct StateUnion
{
	private static readonly System.IntPtr NativeFieldInfoPtr_State;

	private static readonly System.IntPtr NativeFieldInfoPtr_AllElementsRequired;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurPosIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_NumberOfRunningPos;

	[FieldOffset(0)]
	public int State;

	[FieldOffset(0)]
	public int AllElementsRequired;

	[FieldOffset(0)]
	public int CurPosIndex;

	[FieldOffset(0)]
	public int NumberOfRunningPos;

	static StateUnion()
	{
		Il2CppClassPointerStore<StateUnion>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "StateUnion");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateUnion>.NativeClassPtr);
		NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateUnion>.NativeClassPtr, "State");
		NativeFieldInfoPtr_AllElementsRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateUnion>.NativeClassPtr, "AllElementsRequired");
		NativeFieldInfoPtr_CurPosIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateUnion>.NativeClassPtr, "CurPosIndex");
		NativeFieldInfoPtr_NumberOfRunningPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateUnion>.NativeClassPtr, "NumberOfRunningPos");
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StateUnion>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
