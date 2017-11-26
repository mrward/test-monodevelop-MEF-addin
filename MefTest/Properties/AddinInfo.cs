
using System;
using Mono.Addins;
using Mono.Addins.Description;

[assembly: Addin(
	"MefTest",
	Namespace = "MefTest",
	Version = "1.0"
)]

[assembly: AddinName("MefTest")]
[assembly: AddinCategory("IDE extensions")]
[assembly: AddinDescription("MefTest")]
[assembly: AddinAuthor("Matt Ward")]
