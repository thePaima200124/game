#!/usr/bin/env bash

declare -A build_options
declare -A build_paths
declare -A build_targets

build_options[linux-il2cpp]='-buildLinux64Player'
build_options[windows]='-buildWindows64Player'

build_paths[linux-il2cpp]="$PWD/game"
build_paths[windows]="$PWD/game.exe"

build_targets[linux-il2cpp]='Linux64'
build_targets[windows]='Win64'

export build_option="${build_options[$1]}"
export build_path="${build_paths[$1]}"
export build_target="${build_targets[$1]}"
