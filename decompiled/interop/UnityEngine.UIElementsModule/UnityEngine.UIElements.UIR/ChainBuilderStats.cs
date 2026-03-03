using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000557")]
internal struct ChainBuilderStats
{
	[Token(Token = "0x4001290")]
	[FieldOffset(Offset = "0x0")]
	public uint elementsAdded;

	[Token(Token = "0x4001291")]
	[FieldOffset(Offset = "0x4")]
	public uint elementsRemoved;

	[Token(Token = "0x4001292")]
	[FieldOffset(Offset = "0x8")]
	public uint recursiveClipUpdates;

	[Token(Token = "0x4001293")]
	[FieldOffset(Offset = "0xC")]
	public uint recursiveClipUpdatesExpanded;

	[Token(Token = "0x4001294")]
	[FieldOffset(Offset = "0x10")]
	public uint nonRecursiveClipUpdates;

	[Token(Token = "0x4001295")]
	[FieldOffset(Offset = "0x14")]
	public uint recursiveTransformUpdates;

	[Token(Token = "0x4001296")]
	[FieldOffset(Offset = "0x18")]
	public uint recursiveTransformUpdatesExpanded;

	[Token(Token = "0x4001297")]
	[FieldOffset(Offset = "0x1C")]
	public uint recursiveOpacityUpdates;

	[Token(Token = "0x4001298")]
	[FieldOffset(Offset = "0x20")]
	public uint recursiveOpacityUpdatesExpanded;

	[Token(Token = "0x4001299")]
	[FieldOffset(Offset = "0x24")]
	public uint opacityIdUpdates;

	[Token(Token = "0x400129A")]
	[FieldOffset(Offset = "0x28")]
	public uint colorUpdates;

	[Token(Token = "0x400129B")]
	[FieldOffset(Offset = "0x2C")]
	public uint colorUpdatesExpanded;

	[Token(Token = "0x400129C")]
	[FieldOffset(Offset = "0x30")]
	public uint recursiveVisualUpdates;

	[Token(Token = "0x400129D")]
	[FieldOffset(Offset = "0x34")]
	public uint recursiveVisualUpdatesExpanded;

	[Token(Token = "0x400129E")]
	[FieldOffset(Offset = "0x38")]
	public uint nonRecursiveVisualUpdates;

	[Token(Token = "0x400129F")]
	[FieldOffset(Offset = "0x3C")]
	public uint dirtyProcessed;

	[Token(Token = "0x40012A0")]
	[FieldOffset(Offset = "0x40")]
	public uint nudgeTransformed;

	[Token(Token = "0x40012A1")]
	[FieldOffset(Offset = "0x44")]
	public uint boneTransformed;

	[Token(Token = "0x40012A2")]
	[FieldOffset(Offset = "0x48")]
	public uint skipTransformed;

	[Token(Token = "0x40012A3")]
	[FieldOffset(Offset = "0x4C")]
	public uint visualUpdateTransformed;

	[Token(Token = "0x40012A4")]
	[FieldOffset(Offset = "0x50")]
	public uint updatedMeshAllocations;

	[Token(Token = "0x40012A5")]
	[FieldOffset(Offset = "0x54")]
	public uint newMeshAllocations;

	[Token(Token = "0x40012A6")]
	[FieldOffset(Offset = "0x58")]
	public uint groupTransformElementsChanged;
}
