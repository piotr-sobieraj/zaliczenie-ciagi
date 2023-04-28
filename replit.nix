{ pkgs }: {
	deps = [
		pkgs.less
  pkgs.jq.bin
  pkgs.dotnet-sdk
    pkgs.omnisharp-roslyn
	];
}