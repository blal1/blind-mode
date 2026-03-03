using System;

namespace UnityEngine.InputSystem.LowLevel;

[Flags]
public enum TouchFlags : byte
{
	IndirectTouch = 1,
	PrimaryTouch = 8,
	TapPress = 0x10,
	TapRelease = 0x20,
	OrphanedPrimaryTouch = 0x40,
	BeganInSameFrame = 0x80
}
