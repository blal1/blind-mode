using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net;

[OriginalName("System.dll", "System.Net", "FtpOperation")]
public enum FtpOperation
{
	DownloadFile,
	ListDirectory,
	ListDirectoryDetails,
	UploadFile,
	UploadFileUnique,
	AppendFile,
	DeleteFile,
	GetDateTimestamp,
	GetFileSize,
	Rename,
	MakeDirectory,
	RemoveDirectory,
	PrintWorkingDirectory,
	Other
}
