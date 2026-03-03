using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x200027D")]
[UnityEngine.Bindings.NativeHeader("Modules/UIElements/Core/Native/Renderer/UIPainter2D.bindings.h")]
internal static class UIPainter2D
{
	[MethodImpl(4096)]
	[Token(Token = "0x600113C")]
	[Address(RVA = "0x2B40BE0", Offset = "0x2B3FDE0", VA = "0x182B40BE0")]
	public static extern IntPtr Create(bool computeBBox = false);

	[MethodImpl(4096)]
	[Token(Token = "0x600113D")]
	[Address(RVA = "0x2B40C20", Offset = "0x2B3FE20", VA = "0x182B40C20")]
	public static extern void Destroy(IntPtr handle);

	[MethodImpl(4096)]
	[Token(Token = "0x600113E")]
	[Address(RVA = "0x2B40D10", Offset = "0x2B3FF10", VA = "0x182B40D10")]
	public static extern void Reset(IntPtr handle);

	[MethodImpl(4096)]
	[Token(Token = "0x600113F")]
	[Address(RVA = "0x2B40BA0", Offset = "0x2B3FDA0", VA = "0x182B40BA0")]
	public static extern void ClearSnapshots(IntPtr handle);

	[Token(Token = "0x6001140")]
	[Address(RVA = "0x2B40CB0", Offset = "0x2B3FEB0", VA = "0x182B40CB0")]
	[UnityEngine.Bindings.ThreadSafe]
	public static MeshWriteDataInterface ExecuteSnapshotFromJob(IntPtr painterHandle, int i)
	{
		return default(MeshWriteDataInterface);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6001141")]
	[Address(RVA = "0x2B40C60", Offset = "0x2B3FE60", VA = "0x182B40C60")]
	private static extern void ExecuteSnapshotFromJob_Injected(IntPtr painterHandle, int i, out MeshWriteDataInterface ret);
}
