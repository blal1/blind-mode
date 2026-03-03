using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

[Token(Token = "0x200027E")]
[UnityEngine.Bindings.NativeType(Header = "Modules/UIElements/Core/Native/Renderer/UIRenderer.h")]
public sealed class UIRenderer : Renderer
{
	[Token(Token = "0x40009C1")]
	[FieldOffset(Offset = "0x18")]
	internal List<CommandList>[] commandLists;

	[Token(Token = "0x40009C2")]
	[FieldOffset(Offset = "0x20")]
	internal bool skipRendering;

	[Token(Token = "0x6001142")]
	[Address(RVA = "0x2B40E70", Offset = "0x2B40070", VA = "0x182B40E70")]
	internal void SetNativeData(int safeFrameIndex, int cmdListIndex, Material mat)
	{
	}

	[Token(Token = "0x6001143")]
	[Address(RVA = "0x2B40D50", Offset = "0x2B3FF50", VA = "0x182B40D50")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private static void OnRenderNodeExecute(UIRenderer renderer, int safeFrameIndex, int cmdListIndex)
	{
	}

	[Token(Token = "0x6001144")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public UIRenderer()
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6001145")]
	[Address(RVA = "0x2B40E10", Offset = "0x2B40010", VA = "0x182B40E10")]
	private static extern void SetNativeData_Injected(IntPtr _unity_self, int safeFrameIndex, int cmdListIndex, IntPtr mat);
}
