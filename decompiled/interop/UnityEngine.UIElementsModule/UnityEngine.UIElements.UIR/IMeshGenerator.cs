using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200054A")]
internal interface IMeshGenerator
{
	[Token(Token = "0x17000996")]
	VisualElement currentElement
	{
		[Token(Token = "0x6002584")]
		set;
	}

	[Token(Token = "0x17000997")]
	TextJobSystem textJobSystem
	{
		[Token(Token = "0x6002585")]
		get;
	}

	[Token(Token = "0x6002586")]
	void DrawText(List<NativeSlice<Vertex>> vertices, List<NativeSlice<ushort>> indices, List<Texture2D> atlases, List<GlyphRenderMode> renderModes, List<float> sdfScales);

	[Token(Token = "0x6002587")]
	void DrawText(List<NativeSlice<Vertex>> vertices, List<NativeSlice<ushort>> indices, List<Material> materials, List<GlyphRenderMode> renderModes);

	[Token(Token = "0x6002588")]
	void DrawRectangle(MeshGenerator.RectangleParams rectParams);

	[Token(Token = "0x6002589")]
	void DrawBorder(MeshGenerator.BorderParams borderParams);

	[Token(Token = "0x600258A")]
	void DrawRectangleRepeat(MeshGenerator.RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint);

	[Token(Token = "0x600258B")]
	void ScheduleJobs(MeshGenerationContext mgc);
}
