using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004D9")]
[Flags]
internal enum VisualElementFlags
{
	[Token(Token = "0x4000FE7")]
	WorldTransformDirty = 1,
	[Token(Token = "0x4000FE8")]
	WorldTransformInverseDirty = 2,
	[Token(Token = "0x4000FE9")]
	WorldClipDirty = 4,
	[Token(Token = "0x4000FEA")]
	BoundingBoxDirty = 8,
	[Token(Token = "0x4000FEB")]
	WorldBoundingBoxDirty = 0x10,
	[Token(Token = "0x4000FEC")]
	EventInterestParentCategoriesDirty = 0x20,
	[Token(Token = "0x4000FED")]
	LayoutManual = 0x40,
	[Token(Token = "0x4000FEE")]
	CompositeRoot = 0x80,
	[Token(Token = "0x4000FEF")]
	RequireMeasureFunction = 0x100,
	[Token(Token = "0x4000FF0")]
	EnableViewDataPersistence = 0x200,
	[Token(Token = "0x4000FF1")]
	DisableClipping = 0x400,
	[Token(Token = "0x4000FF2")]
	NeedsAttachToPanelEvent = 0x800,
	[Token(Token = "0x4000FF3")]
	HierarchyDisplayed = 0x1000,
	[Token(Token = "0x4000FF4")]
	StyleInitialized = 0x2000,
	[Token(Token = "0x4000FF5")]
	DisableRendering = 0x4000,
	[Token(Token = "0x4000FF6")]
	Needs3DBounds = 0x8000,
	[Token(Token = "0x4000FF7")]
	LocalBounds3DDirty = 0x10000,
	[Token(Token = "0x4000FF8")]
	DetachedDataSource = 0x20000,
	[Token(Token = "0x4000FF9")]
	ReceivesHierarchyGeometryChangedEvents = 0x40000,
	[Token(Token = "0x4000FFA")]
	BoundingBoxDirtiedSinceLastLayoutPass = 0x80000,
	[Token(Token = "0x4000FFB")]
	Init = 0x3003F
}
