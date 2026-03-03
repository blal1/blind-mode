using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem;

[Token(Token = "0x20001A2")]
public interface ICanvasToSpriteMaskBehaviour
{
	[Token(Token = "0x17000112")]
	CanvasToSpriteMask.BehaviourType behaviourType
	{
		[Token(Token = "0x6000A6B")]
		get;
	}

	[Token(Token = "0x17000113")]
	bool exists
	{
		[Token(Token = "0x6000A6C")]
		get;
	}

	[Token(Token = "0x17000114")]
	Component sourceMask
	{
		[Token(Token = "0x6000A6D")]
		get;
	}

	[Token(Token = "0x17000115")]
	Canvas sourceMaskCanvas
	{
		[Token(Token = "0x6000A6E")]
		get;
	}

	[Token(Token = "0x17000116")]
	IReadOnlyList<SpriteMask> allSpriteMasks
	{
		[Token(Token = "0x6000A6F")]
		get;
	}

	[Token(Token = "0x6000A67")]
	bool ApplyMask(RectTransform parent, Component sourceMask);

	[Token(Token = "0x6000A68")]
	void ApplyTranLocate();

	[Token(Token = "0x6000A69")]
	void ApplyRect2DClip(Rect clipScreenRect, Camera canvasCamera, RectTransform canvasRootRt, RectTransform maskRootRt);

	[Token(Token = "0x6000A6A")]
	void ReleaseResources();
}
