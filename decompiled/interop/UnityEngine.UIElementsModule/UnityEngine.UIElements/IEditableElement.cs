using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000E3")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal interface IEditableElement
{
	[Token(Token = "0x17000100")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal Action editingStarted
	{
		[Token(Token = "0x60006DA")]
		get;
	}

	[Token(Token = "0x17000101")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal Action editingEnded
	{
		[Token(Token = "0x60006DB")]
		get;
	}
}
